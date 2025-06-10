using BCrypt.Net;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RestorantApp
{
    public partial class EmployeeDashboard : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _loggedUser;

        public EmployeeDashboard(AppDbContext dbContext, User user)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _loggedUser = user;

            lblWelcome.Text = $"Mirësevini në faqen e punojësit, {_loggedUser.Username}!";

            LoadTasksForEmployee();
        }

        private void LoadTasksForEmployee()
        {
            var tasks = _dbContext.EmployeeTasks
                .Where(t => t.UserId == _loggedUser.Id)
                .Select(t => new
                {
                    Detyra = t.TaskName,
                    Afati = t.DueDate,
                    Gjendja = t.Status
                })
                .ToList();
        }

        private void btnOrderEntry_Click(object sender, EventArgs e)
        {
            var orderEntryForm = new OrderEntryForm(_loggedUser, _dbContext);
            orderEntryForm.ShowDialog();
        }

        private void buttonTableControl_Click(object sender, EventArgs e)
        {
            var tableForm = new TableStatusForm();
            tableForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var feedbackForm = new ClientFeedbackForm(_dbContext);
            feedbackForm.ShowDialog();
        }

        // Shembull për funksion për gjenerimin e faturës nga një porosi

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            pictureBoxEmployee.Image = Properties.Resource.kamarier; // emri i fotos në Resources
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.Zoom; // ose StretchImage për mbushje totale
        }
        private void buttonPorosit_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderEntryForm(_loggedUser, _dbContext);
            orderForm.ShowDialog();
        }
    }
}