namespace RestorantApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            labelGreeting = new Label();
            panelLogin = new Panel();
            buttonSignUp = new Button();
            lblTitle = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(3, 58);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(84, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(3, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(3, 81);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(3, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.AntiqueWhite;
            btnLogin.Location = new Point(27, 180);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelGreeting
            // 
            labelGreeting.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGreeting.Location = new Point(74, 9);
            labelGreeting.Name = "labelGreeting";
            labelGreeting.Size = new Size(90, 40);
            labelGreeting.TabIndex = 5;
            labelGreeting.Text = "RMS";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Khaki;
            panelLogin.Controls.Add(buttonSignUp);
            panelLogin.Controls.Add(labelGreeting);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Location = new Point(266, 124);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(325, 224);
            panelLogin.TabIndex = 6;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.AntiqueWhite;
            buttonSignUp.Location = new Point(189, 182);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(90, 30);
            buttonSignUp.TabIndex = 6;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Black;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(935, 68);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Restaurant Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            ClientSize = new Size(935, 458);
            Controls.Add(lblTitle);
            Controls.Add(panelLogin);
            Name = "LoginForm";
            Text = "Login";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }
        private Label labelGreeting;
        private Panel panelLogin;
        private Label lblTitle;
        private Button buttonSignUp;
    }
}