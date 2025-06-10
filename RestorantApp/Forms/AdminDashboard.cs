using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System;
using System.Windows.Forms;
using RestorantApp.Models;
using System;

namespace RestorantApp.Forms
{
    public partial class AdminDashboard : Form
    {
        private readonly AppDbContext _context;
        private readonly User _currentUser;

        public AdminDashboard(AppDbContext context, User currentUser)
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resource.foto1;  // ResourceS (me S)
            this.BackgroundImageLayout = ImageLayout.Stretch;

            _context = context;
            _currentUser = currentUser;

            labelWelcome.Text = $"Mirësevini, {_currentUser.Username}!";

            btnMenuUpdate.Click += BtnMenuUpdate_Click;
            btnUserManagment.Click += BtnUserManagment_Click;
            btnFinancaReports.Click += BtnFinancaReportsForm_Click;
            // btnTableAvailability.Click += BtnTableAvailability_Click;


        }

        private void BtnMenuUpdate_Click(object sender, EventArgs e)
        {
            var menuForm = new MenuManagementForm(_context);
            menuForm.ShowDialog();
        }

        private void BtnUserManagment_Click(object sender, EventArgs e)
        {
            var userForm = new UserManagmentForm(_context);
            userForm.ShowDialog();
        }

        private void BtnFinancaReportsForm_Click(object sender, EventArgs e)
        {
            using var reportsForm = new FinancialReportsForm(_context);
            reportsForm.ShowDialog();
        }

        private void btnReservationManagement_Click(object sender, EventArgs e)
        {
            var reservationForm = new ReservationManagementForm();
            reservationForm.ShowDialog();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnPerformanceAnalysis_Click(object sender, EventArgs e)
        {
            PerformanceAnalysisForm analysisForm = new PerformanceAnalysisForm();
            analysisForm.Show();
        }
    }
}