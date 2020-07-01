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
    public partial class Cars : Form
    {
        public Cars()
        {
           
            InitializeComponent();
            buttonAdd.BackColor = Color.CornflowerBlue;
            buttonEdit.BackColor = Color.CornflowerBlue;
            buttonDel.BackColor = Color.CornflowerBlue;
            ShowCars();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }
        void ShowCars()
        {
            listViewCars.Items.Clear();
            foreach (CarsSet carsSet in Program.dbmotor.CarsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    carsSet.Id.ToString(), carsSet.Mark, carsSet.Model, carsSet.Kompl, carsSet.SerNumber, carsSet.Price
                });
                item.Tag = carsSet;
                listViewCars.Items.Add(item);
            }
            listViewCars.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

      

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                CarsSet carsSet = listViewCars.SelectedItems[0].Tag as CarsSet;
                textBoxMarka.Text = carsSet.Mark;
                textBoxModel.Text = carsSet.Model;
                textBoxKompl.Text = carsSet.Kompl;
                textBoxSerNomer.Text = carsSet.SerNumber;
                textBoxPrice.Text = carsSet.Price;
            }
            else
            {
                textBoxMarka.Text = "";
                textBoxModel.Text = "";
                textBoxKompl.Text = "";
                textBoxSerNomer.Text = "";
                textBoxPrice.Text = "";
            }
        } 

        

        private void listViewCars_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                CarsSet carsSet = listViewCars.SelectedItems[0].Tag as CarsSet;
                textBoxMarka.Text = carsSet.Mark;
                textBoxModel.Text = carsSet.Model;
                textBoxKompl.Text = carsSet.Kompl;
                textBoxSerNomer.Text = carsSet.SerNumber;
                textBoxPrice.Text = carsSet.Price;
            }
            else
            {
                textBoxMarka.Text = "";
                textBoxModel.Text = "";
                textBoxKompl.Text = "";
                textBoxSerNomer.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            CarsSet carsSet = new CarsSet();
            carsSet.Mark = textBoxMarka.Text;
            carsSet.Model = textBoxModel.Text;
            carsSet.Kompl = textBoxKompl.Text;
            carsSet.SerNumber = textBoxSerNomer.Text;
            carsSet.Price = textBoxPrice.Text;
            Program.dbmotor.CarsSet.Add(carsSet);
            Program.dbmotor.SaveChanges();
            ShowCars();
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(listViewCars.SelectedItems.Count == 1)
                {
                    CarsSet carsSet = listViewCars.SelectedItems[0].Tag as CarsSet;
                    Program.dbmotor.CarsSet.Remove(carsSet);
                    Program.dbmotor.SaveChanges();
                    ShowCars();
                }
                textBoxMarka.Text = "";
                textBoxModel.Text = "";
                textBoxKompl.Text = "";
                textBoxSerNomer.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count == 1)
            {
                CarsSet carsset = listViewCars.SelectedItems[0].Tag as CarsSet;
                carsset.Mark = textBoxMarka.Text;
                carsset.Model = textBoxModel.Text;
                carsset.Kompl = textBoxKompl.Text;
                carsset.SerNumber = textBoxSerNomer.Text;
                carsset.Price = textBoxPrice.Text;
                Program.dbmotor.SaveChanges();
                ShowCars();
            }
        }
    }
    }

