namespace EoSNI
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBoxLogo = new PictureBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnHelp = new Button();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(100, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(150, 242);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.eos_ni_high_resolution_logo_transparent;
            pictureBoxLogo.Location = new Point(100, 56);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 50);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(100, 132);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 16;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(100, 182);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Password:";
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(150, 278);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(100, 30);
            btnHelp.TabIndex = 18;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(150, 314);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(97, 30);
            btnQuit.TabIndex = 19;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            ClientSize = new Size(400, 350);
            Controls.Add(btnQuit);
            Controls.Add(btnHelp);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            Text = "EoS NI - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblUsername;
        private Label lblPassword;
        private Button btnHelp;
        private Button btnQuit;
    }
}