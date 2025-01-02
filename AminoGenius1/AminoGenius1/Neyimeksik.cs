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
    public partial class Neyimeksik : Form
    {
        public Neyimeksik()
        {
            InitializeComponent();
            LoadComboBoxItems();

        }
        private void LoadComboBoxItems()
        {
            comboBox1.Items.Add("Baş Ağrısı");
            comboBox1.Items.Add("Grip");
            comboBox1.Items.Add("Vücut Ağrısı");
            comboBox1.Items.Add("Ülser");
            comboBox1.Items.Add("Kolestrol");
            comboBox1.Items.Add("Alzheimer");
            comboBox1.Items.Add("Depresyon");
            comboBox1.Items.Add("Hormon Bozukluğu");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Baş Ağrısı")
                {
                    textBox1.Text = "Herhangi bir aminoasit eksikliği baş ağrısına neden olacağından aminoasit farketmeksizin 50mg civarı alınabilir.";
                }
                else if (comboBox1.SelectedItem.ToString() == "Grip")
                {
                    textBox1.Text = "Fenilalanin diğer aminoasitlerin üretime yardımcı olduğundan alınırsa gribi en kısa sürede atlatmanıza yardımcı olur. Günlük 135mg yeterli olacaktır.";

                }
                else if (comboBox1.SelectedItem.ToString() == "Vücut Ağrısı")
                {
                    textBox1.Text = "Metiyonin vücudu daha güçlü ve dirençli hale getirdiğinden vücut ağrıları için birebirdir. Günlük 120mg Metiyonin yeterli olacaktır.";

                }
                else if (comboBox1.SelectedItem.ToString() == "Ülser")
                {
                    textBox1.Text = "Aspartik Asit mide asidini düzenlemeye yardımcı olduğundan ülser için iyi bir arkadaştır. Günlük 75mg yeterlidir.";

                }
                else if (comboBox1.SelectedItem.ToString() == "Kolestrol")
                {
                    textBox1.Text = "İzolösin kolestrolun en büyük düşmanı olduğundan çok iyi bir takviyedir. Günlük 15mg önerilir.";

                }
                else if (comboBox1.SelectedItem.ToString() == "Alzheimer")
                {
                    textBox1.Text = "Arjinin, Asparajin ve Glutamik Asit beynin hafıza bölgesini güçlendirir. Her birinden günlük 12mg önerilir.";

                }
                else if (comboBox1.SelectedItem.ToString() == "Depresyon")
                {
                    textBox1.Text = "Valin odaklanmaya ve sakinliği tetiklediğinden depresyon için kullanılabilir. Günlük 25mg Valin yeterlidir.";

                }
                else if (comboBox1.SelectedItem.ToString() == "Hormon Bozukluğu")
                {
                    textBox1.Text = "Lizin Hormonal bozukluklarda hem kadınlara hem erkeklere kullanılabilen bir amino asittir. Günlük 50mg Lizin kullanımı önerilir.";

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
