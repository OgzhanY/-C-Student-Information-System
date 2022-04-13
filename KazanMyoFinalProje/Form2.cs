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
using System.Data.SqlClient;

namespace KazanMyoFinalProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        BolumlerBL bl = new BolumlerBL();
        public string GenerateNewPassword(int size)
        {
            char[] cr = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string result = string.Empty;
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                result += cr[r.Next(0, cr.Length - 1)].ToString();
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            og_sifre.Text = GenerateNewPassword(10);
        }

        void BolumYukle()
        {
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "BolumID";
            cmbBolum2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBolum.DataSource = bl.BolumListesiniGetir();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BolumYukle();

                if (og_tc2.Text != "")

                {
                gncl.Text = "Güncelle";
                }
                else
                {
                og_adi2.ReadOnly = true;
                og_soyadi2.ReadOnly = true;
                og_sicil2.ReadOnly = true;
                og_sil.Enabled = false;
                cmbBolum2.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbBolum2.DisplayMember = "BolumAd";
                cmbBolum2.ValueMember = "BolumID";
                cmbBolum2.DataSource = bl.BolumListesiniGetir();
            }

        }

        private void og_kaydet_Click(object sender, EventArgs e)
        {
            if(og_sifre.Text != "")
            {
                Ogretim_Elemanlari o = new Ogretim_Elemanlari { Ad = og_adi.Text.Trim(), Soyad = og_soyadi.Text.Trim(), SicilNo = Convert.ToInt32(og_sicil.Text), Tc = Convert.ToInt32(og_tc.Text), Sifre = og_sifre.Text.Trim(), BolumID = Convert.ToInt32(cmbBolum.SelectedValue) };
                YoneticiBL yb = new YoneticiBL();
                yb.OgretimGorevlisiEkle(o);
                MessageBox.Show("Kayıt işlemi başarıyla yapıldı !");
            }
            else
            {
                MessageBox.Show("Lütfen rastgele bir şifre oluşturunuz.");
            }
            
        }

        private void gncl_Click(object sender, EventArgs e)
        {
            Ogretim_Elemanlari oe = new Ogretim_Elemanlari { Ad = og_adi2.Text.Trim(), Soyad = og_soyadi2.Text.Trim(), SicilNo = Convert.ToInt32(og_sicil2.Text), Tc = Convert.ToInt32(og_tc2.Text),BolumID = Convert.ToInt32(cmbBolum2.SelectedValue) };
            YoneticiBL yb = new YoneticiBL();
            yb.OgretimGorevlisiUpdate(oe);
            MessageBox.Show("Görevli başarıyla güncellendi !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogretim_Elemanlari oe = ElemanBul(og_tc2.Text.Trim());
            if (oe == null)
            {
                MessageBox.Show("Böyle bir öğretim görevlisi bulunamadı");
            }
            else
            {
                og_adi2.Text = oe.Ad;
                og_soyadi2.Text = oe.Soyad;
                og_sicil2.Text = Convert.ToInt32(oe.SicilNo).ToString();
                og_tc2.Text = Convert.ToInt32(oe.Tc).ToString();
            }
        }

        Ogretim_Elemanlari ElemanBul(string og_tc2)
        {
            Ogretim_Elemanlari oe = null;
            SqlConnection cn = null;
            using (cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=true"))
            {
                SqlParameter[] p = { new SqlParameter("@TC", og_tc2.Trim()) };
                using (SqlCommand cmd = new SqlCommand("Select Ad,Soyad,TC,SicilNo,BolumID from OgretimElemanlari where TC=@TC", cn))
                {
                    cmd.Parameters.AddRange(p);
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        oe = new Ogretim_Elemanlari();
                        oe.Ad = dr["Ad"].ToString();
                        oe.Soyad = dr["Soyad"].ToString();
                        oe.Tc = Convert.ToInt32(dr["TC"].ToString());
                        oe.SicilNo = Convert.ToInt32(dr["SicilNo"].ToString());
                        oe.BolumID = Convert.ToInt32(dr["BolumID"].ToString());
                        og_adi2.ReadOnly = false;
                        og_soyadi2.ReadOnly = false;
                        og_sicil2.ReadOnly = false;
                        og_sil.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Bulunamadı");
                    }
                    dr.Close();
                }
            }
            return oe;
        }

        private void og_tc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("TC kimlik numarası yalnızca sayılardan oluşabilir ");
            }
        }

        private void og_sicil2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sicil No yalnızca sayılardan oluşabilir ");
            }
        }

        private void og_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("TC kimlik numarası yalnızca sayılardan oluşabilir ");
            }
        }

        private void og_sicil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8 && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sicil No yalnızca sayılardan oluşabilir ");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Ogretim_Elemanlari oe = new Ogretim_Elemanlari {Tc = Convert.ToInt32(og_tc2.Text) };
            YoneticiBL yb = new YoneticiBL();
            yb.OgretimGorevlisiSil(oe);
            MessageBox.Show("Görevli başarıyla silindi !");
            og_adi2.Text = "";
            og_sicil2.Text = "";
            og_soyadi2.Text = "";
            cmbBolum2.DisplayMember = null;
            cmbBolum2.ValueMember = null;
            og_tc2.Text = "";
        }
    }
}
