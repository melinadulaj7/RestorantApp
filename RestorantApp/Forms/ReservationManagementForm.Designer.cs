namespace RestorantApp
{
    partial class ReservationManagementForm
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
            labelCustomerNAme = new Label();
            labelPhoneNumber = new Label();
            labelPeople = new Label();
            textBoxCustomerName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxPeople = new TextBox();
            labelReservationDate = new Label();
            dateTimePickerDate = new DateTimePicker();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            dataGridViewRezervations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezervations).BeginInit();
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
            labelTitle.Size = new Size(894, 33);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Menaxhimi i Rezervimeve";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCustomerNAme
            // 
            labelCustomerNAme.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCustomerNAme.Location = new Point(41, 67);
            labelCustomerNAme.Name = "labelCustomerNAme";
            labelCustomerNAme.Size = new Size(127, 25);
            labelCustomerNAme.TabIndex = 1;
            labelCustomerNAme.Text = "Emri i klientit:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhoneNumber.Location = new Point(41, 113);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(151, 25);
            labelPhoneNumber.TabIndex = 2;
            labelPhoneNumber.Text = "Numri i telefonit:";
            // 
            // labelPeople
            // 
            labelPeople.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPeople.Location = new Point(448, 67);
            labelPeople.Name = "labelPeople";
            labelPeople.Size = new Size(164, 25);
            labelPeople.TabIndex = 3;
            labelPeople.Text = "Numri i personave:";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(199, 65);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(125, 27);
            textBoxCustomerName.TabIndex = 4;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(199, 111);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(125, 27);
            textBoxPhoneNumber.TabIndex = 5;
            // 
            // textBoxPeople
            // 
            textBoxPeople.Location = new Point(618, 65);
            textBoxPeople.Name = "textBoxPeople";
            textBoxPeople.Size = new Size(125, 27);
            textBoxPeople.TabIndex = 6;
            // 
            // labelReservationDate
            // 
            labelReservationDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReservationDate.Location = new Point(412, 113);
            labelReservationDate.Name = "labelReservationDate";
            labelReservationDate.Size = new Size(166, 25);
            labelReservationDate.TabIndex = 7;
            labelReservationDate.Text = "Data e Rezervimit:";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(618, 110);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(250, 27);
            dateTimePickerDate.TabIndex = 8;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(113, 219);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Shto";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(263, 219);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Edito";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(412, 219);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Fshi";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(561, 219);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 12;
            buttonClear.Text = "Pastro";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRezervations
            // 
            dataGridViewRezervations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRezervations.Location = new Point(41, 307);
            dataGridViewRezervations.Name = "dataGridViewRezervations";
            dataGridViewRezervations.RowHeadersWidth = 51;
            dataGridViewRezervations.Size = new Size(757, 188);
            dataGridViewRezervations.TabIndex = 13;
            // 
            // ReservationManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 519);
            Controls.Add(dataGridViewRezervations);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePickerDate);
            Controls.Add(labelReservationDate);
            Controls.Add(textBoxPeople);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxCustomerName);
            Controls.Add(labelPeople);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelCustomerNAme);
            Controls.Add(labelTitle);
            Name = "ReservationManagementForm";
            Text = "ReservationManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRezervations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelCustomerNAme;
        private Label labelPhoneNumber;
        private Label labelPeople;
        private TextBox textBoxCustomerName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxPeople;
        private Label labelReservationDate;
        private DateTimePicker dateTimePickerDate;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonClear;
        private DataGridView dataGridViewRezervations;
    }
}