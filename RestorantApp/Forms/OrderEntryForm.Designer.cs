namespace RestorantApp
{
    partial class OrderEntryForm
    {
        private System.ComponentModel.IContainer components = null;

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
            labelTitle = new Label();
            comboBoxMenuItems = new ComboBox();
            dataGridViewMenuItems = new DataGridView();
            buttonAddToOrder = new Button();
            labelTotal = new Label();
            textBoxTotal = new TextBox();
            buttonSaveOrder = new Button();
            buttonCancel = new Button();
            labelMenuItems = new Label();
            numericUpDownQuantity = new NumericUpDown();
            labelQuantity = new Label();
            dataGridViewOrderItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenuItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Regjistrimi i Porosisë";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxMenuItems
            // 
            comboBoxMenuItems.FormattingEnabled = true;
            comboBoxMenuItems.Items.AddRange(new object[] { "Pizza", "Uje", "Lazanja" });
            comboBoxMenuItems.Location = new Point(197, 52);
            comboBoxMenuItems.Name = "comboBoxMenuItems";
            comboBoxMenuItems.Size = new Size(151, 28);
            comboBoxMenuItems.TabIndex = 1;
            //comboBoxMenuItems.Visible = true;
          
            // 
            // dataGridViewMenuItems
            // 
            dataGridViewMenuItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenuItems.Location = new Point(0, 111);
            dataGridViewMenuItems.Name = "dataGridViewMenuItems";
            dataGridViewMenuItems.RowHeadersWidth = 51;
            dataGridViewMenuItems.Size = new Size(530, 188);
            dataGridViewMenuItems.TabIndex = 2;
            // 
            // buttonAddToOrder
            // 
            buttonAddToOrder.Location = new Point(585, 256);
            buttonAddToOrder.Name = "buttonAddToOrder";
            buttonAddToOrder.Size = new Size(175, 29);
            buttonAddToOrder.TabIndex = 3;
            buttonAddToOrder.Text = "Shto në Porosi";
            buttonAddToOrder.UseVisualStyleBackColor = true;
            buttonAddToOrder.Click += buttonAddToOrder_Click;
            // 
            // labelTotal
            // 
            labelTotal.Location = new Point(572, 420);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(158, 20);
            labelTotal.TabIndex = 5;
            labelTotal.Text = "Totali i përgjithshëm:";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(645, 460);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(125, 27);
            textBoxTotal.TabIndex = 6;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.Location = new Point(572, 146);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(163, 29);
            buttonSaveOrder.TabIndex = 7;
            buttonSaveOrder.Text = "Ruaj porosinë";
            buttonSaveOrder.UseVisualStyleBackColor = true;
            buttonSaveOrder.Click += buttonSaveOrder_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(616, 196);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Anulo";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelMenuItems
            // 
            labelMenuItems.Location = new Point(51, 55);
            labelMenuItems.Name = "labelMenuItems";
            labelMenuItems.Size = new Size(140, 25);
            labelMenuItems.TabIndex = 9;
            labelMenuItems.Text = "Zgjidh Artikullin:";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(585, 52);
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(150, 27);
            numericUpDownQuantity.TabIndex = 11;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelQuantity
            // 
            labelQuantity.Location = new Point(446, 55);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(114, 25);
            labelQuantity.TabIndex = 12;
            labelQuantity.Text = "Vendos sasinë:";
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(-4, 305);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.RowHeadersWidth = 51;
            dataGridViewOrderItems.Size = new Size(534, 188);
            dataGridViewOrderItems.TabIndex = 13;
            // 
            // OrderEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(dataGridViewOrderItems);
            Controls.Add(labelQuantity);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(labelMenuItems);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSaveOrder);
            Controls.Add(textBoxTotal);
            Controls.Add(labelTotal);
            Controls.Add(buttonAddToOrder);
            Controls.Add(dataGridViewMenuItems);
            Controls.Add(comboBoxMenuItems);
            Controls.Add(labelTitle);
            Name = "OrderEntryForm";
            Text = "Regjistrimi i Porosisë";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenuItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private ComboBox comboBoxMenuItems;
        private DataGridView dataGridViewMenuItems;
        private Button buttonAddToOrder;
        private Label labelTotal;
        private TextBox textBoxTotal;
        private Button buttonSaveOrder;
        private Button buttonCancel;
        private Label labelMenuItems;
        private NumericUpDown numericUpDownQuantity;
        private Label labelQuantity;
        private DataGridView dataGridViewOrderItems;

        // Në formën e parë nuk ke datagridview për orderItems, por nëse do ta shtosh mund ta bësh pas rregullimeve.
    }
}