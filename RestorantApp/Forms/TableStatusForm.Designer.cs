namespace RestorantApp
{
    partial class TableStatusForm
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
            dataGridViewTables = new DataGridView();
            labelNumber = new Label();
            labelStatus = new Label();
            textBoxNumber = new TextBox();
            comboBoxStatus = new ComboBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).BeginInit();
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
            labelTitle.Size = new Size(800, 33);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Menaxhimi i Tavolinave";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewTables
            // 
            dataGridViewTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTables.Location = new Point(47, 63);
            dataGridViewTables.Name = "dataGridViewTables";
            dataGridViewTables.RowHeadersWidth = 51;
            dataGridViewTables.Size = new Size(674, 188);
            dataGridViewTables.TabIndex = 1;
            // 
            // labelNumber
            // 
            labelNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumber.Location = new Point(47, 278);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(98, 25);
            labelNumber.TabIndex = 2;
            labelNumber.Text = "Tavolina :";
            // 
            // labelStatus
            // 
            labelStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(47, 322);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(78, 25);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "Status:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(167, 276);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(125, 27);
            textBoxNumber.TabIndex = 4;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "E lire", "E zene" });
            comboBoxStatus.Location = new Point(167, 321);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(94, 412);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Shto";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(275, 411);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Edito";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(465, 412);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Fshi";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // TableStatusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxNumber);
            Controls.Add(labelStatus);
            Controls.Add(labelNumber);
            Controls.Add(dataGridViewTables);
            Controls.Add(labelTitle);
            Name = "TableStatusForm";
            Text = "TableStatusForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridViewTables;
        private Label labelNumber;
        private Label labelStatus;
        private TextBox textBoxNumber;
        private ComboBox comboBoxStatus;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}