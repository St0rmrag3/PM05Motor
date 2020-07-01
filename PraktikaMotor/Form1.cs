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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            buttonTrade.BackColor = Color.CornflowerBlue;
            buttonClients.BackColor = Color.CornflowerBlue;
            buttonNomer.BackColor = Color.CornflowerBlue;
            buttonPokup.BackColor = Color.CornflowerBlue;
            buttonZakaz.BackColor = Color.CornflowerBlue;
            buttonCar.BackColor = Color.CornflowerBlue;
            labelHello.Text = "Приветствую тебя, " + Authorization.users.login;
            if (Authorization.users.type == "zakaznik")
            {
                buttonNomer.Hide();
                buttonPokup.Hide();
            }
            if (Authorization.users.type == "prodavec")
            {
                buttonZakaz.Hide();
                buttonTrade.Hide();
                
            }
        }

        private void buttonNomer_Click(object sender, EventArgs e)
        {
            Form nomer = new Nomer();
            nomer.Show();

        }

        private void buttonZakaz_Click(object sender, EventArgs e)
        {
            Form zakaz = new Zakaz();
            zakaz.Show();
        }

        private void buttonTrade_Click(object sender, EventArgs e)
        {
            Form tradein = new Trade_in();
            tradein.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form client = new Clients();
            client.Show();
        }

        private void buttonPokup_Click(object sender, EventArgs e)
        {
            Form sales = new Sales();
            sales.Show();
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            Form cars = new Cars();
            cars.Show();
        }
    }
}
