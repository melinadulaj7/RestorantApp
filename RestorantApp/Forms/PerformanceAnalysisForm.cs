using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestorantApp
{
    public partial class PerformanceAnalysisForm : Form
    {

        public PerformanceAnalysisForm()
        {
            this.Text = "Analiza e Performancës";
            this.Size = new System.Drawing.Size(700, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeControls();
        }

        private void InitializeControls()
        {
            labelTitle = new Label()
            {
                Text = "Analiza e Performancës",
                Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                Location = new System.Drawing.Point(250, 15)
            };
            this.Controls.Add(labelTitle);

            labelStartDate = new Label()
            {
                Text = "Data Fillimit:",
                AutoSize = true,
                Location = new System.Drawing.Point(30, 60)
            };
            this.Controls.Add(labelStartDate);

            dateTimePickerStart = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Short,
                Location = new System.Drawing.Point(120, 55),
                Width = 120
            };
            this.Controls.Add(dateTimePickerStart);

            labelEndDate = new Label()
            {
                Text = "Data Mbarimit:",
                AutoSize = true,
                Location = new System.Drawing.Point(350, 60)
            };
            this.Controls.Add(labelEndDate);

            dateTimePickerEnd = new DateTimePicker()
            {
                Format = DateTimePickerFormat.Short,
                Location = new System.Drawing.Point(450, 55),
                Width = 120
            };
            this.Controls.Add(dateTimePickerEnd);

            labelAnalysisWrite = new Label()
            {
                Text = "Shkruani analizën:",
                AutoSize = true,
                Location = new System.Drawing.Point(30, 100)
            };
            this.Controls.Add(labelAnalysisWrite);

            richTextBoxAnalysis = new RichTextBox()
            {
                Location = new System.Drawing.Point(30, 130),
                Size = new System.Drawing.Size(610, 100)
            };
            this.Controls.Add(richTextBoxAnalysis);

            buttonAddAnalysis = new Button()
            {
                Text = "Shto Analizën",
                Location = new System.Drawing.Point(270, 240),
                Size = new System.Drawing.Size(130, 30)
            };
            buttonAddAnalysis.Click += ButtonAddAnalysis_Click;
            this.Controls.Add(buttonAddAnalysis);

            dataGridViewAnalysis = new DataGridView()
            {
                Location = new System.Drawing.Point(30, 280),
                Size = new System.Drawing.Size(610, 170),
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            dataGridViewAnalysis.Columns.Add("StartDate", "Data Fillimit");
            dataGridViewAnalysis.Columns.Add("EndDate", "Data Mbarimit");
            dataGridViewAnalysis.Columns.Add("AnalysisText", "Analiza");
            this.Controls.Add(dataGridViewAnalysis);
        }

        private void ButtonAddAnalysis_Click(object sender, EventArgs e)
        {
            string analiza = richTextBoxAnalysis.Text.Trim();
            if (string.IsNullOrEmpty(analiza))
            {
                MessageBox.Show("Ju lutem shkruani analizën para se ta shtoni.", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Data Fillimit duhet të jetë më e vogël ose e barabartë me Data Mbarimit.", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridViewAnalysis.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), analiza);

            richTextBoxAnalysis.Clear();
        }
    }

}