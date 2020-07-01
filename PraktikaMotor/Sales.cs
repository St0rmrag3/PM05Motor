using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikaMotor
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            buttonAdd.BackColor = Color.CornflowerBlue;
            buttonEdit.BackColor = Color.CornflowerBlue;
            buttonDel.BackColor = Color.CornflowerBlue;
            ShowClients();
            ShowCars();
            ShowSales();
        }

        private void listViewPokupki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSales.SelectedItems.Count == 1)
            {
                SalesSet saleSet = listViewSales.SelectedItems[0].Tag as SalesSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(saleSet.IdClient.ToString());

                textBoxDate.Text = saleSet.Date.ToString();
                comboBoxCar.SelectedIndex = comboBoxCar.FindString(saleSet.IdCar.ToString());
            }
            else
            {
                comboBoxClient.SelectedItem = null;

                textBoxDate.Text = "";
                comboBoxCar.SelectedItem = null;
            }
        }
        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.dbmotor.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowCars()
        {
            comboBoxCar.Items.Clear();
            foreach (CarsSet carsSet in Program.dbmotor.CarsSet)
            {
                string[] item = { carsSet.Id.ToString() + ".", carsSet.Mark, carsSet.Model, carsSet.Kompl, carsSet.SerNumber, carsSet.Price };
                comboBoxCar.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && textBoxDate.Text != "" && comboBoxCar.SelectedItem != null)
            {
                SalesSet saleSet = new SalesSet();
                saleSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                saleSet.Date = (textBoxDate.Text);
                saleSet.IdCar = Convert.ToInt32(comboBoxCar.SelectedItem.ToString().Split('.')[0]);
                Program.dbmotor.SalesSet.Add(saleSet);
                Program.dbmotor.SaveChanges();
                ShowSales();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowSales()
        {
            listViewSales.Items.Clear();
            foreach (SalesSet salesSet in Program.dbmotor.SalesSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {

                    salesSet.Id.ToString(),
                    salesSet.ClientsSet.LastName+" "+salesSet.ClientsSet.FirstName+" "+salesSet.ClientsSet.MiddleName,
                    salesSet.CarsSet.Mark,
                    salesSet.CarsSet.Model,
                    salesSet.CarsSet.Kompl,
                    salesSet.CarsSet.SerNumber,
                    salesSet.CarsSet.Price,
                    salesSet.Date.ToString()
                }); ;
                item.Tag = salesSet;
                listViewSales.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSales.SelectedItems.Count == 1)
            {
                SalesSet salesSet = listViewSales.SelectedItems[0].Tag as SalesSet;


                salesSet.Date = (textBoxDate.Text);

                Program.dbmotor.SaveChanges();
                ShowSales();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSales.SelectedItems.Count == 1)
                {
                    SalesSet salesSet = listViewSales.SelectedItems[0].Tag as SalesSet;
                    Program.dbmotor.SalesSet.Remove(salesSet);
                    Program.dbmotor.SaveChanges();
                    ShowSales();
                }

                comboBoxClient.SelectedItem = null;
                textBoxDate.Text = "";
                comboBoxCar.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

