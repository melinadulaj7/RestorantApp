namespace RestorantApp
{
    partial class MenuManagementForm
    {
       
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


        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelTitle = new Label();
            labelName = new Label();
            labelDescription = new Label();
            labelPrice = new Label();
            textBoxSearch = new TextBox();
            textBoxDescription = new TextBox();
            comboBoxCategory = new ComboBox();
            dataGridViewMenuItems = new DataGridView();
            buttonSearch = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            labelCategory = new Label();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            checkBoxAvailable = new CheckBox();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenuItems).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.DeepSkyBlue;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Transparent;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(792, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Menu Management";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            labelName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.FromArgb(128, 128, 255);
            labelName.Location = new Point(51, 267);
            labelName.Name = "labelName";
            labelName.Size = new Size(137, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Emri i artikullit:";
            // 
            // labelDescription
            // 
            labelDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescription.ForeColor = Color.FromArgb(128, 128, 255);
            labelDescription.Location = new Point(0, 310);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(188, 25);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Përshkrimi i artikullit:";
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.FromArgb(128, 128, 255);
            labelPrice.Location = new Point(117, 352);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(71, 25);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Çmimi:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(255, 224, 192);
            textBoxSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(66, 57);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Kërko artikull...";
            textBoxSearch.Size = new Size(196, 30);
            textBoxSearch.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(233, 308);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(125, 27);
            textBoxDescription.TabIndex = 5;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Pjate Kryesore", "Pije", "Embelsira", "Antipasta" });
            comboBoxCategory.Location = new Point(233, 403);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 31);
            comboBoxCategory.TabIndex = 6;
            // 
            // dataGridViewMenuItems
            // 
            dataGridViewMenuItems.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewMenuItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenuItems.Location = new Point(51, 108);
            dataGridViewMenuItems.Name = "dataGridViewMenuItems";
            dataGridViewMenuItems.ReadOnly = true;
            dataGridViewMenuItems.RowHeadersVisible = false;
            dataGridViewMenuItems.RowHeadersWidth = 51;
            dataGridViewMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenuItems.Size = new Size(704, 131);
            dataGridViewMenuItems.TabIndex = 7;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(255, 224, 192);
            buttonSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(370, 57);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(80, 30);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Kërko";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(255, 255, 192);
            buttonAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(137, 510);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(80, 30);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Shto";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(255, 255, 192);
            buttonEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(299, 510);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(80, 30);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Edito";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 255, 192);
            buttonDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(457, 510);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(80, 30);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Fshi";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelCategory
            // 
            labelCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategory.ForeColor = Color.FromArgb(128, 128, 255);
            labelCategory.Location = new Point(95, 409);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(103, 25);
            labelCategory.TabIndex = 12;
            labelCategory.Text = "Kategoria:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(233, 350);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 14;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(233, 269);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 15;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAvailable.ForeColor = Color.Blue;
            checkBoxAvailable.Location = new Point(167, 458);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(144, 27);
            checkBoxAvailable.TabIndex = 16;
            checkBoxAvailable.Text = "Në dispozicion";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(255, 255, 192);
            buttonClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(602, 509);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(80, 30);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Pastro";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // MenuManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(792, 551);
            Controls.Add(buttonClear);
            Controls.Add(checkBoxAvailable);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPrice);
            Controls.Add(labelCategory);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridViewMenuItems);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxSearch);
            Controls.Add(labelPrice);
            Controls.Add(labelDescription);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            Name = "MenuManagementForm";
            Text = "MenuManagmentForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenuItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelName;
        private Label labelDescription;
        private Label labelPrice;
        private TextBox textBoxSearch;
        private TextBox textBoxDescription;
        private ComboBox comboBoxCategory;
        private DataGridView dataGridViewMenuItems;
        private Button buttonSearch;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Label labelCategory;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private CheckBox checkBoxAvailable;
        private Button buttonClear;
    }
}