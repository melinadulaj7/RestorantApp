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
    public partial class ReservationManagementForm : Form
    {
        private List<Reservation> reservations = new List<Reservation>();
        private int selectedReservationId = -1;
        private int nextId = 1;

        public ReservationManagementForm()
        {
            InitializeComponent();
            LoadReservations();
            dataGridViewRezervations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRezervations.MultiSelect = false;
            dataGridViewRezervations.ReadOnly = true;

            dataGridViewRezervations.CellClick += dataGridViewRezervations_CellClick;
            buttonAdd.Click += buttonAdd_Click;
            buttonEdit.Click += buttonEdit_Click;
            buttonDelete.Click += buttonDelete_Click;
            buttonClear.Click += buttonClear_Click;
        }

        private void LoadReservations()
        {
            dataGridViewRezervations.DataSource = null;
            dataGridViewRezervations.DataSource = reservations
                .Select(r => new
                {
                    r.Id,
                    r.CustomerName,
                    r.PhoneNumber,
                    r.NumberOfPeople,
                    ReservationDate = r.ReservationDate.ToString("g")
                })
                .ToList();
        }

        private void ClearFields()
        {
            textBoxCustomerName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxPeople.Clear();
            dateTimePickerDate.Value = DateTime.Now;
            selectedReservationId = -1;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(textBoxPeople.Text))
            {
                MessageBox.Show("Ju lutem plotësoni të gjitha fushat.");
                return;
            }

            if (!int.TryParse(textBoxPeople.Text, out int numberOfPeople))
            {
                MessageBox.Show("Numri i personave duhet të jetë numër.");
                return;
            }

            var reservation = new Reservation
            {
                Id = nextId++,
                CustomerName = textBoxCustomerName.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                NumberOfPeople = numberOfPeople,
                ReservationDate = dateTimePickerDate.Value
            };

            reservations.Add(reservation);
            LoadReservations();
            ClearFields();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (selectedReservationId == -1)
            {
                MessageBox.Show("Zgjidh një rezervim për ta përditësuar.");
                return;
            }

            var reservation = reservations.FirstOrDefault(r => r.Id == selectedReservationId);
            if (reservation != null)
            {
                if (!int.TryParse(textBoxPeople.Text, out int numberOfPeople))
                {
                    MessageBox.Show("Numri i personave duhet të jetë numër.");
                    return;
                }

                reservation.CustomerName = textBoxCustomerName.Text;
                reservation.PhoneNumber = textBoxPhoneNumber.Text;
                reservation.NumberOfPeople = numberOfPeople;
                reservation.ReservationDate = dateTimePickerDate.Value;

                LoadReservations();
                ClearFields();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedReservationId == -1)
            {
                MessageBox.Show("Zgjidh një rezervim për ta fshirë.");
                return;
            }

            var reservation = reservations.FirstOrDefault(r => r.Id == selectedReservationId);
            if (reservation != null)
            {
                reservations.Remove(reservation);
                LoadReservations();
                ClearFields();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewRezervations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewRezervations.Rows.Count)
            {
                DataGridViewRow row = dataGridViewRezervations.Rows[e.RowIndex];

                selectedReservationId = Convert.ToInt32(row.Cells["Id"].Value);
                textBoxCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                textBoxPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                textBoxPeople.Text = row.Cells["NumberOfPeople"].Value.ToString();
                dateTimePickerDate.Value = DateTime.Parse(row.Cells["ReservationDate"].Value.ToString());
            }
        }
    }
}
