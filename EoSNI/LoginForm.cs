using System;
using System.Windows.Forms;

namespace EoSNI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                MainForm mainForm = new MainForm();
                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.");
            }
        }
    }
}
