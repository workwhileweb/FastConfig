using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FastConfig
{
    public partial class StatusForm : Form
    {
        private readonly List<LevCheckbox> levCheckboxList;

        public StatusForm()
        {
            InitializeComponent();
        }

        public StatusForm(List<LevCheckbox> levCheckboxList)
        {
            InitializeComponent();
            this.levCheckboxList = levCheckboxList;
        }

        public void updateProgress()
        {
            if (rtbProgress.InvokeRequired)
            {
                DelegateUpdateProgress d = updateProgress;
                Invoke(d);
            }
            else
            {
                rtbProgress.Text = "";
                foreach (var levCheckbox in levCheckboxList)
                    if (levCheckbox.checkBox.Checked)
                        rtbProgress.Text += levCheckbox.status + Environment.NewLine;
                rtbProgress.Update();
            }
        }

        private delegate void DelegateUpdateProgress();
    }
}