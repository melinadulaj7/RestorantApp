using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestorantApp.Models;
using RestorantApp.Data;
using System.Security.Cryptography;
//using RestorantApp.data;
namespace RestorantApp
{
    public partial class UserManagmentForm : Form
    {
        private AppDbContext _context;
        private BindingSource _userBindingSource = new BindingSource();

        public UserManagmentForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadUsers();
            SetupRoleComboBox();

            btnAddUser.Click += btnAddUser_Click;
            btnEditUser.Click += btnEditUser_Click;
            btnDeleteUser.Click += btnDeleteUser_Click;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
        }

        private void LoadUsers()
        {
            var users = _context.Users.ToList();
            _userBindingSource.DataSource = users;
            dataGridViewUsers.DataSource = _userBindingSource;

            
            if (dataGridViewUsers.Columns["PasswordHash"] != null)
            {
                dataGridViewUsers.Columns["PasswordHash"].Visible = false;
            }
        }

        private void SetupRoleComboBox()
        {
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.Add("Employee");
            comboBoxRole.SelectedIndex = 0;
            comboBoxRole.Enabled = false;
          
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Ju lutem plotësoni Username dhe Password.");
                return;
            }

            var exists = _context.Users.Any(u => u.Username == textBoxUsername.Text);
            if (exists)
            {
                MessageBox.Show("Ky username ekziston tashmë.");
                return;
            }

            var newUser = new User
            {
                Username = textBoxUsername.Text.Trim(),
                PasswordHash = HashPassword(textBoxPassword.Text),
                Role = comboBoxRole.SelectedItem.ToString()
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();
            LoadUsers();
            ClearInputs();
            comboBoxRole.SelectedItem = "Employee";
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow?.DataBoundItem is not User user)
            {
                MessageBox.Show("Zgjidhni një përdorues për të modifikuar.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(textBoxUsername.Text))
                user.Username = textBoxUsername.Text.Trim();

            user.Role = comboBoxRole.SelectedItem.ToString();

            if (!string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                user.PasswordHash = HashPassword(textBoxPassword.Text);
            }

            _context.SaveChanges();
            LoadUsers();
            ClearInputs();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow?.DataBoundItem is not User user)
            {
                MessageBox.Show("Zgjidhni një përdorues për të fshirë.");
                return;
            }

            var confirm = MessageBox.Show($"Jeni i sigurt që dëshironi të fshini përdoruesin '{user.Username}'?", "Konfirmim", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                LoadUsers();
                ClearInputs();
            }
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow?.DataBoundItem is User user)
            {
                textBoxUsername.Text = user.Username;
                comboBoxRole.SelectedItem = user.Role;
                textBoxPassword.Text = "";
            }
        }

        private void ClearInputs()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxRole.SelectedIndex = 0;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(password.Trim());
                var hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}