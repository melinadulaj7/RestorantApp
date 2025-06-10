using System;
using System.Windows.Forms;
using System.Drawing;
namespace RestorantApp.Forms
{
    partial class FinancialReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labelNetProfit;
        private System.Windows.Forms.TextBox textBoxTotalIncome;
        private System.Windows.Forms.TextBox textBoxNetProfit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelFrom = new Label();
            labelTo = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            buttonGenerateReport = new Button();
            dataGridViewReport = new DataGridView();
            labelTotalIncome = new Label();
            labelNetProfit = new Label();
            textBoxTotalIncome = new TextBox();
            textBoxNetProfit = new TextBox();
            labelTitle = new Label();
            buttonExportReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // labelFrom
            // 
            labelFrom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFrom.Location = new Point(18, 69);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(109, 20);
            labelFrom.TabIndex = 0;
            labelFrom.Text = "Prej datës:";
            // 
            // labelTo
            // 
            labelTo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTo.Location = new Point(417, 69);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(126, 20);
            labelTo.TabIndex = 1;
            labelTo.Text = "Deri më datë:";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(151, 66);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(180, 27);
            dateTimePickerFrom.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(549, 66);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(180, 27);
            dateTimePickerTo.TabIndex = 3;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.BackColor = Color.Honeydew;
            buttonGenerateReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGenerateReport.Location = new Point(622, 335);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(150, 29);
            buttonGenerateReport.TabIndex = 4;
            buttonGenerateReport.Text = "Gjenero Raportin";
            buttonGenerateReport.UseVisualStyleBackColor = false;
            buttonGenerateReport.Click += ButtonGenerateReport_Click;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToAddRows = false;
            dataGridViewReport.AllowUserToDeleteRows = false;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(12, 99);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.ReadOnly = true;
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new Size(760, 230);
            dataGridViewReport.TabIndex = 5;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalIncome.Location = new Point(12, 370);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(159, 23);
            labelTotalIncome.TabIndex = 6;
            labelTotalIncome.Text = "Të ardhurat totale:";
            // 
            // labelNetProfit
            // 
            labelNetProfit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNetProfit.Location = new Point(18, 404);
            labelNetProfit.Name = "labelNetProfit";
            labelNetProfit.Size = new Size(109, 20);
            labelNetProfit.TabIndex = 7;
            labelNetProfit.Text = "Fitimi neto:";
            // 
            // textBoxTotalIncome
            // 
            textBoxTotalIncome.Location = new Point(177, 370);
            textBoxTotalIncome.Name = "textBoxTotalIncome";
            textBoxTotalIncome.ReadOnly = true;
            textBoxTotalIncome.Size = new Size(180, 27);
            textBoxTotalIncome.TabIndex = 8;
            // 
            // textBoxNetProfit
            // 
            textBoxNetProfit.Location = new Point(177, 403);
            textBoxNetProfit.Name = "textBoxNetProfit";
            textBoxNetProfit.ReadOnly = true;
            textBoxNetProfit.Size = new Size(180, 27);
            textBoxNetProfit.TabIndex = 9;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Black;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Transparent;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(784, 35);
            labelTitle.TabIndex = 10;
            labelTitle.Text = "Raporti Financiar";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonExportReport
            // 
            buttonExportReport.BackColor = Color.Honeydew;
            buttonExportReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExportReport.Location = new Point(549, 420);
            buttonExportReport.Name = "buttonExportReport";
            buttonExportReport.Size = new Size(152, 29);
            buttonExportReport.TabIndex = 11;
            buttonExportReport.Text = "Shkarko Raportin";
            buttonExportReport.UseVisualStyleBackColor = false;
            buttonExportReport.Click += buttonExportReport_Click;
            // 
            // FinancialReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(784, 461);
            Controls.Add(buttonExportReport);
            Controls.Add(labelTitle);
            Controls.Add(textBoxNetProfit);
            Controls.Add(textBoxTotalIncome);
            Controls.Add(labelNetProfit);
            Controls.Add(labelTotalIncome);
            Controls.Add(dataGridViewReport);
            Controls.Add(buttonGenerateReport);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(labelTo);
            Controls.Add(labelFrom);
            Name = "FinancialReportsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Raporti Financiar";
            Load += FinancialReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label labelTitle;
        private Button buttonExportReport;
    }
}