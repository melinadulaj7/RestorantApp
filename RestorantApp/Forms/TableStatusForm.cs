using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RestorantApp.Data;
using RestorantApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace RestorantApp
{
    public partial class TableStatusForm : Form
    {
        private AppDbContext _context;

        public TableStatusForm()
        {
            InitializeComponent();

            // Ngarkojmë connection string nga appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("RestorantAppDb");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            _context = new AppDbContext(optionsBuilder.Options);

            // Event-i për ngarkim forme
            Load += TableStatusForm_Load;

            // Event-et për butonat dhe grid
            buttonAdd.Click += ButtonAdd_Click;
            buttonEdit.Click += ButtonEdit_Click;
            buttonDelete.Click += ButtonDelete_Click;
            dataGridViewTables.SelectionChanged += DataGridViewTables_SelectionChanged;
        }

        private void TableStatusForm_Load(object sender, EventArgs e)
        {
            RefreshTableGrid();
            ClearInputs();
        }

        private void RefreshTableGrid()
        {
            var tables = _context.Tables.OrderBy(t => t.Number).ToList();
            dataGridViewTables.DataSource = null;
            dataGridViewTables.DataSource = tables;

            // Përmirëso formatin e kolonave (opsionale)
            dataGridViewTables.Columns["Id"].Visible = false; // fsheh Id-në
            dataGridViewTables.Columns["Number"].HeaderText = "Numri i Tavolinës";
            dataGridViewTables.Columns["Status"].HeaderText = "Statusi";
        }

        private void ClearInputs()
        {
            textBoxNumber.Clear();
            comboBoxStatus.SelectedIndex = -1;
            dataGridViewTables.ClearSelection();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxNumber.Text, out int tableNumber))
            {
                MessageBox.Show("Vendosni një numër të vlefshëm për tavolinën.");
                return;
            }

            if (comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Zgjidhni statusin e tavolinës.");
                return;
            }

            // Kontrollojmë nëse numri ekziston
            if (_context.Tables.Any(t => t.Number == tableNumber))
            {
                MessageBox.Show("Numri i tavolinës ekziston tashmë.");
                return;
            }

            var newTable = new Table
            {
                Number = tableNumber,
                Status = comboBoxStatus.SelectedItem.ToString()
            };

            _context.Tables.Add(newTable);
            _context.SaveChanges();

            RefreshTableGrid();
            ClearInputs();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zgjidh një tavolinë nga lista për të përditësuar.");
                return;
            }

            if (!int.TryParse(textBoxNumber.Text, out int tableNumber) || comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Shkruaj një numër tavoline të vlefshëm dhe zgjedh statusin.");
                return;
            }

            var selectedTable = dataGridViewTables.SelectedRows[0].DataBoundItem as Table;
            if (selectedTable == null) return;

            // Kontrollojmë nëse numri i ri është i zënë nga një tavolinë tjetër
            if (tableNumber != selectedTable.Number && _context.Tables.Any(t => t.Number == tableNumber))
            {
                MessageBox.Show("Numri i tavolinës që po përditëson ekziston tashmë!");
                return;
            }

            var tableToUpdate = _context.Tables.Find(selectedTable.Id);
            if (tableToUpdate != null)
            {
                tableToUpdate.Number = tableNumber;
                tableToUpdate.Status = comboBoxStatus.SelectedItem.ToString();

                _context.SaveChanges();

                RefreshTableGrid();
                ClearInputs();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zgjidh një tavolinë nga lista për të fshirë.");
                return;
            }

            var selectedTable = dataGridViewTables.SelectedRows[0].DataBoundItem as Table;
            if (selectedTable == null) return;

            var confirm = MessageBox.Show($"A dëshiron të fshish tavolinën #{selectedTable.Number}?", "Konfirmo Fshirjen", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                var tableToDelete = _context.Tables.Find(selectedTable.Id);
                if (tableToDelete != null)
                {
                    _context.Tables.Remove(tableToDelete);
                    _context.SaveChanges();

                    RefreshTableGrid();
                    ClearInputs();
                }
            }
        }

        private void DataGridViewTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTables.SelectedRows.Count > 0)
            {
                var selectedTable = dataGridViewTables.SelectedRows[0].DataBoundItem as Table;
                if (selectedTable != null)
                {
                    textBoxNumber.Text = selectedTable.Number.ToString();
                    comboBoxStatus.SelectedItem = selectedTable.Status;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }
    }
}