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
    public partial class Trade_in : Form
    {
        public Trade_in()
        {
            InitializeComponent();
            buttonAdd.BackColor = Color.CornflowerBlue;
            buttonEdit.BackColor = Color.CornflowerBlue;
            buttonDel.BackColor = Color.CornflowerBlue;
            ShowClients();
            ShowTrade();
        }

        private void Trade_in_Load(object sender, EventArgs e)
        {

        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTrade.SelectedItems.Count == 1)
            {
                TradeInSet tradeSet = listViewTrade.SelectedItems[0].Tag as TradeInSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(tradeSet.IdClient.ToString());

                textBoxMark.Text = tradeSet.Mark.ToString();
                textBoxModel.Text = tradeSet.Model.ToString();
                textBoxYear.Text = tradeSet.Year.ToString();
                textBoxSerNomer.Text = tradeSet.SerNumber.ToString();
                textBoxPredvPrice.Text = tradeSet.PrePrice.ToString();

            }
            else
            {
                comboBoxClient.SelectedItem = null;

                textBoxMark.Text = "";
                textBoxModel.Text = "";
                textBoxYear.Text = "";
                textBoxSerNomer.Text = "";
                textBoxPredvPrice.Text = "";
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
            if (comboBoxClient.SelectedItem != null && textBoxMark.Text != "" && textBoxModel.Text !="" && textBoxYear.Text !="" && textBoxSerNomer.Text != "" && textBoxPredvPrice.Text !="")
            {
                TradeInSet tradeSet = new TradeInSet();
                tradeSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                tradeSet.Mark = (textBoxMark.Text);
                tradeSet.Model = textBoxModel.Text;
                tradeSet.Year = textBoxYear.Text;
                tradeSet.SerNumber = textBoxSerNomer.Text;
                tradeSet.PrePrice = textBoxPredvPrice.Text;
                Program.dbmotor.TradeInSet.Add(tradeSet);
                Program.dbmotor.SaveChanges();
                ShowTrade();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowTrade()
        {
            listViewTrade.Items.Clear();
            foreach (TradeInSet tradeset in Program.dbmotor.TradeInSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {

                    tradeset.Id.ToString(),
                    tradeset.ClientsSet.LastName+" "+tradeset.ClientsSet.FirstName+" "+tradeset.ClientsSet.MiddleName,
                    tradeset.Mark,
                    tradeset.Model,
                    tradeset.Year,
                   tradeset.SerNumber,
                   tradeset.PrePrice
                    
                    
                }); ;
                item.Tag = tradeset;
                listViewTrade.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTrade.SelectedItems.Count == 1)
            {
                TradeInSet tradeset = listViewTrade.SelectedItems[0].Tag as TradeInSet;


                tradeset.Mark = textBoxMark.Text;
                tradeset.Model = textBoxModel.Text;
                tradeset.Year = textBoxYear.Text;
                tradeset.SerNumber = textBoxSerNomer.Text;
                tradeset.PrePrice= textBoxPredvPrice.Text;

                Program.dbmotor.SaveChanges();
                ShowTrade();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTrade.SelectedItems.Count == 1)
                {
                    TradeInSet tradeset = listViewTrade.SelectedItems[0].Tag as TradeInSet;
                    Program.dbmotor.TradeInSet.Remove(tradeset);
                    Program.dbmotor.SaveChanges();
                    ShowTrade();
                }

                comboBoxClient.SelectedItem = null;

                textBoxMark.Text = "";
                textBoxModel.Text = "";
                textBoxYear.Text = "";
                textBoxSerNomer.Text = "";
                textBoxPredvPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


