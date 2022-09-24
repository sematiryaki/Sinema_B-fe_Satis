using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satis
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtSu.Text);
            su = Convert.ToInt16(TxtCay.Text);
            cay = Convert.ToInt16(TxtBilet.Text);

            toplam = misir * 35 + cay * 10 + su * 15 + bilet * 65;
            LblToplam.Text = toplam.ToString() + "TL";

            kasatutar += kasatutar + toplam;
            label12.Text = kasatutar.ToString() + "TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = " ";
            TxtSu.Text = " ";
            TxtCay.Text = " ";
            TxtBilet.Text = " ";
            TxtMisir.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
