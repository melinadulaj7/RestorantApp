namespace RestorantApp
{
    partial class ClientFeedbackForm
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
            labelTitle = new Label();
            dataGridView1 = new DataGridView();
            labelComment = new Label();
            textBoxComment = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Black;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Transparent;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 36);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Pervoja me Klientet";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(733, 188);
            dataGridView1.TabIndex = 1;
            // 
            // labelComment
            // 
            labelComment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComment.Location = new Point(116, 274);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(116, 25);
            labelComment.TabIndex = 2;
            labelComment.Text = "Koment i ri:";
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(258, 274);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(125, 27);
            textBoxComment.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(97, 363);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Shto";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(333, 363);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Fshi";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(557, 363);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 6;
            buttonEdit.Text = "Edito";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // ClientFeedbackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxComment);
            Controls.Add(labelComment);
            Controls.Add(dataGridView1);
            Controls.Add(labelTitle);
            Name = "ClientFeedbackForm";
            Text = "ClientFeedbackForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridView1;
        private Label labelComment;
        private TextBox textBoxComment;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
    }
}