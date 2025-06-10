namespace RestorantApp
{
    partial class RegisterForm
    {
       
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
            label1 = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            textBox1 = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxRole = new ComboBox();
            buttonSave = new Button();
            labelRole = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 41);
            label1.TabIndex = 0;
            label1.Text = "TABELA E REGJISTRIMIT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(179, 137);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(94, 23);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(179, 221);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(94, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(308, 214);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(235, 27);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "Employee" });
            comboBoxRole.Location = new Point(308, 295);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(151, 28);
            comboBoxRole.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.GradientActiveCaption;
            buttonSave.Location = new Point(435, 378);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Ruaj";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRole.Location = new Point(227, 295);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(46, 23);
            labelRole.TabIndex = 7;
            labelRole.Text = "Roli:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRole);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPassword);
            Controls.Add(textBox1);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private Label label1;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBox1;
        private TextBox textBoxPassword;
        private ComboBox comboBoxRole;
        private Button buttonSave;
        private Label labelRole;
    }
}