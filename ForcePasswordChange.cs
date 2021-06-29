using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FastConfig
{
    public partial class ForcePasswordChange : Form
    {
        public ForcePasswordChange()
        {
            InitializeComponent();
        }

        public string newPassword { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                var cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        private void btnForceChangePassword_Click(object sender, EventArgs e)
        {
            submitPassword();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (isStrongPassword(txtNewPassword.Text))
            {
                lblPasswordStrength.Text = "Good";
                lblPasswordStrength.ForeColor = Color.Green;
            }
            else
            {
                lblPasswordStrength.Text = "Weak";
                lblPasswordStrength.ForeColor = Color.Red;
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) submitPassword();
        }

        private bool isStrongPassword(string password)
        {
            string[] badPasswordList = null;
            try
            {
                badPasswordList = File.ReadAllText("C:\\Users\\Public\\LEV\\bad_pw.txt").Split(',');
            }
            catch
            {
            }

            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) &&
                password.Any(char.IsDigit) && (badPasswordList == null || !badPasswordList.Contains(password)))
                return true;
            return false;
        }

        private void submitPassword()
        {
            if (!isStrongPassword(txtNewPassword.Text))
            {
                MessageBox.Show(
                    "Password must be:\r\n- More than 8 characters\r\n- Contains UPPER CASE leters (A-Z)\r\n- Contains lower case letter (a-z)\r\n- Contains number (0-9)");
                return;
            }

            newPassword = txtNewPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}