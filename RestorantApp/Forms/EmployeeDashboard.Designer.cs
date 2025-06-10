namespace RestorantApp
{
    partial class EmployeeDashboard : Form
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
            lblWelcome = new Label();
            buttonPorosit = new Button();
            buttonTableControl = new Button();
            buttonPervoja = new Button();
            panel1 = new Panel();
            pictureBoxEmployee = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Black;
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Transparent;
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1041, 40);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Mirësevini";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonPorosit
            // 
            buttonPorosit.BackColor = Color.Black;
            buttonPorosit.Location = new Point(24, 309);
            buttonPorosit.Name = "buttonPorosit";
            buttonPorosit.Size = new Size(188, 29);
            buttonPorosit.TabIndex = 1;
            buttonPorosit.Text = "Porositë";
            buttonPorosit.UseVisualStyleBackColor = false;
            buttonPorosit.Click += buttonPorosit_Click;
            // 
            // buttonTableControl
            // 
            buttonTableControl.BackColor = Color.Black;
            buttonTableControl.Location = new Point(24, 86);
            buttonTableControl.Name = "buttonTableControl";
            buttonTableControl.Size = new Size(186, 29);
            buttonTableControl.TabIndex = 2;
            buttonTableControl.Text = "Menaxhimi i tavolinave";
            buttonTableControl.UseVisualStyleBackColor = false;
            buttonTableControl.Click += buttonTableControl_Click;
            // 
            // buttonPervoja
            // 
            buttonPervoja.BackColor = Color.Black;
            buttonPervoja.Location = new Point(24, 204);
            buttonPervoja.Name = "buttonPervoja";
            buttonPervoja.Size = new Size(188, 29);
            buttonPervoja.TabIndex = 3;
            buttonPervoja.Text = "Përvoja me klientet";
            buttonPervoja.UseVisualStyleBackColor = false;
            buttonPervoja.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonTableControl);
            panel1.Controls.Add(buttonPorosit);
            panel1.Controls.Add(buttonPervoja);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 413);
            panel1.TabIndex = 4;
            // 
            // pictureBoxEmployee
            // 
            pictureBoxEmployee.Image = Properties.Resource.kamarier;
            pictureBoxEmployee.ImageLocation = "";
            pictureBoxEmployee.Location = new Point(246, 43);
            pictureBoxEmployee.Name = "pictureBoxEmployee";
            pictureBoxEmployee.Size = new Size(795, 413);
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEmployee.TabIndex = 5;
            pictureBoxEmployee.TabStop = false;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 450);
            Controls.Add(pictureBoxEmployee);
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Name = "EmployeeDashboard";
            Text = "EmployeeDashboard";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
     
        private Button buttonPorosit;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button buttonTableControl;
        private Button buttonFatura;
        private Button buttonPervoja;
        private Panel panel1;
        private PictureBox pictureBoxEmployee;
    }
}