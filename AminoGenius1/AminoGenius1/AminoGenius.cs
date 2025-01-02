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
    public partial class AminoGenius : Form
    {
        public AminoGenius()
        {
            InitializeComponent();
        }

        private void AminoGenius_Load(object sender, EventArgs e)
        {
            MessageBox.Show("AminoGenius'a Hoşgeldinizzz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alanin goster= new Alanin();
            goster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arjinin goster = new Arjinin();
            goster.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Asparajin goster = new Asparajin(); 
            goster.Show();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aspartikasit goster = new Aspartikasit();
            goster.Show();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sistein goster = new Sistein(); 
            goster.Show();  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Glütamikasit goster = new Glütamikasit();
            goster.Show();  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Glütamin goster = new Glütamin();
            goster.Show();  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Glisin goster = new Glisin();
            goster.Show();  
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Histidin goster = new Histidin();   
            goster.Show();  
        }

        private void button10_Click(object sender, EventArgs e)
        {
            İzolösin goster= new İzolösin();
            goster.Show();  
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Lösin goster = new Lösin();
            goster.Show();  
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Lizin goster = new Lizin(); 
            goster.Show();  
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Metiyonin goster = new Metiyonin(); 
            goster.Show();  
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Fenilalanin goster = new Fenilalanin(); 
            goster.Show();  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Prolin goster= new Prolin();
            goster.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Serin goster= new Serin();  
            goster.Show();  
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Treonin goster= new Treonin();  
            goster.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Triptofan goster= new Triptofan();
            goster.Show();  
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Tirozin goster= new Tirozin();  
            goster.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Valin goster= new Valin();
            goster.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Besindeğeri goster= new Besindeğeri();
            goster.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Nekadar goster= new Nekadar();
            goster.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Neyimeksik goster= new Neyimeksik();
            goster.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Kendinyap goster= new Kendinyap();  
            goster.Show();
        }
    }
}
