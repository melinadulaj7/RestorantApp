using System;
using System.Linq;
using RestorantApp.Data;
using RestorantApp.Models;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace RestorantApp
{
    partial class UserManagmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRole;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxRole = new ComboBox();
            dataGridViewUsers = new DataGridView();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            labelUsername = new Label();
            labelPassword = new Label();
            labelRole = new Label();
            labelTitle = new Label();
            ((ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(250, 99);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 27);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(250, 144);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(200, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Items.AddRange(new object[] { "Employee" });
            comboBoxRole.Location = new Point(250, 194);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(200, 28);
            comboBoxRole.TabIndex = 5;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeight = 29;
            dataGridViewUsers.Location = new Point(110, 246);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(586, 220);
            dataGridViewUsers.TabIndex = 9;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.SeaShell;
            btnAddUser.Location = new Point(504, 96);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(100, 30);
            btnAddUser.TabIndex = 6;
            btnAddUser.Text = "Shto";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.SeaShell;
            btnEditUser.Location = new Point(504, 144);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(100, 30);
            btnEditUser.TabIndex = 7;
            btnEditUser.Text = "Edito";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.SeaShell;
            btnDeleteUser.Location = new Point(504, 192);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(100, 30);
            btnDeleteUser.TabIndex = 8;
            btnDeleteUser.Text = "Fshi";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // labelUsername
            // 
            labelUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(122, 96);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(111, 20);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username :";
            // 
            // labelPassword
            // 
            labelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(122, 144);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(99, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password :";
            // 
            // labelRole
            // 
            labelRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRole.Location = new Point(122, 197);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(52, 20);
            labelRole.TabIndex = 4;
            labelRole.Text = "Roli :";
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Black;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Transparent;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(796, 38);
            labelTitle.TabIndex = 10;
            labelTitle.Text = "Menaxhimi  i Përdoruesve";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserManagmentForm
            // 
            BackColor = Color.PeachPuff;
            ClientSize = new Size(796, 495);
            Controls.Add(labelTitle);
            Controls.Add(labelUsername);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelRole);
            Controls.Add(comboBoxRole);
            Controls.Add(btnAddUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(dataGridViewUsers);
            Name = "UserManagmentForm";
            Text = "Menaxhimi i Përdoruesve";
            ((ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label labelTitle;
    }
}