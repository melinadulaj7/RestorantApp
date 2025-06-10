
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using RestorantApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System.IO;
using System.Runtime.Versioning;
using RestorantApp.Properties;
using RestorantApp.Models;
using System;
using System.Linq;
using RestorantApp.Forms;
using System.Windows.Forms;
namespace RestorantApp
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _dbContext;

        public LoginForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;

            this.BackgroundImage = Properties.Resource.restorantt;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            StyleControls();
        }

        private void StyleControls()
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var user = _dbContext.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                MessageBox.Show("Përdoruesi nuk ekziston.");
                return;
            }

            // Kontrollo edhe fjalëkalimin për siguri
            if (!VerifyPassword(password, user.PasswordHash))
            {
                MessageBox.Show("Fjalëkalimi është i gabuar.");
                return;
            }

            if (user.Role == "Admin")
            {
                var adminDashboard = new AdminDashboard(_dbContext, user);
                adminDashboard.Show();
                this.Hide();
            }
            else if (user.Role == "Employee")
            {
                var employeeDashboard = new EmployeeDashboard(_dbContext, user);
                employeeDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Roli i përdoruesit nuk njihet.");
            }
        }

        private bool VerifyPassword(string passwordInput, string storedPasswordHash)
        {
            return BCrypt.Net.BCrypt.Verify(passwordInput, storedPasswordHash);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_dbContext);
            registerForm.ShowDialog();
        }
    }
}