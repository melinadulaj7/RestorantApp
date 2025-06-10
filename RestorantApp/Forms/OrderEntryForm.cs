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
namespace RestorantApp
{
    public partial class OrderEntryForm : Form
    {
        private readonly AppDbContext _dbContext;
        private readonly User _loggedUser;
        private BindingList<OrderItem> orderItems = new BindingList<OrderItem>();

        public OrderEntryForm(User loggedUser, AppDbContext dbContext)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            _dbContext = dbContext;

            // Setup DataGridView
            dataGridViewOrderItems.AutoGenerateColumns = false;
            dataGridViewOrderItems.DataSource = orderItems;

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Artikulli",
                DataPropertyName = "ProductName",
                Width = 200
            });
            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sasia",
                DataPropertyName = "Quantity",
                Width = 80
            });
            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Çmimi",
                DataPropertyName = "SellingPrice",
                Width = 100
            });
            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Totali",
                Name = "Totali",
                Width = 100,
                ReadOnly = true
            });

            dataGridViewOrderItems.DataBindingComplete += DataGridViewOrderItems_DataBindingComplete;
        }

        private void OrderEntryForm_Load(object sender, EventArgs e)
        {
            var menuItems = _dbContext.MenuItems
                .Where(m => m.IsAvailable)
                .ToList();

            comboBoxMenuItems.DataSource = menuItems;
            comboBoxMenuItems.DisplayMember = "Name";
            comboBoxMenuItems.ValueMember = "Id";

            numericUpDownQuantity.Value = 1;

            InitDataGridView();
            UpdateTotal();
        }
        private void InitDataGridView()
        {
            dataGridViewOrderItems.AutoGenerateColumns = false;
            dataGridViewOrderItems.Columns.Clear();

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Artikulli",
                DataPropertyName = "ProductName",
                Width = 200
            });

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Sasia",
                DataPropertyName = "Quantity",
                Width = 80
            });

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Çmimi",
                DataPropertyName = "SellingPrice",
                Width = 100
            });

            dataGridViewOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Totali",
                Name = "Totali",
                Width = 100
            });

            dataGridViewOrderItems.DataBindingComplete += dataGridViewOrderItems_DataBindingComplete;
        }
        private void dataGridViewOrderItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOrderItems.Rows)
            {
                if (row.DataBoundItem is OrderItem item)
                {
                    decimal total = item.SellingPrice * item.Quantity;
                    row.Cells["Totali"].Value = total.ToString("0.00");
                }
            }
        }
        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxMenuItems.SelectedItem is MenuItem selectedItem &&
                numericUpDownQuantity.Value > 0)
            {
                int quantity = (int)numericUpDownQuantity.Value;

                var orderItem = new OrderItem
                {
                    MenuItemId = selectedItem.Id,
                    MenuItem = selectedItem,
                    ProductName = selectedItem.Name,
                    Quantity = quantity,
                    CostPrice = selectedItem.CostPrice,
                    SellingPrice = selectedItem.Price
                };

                orderItems.Add(orderItem);

                // Rifresko DataGridView
                dataGridViewOrderItems.DataSource = null;
                dataGridViewOrderItems.DataSource = orderItems;

                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Zgjidh një artikull dhe vendos një sasi valide.");
            }
        }

        private void DataGridViewOrderItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewOrderItems.Rows)
            {
                if (row.DataBoundItem is OrderItem item)
                {
                    decimal total = item.SellingPrice * item.Quantity;
                    row.Cells["Totali"].Value = total.ToString("0.00");
                }
            }
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Shto të paktën një artikull në porosi.");
                return;
            }

            var order = new OrderInfo
            {
                OrderDate = DateTime.Now,
                UserId = _loggedUser.Id,
                OrderItems = orderItems.ToList()
            };

            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();

            MessageBox.Show("Porosia u ruajt me sukses!");

            orderItems.Clear();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = orderItems.Sum(i => i.SellingPrice * i.Quantity);
            textBoxTotal.Text = total.ToString("0.00");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            orderItems.Clear();
            UpdateTotal();
            numericUpDownQuantity.Value = 1;
        }
    }
}