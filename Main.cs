using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FastConfig
{
    public partial class Main : Form
    {
        public Main(string[] args)
        {
            InitializeComponent();
            
            initCheckbox();
            initRegistry();
            initLEVDir();

            // Initialize combobox
            foreach (var dnsConfig in DNSServerList) cmbDNS.Items.Add(dnsConfig);
            cmbDNS.DropDownWidth = 200;

            if (File.Exists(NETWORK_CONFIG_PATH))
                loadNetworkConfigFile(NETWORK_CONFIG_PATH);
            else
                foreach (var drive in DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.CDRom))
                    if (drive.IsReady)
                    {
                        var configOnCD = drive.RootDirectory + "config.txt";
                        if (File.Exists(configOnCD)) loadNetworkConfigFile(configOnCD);
                    }

            // Get & set current username which runs the app
            var fullUsername = WindowsIdentity.GetCurrent().Name;
            if (fullUsername.Contains("\\"))
                currentUsername = fullUsername.Split('\\')[fullUsername.Split('\\').Length - 1];
            else
                currentUsername = fullUsername;
            txtAdminAcc.Text = currentUsername;

            // Get & set current RDP port
            txtRDPPort.Text = Registry.LocalMachine.OpenSubKey(REG_RDP_PORT).GetValue("PortNumber").ToString();
        }

        #region Inner classes

        public class DNSConfig
        {
            public DNSConfig(string serverName, string DNS1)
            {
                this.serverName = serverName;
                this.DNS1 = DNS1;
            }

            public string serverName { get; set; }
            public string DNS1 { get; set; }

            public override string ToString()
            {
                return serverName + " | " + DNS1;
            }
        }

        #endregion

        #region Final variables

        private static readonly string APPNAME = "VM QuickConfig";
        public readonly string VERSION = "1.3";
        private static readonly string GITNAME = "VM QuickConfig";
        private static readonly string GITHOME = "https://github.com/chieunhatnang/VM-QuickConfig";

        private const string REG_STARTUP = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\";
        private const string REG_LEV = "Software\\LEV\\VMQuickConfig";

        private const string REG_RDP_PORT = "SYSTEM\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp";

        private static readonly string LEV_DIR = "C:\\Users\\Public\\LEV\\";
        private static readonly string DISKPART_CONFIG_PATH = LEV_DIR + "diskpartconfig.txt";
        private static readonly string NETWORK_CONFIG_PATH = LEV_DIR + "networkconfig.txt";

        #endregion

        #region Global variables

        public static List<DNSConfig> DNSServerList;

        public List<LevCheckbox> levCheckbox4WindowsList;
        public List<LevCheckbox> levCheckbox4Software;

        private RegistryKey LEVStartupKey;
        private RegistryKey LEVRegKey;

        private readonly string currentUsername;

        #endregion

        #region Event Processing

        private void form_LowEndVietFastVPSConfig_Load(object sender, EventArgs e)
        {
            // Check and force change password
            if (LEVRegKey.GetValue("ForceChangePassword").ToString() == "1")
            {
                executeCommand("taskkill /IM explorer.exe /F", true);
                var newPassword = "";
                var frm = new ForcePasswordChange();
                var formResult = frm.ShowDialog();
                if (formResult == DialogResult.OK)
                {
                    executeCommand("explorer.exe");
                    newPassword = frm.newPassword;
                    changePassword("Administrator", newPassword);
                    setupAutoLogin(newPassword);
                    LEVRegKey.SetValue("ForceChangePassword", 0);
                    chkForceChangePass.Checked = false;
                }
            }
        }


        private void rdDHCP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdStatic.Checked)
            {
                txtIP.Enabled = true;
                txtNetmask.Enabled = true;
                txtGateway.Enabled = true;
            }

            if (rdDHCP.Checked)
            {
                txtIP.Enabled = false;
                txtNetmask.Enabled = false;
                txtGateway.Enabled = false;
            }
        }

        private void bntConfigNetwork_Click(object sender, EventArgs e)
        {
            if (rdStatic.Checked)
            {
                setStaticIP(txtIP.Text, txtNetmask.Text, txtGateway.Text, txtCustomDNS.Text);
                var config = txtIP.Text + Environment.NewLine
                                        + txtNetmask.Text + Environment.NewLine
                                        + txtGateway.Text + Environment.NewLine
                                        + txtCustomDNS.Text + Environment.NewLine;
                try
                {
                    File.WriteAllText(NETWORK_CONFIG_PATH, config);
                }
                catch
                {
                    // Fail silently
                }
            }

            if (rdDHCP.Checked) setDHCP(txtCustomDNS.Text);
            MessageBox.Show("Successfully set your network configuration!", "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbDNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomDNS.Text = ((DNSConfig) cmbDNS.SelectedItem).DNS1;
            if (((DNSConfig) cmbDNS.SelectedItem).DNS1 == "")
                txtCustomDNS.Enabled = true;
            else
                txtCustomDNS.Enabled = false;
        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var adminAcc = txtAdminAcc.Text;
            var dialogResult = MessageBox.Show("You are changing the password of username \"" + adminAcc + "\"" +
                                               "\r\nIf \"" + adminAcc +
                                               "\" is not your Administrator account, please enter your Administrator account on the text box \"Change Administrator acc.\" above.\r\n" +
                                               "The next time, pleaes login with the new credentials: \r\n\r\n" +
                                               adminAcc + "\r\n" +
                                               txtNewPassword.Text,
                "Change password for " + adminAcc + " ?", MessageBoxButtons.OKCancel);
            changePassword(adminAcc, txtNewPassword.Text);
            if (chkAutoLogin.Checked) setupAutoLogin(txtNewPassword.Text);
        }

        private void btnChangeAdminAcc_Click(object sender, EventArgs e)
        {
            var newAdminAcc = txtAdminAcc.Text;
            var dialogResult = MessageBox.Show(
                "You are renaming your account to " + newAdminAcc +
                ". You may need to restart to apply the change. Please re-login using the new username:\r\n\r\n" +
                newAdminAcc,
                "Rename account to " + newAdminAcc + " ?", MessageBoxButtons.OKCancel);
            if (dialogResult != DialogResult.OK) return;
            executeCommand($"wmic useraccount where name='{currentUsername}' call rename name='{txtAdminAcc.Text}'");
            var dialogResult2 = MessageBox.Show(
                $"Successfully renamed your account to {newAdminAcc}. Do you want to RESTART now?",
                "Success!", MessageBoxButtons.YesNo);
            if (dialogResult2 == DialogResult.Yes) executeCommand("shutdown /r /t 5");
        }

        private void btnChangeRDPPort_Click(object sender, EventArgs e)
        {
            var newRDPPort = txtRDPPort.Text;
            var dialogResult = MessageBox.Show(
                "You are changing RDP port to " + newRDPPort +
                ". After press OK, you will be DISCONNETED!!!\r\nPlease connect to the following address instead:\r\n\r\n" +
                txtIP.Text + ":" + newRDPPort,
                "Change remote port to " + newRDPPort + " ?", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                var portHexa = "0x" + int.Parse(newRDPPort).ToString("X");
                executeCommand("reg add \"HKEY_LOCAL_MACHINE\\" + REG_RDP_PORT + "\" /v PortNumber /t REG_DWORD /d " +
                               portHexa + " /f");
                executeCommand("netsh advfirewall firewall add rule name = \"Secure RDP on port " + newRDPPort +
                               "\" dir =in action = allow protocol = TCP localport = " + newRDPPort);
                executeCommand("net stop \"TermService\" /y && net start \"TermService\"");
                MessageBox.Show("Successfully change RDP port!", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExtendDisk_Click(object sender, EventArgs e)
        {
            extendDisk();
            MessageBox.Show("Successfully extend your disk to maximum capacity!", "Success!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var levCheckbox in levCheckbox4WindowsList) levCheckbox.checkBox.Checked = chkCheckAll.Checked;
        }

        private void btnConfigWindows_Click(object sender, EventArgs e)
        {
            var statusForm = new StatusForm(levCheckbox4WindowsList);
            statusForm.Show();
            var t = new Thread(() =>
            {
                foreach (var levCheckbox in levCheckbox4WindowsList)
                    if (levCheckbox.checkBox.Checked)
                    {
                        levCheckbox.updateResultStatus(executeCommand(levCheckbox.command, true));
                        statusForm.updateProgress();
                    }

                executeCommand("taskkill /IM explorer.exe /F & explorer.exe", true);
            });
            t.Start();
        }


        private void btnInstall_Click(object sender, EventArgs e)
        {
            // Add firefox
            levCheckbox4Software.Add(new LevCheckbox(chkFirefox,
                "https://download.mozilla.org/?product=firefox-latest&os=win&lang=en-US", "FirefoxLatest.exe",
                "FirefoxLatest.exe /S"));
            var statusForm = new StatusForm(levCheckbox4Software);
            statusForm.Show();
            var wc = new WebClient();
            var t = new Task(() =>
            {
                foreach (var levCheckbox in levCheckbox4Software)
                    if (levCheckbox.checkBox.Checked)
                    {
                        ServicePointManager.Expect100Continue = true;
                        ServicePointManager.DefaultConnectionLimit = 9999;

                        // Limitation: .NET 3.5 doesn't support TLS 1.2
                        // ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls; // For .NET 3.5 and .NET 4
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls |
                                                               SecurityProtocolType.Tls12; //For .NET 4.5

                        ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                        levCheckbox.updateDownloadingStatus();
                        statusForm.updateProgress();
                        try
                        {
                            wc.DownloadFile(levCheckbox.softwareURL, Path.GetTempPath() + levCheckbox.setupFileName);
                        }
                        catch (Exception ex)
                        {
                            levCheckbox.remark = ex.Message;
                        }
                        finally
                        {
                            levCheckbox.updateInstallingStatus();
                        }

                        statusForm.updateProgress();
                        levCheckbox.updateResultStatus(executeCommand(Path.GetTempPath() + levCheckbox.command, true));
                        statusForm.updateProgress();
                    }

                wc.Dispose();
            });
            t.Start();
        }

        private void chkStartUp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartUp.Checked)
                LEVStartupKey.SetValue(APPNAME, Application.ExecutablePath);
            else
                LEVStartupKey.DeleteValue(APPNAME, false);
        }

        private void chkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked)
                LEVRegKey.SetValue("AutoUpdate", "1");
            else
                LEVRegKey.SetValue("AutoUpdate", "0");
        }


        private void chkForceChangePass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForceChangePass.Checked)
                LEVRegKey.SetValue("ForceChangePassword", "1");
            else
                LEVRegKey.SetValue("ForceChangePassword", "0");
        }

        private void lnkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(GITHOME);
        }


        private void form_LowEndVietFastVPSConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            LEVStartupKey.Close();
            LEVRegKey.Close();
        }

        #endregion

        private void initCheckbox()
        {
            DNSServerList = new List<DNSConfig>(new[]
            {
                new DNSConfig("Google DNS", "8.8.8.8"),
                new DNSConfig("Cloudflare DNS", "1.1.1.1"),
                new DNSConfig("Cisco OpenDNS", "208.67.222.222"),
                new DNSConfig("Custom DNS", "")
            });

            // Initialize LevCheckbox list for Windows config
            levCheckbox4WindowsList = new List<LevCheckbox>(new[]
            {
                new LevCheckbox(chkDisableUAC,
                    "reg ADD HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v EnableLUA /t REG_DWORD /d 0 /f"),
                new LevCheckbox(chkDisableHiberfil, "powercfg.exe /hibernate off"),
                new LevCheckbox(chkTurnoffESC,
                    "REG ADD \"HKLM\\SOFTWARE\\Microsoft\\Active Setup\\Installed Components\\{A509B1A7-37EF-4b3f-8CFC-4F3A74704073}\" /v IsInstalled /t REG_DWORD /d 00000000 /f"
                    + "&& REG ADD \"HKLM\\SOFTWARE\\Microsoft\\Active Setup\\Installed Components\\{A509B1A7-37EF-4b3f-8CFC-4F3A74704073}\" /v IsInstalled /t REG_DWORD /d 00000000 /f"),
                new LevCheckbox(chkDisableRecovery, "bcdedit /set {default} bootstatuspolicy ignoreallfailures"
                                                    + " && bcdedit /set {default} recoveryenabled No"),
                new LevCheckbox(chkDisableUpdate,
                    "reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate\\Auto Update\" /v AUOptions /t REG_DWORD /d 1 /f"),
                new LevCheckbox(chkDisableDriverSig, "bcdedit -set loadoptions DISABLE_INTEGRITY_CHECKS"),
                new LevCheckbox(chkShowTrayIcon,
                    "reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\" /v EnableAutoTray /t REG_DWORD /d 0 /f"),
                new LevCheckbox(chkPerformanceRDP,
                    "reg add \"HKEY_USERS\\.DEFAULT\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\VisualEffects\" /v VisualFXSetting /t REG_DWORD /d 2 /f"),
                new LevCheckbox(chkSmallTaskbar,
                    "reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v TaskbarSmallIcons /t REG_DWORD /d 1 /f"),
                new LevCheckbox(chkDeleteTempFolder, "DEL /F /S /Q %TEMP%"),
                new LevCheckbox(chkTurnOffFW, "netsh Advfirewall set allprofiles state off"),
                new LevCheckbox(chkDisableSleep, "powercfg /x -standby-timeout-ac 0")
            });

            // Initialize LevCheckbox list for software
            if (Environment.Is64BitOperatingSystem) // 64 bit OS
                levCheckbox4Software = new List<LevCheckbox>(new[]
                {
                    new LevCheckbox(chkChrome,
                        "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B162F372C-537B-5D4B-4170-3A63D3FA265F%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Ddefaultbrowser/chrome/install/ChromeStandaloneSetup64.exe",
                        "ChromeSetup64.exe", "ChromeSetup64.exe /silent /install"),
                    new LevCheckbox(chkUnikey, "http://file.lowendviet.com/Software/UniKey42RC.exe", "UniKey42RC.exe",
                        " & copy " + Path.GetTempPath() + "UniKey42RC.exe " +
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop)),
                    new LevCheckbox(chkIDMSilient, "http://file.lowendviet.com/Software/IDM.60710.SiLeNt.InStAlL.exe",
                        "IDMSilent.exe", "IDMSilent.exe /silent /install"),
                    new LevCheckbox(chkNotepad,
                        "https://notepad-plus-plus.org/repository/7.x/7.5.6/npp.7.5.6.Installer.exe", "npp.exe",
                        "npp.exe /S"),
                    new LevCheckbox(chkOpera,
                        "https://ftp.opera.com/pub/opera/desktop/69.0.3686.77/win/Opera_69.0.3686.77_Setup_x64.exe",
                        "OperaSetup.exe", "OperaSetup.exe /silent /install"),
                    new LevCheckbox(chkCcleaner, "https://download.ccleaner.com/ccsetup542.exe", "CCleaner.exe",
                        "CCleaner.exe /S"),
                    new LevCheckbox(chk7zip, "https://www.7-zip.org/a/7z1900-x64.exe", "7zSetup.exe", "7zSetup.exe /S"),
                    new LevCheckbox(chkNET48,
                        "https://download.visualstudio.microsoft.com/download/pr/014120d7-d689-4305-befd-3cb711108212/0fd66638cde16859462a6243a4629a50/ndp48-x86-x64-allos-enu.exe",
                        "net48.exe", "net48.exe /q /norestart"),
                    new LevCheckbox(chkProxifier, "http://file.lowendviet.com/Software/Proxifier%203.21%20Setup.exe",
                        "ProxifierSetup.exe", "ProxifierSetup.exe /S",
                        "Use this key to register: KFZUS-F3JGV-T95Y7-BXGAS-5NHHP"),
                    new LevCheckbox(chkBitvise, "https://dl.bitvise.com/BvSshClient-Inst.exe", "BitviseSSH.exe",
                        "BitviseSSH.exe -acceptEULA -force"),
                    new LevCheckbox(chkBrave, "https://laptop-updates.brave.com/latest/winx64", "Brave.exe",
                        "Brave.exe /silent /install"),
                    new LevCheckbox(chkTor,
                        "https://www.torproject.org/dist/torbrowser/9.5.1/torbrowser-install-win64-9.5.1_en-US.exe",
                        "Tor.exe", "Tor.exe /S"),
                    new LevCheckbox(chkPutty,
                        "https://the.earth.li/~sgtatham/putty/latest/w64/putty-64bit-0.74-installer.msi", "Putty64.exe",
                        "msiexec /i Putty64.exe /quiet /qn"),
                    new LevCheckbox(chk4K,
                        "https://dl.4kdownload.com/app/4kvideodownloader_4.9.2_x64.msi?source=website",
                        "4KDownloader.exe", "msiexec /i 4KDownloader.exe /quiet /qn"),
                    new LevCheckbox(chkUTorrent,
                        "http://download-hr.utorrent.com/track/stable/endpoint/utorrent/os/windows", "uTorrent.exe",
                        "uTorrent.exe"),
                    new LevCheckbox(chkBitTorrent, "https://www.bittorrent.com/downloads/complete/track/stable/os/win",
                        "BitTorrent.exe", "BitTorrent.exe"),
                    new LevCheckbox(chkWinRAR, "https://www.rarlab.com/rar/winrar-x64-58b2.exe", "WinRAR.exe",
                        "WinRAR.exe /s")
                });
            else
                levCheckbox4Software = new List<LevCheckbox>(new[]
                {
                    new LevCheckbox(chkChrome,
                        "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B6895D2F5-C00B-C0C3-5A9F-9F5A2D9AE003%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26installdataindex%3Ddefaultbrowser/update2/installers/ChromeSetup.exe",
                        "ChromeSetup.exe", "ChromeSetup.exe /silent /install"),
                    new LevCheckbox(chkUnikey, "http://file.lowendviet.com/Software/UniKey42RC.exe", "UniKey42RC.exe",
                        " & copy " + Path.GetTempPath() + "UniKey42RC.exe " +
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop)),
                    new LevCheckbox(chkIDMSilient, "http://file.lowendviet.com/Software/IDM.60710.SiLeNt.InStAlL.exe",
                        "IDMSilent.exe", "IDMSilent.exe /silent /install"),
                    new LevCheckbox(chkNotepad,
                        "https://notepad-plus-plus.org/repository/7.x/7.5.6/npp.7.5.6.Installer.exe", "npp.exe",
                        "npp.exe /S"),
                    new LevCheckbox(chkOpera,
                        "https://ftp.opera.com/pub/opera/desktop/69.0.3686.77/win/Opera_69.0.3686.77_Setup.exe",
                        "OperaSetup.exe", "OperaSetup.exe /silent /install"),
                    new LevCheckbox(chkCcleaner, "https://download.ccleaner.com/ccsetup542.exe", "CCleaner.exe",
                        "CCleaner.exe /S"),
                    new LevCheckbox(chk7zip, "https://www.7-zip.org/a/7z1900.exe", "7zSetup.exe", "7zSetup.exe /S"),
                    new LevCheckbox(chkNET48,
                        "https://download.visualstudio.microsoft.com/download/pr/014120d7-d689-4305-befd-3cb711108212/0fd66638cde16859462a6243a4629a50/ndp48-x86-x64-allos-enu.exe",
                        "net48.exe", "net48.exe /q /norestart"),
                    new LevCheckbox(chkProxifier, "http://file.lowendviet.com/Software/Proxifier%203.21%20Setup.exe",
                        "ProxifierSetup.exe", "ProxifierSetup.exe /S",
                        "Use this key to register: KFZUS-F3JGV-T95Y7-BXGAS-5NHHP"),
                    new LevCheckbox(chkBitvise, "https://dl.bitvise.com/BvSshClient-Inst.exe", "BitviseSSH.exe",
                        "BitviseSSH.exe -acceptEULA -force"),
                    new LevCheckbox(chkBrave, "https://laptop-updates.brave.com/latest/winx64", "Brave.exe",
                        "Brave.exe /silent /install"),
                    new LevCheckbox(chkTor,
                        "https://www.torproject.org/dist/torbrowser/9.5.1/torbrowser-install-9.5.1_en-US.exee",
                        "Tor.exe", "Tor.exe /S"),
                    new LevCheckbox(chkPutty,
                        "https://the.earth.li/~sgtatham/putty/latest/w32/putty-0.74-installer.msi", "Putty.exe",
                        "msiexec /i Putty.exe /quiet /qn"),
                    new LevCheckbox(chk4K, "https://dl.4kdownload.com/app/4kvideodownloader_4.9.2.msi?source=website",
                        "4KDownloader.exe", "msiexec /i 4KDownloader.exe /quiet /qn"),
                    new LevCheckbox(chkUTorrent,
                        "http://download-hr.utorrent.com/track/stable/endpoint/utorrent/os/windows", "uTorrent.exe",
                        "uTorrent.exe"),
                    new LevCheckbox(chkBitTorrent, "https://www.bittorrent.com/downloads/complete/track/stable/os/win",
                        "BitTorrent.exe", "BitTorrent.exe"),
                    new LevCheckbox(chkWinRAR, "https://www.rarlab.com/rar/wrar58b2.exe", "WinRAR.exe", "WinRAR.exe /s")
                });
        }

        private void initRegistry()
        {
            LEVStartupKey = Registry.LocalMachine.OpenSubKey(REG_STARTUP, true);
            LEVRegKey = Registry.CurrentUser.OpenSubKey(REG_LEV, true);

            // First time start
            if (LEVRegKey == null || LEVRegKey.GetValue("ForceChangePassword") == null ||
                LEVRegKey.GetValue("AutoUpdate") == null || LEVRegKey.GetValue("Version") == null)
            {
                LEVRegKey = Registry.CurrentUser.CreateSubKey(REG_LEV);
                LEVRegKey.SetValue("ForceChangePassword", "0"); // Default not require changing password
                LEVRegKey.SetValue("AutoUpdate", "1"); // Default auto update
                LEVStartupKey.SetValue(APPNAME, Application.ExecutablePath); // Default autostart
            }

            // Set version to Registry
            LEVRegKey.SetValue("Version", VERSION);

            // Load value for checkbox
            if (LEVRegKey.GetValue("ForceChangePassword").ToString() == "1") chkForceChangePass.Checked = true;
            if (LEVRegKey.GetValue("AutoUpdate").ToString() == "1") chkUpdate.Checked = true;
            if (LEVStartupKey.GetValue(APPNAME) != null) chkStartUp.Checked = true;
        }

        private void initLEVDir()
        {
            try
            {
                // If the directory doesn't exist, create it.
                if (!Directory.Exists(LEV_DIR)) Directory.CreateDirectory(LEV_DIR);
            }
            catch (Exception)
            {
                // Fail silently
            }
        }

        private void loadNetworkConfigFile(string filePath)
        {
            try
            {
                var fileContent = File.ReadAllText(filePath);
                fileContent = fileContent.TrimEnd('\r', '\n');

                var options = RegexOptions.None;
                var regex = new Regex("[\r, \n]{1,}", options);
                fileContent = regex.Replace(fileContent, "|");

                var lines = fileContent.Split('|');

                txtIP.Text = lines[0];
                txtNetmask.Text = lines[1];
                txtGateway.Text = lines[2];
                if (lines.Length > 3)
                {
                    cmbDNS.SelectedIndex = 3;
                    txtCustomDNS.Text = lines[3];
                }
                else
                {
                    cmbDNS.SelectedIndex = 0;
                }
            }
            catch
            {
                // Fail silently
            }
        }

        private void setupAutoLogin(string autoLoginPassword)
        {
            executeCommand(
                "REG ADD \"HKLM\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\" /v AutoAdminLogon /t REG_SZ /d 1 /f");
            //"REG ADD \"HKLM\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\" /v DefaultDomainName /t REG_SZ /d " + Environment.UserDomainName + " /f && " +
            executeCommand(
                "REG ADD \"HKLM\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\" /v DefaultUserName /t REG_SZ /d Administrator /f");
            executeCommand(
                "REG ADD \"HKLM\\Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\" /v DefaultPassword /t REG_SZ /d " +
                autoLoginPassword + " /f");
        }

        private void changePassword(string account, string newPassword)
        {
            if (newPassword.Length < 8 || !(newPassword.Any(char.IsUpper) && newPassword.Any(char.IsLower) &&
                                            newPassword.Any(char.IsDigit)))
            {
                MessageBox.Show(
                    "New password must have at least 8 character, with both UPPERCASE, lowercase and number!", "Error!",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                executeCommand("net user " + account + " \"" + newPassword + "\"", true);
                MessageBox.Show("Successfully change Windows password!", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void setStaticIP(string ip, string netmask, string gateway, string dns)
        {
            var objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
                if ((bool)objMO["IPEnabled"])
                {
                    ManagementBaseObject setIP;
                    var newIP =
                        objMO.GetMethodParameters("EnableStatic");

                    newIP["IPAddress"] = new[] { ip };
                    newIP["SubnetMask"] = new[] { netmask };

                    setIP = objMO.InvokeMethod("EnableStatic", newIP, null);

                    ManagementBaseObject setGateway;
                    var newGateway =
                        objMO.GetMethodParameters("SetGateways");

                    newGateway["DefaultIPGateway"] = new[] { gateway };
                    newGateway["GatewayCostMetric"] = new[] { 1 };

                    setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);

                    var newDNS =
                        objMO.GetMethodParameters("SetDNSServerSearchOrder");
                    newDNS["DNSServerSearchOrder"] = dns.Split(',');
                    var setDNS =
                        objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                }
        }

        private static void setDHCP(string dns)
        {
            var objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
                if ((bool)objMO["IPEnabled"])
                {
                    ManagementBaseObject setDHCP;

                    setDHCP = objMO.InvokeMethod("EnableDHCP", null, null);

                    var newDNS =
                        objMO.GetMethodParameters("SetDNSServerSearchOrder");
                    newDNS["DNSServerSearchOrder"] = dns.Split(',');
                    var setDNS =
                        objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                }
        }
        

        private static string getLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            return "";
        }

        private void extendDisk()
        {
            var textScript = $"SELECT DISK 0{Environment.NewLine}RESCAN{Environment.NewLine}SELECT PARTITION 2{Environment.NewLine}EXTEND{Environment.NewLine}EXIT";
            File.WriteAllText(DISKPART_CONFIG_PATH, textScript);
            executeCommand("diskpart.exe /s " + DISKPART_CONFIG_PATH, true);
            File.Delete(DISKPART_CONFIG_PATH);
        }

        private static int executeCommand(string commnd, bool sync = false, int timeout = 200000)
        {
            var pp = new ProcessStartInfo("cmd.exe", "/C" + commnd)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\"
            };
            var process = Process.Start(pp);
            if (sync)
            {
                process.WaitForExit(timeout);
                var exitCode = process.ExitCode;
                process.Close();
                return exitCode;
            }

            return 0;
        }
    }
}