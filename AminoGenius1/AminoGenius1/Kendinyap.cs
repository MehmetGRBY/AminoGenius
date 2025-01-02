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
    public partial class Kendinyap : Form
    {

        private string[] veriler = new string[]
        {
            "Kollajen",
            "Albümin",
            "Globülin",
            "Globin",
            "Glutelin",
            "Prolamin",
            "Protamin",
            "Histon",
            "Fibril",
            "Keratin",
            "Elastin",
            "Fibrinojen",
            "Fiyozin",
            "Proteoglikan",
            "Lipoprotein",
            "Kazein",
            "Nükleoprotein",
            "Ferritin",
            "Transferrin",
            "Seruloplazmin",
            "Hemoglobin",
            "Miyoglobin",
            "Sitokrom",
            "Peroksidaz",
            "Protean",
            "Metaprotein",
            "Koagule",
            "Proteoz",
            "Peptit",
            "Oligopeptit",



        };

        private Random random = new Random();

        public Kendinyap()
        {
            InitializeComponent();
        }

        private void Kendinyap_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            radioButton8.Checked = true;
            radioButton9.Checked = true;
            radioButton10.Checked = true;
            radioButton11.Checked = true;
            radioButton12.Checked = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = random.Next(veriler.Length);

            textBox1.Text = veriler[index];

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = true;
            radioButton3.Checked = true;
            radioButton4.Checked = true;
            radioButton5.Checked = true;
            radioButton6.Checked = true;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lösin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            radioButton13.Checked = true;
            radioButton14.Checked = true;
            radioButton15.Checked = true;
            radioButton16.Checked = true;
            radioButton17.Checked = true;
            radioButton18.Checked = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
