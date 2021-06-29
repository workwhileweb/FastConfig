using System;
using System.Windows.Forms;

namespace FastConfig
{
    public partial class AutoLoginPasswordForm : Form
    {
        public AutoLoginPasswordForm()
        {
            InitializeComponent();
            MaximumSize = Size;
            MinimumSize = Size;
        }

        public string autoLoginPassword { get; set; }

        private void btnSubmitAutoLoginPassword_Click(object sender, EventArgs e)
        {
            submitPassword();
        }

        private void txtAutoLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) submitPassword();
        }

        private void submitPassword()
        {
            autoLoginPassword = txtAutoLoginPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}