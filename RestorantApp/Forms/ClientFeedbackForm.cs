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
    public partial class ClientFeedbackForm : Form
    {
        private readonly AppDbContext _dbContext;

        public ClientFeedbackForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;

            LoadFeedbacks();

            buttonAdd.Click += ButtonAdd_Click;
            buttonDelete.Click += ButtonDelete_Click;
            buttonEdit.Click += ButtonEdit_Click;

            // Optional: Ngarkoj tekstin e komentit në textbox kur zgjidhet rreshti për editim
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void LoadFeedbacks()
        {
            try
            {
                var feedbacks = _dbContext.ClientFeedbacks
                    .OrderByDescending(f => f.Date)
                    .Select(f => new { f.Id, f.Comment, Data = f.Date })
                    .ToList();

                dataGridView1.DataSource = feedbacks;
                if (dataGridView1.Columns["Id"] != null)
                    dataGridView1.Columns["Id"].Visible = false;

                if (dataGridView1.Columns["Data"] != null)
                    dataGridView1.Columns["Data"].HeaderText = "Data";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë ngarkimit të komenteve: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string commentText = textBoxComment.Text.Trim();

            if (string.IsNullOrEmpty(commentText))
            {
                MessageBox.Show("Ju lutem shkruani një koment!", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var feedback = new ClientFeedback
                {
                    Comment = commentText,
                    Date = DateTime.Now
                };

                _dbContext.ClientFeedbacks.Add(feedback);
                _dbContext.SaveChanges();

                textBoxComment.Clear();
                LoadFeedbacks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë shtimit të komenti: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zgjidh një koment për të fshirë.", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("A jeni të sigurt që dëshironi ta fshini këtë koment?", "Konfirmim Fshirjeje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int feedbackId = (int)selectedRow.Cells["Id"].Value;

                var feedback = _dbContext.ClientFeedbacks.Find(feedbackId);
                if (feedback != null)
                {
                    _dbContext.ClientFeedbacks.Remove(feedback);
                    _dbContext.SaveChanges();
                    LoadFeedbacks();
                    textBoxComment.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë fshirjes së komenti: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zgjidh një koment për të edituar.", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updatedText = textBoxComment.Text.Trim();
            if (string.IsNullOrEmpty(updatedText))
            {
                MessageBox.Show("Komenti nuk mund të jetë bosh.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int feedbackId = (int)selectedRow.Cells["Id"].Value;

                var feedback = _dbContext.ClientFeedbacks.Find(feedbackId);
                if (feedback != null)
                {
                    feedback.Comment = updatedText;
                    _dbContext.SaveChanges();
                    LoadFeedbacks();
                    textBoxComment.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë editimit të komenti: " + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Opsionale: kur zgjedh një rresht, të ngarkojë komentimin në textbox për editim
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                textBoxComment.Text = selectedRow.Cells["Comment"].Value?.ToString();
            }
        }
    }
}