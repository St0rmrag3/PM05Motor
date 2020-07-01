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
    public partial class Nomer : Form
    {
        public Nomer()
        {
            InitializeComponent();
            buttonAdd.BackColor = Color.CornflowerBlue;
            buttonEdit.BackColor = Color.CornflowerBlue;
            buttonDel.BackColor = Color.CornflowerBlue;
            ShowClients();
            ShowNomer();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewNomer.SelectedItems.Count == 1)
            {
                NumbersSet numberSet = listViewNomer.SelectedItems[0].Tag as NumbersSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(numberSet.IdClient.ToString());

                textBoxNomer.Text = numberSet.Number.ToString();
                textBoxPrice.Text = numberSet.Price.ToString();
            }
            else
            {
                comboBoxClient.SelectedItem = null;

                textBoxNomer.Text = "";
                textBoxPrice.Text = "";
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null  && textBoxPrice.Text != "" && textBoxNomer.Text != "")
            {
                NumbersSet numberSet = new NumbersSet();
                numberSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                numberSet.Number = (textBoxNomer.Text);
                numberSet.Price = (textBoxPrice.Text);
                Program.dbmotor.NumbersSet.Add(numberSet);
                Program.dbmotor.SaveChanges();
                ShowNomer();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        void ShowNomer()
        {
            listViewNomer.Items.Clear();
            foreach (NumbersSet numberSet in Program.dbmotor.NumbersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    numberSet.Id.ToString(),
                    numberSet.ClientsSet.LastName+" "+numberSet.ClientsSet.FirstName+" "+numberSet.ClientsSet.MiddleName,
                    numberSet.Number.ToString(),
                    
                    numberSet.Price.ToString()
                });
                item.Tag = numberSet;
                listViewNomer.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewNomer.SelectedItems.Count == 1)
            {
                NumbersSet numberSet = listViewNomer.SelectedItems[0].Tag as NumbersSet;

                numberSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                numberSet.Number = (textBoxNomer.Text);
                numberSet.Price = (textBoxPrice.Text);
                Program.dbmotor.SaveChanges();
                ShowNomer();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewNomer.SelectedItems.Count == 1)
                {
                    NumbersSet numberSet = listViewNomer.SelectedItems[0].Tag as NumbersSet;
                    Program.dbmotor.NumbersSet.Remove(numberSet);
                    Program.dbmotor.SaveChanges();
                    ShowNomer();
                }
                
                comboBoxClient.SelectedItem = null;
                textBoxNomer.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
