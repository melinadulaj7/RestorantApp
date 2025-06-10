namespace RestorantApp
{
    partial class PerformanceAnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            labelTitle = new Label();
            buttonAddAnalysis = new Button();
            dataGridViewAnalysis = new DataGridView();
            richTextBoxAnalysis = new RichTextBox();
            labelStartDate = new Label();
            labelEndDate = new Label();
            labelAnalysisWrite = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnalysis).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(146, 49);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(146, 95);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(341, 14);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(168, 20);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Analiza e performancës:";
            // 
            // buttonAddAnalysis
            // 
            buttonAddAnalysis.Location = new Point(852, 199);
            buttonAddAnalysis.Name = "buttonAddAnalysis";
            buttonAddAnalysis.Size = new Size(121, 29);
            buttonAddAnalysis.TabIndex = 4;
            buttonAddAnalysis.Text = "Shto analizën";
            buttonAddAnalysis.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAnalysis
            // 
            dataGridViewAnalysis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnalysis.Location = new Point(57, 304);
            dataGridViewAnalysis.Name = "dataGridViewAnalysis";
            dataGridViewAnalysis.RowHeadersWidth = 51;
            dataGridViewAnalysis.Size = new Size(903, 188);
            dataGridViewAnalysis.TabIndex = 5;
            // 
            // richTextBoxAnalysis
            // 
            richTextBoxAnalysis.Location = new Point(164, 159);
            richTextBoxAnalysis.Name = "richTextBoxAnalysis";
            richTextBoxAnalysis.Size = new Size(561, 120);
            richTextBoxAnalysis.TabIndex = 6;
            richTextBoxAnalysis.Text = "";
            // 
            // labelStartDate
            // 
            labelStartDate.Location = new Point(12, 49);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(118, 25);
            labelStartDate.TabIndex = 7;
            labelStartDate.Text = "Data e fillimit:";
            // 
            // labelEndDate
            // 
            labelEndDate.Location = new Point(12, 95);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(126, 25);
            labelEndDate.TabIndex = 8;
            labelEndDate.Text = "Data e mbarimit:";
            // 
            // labelAnalysisWrite
            // 
            labelAnalysisWrite.Location = new Point(12, 162);
            labelAnalysisWrite.Name = "labelAnalysisWrite";
            labelAnalysisWrite.Size = new Size(136, 25);
            labelAnalysisWrite.TabIndex = 9;
            labelAnalysisWrite.Text = "Shkruani Analizën:";
            // 
            // PerformanceAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 504);
            Controls.Add(labelAnalysisWrite);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(richTextBoxAnalysis);
            Controls.Add(dataGridViewAnalysis);
            Controls.Add(buttonAddAnalysis);
            Controls.Add(labelTitle);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "PerformanceAnalysisForm";
            Text = "PerformanceAnalysisForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnalysis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label labelTitle;
        private Button buttonAddAnalysis;
        private DataGridView dataGridViewAnalysis;
        private RichTextBox richTextBoxAnalysis;
        private Label labelStartDate;
        private Label labelEndDate;
        private Label labelAnalysisWrite;
    }
}