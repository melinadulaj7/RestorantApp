using Microsoft.EntityFrameworkCore;
using RestorantApp;
using RestorantApp.Data;
using RestorantApp.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace RestorantApp
{
    public partial class RegisterForm : Form
    {
        private readonly AppDbContext _dbContext;

        public RegisterForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.Clear();

            bool adminExists = _dbContext.Users.Any(u => u.Role == "Admin");

            if (!adminExists)
            {
                // Nëse nuk ka admin, lejo zgjedhjen e rolit Admin apo Employee
                comboBoxRole.Items.Add("Admin");
                comboBoxRole.Items.Add("Employee");
                comboBoxRole.Enabled = true; // lejo përdoruesin të zgjedhë rolin
                comboBoxRole.SelectedIndex = 0; // default Admin
            }
            else
            {
                // Nëse ka admin, mund të regjistrohen vetëm Employee
                comboBoxRole.Items.Add("Employee");
                comboBoxRole.Enabled = false; // mos lejo ndryshimin
                comboBoxRole.SelectedIndex = 0;
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Plotëso të gjitha fushat!");
                return;
            }

            if (_dbContext.Users.Any(u => u.Username == username))
            {
                MessageBox.Show("Ky emër përdoruesi ekziston tashmë.");
                return;
            }

            string role = comboBoxRole.SelectedItem?.ToString() ?? "Employee";

            // Kontroll shtesë për Admin-in
            if (role == "Admin")
            {
                bool adminExists = _dbContext.Users.Any(u => u.Role == "Admin");
                if (adminExists)
                {
                    MessageBox.Show("Admin i ri nuk mund të regjistrohet, sepse ekziston tashmë një Admin.");
                    return; // ndalon regjistrimin
                }
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            try
            {
                var user = new User
                {
                    Username = username,
                    PasswordHash = passwordHash,
                    Role = role
                };

                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                MessageBox.Show($"Përdoruesi u regjistrua me sukses si {role}!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë regjistrimit: " + ex.Message);
            }
        }
    }
}