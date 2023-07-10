using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numecombo.SelectedItem.ToString()=="Latte")
            {
                if (tipcombo.SelectedItem.ToString() == "Frappe")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 7.5).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Iced")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 5.5).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Hot")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 5).ToString();

                }
                dataGridView1.Rows.Add(idtext.Text, numecombo.Text, tipcombo.Text, cantitatecombo.Text, platatext.Text);
            }
            else if (numecombo.SelectedItem.ToString()== "Cappuccino")
            {
                if (tipcombo.SelectedItem.ToString() == "Frappe")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 8).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Iced")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 6).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Hot")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 5.5).ToString();

                }
                dataGridView1.Rows.Add(idtext.Text, numecombo.Text, tipcombo.Text, cantitatecombo.Text, platatext.Text);

            }
            else if (numecombo.SelectedItem.ToString() == "Espresso")
            {
                if (tipcombo.SelectedItem.ToString() == "Frappe")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 12).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Iced")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 10.5).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Hot")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 10).ToString();

                }
                dataGridView1.Rows.Add(idtext.Text, numecombo.Text, tipcombo.Text, cantitatecombo.Text, platatext.Text);

            }
            else if (numecombo.SelectedItem.ToString() == "Americano")
            {
                if (tipcombo.SelectedItem.ToString() == "Frappe")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 10).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Iced")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 8.5).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Hot")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 7.5).ToString();

                }
                dataGridView1.Rows.Add(idtext.Text, numecombo.Text, tipcombo.Text, cantitatecombo.Text, platatext.Text);

            }
            else if (numecombo.SelectedItem.ToString() == "Irish Coffee")
            {
                if (tipcombo.SelectedItem.ToString() == "Frappe")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 15).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Iced")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 10).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Hot")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 8.5).ToString();

                }
                dataGridView1.Rows.Add(idtext.Text, numecombo.Text, tipcombo.Text, cantitatecombo.Text, platatext.Text);

            }
            else if (numecombo.SelectedItem.ToString() == "Black Coffee")
            {
                if (tipcombo.SelectedItem.ToString() == "Frappe")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 12.5).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Iced")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 10).ToString();
                }
                if (tipcombo.SelectedItem.ToString() == "Hot")
                {
                    platatext.Text = (float.Parse(cantitatecombo.Text) * 8).ToString();

                }
                dataGridView1.Rows.Add(idtext.Text, numecombo.Text, tipcombo.Text, cantitatecombo.Text, platatext.Text);

            }
        }

        private void idtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (Char)Keys.Back;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            numecombo.Text = "";
            tipcombo.Text = "";
            cantitatecombo.Text = "";
            platatext.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
