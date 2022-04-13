using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace KazanMyoFinalProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        YoneticiBL yeg = new YoneticiBL();
        OgrenciBL og = new OgrenciBL();
        OgretimElemaniBL oeg = new OgretimElemaniBL();

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = og.OgrenciGiris(Convert.ToInt32(ogr_no.Text), txt_sifre.Text);
            if (!(ogr == null))
            {
                MessageBox.Show("Sisteme girildi !");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogretim_Elemanlari oe = oeg.OgretimElemaniGiris(Convert.ToInt32(og_tc.Text),txt_sifre2.Text);
            if (!(oe == null))
            {
                MessageBox.Show("Sisteme girildi !");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yoneticiler ye = yeg.YoneticiGiris(y_kadi.Text, y_sifre.Text);
            if (!(ye == null))
            {
                MessageBox.Show("Sisteme girildi !"); 
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !");
            }
        }
    }
}
