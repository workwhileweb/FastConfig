using System.Windows.Forms;

namespace FastConfig
{
    public class LevCheckbox
    {
        public LevCheckbox(CheckBox chk, string command)
        {
            checkBox = chk;
            this.command = command;
            status = checkBox.Text + " >>> Waiting.....";
        }

        public LevCheckbox(CheckBox chk, string url, string fileName, string command, string remark = null)
        {
            checkBox = chk;
            this.command = command;
            softwareURL = url;
            setupFileName = fileName;
            status = checkBox.Text + " >>> Waiting.....";
            this.remark = remark;
        }

        public CheckBox checkBox { get; set; }
        public string status { get; set; }
        public string command { get; set; }
        public string softwareURL { get; set; }
        public string setupFileName { get; set; }
        public string remark { get; set; }

        public void updateResultStatus(int exitCode)
        {
            if (exitCode == 0)
                status = checkBox.Text + " >>> Success!";
            else
                status = checkBox.Text + " >>> Error!";
            if (remark != null) status += remark;
        }

        public void updateInstallingStatus()
        {
            status = checkBox.Text + " >>> Installing...";
        }

        public void updateDownloadingStatus()
        {
            status = checkBox.Text + " >>> Downloading...";
        }
    }
}