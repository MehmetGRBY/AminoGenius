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
    public partial class Besindeğeri : Form
    {
        public Besindeğeri()
        {
            InitializeComponent();
            LoadComboBoxItems(); // Combobox öğelerini yükler
        }

        private void LoadComboBoxItems()
        {
            comboBox1.Items.Add("Tavuk Grubu (100gr)");
            comboBox1.Items.Add("Et Grubu (100gr)");
            comboBox1.Items.Add("Sebze Grubu (100gr)");
            comboBox1.Items.Add("Meyve Grubu (100gr)");
            comboBox1.Items.Add("Şekerler (100gr)");
            comboBox1.Items.Add("Yağlar (100gr)");
            comboBox1.Items.Add("Ekmek ve Tahıl Grubu (100gr)");
            comboBox1.Items.Add("Süt Ürünleri (100gr)");
        }

        private void Besindeğeri_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışır
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combobox'taki seçim değiştiğinde çalışır
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) // Combobox'tan bir öğe seçilmişse
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Tavuk Grubu (100gr)":
                        textBox1.Text = "100 gr Tavukta bulunan amino asitler:\n" +
                                         "Histidin: 770 mg \n" +
                                         "İzolösin: 1060 mg \n" +
                                         "Lösin: 1730 mg \n" +
                                         "Lizin: 1950 mg \n" +
                                         "Metionin: 580 mg \n" +
                                         "Fenilalanin: 780 mg \n" +
                                         "Treonin: 940 mg \n" +
                                         "Triptofan: 220 mg \n" +
                                         "Valin: 1060 mg \n" +
                                         "Arjinin: 1330 mg \n" +
                                         "Alanin: 1200 mg \n" +
                                         "Aspartik Asit: 2090 mg \n" +
                                         "Glutamik Asit: 3430 mg \n" +
                                         "Glisin: 970 mg \n" +
                                         "Prolin: 910 mg \n" +
                                         "Serin: 880 mg \n" +
                                         "Tirozin: 710 mg";
                        break;
                    case "Et Grubu (100gr)":
                        textBox1.Text = "100 gr Kırmızı Ette bulunan amino asitler:\n" +
                                        "Histidin: 820 mg \n" +
                                        "İzolösin: 1040 mg \n" +
                                        "Lösin: 1740 mg \n" +
                                        "Lizin: 1870 mg \n" +
                                        "Metionin: 540 mg \n" +
                                        "Fenilalanin: 850 mg \n" +
                                        "Treonin: 920 mg \n" +
                                        "Triptofan: 220 mg \n" +
                                        "Valin: 1050 mg \n" +
                                        "Arjinin: 1300 mg \n" +
                                        "Alanin: 1230 mg \n" +
                                        "Aspartik Asit: 2070 mg \n" +
                                        "Glutamik Asit: 3450 mg \n" +
                                        "Glisin: 1120 mg \n" +
                                        "Prolin: 1050 mg \n" +
                                        "Serin: 860 mg \n" +
                                        "Tirozin: 730 mg";

                        break;
                    case "Sebze Grubu (100gr)":
                        textBox1.Text = "100 gr Sebzede bulunan amino asitler:\n" +
                                        "Histidin: 250 mg \n" +
                                        "İzolösin: 420 mg \n" +
                                        "Lösin: 650 mg \n" +
                                        "Lizin: 530 mg \n" +
                                        "Metionin: 150 mg \n" +
                                        "Fenilalanin: 430 mg \n" +
                                        "Treonin: 380 mg \n" +
                                        "Triptofan: 90 mg \n" +
                                        "Valin: 490 mg \n" +
                                        "Arjinin: 600 mg \n" +
                                        "Alanin: 480 mg \n" +
                                        "Aspartik Asit: 860 mg \n" +
                                        "Glutamik Asit: 1050 mg \n" +
                                        "Glisin: 350 mg \n" +
                                        "Prolin: 320 mg \n" +
                                        "Serin: 400 mg \n" +
                                        "Tirozin: 270 mg";
                        break;
                    case "Meyve Grubu (100gr)":
                        textBox1.Text = "100 gr Meyvede bulunan amino asitler:\n" +
                                        "Histidin: 60 mg \n" +
                                        "İzolösin: 130 mg \n" +
                                        "Lösin: 220 mg \n" +
                                        "Lizin: 170 mg \n" +
                                        "Metionin: 40 mg \n" +
                                        "Fenilalanin: 160 mg \n" +
                                        "Treonin: 160 mg \n" +
                                        "Triptofan: 40 mg \n" +
                                        "Valin: 170 mg \n" +
                                        "Arjinin: 200 mg \n" +
                                        "Alanin: 150 mg \n" +
                                        "Aspartik Asit: 250 mg \n" +
                                        "Glutamik Asit: 300 mg \n" +
                                        "Glisin: 110 mg \n" +
                                        "Prolin: 120 mg \n" +
                                        "Serin: 140 mg \n" +
                                        "Tirozin: 90 mg";
                        break;
                    case "Şekerler (100gr)":
                        textBox1.Text = "100 gr Şekerde bulunan amino asitler:\n" +
                                        "Histidin: 5 mg \n" +
                                        "İzolösin: 10 mg \n" +
                                        "Lösin: 20 mg \n" +
                                        "Lizin: 15 mg \n" +
                                        "Metionin: 5 mg \n" +
                                        "Fenilalanin: 10 mg \n" +
                                        "Treonin: 15 mg \n" +
                                        "Triptofan: 5 mg \n" +
                                        "Valin: 10 mg \n" +
                                        "Arjinin: 20 mg \n" +
                                        "Alanin: 10 mg \n" +
                                        "Aspartik Asit: 20 mg \n" +
                                        "Glutamik Asit: 30 mg \n" +
                                        "Glisin: 10 mg \n" +
                                        "Prolin: 10 mg \n" +
                                        "Serin: 10 mg \n" +
                                        "Tirozin: 5 mg";

                        break;
                    case "Yağlar (100gr)":
                        textBox1.Text = "100 gr Yağda bulunan amino asitler:\n" +
                                        "Histidin: 5 mg \n" +
                                        "İzolösin: 15 mg \n" +
                                        "Lösin: 25 mg \n" +
                                        "Lizin: 20 mg \n" +
                                        "Metionin: 5 mg \n" +
                                        "Fenilalanin: 15 mg \n" +
                                        "Treonin: 20 mg \n" +
                                        "Triptofan: 5 mg \n" +
                                        "Valin: 15 mg \n" +
                                        "Arjinin: 30 mg \n" +
                                        "Alanin: 20 mg\n" +
                                        "Aspartik Asit: 30 mg \n" +
                                        "Glutamik Asit: 40 mg \n" +
                                        "Glisin: 15 mg \n" +
                                        "Prolin: 15 mg \n" +
                                        "Serin: 15 mg \n" +
                                        "Tirozin: 10 mg";
                        break;
                    case "Ekmek ve Tahıl Grubu (100gr)":
                        textBox1.Text = "100 gr Ekmek ve Tahılda bulunan amino asitler:\n" +
                                        "Histidin: 200 mg \n" +
                                        "İzolösin: 400 mg \n" +
                                        "Lösin: 700 mg \n" +
                                        "Lizin: 250 mg \n" +
                                        "Metionin: 150 mg \n" +
                                        "Fenilalanin: 500 mg \n" +
                                        "Treonin: 300 mg \n" +
                                        "Triptofan: 80 mg \n" +
                                        "Valin: 450 mg \n" +
                                        "Arjinin: 350 mg \n" +
                                        "Alanin: 400 mg \n" +
                                        "Aspartik Asit: 850 mg \n" +
                                        "Glutamik Asit: 4500 mg \n" +
                                        "Glisin: 300 mg \n" +
                                        "Prolin: 500 mg \n" +
                                        "Serin: 350 mg \n" +
                                        "Tirozin: 300 mg";
                        break;
                    case "Süt Ürünleri (100gr)":
                        textBox1.Text = "100 gr Süt Ürünlerinde bulunan amino asitler:\n" +
                    "Histidin: 32 mg \n" +
                    "İzolösin: 80 mg \n" +
                    "Lösin: 120 mg \n" +
                    "Lizin: 100 mg \n" +
                    "Metionin: 30 mg \n" +
                    "Fenilalanin: 60 mg \n" +
                    "Treonin: 70 mg \n" +
                    "Triptofan: 20 mg \n" +
                    "Valin: 80 mg \n" +
                    "Arjinin: 80 mg \n" +
                    "Alanin: 60 mg \n" +
                    "Aspartik Asit: 110 mg \n" +
                    "Glutamik Asit: 370 mg \n" +
                    "Glisin: 40 mg \n" +
                    "Prolin: 250 mg \n" +
                    "Serin: 80 mg \n" +
                    "Tirozin: 50 mg";
                        break;
                    default:
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Textbox'taki metin değiştiğinde çalışır
        }
    }
}

