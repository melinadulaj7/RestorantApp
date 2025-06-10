//using RestorantApp.data;
using RestorantApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RestorantApp
{
    public partial class MenuManagementForm : Form
    {
        private readonly AppDbContext _dbContext;

        // Ky event do të njoftojë format tjera që menuja u ndryshua
        public event EventHandler MenuUpdated;

        public MenuManagementForm(AppDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;

            // Për shembull, në Load të formës ngarko listën e menusë
            this.Load += MenuManagementForm_Load;
        }

        private void MenuManagementForm_Load(object sender, EventArgs e)
        {
            RefreshMenuItemsGrid();
        }

        private void RefreshMenuItemsGrid()
        {
            var menuItems = _dbContext.MenuItems.ToList();
            dataGridViewMenuItems.DataSource = null;
            dataGridViewMenuItems.DataSource = menuItems;
        }

        // Kur ruan ndryshimet e menusë (shtim/edit), thirri këtë metodë
        private void SaveMenuChanges()
        {
            _dbContext.SaveChanges();

            // Njofto se menuja u përditësua
            MenuUpdated?.Invoke(this, EventArgs.Empty);

            RefreshMenuItemsGrid();
        }

        // Shembull për butonin Save (modifiko sipas kodit tënd)
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Lexo të dhënat nga forma
            var name = textBoxName.Text.Trim();
            var description = textBoxDescription.Text.Trim();
            var category = comboBoxCategory.Text; // supozojmë që ka kategori të listuara
            var isAvailable = checkBoxAvailable.Checked;

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price) ||
                !decimal.TryParse(textBoxPrice.Text, out decimal costPrice))
            {
                MessageBox.Show("Ju lutem jepni çmim dhe çmim kostoje të vlefshëm.");
                return;
            }

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Emri dhe Kategoria janë të detyrueshme.");
                return;
            }

            // Krijo artikullin e ri
            var newItem = new MenuItem
            {
                Name = name,
                Description = description,
                Category = category,
                Price = price,
                CostPrice = costPrice,
                IsAvailable = isAvailable
            };

            _dbContext.MenuItems.Add(newItem);
            SaveMenuChanges(); // ruan dhe rifreskon
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenuItems.CurrentRow == null)
            {
                MessageBox.Show("Zgjidh një artikull për ta ndryshuar.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewMenuItems.CurrentRow.Cells["Id"].Value);
            var item = _dbContext.MenuItems.FirstOrDefault(m => m.Id == id);
            if (item == null)
            {
                MessageBox.Show("Artikulli nuk u gjet.");
                return;
            }

            item.Name = textBoxName.Text.Trim();
            item.Description = textBoxDescription.Text.Trim();
            item.Category = comboBoxCategory.Text;
            item.IsAvailable = checkBoxAvailable.Checked;

            // Përgatit tekstin e çmimeve duke zëvendësuar presjen me pikë dhe duke hequr hapësirat
            string priceText = textBoxPrice.Text.Trim().Replace(',', '.');
            string costPriceText = textBoxPrice.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(priceText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price) ||
                !decimal.TryParse(costPriceText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal costPrice))
            {
                MessageBox.Show("Shkruani çmime të vlefshme (p.sh. 12.50).");
                return;
            }

            item.Price = price;
            item.CostPrice = costPrice;

            SaveMenuChanges();
            MessageBox.Show("Artikulli u përditësua me sukses.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenuItems.CurrentRow == null)
            {
                MessageBox.Show("Zgjidh një artikull për ta fshirë.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewMenuItems.CurrentRow.Cells["Id"].Value);
            var item = _dbContext.MenuItems.FirstOrDefault(m => m.Id == id);
            if (item == null)
            {
                MessageBox.Show("Artikulli nuk u gjet.");
                return;
            }

            var result = MessageBox.Show("A jeni i sigurt që doni ta fshini?", "Konfirmo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _dbContext.MenuItems.Remove(item);
                SaveMenuChanges();
                MessageBox.Show("Artikulli u fshi.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
            comboBoxCategory.SelectedIndex = -1;
            textBoxPrice.Clear();
            textBoxPrice.Clear();
            checkBoxAvailable.Checked = false;
        }


        // Shembull: në çdo modifikim (shto/edit/fshi) thirri SaveMenuChanges për të njoftuar ndryshimin
        // P.sh.:
        // private void buttonAdd_Click(...) { ... SaveMenuChanges(); }
        // private void buttonEdit_Click(...) { ... SaveMenuChanges(); }
        // private void buttonDelete_Click(...) { ... SaveMenuChanges(); }
    }
}