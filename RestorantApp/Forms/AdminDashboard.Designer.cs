namespace RestorantApp.Forms
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelWelcome;
        private Panel panel1;
        private Button btnMenuUpdate;
        private Button btnPriceSetting;
        private Button btnFinancaReports;
        private Button btnTableAvailability;
        private Button btnReservationManagment;
        private Button btnPerformanceAnalysis;
        private Button btnUserManagment;
        private PictureBox pictureBoxMainImage;
        private Label labelMenu;

        private void InitializeComponent()
        {
            labelWelcome = new Label();
            panel1 = new Panel();
            labelMenu = new Label();
            btnUserManagment = new Button();
            btnPerformanceAnalysis = new Button();
            btnReservationManagment = new Button();
            btnFinancaReports = new Button();
            btnMenuUpdate = new Button();
            pictureBoxMainImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainImage).BeginInit();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.BackColor = Color.Black;
            labelWelcome.Dock = DockStyle.Top;
            labelWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(0, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(1114, 50);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Mirësevini në Admin Dashboard";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(labelMenu);
            panel1.Controls.Add(btnUserManagment);
            panel1.Controls.Add(btnPerformanceAnalysis);
            panel1.Controls.Add(btnReservationManagment);
            panel1.Controls.Add(btnFinancaReports);
            panel1.Controls.Add(btnMenuUpdate);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 501);
            panel1.TabIndex = 12;
            // 
            // labelMenu
            // 
            labelMenu.BackColor = Color.FromArgb(224, 224, 224);
            labelMenu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelMenu.Location = new Point(12, 25);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(62, 25);
            labelMenu.TabIndex = 8;
            labelMenu.Text = "Menu:";
            // 
            // btnUserManagment
            // 
            btnUserManagment.BackColor = Color.Black;
            btnUserManagment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUserManagment.ForeColor = Color.White;
            btnUserManagment.Location = new Point(0, 345);
            btnUserManagment.Name = "btnUserManagment";
            btnUserManagment.Size = new Size(242, 29);
            btnUserManagment.TabIndex = 6;
            btnUserManagment.Text = "Menaxhimi i përdoruesve";
            btnUserManagment.UseVisualStyleBackColor = false;
            // 
            // btnPerformanceAnalysis
            // 
            btnPerformanceAnalysis.BackColor = Color.Black;
            btnPerformanceAnalysis.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnPerformanceAnalysis.ForeColor = Color.White;
            btnPerformanceAnalysis.Location = new Point(0, 296);
            btnPerformanceAnalysis.Name = "btnPerformanceAnalysis";
            btnPerformanceAnalysis.Size = new Size(242, 29);
            btnPerformanceAnalysis.TabIndex = 5;
            btnPerformanceAnalysis.Text = "Analiza e performancës";
            btnPerformanceAnalysis.UseVisualStyleBackColor = false;
            btnPerformanceAnalysis.Click += btnPerformanceAnalysis_Click;
            // 
            // btnReservationManagment
            // 
            btnReservationManagment.BackColor = Color.Black;
            btnReservationManagment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnReservationManagment.ForeColor = Color.White;
            btnReservationManagment.Location = new Point(0, 239);
            btnReservationManagment.Name = "btnReservationManagment";
            btnReservationManagment.Size = new Size(242, 29);
            btnReservationManagment.TabIndex = 4;
            btnReservationManagment.Text = "Menaxhimi i rezervimeve";
            btnReservationManagment.UseVisualStyleBackColor = false;
            btnReservationManagment.Click += btnReservationManagement_Click;
            // 
            // btnFinancaReports
            // 
            btnFinancaReports.BackColor = Color.Black;
            btnFinancaReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnFinancaReports.ForeColor = Color.White;
            btnFinancaReports.Location = new Point(0, 182);
            btnFinancaReports.Name = "btnFinancaReports";
            btnFinancaReports.Size = new Size(242, 29);
            btnFinancaReports.TabIndex = 2;
            btnFinancaReports.Text = "Raportet Financiare";
            btnFinancaReports.UseVisualStyleBackColor = false;
            // 
            // btnMenuUpdate
            // 
            btnMenuUpdate.BackColor = Color.Black;
            btnMenuUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnMenuUpdate.ForeColor = Color.White;
            btnMenuUpdate.Location = new Point(0, 117);
            btnMenuUpdate.Name = "btnMenuUpdate";
            btnMenuUpdate.Size = new Size(242, 29);
            btnMenuUpdate.TabIndex = 0;
            btnMenuUpdate.Text = "Përditësimi i menysë";
            btnMenuUpdate.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMainImage
            // 
            pictureBoxMainImage.BackgroundImage = Properties.Resource.foto1;
            pictureBoxMainImage.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxMainImage.Dock = DockStyle.Fill;
            pictureBoxMainImage.Location = new Point(257, 50);
            pictureBoxMainImage.Name = "pictureBoxMainImage";
            pictureBoxMainImage.Size = new Size(857, 501);
            pictureBoxMainImage.TabIndex = 13;
            pictureBoxMainImage.TabStop = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 551);
            Controls.Add(pictureBoxMainImage);
            Controls.Add(panel1);
            Controls.Add(labelWelcome);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMainImage).EndInit();
            ResumeLayout(false);
        }
    }
}