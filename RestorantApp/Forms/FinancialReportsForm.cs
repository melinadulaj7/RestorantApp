using Microsoft.EntityFrameworkCore;
using RestorantApp;
using RestorantApp.Data;
using RestorantApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RestorantApp.Forms
{
    public partial class FinancialReportsForm : Form
    {
        private readonly AppDbContext _dbContext;

        public FinancialReportsForm(AppDbContext context)
        {
            InitializeComponent();
            _dbContext = context;

            InitializeDataGridView();

            // Shto event handler për butonin e raportit në constructor ose Load event
            buttonGenerateReport.Click += ButtonGenerateReport_Click;
            buttonExportReport.Click += buttonExportReport_Click;
        }

        private void FinancialReportsForm_Load(object sender, EventArgs e)
        {
            SeedTestData();
            LoadOrders();
        }

        private void SeedTestData()
        {
            try
            {
                if (_dbContext.Orders.Any())
                    return;

                var order1 = new OrderInfo
                {
                    OrderDate = new DateTime(2025, 5, 20),
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Pizza Margheritte", Quantity = 2, CostPrice = 5m, SellingPrice = 10m },
                        new OrderItem { ProductName = "Fileto Pule", Quantity = 1, CostPrice = 3m, SellingPrice = 8m }
                    }
                };

                var order2 = new OrderInfo
                {
                    OrderDate = new DateTime(2025, 5, 25),
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Ujë Mineral", Quantity = 3, CostPrice = 4m, SellingPrice = 12m }
                    }
                };

                var order3 = new OrderInfo
                {
                    OrderDate = new DateTime(2025, 5, 12),
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Lazanja", Quantity = 1, CostPrice = 4m, SellingPrice = 9m },
                        new OrderItem { ProductName = "Sallatë", Quantity = 3, CostPrice = 2m, SellingPrice = 5m }
                    }
                };

                var order4 = new OrderInfo
                {
                    OrderDate = new DateTime(2025, 4, 18),
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ProductName = "Lëng Portokalli", Quantity = 4, CostPrice = 1m, SellingPrice = 3m }
                    }
                };

                _dbContext.Orders.AddRange(order1, order2, order3, order4);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë shtimit të të dhënave testuese:\n\n{ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridView()
        {
            dataGridViewReport.Columns.Clear();

            dataGridViewReport.Columns.Add("OrderId", "ID");
            dataGridViewReport.Columns.Add("OrderDate", "Data e Porosisë");
            dataGridViewReport.Columns.Add("Total", "Totali");
            dataGridViewReport.Columns.Add("Profit", "Fitimi");

            dataGridViewReport.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReport.MultiSelect = false;
            dataGridViewReport.ReadOnly = true;
        }

        private void LoadOrders()
        {
            // Opsionale: ngarko porositë në ComboBox ose tjetër nëse ke
            // Për shembull, mund të ngarkosh id-të e porosive në combobox
        }

        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dateTimePickerFrom.Value.Date;
                DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1);

                var orders = _dbContext.Orders
                    .Where(o => o.OrderDate >= fromDate && o.OrderDate <= toDate)
                    .Include(o => o.OrderItems)
                    .ToList();

                var reportData = orders.Select(o => new
                {
                    OrderId = o.Id,
                    OrderDate = o.OrderDate.ToString("dd/MM/yyyy"),
                    Total = o.OrderItems != null ? o.OrderItems.Sum(i => i.SellingPrice * i.Quantity) : 0,
                    Profit = CalculateProfit(o)
                }).ToList();

                // Mos e fshish kolonat, vetëm vendos DataSource
                dataGridViewReport.DataSource = reportData;

                textBoxTotalIncome.Text = reportData.Sum(r => r.Total).ToString("C", CultureInfo.CurrentCulture);
                textBoxNetProfit.Text = reportData.Sum(r => r.Profit).ToString("C", CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë përgatitjes së raportit:\n\n{ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateProfit(OrderInfo order)
        {
            decimal totalCost = 0;

            if (order.OrderItems != null)
            {
                foreach (var item in order.OrderItems)
                {
                    decimal costPrice = item.CostPrice >= 0 ? item.CostPrice : 0;
                    int quantity = item.Quantity > 0 ? item.Quantity : 0;

                    totalCost += costPrice * quantity;
                }
            }

            decimal totalRevenue = order.OrderItems?.Sum(i => i.SellingPrice * i.Quantity) ?? 0;
            return totalRevenue - totalCost;
        }

        private void buttonExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                string reportContent = "Fatura - Raporti Financiar\n";
                reportContent += "-------------------------\n";
                reportContent += "Data: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n";

                DateTime fromDate = dateTimePickerFrom.Value.Date;
                DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1);

                var orders = _dbContext.Orders
                    .Where(o => o.OrderDate >= fromDate && o.OrderDate <= toDate)
                    .Include(o => o.OrderItems)
                    .ToList();

                foreach (var order in orders)
                {
                    decimal totalOrder = order.OrderItems?.Sum(i => i.SellingPrice * i.Quantity) ?? 0;

                    reportContent += $"Porosia #{order.Id} - {order.OrderDate:dd/MM/yyyy}\n";
                    foreach (var item in order.OrderItems)
                    {
                        reportContent += $"- {item.ProductName} x {item.Quantity} = {(item.SellingPrice * item.Quantity):C}\n";
                    }
                    reportContent += $"Totali: {totalOrder:C}\n";
                    reportContent += "-------------------------\n";
                }

                reportContent += $"\nTotali i të ardhurave: {textBoxTotalIncome.Text}";
                reportContent += $"\nFitimi neto: {textBoxNetProfit.Text}";

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (.txt)|*.txt";
                    saveFileDialog.Title = "Ruaj raportin financiar";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, reportContent);
                        MessageBox.Show("Raporti u ruajt me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë ruajtjes së raportit:\n\n{ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}