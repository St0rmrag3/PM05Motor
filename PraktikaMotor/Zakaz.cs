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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
            buttonAdd.BackColor = Color.CornflowerBlue;
            buttonEdit.BackColor = Color.CornflowerBlue;
            buttonDel.BackColor = Color.CornflowerBlue;
            ShowClients();
            ShowCars();
            ShowZakaz();
            
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewZakaz.SelectedItems.Count == 1)
            {
                OrdersSet zakazSet = listViewZakaz.SelectedItems[0].Tag as OrdersSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(zakazSet.IdClient.ToString());

                textBoxDate.Text = zakazSet.Date.ToString();
                comboBoxCar.SelectedIndex = comboBoxCar.FindString(zakazSet.IdCar.ToString());
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
                string[] item = { carsSet.Id.ToString() + ".", carsSet.Mark, carsSet.Model, carsSet.Kompl, carsSet.SerNumber, carsSet.Price};
                comboBoxCar.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && textBoxDate.Text != "" && comboBoxCar.SelectedItem != null)
            {
                OrdersSet zakazSet = new OrdersSet();
                zakazSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                zakazSet.Date = (textBoxDate.Text);
                zakazSet.IdCar = Convert.ToInt32(comboBoxCar.SelectedItem.ToString().Split('.')[0]);
                Program.dbmotor.OrdersSet.Add(zakazSet);
                Program.dbmotor.SaveChanges();
                ShowZakaz();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowZakaz()
        {
            listViewZakaz.Items.Clear();
            foreach (OrdersSet zakazSet in Program.dbmotor.OrdersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {

                    zakazSet.Id.ToString(),
                    zakazSet.ClientsSet.LastName+" "+zakazSet.ClientsSet.FirstName+" "+zakazSet.ClientsSet.MiddleName,           
                    zakazSet.CarsSet.Mark,
                    zakazSet.CarsSet.Model,
                    zakazSet.CarsSet.Kompl,
                    zakazSet.CarsSet.SerNumber,
                    zakazSet.CarsSet.Price,
                    zakazSet.Date.ToString()
                }); ;
                item.Tag = zakazSet;
                listViewZakaz.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewZakaz.SelectedItems.Count == 1)
            {
                OrdersSet zakazSet = listViewZakaz.SelectedItems[0].Tag as OrdersSet;

                
                zakazSet.Date = (textBoxDate.Text);
                
                Program.dbmotor.SaveChanges();
                ShowZakaz();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewZakaz.SelectedItems.Count == 1)
                {
                    OrdersSet zakazSet = listViewZakaz.SelectedItems[0].Tag as OrdersSet;
                    Program.dbmotor.OrdersSet.Remove(zakazSet);
                    Program.dbmotor.SaveChanges();
                    ShowZakaz();
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
