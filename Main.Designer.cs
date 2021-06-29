namespace FastConfig
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDHCP = new System.Windows.Forms.RadioButton();
            this.rdStatic = new System.Windows.Forms.RadioButton();
            this.bntConfigNetwork = new System.Windows.Forms.Button();
            this.cmbDNS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomDNS = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.txtNetmask = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangeAdminAcc = new System.Windows.Forms.Button();
            this.btnChangeRDPPort = new System.Windows.Forms.Button();
            this.txtAdminAcc = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtRDPPort = new System.Windows.Forms.TextBox();
            this.chkAutoLogin = new System.Windows.Forms.CheckBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnExtendDisk = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnConfigWindows = new System.Windows.Forms.Button();
            this.chkCheckAll = new System.Windows.Forms.CheckBox();
            this.chkDeleteTempFolder = new System.Windows.Forms.CheckBox();
            this.chkPerformanceRDP = new System.Windows.Forms.CheckBox();
            this.chkDisableDriverSig = new System.Windows.Forms.CheckBox();
            this.chkDisableRecovery = new System.Windows.Forms.CheckBox();
            this.chkDisableHiberfil = new System.Windows.Forms.CheckBox();
            this.chkDisableSleep = new System.Windows.Forms.CheckBox();
            this.chkTurnOffFW = new System.Windows.Forms.CheckBox();
            this.chkSmallTaskbar = new System.Windows.Forms.CheckBox();
            this.chkShowTrayIcon = new System.Windows.Forms.CheckBox();
            this.chkDisableUpdate = new System.Windows.Forms.CheckBox();
            this.chkTurnoffESC = new System.Windows.Forms.CheckBox();
            this.chkDisableUAC = new System.Windows.Forms.CheckBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.chkPutty = new System.Windows.Forms.CheckBox();
            this.chkBitvise = new System.Windows.Forms.CheckBox();
            this.chkProxifier = new System.Windows.Forms.CheckBox();
            this.chkTor = new System.Windows.Forms.CheckBox();
            this.chkBrave = new System.Windows.Forms.CheckBox();
            this.chkFirefox = new System.Windows.Forms.CheckBox();
            this.chkOpera = new System.Windows.Forms.CheckBox();
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.chkBitTorrent = new System.Windows.Forms.CheckBox();
            this.chkUTorrent = new System.Windows.Forms.CheckBox();
            this.chk4K = new System.Windows.Forms.CheckBox();
            this.chkIDMSilient = new System.Windows.Forms.CheckBox();
            this.chkUnikey = new System.Windows.Forms.CheckBox();
            this.chkNET48 = new System.Windows.Forms.CheckBox();
            this.chkNotepad = new System.Windows.Forms.CheckBox();
            this.chkCcleaner = new System.Windows.Forms.CheckBox();
            this.chkWinRAR = new System.Windows.Forms.CheckBox();
            this.chk7zip = new System.Windows.Forms.CheckBox();
            this.chkUpdate = new System.Windows.Forms.CheckBox();
            this.chkForceChangePass = new System.Windows.Forms.CheckBox();
            this.chkStartUp = new System.Windows.Forms.CheckBox();
            this.ttAutologin = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // rdDHCP
            // 
            this.rdDHCP.AutoSize = true;
            this.rdDHCP.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdDHCP.Location = new System.Drawing.Point(106, 3);
            this.rdDHCP.Name = "rdDHCP";
            this.rdDHCP.Size = new System.Drawing.Size(52, 24);
            this.rdDHCP.TabIndex = 1;
            this.rdDHCP.Text = "DHCP";
            this.rdDHCP.UseVisualStyleBackColor = true;
            this.rdDHCP.CheckedChanged += new System.EventHandler(this.rdDHCP_CheckedChanged);
            // 
            // rdStatic
            // 
            this.rdStatic.AutoSize = true;
            this.rdStatic.Checked = true;
            this.rdStatic.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdStatic.Location = new System.Drawing.Point(3, 3);
            this.rdStatic.Name = "rdStatic";
            this.rdStatic.Size = new System.Drawing.Size(52, 24);
            this.rdStatic.TabIndex = 0;
            this.rdStatic.TabStop = true;
            this.rdStatic.Text = "Static";
            this.rdStatic.UseVisualStyleBackColor = true;
            // 
            // bntConfigNetwork
            // 
            this.bntConfigNetwork.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.bntConfigNetwork, 2);
            this.bntConfigNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntConfigNetwork.Location = new System.Drawing.Point(3, 183);
            this.bntConfigNetwork.Name = "bntConfigNetwork";
            this.bntConfigNetwork.Size = new System.Drawing.Size(201, 25);
            this.bntConfigNetwork.TabIndex = 7;
            this.bntConfigNetwork.Text = "Config network";
            this.bntConfigNetwork.UseVisualStyleBackColor = false;
            this.bntConfigNetwork.Click += new System.EventHandler(this.bntConfigNetwork_Click);
            // 
            // cmbDNS
            // 
            this.cmbDNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDNS.FormattingEnabled = true;
            this.cmbDNS.Location = new System.Drawing.Point(106, 123);
            this.cmbDNS.Name = "cmbDNS";
            this.cmbDNS.Size = new System.Drawing.Size(98, 21);
            this.cmbDNS.TabIndex = 5;
            this.cmbDNS.SelectedIndexChanged += new System.EventHandler(this.cmbDNS_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "DNS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gateway";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Netmask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // txtCustomDNS
            // 
            this.txtCustomDNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomDNS.Enabled = false;
            this.txtCustomDNS.Location = new System.Drawing.Point(106, 153);
            this.txtCustomDNS.Name = "txtCustomDNS";
            this.txtCustomDNS.Size = new System.Drawing.Size(98, 21);
            this.txtCustomDNS.TabIndex = 6;
            // 
            // txtGateway
            // 
            this.txtGateway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGateway.Location = new System.Drawing.Point(106, 93);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(98, 21);
            this.txtGateway.TabIndex = 4;
            // 
            // txtNetmask
            // 
            this.txtNetmask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetmask.Location = new System.Drawing.Point(106, 63);
            this.txtNetmask.Name = "txtNetmask";
            this.txtNetmask.Size = new System.Drawing.Size(98, 21);
            this.txtNetmask.TabIndex = 3;
            // 
            // txtIP
            // 
            this.txtIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIP.Location = new System.Drawing.Point(106, 33);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(98, 21);
            this.txtIP.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Security";
            // 
            // btnChangeAdminAcc
            // 
            this.btnChangeAdminAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeAdminAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeAdminAcc.Location = new System.Drawing.Point(106, 3);
            this.btnChangeAdminAcc.Name = "btnChangeAdminAcc";
            this.btnChangeAdminAcc.Size = new System.Drawing.Size(98, 24);
            this.btnChangeAdminAcc.TabIndex = 1;
            this.btnChangeAdminAcc.Text = "Change Admin Acc";
            this.btnChangeAdminAcc.UseVisualStyleBackColor = false;
            this.btnChangeAdminAcc.Click += new System.EventHandler(this.btnChangeAdminAcc_Click);
            // 
            // btnChangeRDPPort
            // 
            this.btnChangeRDPPort.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeRDPPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeRDPPort.Location = new System.Drawing.Point(106, 63);
            this.btnChangeRDPPort.Name = "btnChangeRDPPort";
            this.btnChangeRDPPort.Size = new System.Drawing.Size(98, 24);
            this.btnChangeRDPPort.TabIndex = 1;
            this.btnChangeRDPPort.Text = "Change RDP port";
            this.btnChangeRDPPort.UseVisualStyleBackColor = false;
            this.btnChangeRDPPort.Click += new System.EventHandler(this.btnChangeRDPPort_Click);
            // 
            // txtAdminAcc
            // 
            this.txtAdminAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdminAcc.Location = new System.Drawing.Point(3, 3);
            this.txtAdminAcc.Name = "txtAdminAcc";
            this.txtAdminAcc.Size = new System.Drawing.Size(97, 21);
            this.txtAdminAcc.TabIndex = 0;
            this.txtAdminAcc.Text = "Administrator";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangePassword.Location = new System.Drawing.Point(106, 33);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(98, 24);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Change Pass";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtRDPPort
            // 
            this.txtRDPPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRDPPort.Location = new System.Drawing.Point(3, 63);
            this.txtRDPPort.Name = "txtRDPPort";
            this.txtRDPPort.Size = new System.Drawing.Size(97, 21);
            this.txtRDPPort.TabIndex = 0;
            this.txtRDPPort.Text = "3388";
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.Checked = true;
            this.chkAutoLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkAutoLogin.Location = new System.Drawing.Point(3, 93);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(74, 24);
            this.chkAutoLogin.TabIndex = 15;
            this.chkAutoLogin.Text = "Auto login";
            this.ttAutologin.SetToolTip(this.chkAutoLogin, "If you check this box, your VPS will be automatically login when it is started\r\nI" +
        "t allows you to reset your password over Web console in case you forget the pass" +
        "word.");
            this.chkAutoLogin.UseVisualStyleBackColor = true;
            this.chkAutoLogin.CheckedChanged += new System.EventHandler(this.chkStartUp_CheckedChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPassword.Location = new System.Drawing.Point(3, 33);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(97, 21);
            this.txtNewPassword.TabIndex = 0;
            // 
            // btnExtendDisk
            // 
            this.btnExtendDisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtendDisk.BackColor = System.Drawing.Color.Transparent;
            this.btnExtendDisk.Location = new System.Drawing.Point(6, 411);
            this.btnExtendDisk.Name = "btnExtendDisk";
            this.btnExtendDisk.Size = new System.Drawing.Size(151, 23);
            this.btnExtendDisk.TabIndex = 0;
            this.btnExtendDisk.Text = "Extend disk C:\\";
            this.ttAutologin.SetToolTip(this.btnExtendDisk, "Extend C drive to fully capacity.");
            this.btnExtendDisk.UseVisualStyleBackColor = false;
            this.btnExtendDisk.Click += new System.EventHandler(this.btnExtendDisk_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flowLayoutPanel2);
            this.groupBox4.Controls.Add(this.btnConfigWindows);
            this.groupBox4.Controls.Add(this.btnExtendDisk);
            this.groupBox4.Location = new System.Drawing.Point(231, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 469);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Windows optimization";
            // 
            // btnConfigWindows
            // 
            this.btnConfigWindows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigWindows.BackColor = System.Drawing.Color.Transparent;
            this.btnConfigWindows.Location = new System.Drawing.Point(6, 440);
            this.btnConfigWindows.Name = "btnConfigWindows";
            this.btnConfigWindows.Size = new System.Drawing.Size(151, 23);
            this.btnConfigWindows.TabIndex = 15;
            this.btnConfigWindows.Text = "Config Windows";
            this.btnConfigWindows.UseVisualStyleBackColor = false;
            this.btnConfigWindows.Click += new System.EventHandler(this.btnConfigWindows_Click);
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.AutoSize = true;
            this.chkCheckAll.BackColor = System.Drawing.Color.Lime;
            this.chkCheckAll.Location = new System.Drawing.Point(3, 279);
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Size = new System.Drawing.Size(112, 17);
            this.chkCheckAll.TabIndex = 13;
            this.chkCheckAll.Text = "Check/Uncheck all";
            this.chkCheckAll.UseVisualStyleBackColor = false;
            this.chkCheckAll.CheckedChanged += new System.EventHandler(this.btnCheckAll_CheckedChanged);
            // 
            // chkDeleteTempFolder
            // 
            this.chkDeleteTempFolder.AutoSize = true;
            this.chkDeleteTempFolder.Location = new System.Drawing.Point(3, 256);
            this.chkDeleteTempFolder.Name = "chkDeleteTempFolder";
            this.chkDeleteTempFolder.Size = new System.Drawing.Size(139, 17);
            this.chkDeleteTempFolder.TabIndex = 9;
            this.chkDeleteTempFolder.Text = "Delete %Temp% folder";
            this.chkDeleteTempFolder.UseVisualStyleBackColor = true;
            // 
            // chkPerformanceRDP
            // 
            this.chkPerformanceRDP.AutoSize = true;
            this.chkPerformanceRDP.Location = new System.Drawing.Point(3, 233);
            this.chkPerformanceRDP.Name = "chkPerformanceRDP";
            this.chkPerformanceRDP.Size = new System.Drawing.Size(116, 17);
            this.chkPerformanceRDP.TabIndex = 7;
            this.chkPerformanceRDP.Text = "Better RDP turning";
            this.chkPerformanceRDP.UseVisualStyleBackColor = true;
            // 
            // chkDisableDriverSig
            // 
            this.chkDisableDriverSig.AutoSize = true;
            this.chkDisableDriverSig.Location = new System.Drawing.Point(3, 210);
            this.chkDisableDriverSig.Name = "chkDisableDriverSig";
            this.chkDisableDriverSig.Size = new System.Drawing.Size(139, 17);
            this.chkDisableDriverSig.TabIndex = 5;
            this.chkDisableDriverSig.Text = "Disable driver signature";
            this.chkDisableDriverSig.UseVisualStyleBackColor = true;
            // 
            // chkDisableRecovery
            // 
            this.chkDisableRecovery.AutoSize = true;
            this.chkDisableRecovery.Location = new System.Drawing.Point(3, 187);
            this.chkDisableRecovery.Name = "chkDisableRecovery";
            this.chkDisableRecovery.Size = new System.Drawing.Size(148, 17);
            this.chkDisableRecovery.TabIndex = 3;
            this.chkDisableRecovery.Text = "Disable recovery at logon";
            this.chkDisableRecovery.UseVisualStyleBackColor = true;
            // 
            // chkDisableHiberfil
            // 
            this.chkDisableHiberfil.AutoSize = true;
            this.chkDisableHiberfil.Location = new System.Drawing.Point(3, 164);
            this.chkDisableHiberfil.Name = "chkDisableHiberfil";
            this.chkDisableHiberfil.Size = new System.Drawing.Size(115, 17);
            this.chkDisableHiberfil.TabIndex = 1;
            this.chkDisableHiberfil.Text = "Disable hiberfil.sys";
            this.chkDisableHiberfil.UseVisualStyleBackColor = true;
            // 
            // chkDisableSleep
            // 
            this.chkDisableSleep.AutoSize = true;
            this.chkDisableSleep.Location = new System.Drawing.Point(3, 141);
            this.chkDisableSleep.Name = "chkDisableSleep";
            this.chkDisableSleep.Size = new System.Drawing.Size(88, 17);
            this.chkDisableSleep.TabIndex = 12;
            this.chkDisableSleep.Text = "Disable sleep";
            this.chkDisableSleep.UseVisualStyleBackColor = true;
            // 
            // chkTurnOffFW
            // 
            this.chkTurnOffFW.AutoSize = true;
            this.chkTurnOffFW.Location = new System.Drawing.Point(3, 118);
            this.chkTurnOffFW.Name = "chkTurnOffFW";
            this.chkTurnOffFW.Size = new System.Drawing.Size(102, 17);
            this.chkTurnOffFW.TabIndex = 10;
            this.chkTurnOffFW.Text = "Turn off firewall";
            this.chkTurnOffFW.UseVisualStyleBackColor = true;
            // 
            // chkSmallTaskbar
            // 
            this.chkSmallTaskbar.AutoSize = true;
            this.chkSmallTaskbar.Location = new System.Drawing.Point(3, 95);
            this.chkSmallTaskbar.Name = "chkSmallTaskbar";
            this.chkSmallTaskbar.Size = new System.Drawing.Size(89, 17);
            this.chkSmallTaskbar.TabIndex = 8;
            this.chkSmallTaskbar.Text = "Small taskbar";
            this.chkSmallTaskbar.UseVisualStyleBackColor = true;
            // 
            // chkShowTrayIcon
            // 
            this.chkShowTrayIcon.AutoSize = true;
            this.chkShowTrayIcon.Location = new System.Drawing.Point(3, 72);
            this.chkShowTrayIcon.Name = "chkShowTrayIcon";
            this.chkShowTrayIcon.Size = new System.Drawing.Size(110, 17);
            this.chkShowTrayIcon.TabIndex = 6;
            this.chkShowTrayIcon.Text = "Show all tray icon";
            this.chkShowTrayIcon.UseVisualStyleBackColor = true;
            // 
            // chkDisableUpdate
            // 
            this.chkDisableUpdate.AutoSize = true;
            this.chkDisableUpdate.Location = new System.Drawing.Point(3, 49);
            this.chkDisableUpdate.Name = "chkDisableUpdate";
            this.chkDisableUpdate.Size = new System.Drawing.Size(97, 17);
            this.chkDisableUpdate.TabIndex = 4;
            this.chkDisableUpdate.Text = "Disable update";
            this.chkDisableUpdate.UseVisualStyleBackColor = true;
            // 
            // chkTurnoffESC
            // 
            this.chkTurnoffESC.AutoSize = true;
            this.chkTurnoffESC.Location = new System.Drawing.Point(3, 26);
            this.chkTurnoffESC.Name = "chkTurnoffESC";
            this.chkTurnoffESC.Size = new System.Drawing.Size(100, 17);
            this.chkTurnoffESC.TabIndex = 2;
            this.chkTurnoffESC.Text = "Turn off IE ESC";
            this.chkTurnoffESC.UseVisualStyleBackColor = true;
            // 
            // chkDisableUAC
            // 
            this.chkDisableUAC.AutoSize = true;
            this.chkDisableUAC.Location = new System.Drawing.Point(3, 3);
            this.chkDisableUAC.Name = "chkDisableUAC";
            this.chkDisableUAC.Size = new System.Drawing.Size(84, 17);
            this.chkDisableUAC.TabIndex = 0;
            this.chkDisableUAC.Text = "Disable UAC";
            this.chkDisableUAC.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.BackColor = System.Drawing.Color.Transparent;
            this.btnInstall.Location = new System.Drawing.Point(6, 440);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(116, 23);
            this.btnInstall.TabIndex = 14;
            this.btnInstall.Text = "Install softwares";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // chkPutty
            // 
            this.chkPutty.AutoSize = true;
            this.chkPutty.Location = new System.Drawing.Point(3, 164);
            this.chkPutty.Name = "chkPutty";
            this.chkPutty.Size = new System.Drawing.Size(52, 17);
            this.chkPutty.TabIndex = 13;
            this.chkPutty.Text = "Putty";
            this.chkPutty.UseVisualStyleBackColor = true;
            // 
            // chkBitvise
            // 
            this.chkBitvise.AutoSize = true;
            this.chkBitvise.Location = new System.Drawing.Point(3, 141);
            this.chkBitvise.Name = "chkBitvise";
            this.chkBitvise.Size = new System.Drawing.Size(79, 17);
            this.chkBitvise.TabIndex = 13;
            this.chkBitvise.Text = "Bitvise SSH";
            this.chkBitvise.UseVisualStyleBackColor = true;
            // 
            // chkProxifier
            // 
            this.chkProxifier.AutoSize = true;
            this.chkProxifier.Location = new System.Drawing.Point(3, 118);
            this.chkProxifier.Name = "chkProxifier";
            this.chkProxifier.Size = new System.Drawing.Size(66, 17);
            this.chkProxifier.TabIndex = 11;
            this.chkProxifier.Text = "Proxifier";
            this.chkProxifier.UseVisualStyleBackColor = true;
            // 
            // chkTor
            // 
            this.chkTor.AutoSize = true;
            this.chkTor.Location = new System.Drawing.Point(3, 95);
            this.chkTor.Name = "chkTor";
            this.chkTor.Size = new System.Drawing.Size(84, 17);
            this.chkTor.TabIndex = 7;
            this.chkTor.Text = "Tor Browser";
            this.chkTor.UseVisualStyleBackColor = true;
            // 
            // chkBrave
            // 
            this.chkBrave.AutoSize = true;
            this.chkBrave.Location = new System.Drawing.Point(3, 72);
            this.chkBrave.Name = "chkBrave";
            this.chkBrave.Size = new System.Drawing.Size(54, 17);
            this.chkBrave.TabIndex = 7;
            this.chkBrave.Text = "Brave";
            this.chkBrave.UseVisualStyleBackColor = true;
            // 
            // chkFirefox
            // 
            this.chkFirefox.AutoSize = true;
            this.chkFirefox.Location = new System.Drawing.Point(3, 26);
            this.chkFirefox.Name = "chkFirefox";
            this.chkFirefox.Size = new System.Drawing.Size(60, 17);
            this.chkFirefox.TabIndex = 2;
            this.chkFirefox.Text = "Firefox";
            this.chkFirefox.UseVisualStyleBackColor = true;
            // 
            // chkOpera
            // 
            this.chkOpera.AutoSize = true;
            this.chkOpera.Location = new System.Drawing.Point(3, 49);
            this.chkOpera.Name = "chkOpera";
            this.chkOpera.Size = new System.Drawing.Size(56, 17);
            this.chkOpera.TabIndex = 7;
            this.chkOpera.Text = "Opera";
            this.chkOpera.UseVisualStyleBackColor = true;
            // 
            // chkChrome
            // 
            this.chkChrome.AutoSize = true;
            this.chkChrome.Location = new System.Drawing.Point(3, 3);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(63, 17);
            this.chkChrome.TabIndex = 0;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // chkBitTorrent
            // 
            this.chkBitTorrent.AutoSize = true;
            this.chkBitTorrent.Location = new System.Drawing.Point(3, 256);
            this.chkBitTorrent.Name = "chkBitTorrent";
            this.chkBitTorrent.Size = new System.Drawing.Size(74, 17);
            this.chkBitTorrent.TabIndex = 4;
            this.chkBitTorrent.Text = "bitTorrent";
            this.chkBitTorrent.UseVisualStyleBackColor = true;
            // 
            // chkUTorrent
            // 
            this.chkUTorrent.AutoSize = true;
            this.chkUTorrent.Location = new System.Drawing.Point(3, 233);
            this.chkUTorrent.Name = "chkUTorrent";
            this.chkUTorrent.Size = new System.Drawing.Size(68, 17);
            this.chkUTorrent.TabIndex = 4;
            this.chkUTorrent.Text = "uTorrent";
            this.chkUTorrent.UseVisualStyleBackColor = true;
            // 
            // chk4K
            // 
            this.chk4K.AutoSize = true;
            this.chk4K.Location = new System.Drawing.Point(3, 210);
            this.chk4K.Name = "chk4K";
            this.chk4K.Size = new System.Drawing.Size(98, 17);
            this.chk4K.TabIndex = 4;
            this.chk4K.Text = "4K Downloader";
            this.chk4K.UseVisualStyleBackColor = true;
            // 
            // chkIDMSilient
            // 
            this.chkIDMSilient.AutoSize = true;
            this.chkIDMSilient.Location = new System.Drawing.Point(3, 187);
            this.chkIDMSilient.Name = "chkIDMSilient";
            this.chkIDMSilient.Size = new System.Drawing.Size(74, 17);
            this.chkIDMSilient.TabIndex = 4;
            this.chkIDMSilient.Text = "IDM Silent";
            this.chkIDMSilient.UseVisualStyleBackColor = true;
            // 
            // chkUnikey
            // 
            this.chkUnikey.AutoSize = true;
            this.chkUnikey.Location = new System.Drawing.Point(3, 279);
            this.chkUnikey.Name = "chkUnikey";
            this.chkUnikey.Size = new System.Drawing.Size(58, 17);
            this.chkUnikey.TabIndex = 1;
            this.chkUnikey.Text = "Unikey";
            this.chkUnikey.UseVisualStyleBackColor = true;
            // 
            // chkNET48
            // 
            this.chkNET48.AutoSize = true;
            this.chkNET48.Location = new System.Drawing.Point(3, 348);
            this.chkNET48.Name = "chkNET48";
            this.chkNET48.Size = new System.Drawing.Size(68, 17);
            this.chkNET48.TabIndex = 10;
            this.chkNET48.Text = ".NET 4.8";
            this.chkNET48.UseVisualStyleBackColor = true;
            // 
            // chkNotepad
            // 
            this.chkNotepad.AutoSize = true;
            this.chkNotepad.Location = new System.Drawing.Point(3, 302);
            this.chkNotepad.Name = "chkNotepad";
            this.chkNotepad.Size = new System.Drawing.Size(83, 17);
            this.chkNotepad.TabIndex = 6;
            this.chkNotepad.Text = "Notepad++";
            this.chkNotepad.UseVisualStyleBackColor = true;
            // 
            // chkCcleaner
            // 
            this.chkCcleaner.AutoSize = true;
            this.chkCcleaner.Location = new System.Drawing.Point(3, 325);
            this.chkCcleaner.Name = "chkCcleaner";
            this.chkCcleaner.Size = new System.Drawing.Size(68, 17);
            this.chkCcleaner.TabIndex = 8;
            this.chkCcleaner.Text = "Ccleaner";
            this.chkCcleaner.UseVisualStyleBackColor = true;
            // 
            // chkWinRAR
            // 
            this.chkWinRAR.AutoSize = true;
            this.chkWinRAR.Location = new System.Drawing.Point(3, 394);
            this.chkWinRAR.Name = "chkWinRAR";
            this.chkWinRAR.Size = new System.Drawing.Size(65, 17);
            this.chkWinRAR.TabIndex = 9;
            this.chkWinRAR.Text = "WinRAR";
            this.chkWinRAR.UseVisualStyleBackColor = true;
            // 
            // chk7zip
            // 
            this.chk7zip.AutoSize = true;
            this.chk7zip.Location = new System.Drawing.Point(3, 371);
            this.chk7zip.Name = "chk7zip";
            this.chk7zip.Size = new System.Drawing.Size(45, 17);
            this.chk7zip.TabIndex = 9;
            this.chk7zip.Text = "7zip";
            this.chk7zip.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            this.chkUpdate.AutoSize = true;
            this.chkUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkUpdate.Location = new System.Drawing.Point(3, 123);
            this.chkUpdate.Name = "chkUpdate";
            this.chkUpdate.Size = new System.Drawing.Size(86, 24);
            this.chkUpdate.TabIndex = 15;
            this.chkUpdate.Text = "Auto update";
            this.chkUpdate.UseVisualStyleBackColor = true;
            this.chkUpdate.CheckedChanged += new System.EventHandler(this.chkUpdate_CheckedChanged);
            // 
            // chkForceChangePass
            // 
            this.chkForceChangePass.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkForceChangePass, 2);
            this.chkForceChangePass.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkForceChangePass.Location = new System.Drawing.Point(3, 153);
            this.chkForceChangePass.Name = "chkForceChangePass";
            this.chkForceChangePass.Size = new System.Drawing.Size(160, 24);
            this.chkForceChangePass.TabIndex = 15;
            this.chkForceChangePass.Text = "Change password next time";
            this.chkForceChangePass.UseVisualStyleBackColor = true;
            this.chkForceChangePass.CheckedChanged += new System.EventHandler(this.chkForceChangePass_CheckedChanged);
            // 
            // chkStartUp
            // 
            this.chkStartUp.AutoSize = true;
            this.chkStartUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkStartUp.Location = new System.Drawing.Point(106, 93);
            this.chkStartUp.Name = "chkStartUp";
            this.chkStartUp.Size = new System.Drawing.Size(75, 24);
            this.chkStartUp.TabIndex = 15;
            this.chkStartUp.Text = "Auto start";
            this.chkStartUp.UseVisualStyleBackColor = true;
            this.chkStartUp.CheckedChanged += new System.EventHandler(this.chkStartUp_CheckedChanged);
            // 
            // ttAutologin
            // 
            this.ttAutologin.AutomaticDelay = 50;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.chkChrome);
            this.flowLayoutPanel1.Controls.Add(this.chkFirefox);
            this.flowLayoutPanel1.Controls.Add(this.chkOpera);
            this.flowLayoutPanel1.Controls.Add(this.chkBrave);
            this.flowLayoutPanel1.Controls.Add(this.chkTor);
            this.flowLayoutPanel1.Controls.Add(this.chkProxifier);
            this.flowLayoutPanel1.Controls.Add(this.chkBitvise);
            this.flowLayoutPanel1.Controls.Add(this.chkPutty);
            this.flowLayoutPanel1.Controls.Add(this.chkIDMSilient);
            this.flowLayoutPanel1.Controls.Add(this.chk4K);
            this.flowLayoutPanel1.Controls.Add(this.chkUTorrent);
            this.flowLayoutPanel1.Controls.Add(this.chkBitTorrent);
            this.flowLayoutPanel1.Controls.Add(this.chkUnikey);
            this.flowLayoutPanel1.Controls.Add(this.chkNotepad);
            this.flowLayoutPanel1.Controls.Add(this.chkCcleaner);
            this.flowLayoutPanel1.Controls.Add(this.chkNET48);
            this.flowLayoutPanel1.Controls.Add(this.chk7zip);
            this.flowLayoutPanel1.Controls.Add(this.chkWinRAR);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 414);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.chkDisableUAC);
            this.flowLayoutPanel2.Controls.Add(this.chkTurnoffESC);
            this.flowLayoutPanel2.Controls.Add(this.chkDisableUpdate);
            this.flowLayoutPanel2.Controls.Add(this.chkShowTrayIcon);
            this.flowLayoutPanel2.Controls.Add(this.chkSmallTaskbar);
            this.flowLayoutPanel2.Controls.Add(this.chkTurnOffFW);
            this.flowLayoutPanel2.Controls.Add(this.chkDisableSleep);
            this.flowLayoutPanel2.Controls.Add(this.chkDisableHiberfil);
            this.flowLayoutPanel2.Controls.Add(this.chkDisableRecovery);
            this.flowLayoutPanel2.Controls.Add(this.chkDisableDriverSig);
            this.flowLayoutPanel2.Controls.Add(this.chkPerformanceRDP);
            this.flowLayoutPanel2.Controls.Add(this.chkDeleteTempFolder);
            this.flowLayoutPanel2.Controls.Add(this.chkCheckAll);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(151, 385);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Controls.Add(this.btnInstall);
            this.groupBox3.Location = new System.Drawing.Point(400, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 469);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Softwares";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chkUpdate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAdminAcc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkAutoLogin, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkStartUp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeRDPPort, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeAdminAcc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRDPPort, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnChangePassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNewPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkForceChangePass, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 212);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bntConfigNetwork, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.rdDHCP, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCustomDNS, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.cmbDNS, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.rdStatic, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtGateway, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtIP, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtNetmask, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(207, 211);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 489);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastConfig";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_LowEndVietFastVPSConfig_FormClosed);
            this.Load += new System.EventHandler(this.form_LowEndVietFastVPSConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntConfigNetwork;
        private System.Windows.Forms.ComboBox cmbDNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomDNS;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.TextBox txtNetmask;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnExtendDisk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnConfigWindows;
        private System.Windows.Forms.CheckBox chkPerformanceRDP;
        private System.Windows.Forms.CheckBox chkDisableDriverSig;
        private System.Windows.Forms.CheckBox chkDisableRecovery;
        private System.Windows.Forms.CheckBox chkDisableHiberfil;
        private System.Windows.Forms.CheckBox chkDisableSleep;
        private System.Windows.Forms.CheckBox chkTurnOffFW;
        private System.Windows.Forms.CheckBox chkSmallTaskbar;
        private System.Windows.Forms.CheckBox chkShowTrayIcon;
        private System.Windows.Forms.CheckBox chkDisableUpdate;
        private System.Windows.Forms.CheckBox chkTurnoffESC;
        private System.Windows.Forms.CheckBox chkDisableUAC;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.CheckBox chkNotepad;
        private System.Windows.Forms.CheckBox chkIDMSilient;
        private System.Windows.Forms.CheckBox chkUnikey;
        private System.Windows.Forms.CheckBox chkBitvise;
        private System.Windows.Forms.CheckBox chkProxifier;
        private System.Windows.Forms.CheckBox chk7zip;
        private System.Windows.Forms.CheckBox chkOpera;
        private System.Windows.Forms.CheckBox chkFirefox;
        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.CheckBox chkDeleteTempFolder;
        private System.Windows.Forms.CheckBox chkNET48;
        private System.Windows.Forms.CheckBox chkCcleaner;
        private System.Windows.Forms.RadioButton rdDHCP;
        private System.Windows.Forms.RadioButton rdStatic;
        private System.Windows.Forms.CheckBox chkCheckAll;
        private System.Windows.Forms.CheckBox chkUpdate;
        private System.Windows.Forms.CheckBox chkStartUp;
        private System.Windows.Forms.CheckBox chkAutoLogin;
        private System.Windows.Forms.CheckBox chkForceChangePass;
        private System.Windows.Forms.ToolTip ttAutologin;
        private System.Windows.Forms.CheckBox chkBrave;
        private System.Windows.Forms.CheckBox chkPutty;
        private System.Windows.Forms.CheckBox chkTor;
        private System.Windows.Forms.CheckBox chkBitTorrent;
        private System.Windows.Forms.CheckBox chkUTorrent;
        private System.Windows.Forms.CheckBox chk4K;
        private System.Windows.Forms.CheckBox chkWinRAR;
        private System.Windows.Forms.Button btnChangeAdminAcc;
        private System.Windows.Forms.Button btnChangeRDPPort;
        private System.Windows.Forms.TextBox txtAdminAcc;
        private System.Windows.Forms.TextBox txtRDPPort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

