using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AminoGenius1
{
    public partial class Nekadar : Form
    {
        public Nekadar()
        {
            InitializeComponent();
            LoadComboBoxItems();
        }

        private void LoadComboBoxItems()
        {
            comboBox1.Items.Add("Erkek");
            comboBox1.Items.Add("Kadın");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = double.Parse(textBox3.Text);
            double kilo = double.Parse(textBox2.Text);
            int yas = int.Parse(textBox1.Text);
            double yasFaktoru = 1.0;

            if (yas >= 0 && yas <= 20)
            {
                yasFaktoru = 1.25;
            }
            else if (yas > 20 && yas <= 50)
            {
                yasFaktoru = 1.0;
            }
            else if (yas > 50)
            {
                yasFaktoru = 0.75;
            }

            double aminomiktari = ((yas * yasFaktoru * kilo) / boy) * 100;

            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Erkek")
                {
                    aminomiktari *= 1.25;
                }
                else if (comboBox1.SelectedItem.ToString() == "Kadın")
                {
                    aminomiktari *= 0.75;
                }
            }




            textBox4.Text = $"{aminomiktari} mg";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nekadar_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}