using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;  // Veri tabanı için kütüphane
using System.Data.SqlClient;  //// Veri tabanı için kütüphane

namespace Coklu_Zeka_Projesi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';  // Girilen şifrenin gizlenmesi için
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5H7164Q\SQLEXPRESS01;Initial Catalog=cokluzeka.dbo;Integrated Security=True;");


        public static string giris_adi, giris_soyadi, giris_cinsiyet, giris_yas, giris_kuladi, giris_sifre, giris_sayisal_Zeka, giris_sozel_Zeka, giris_gorsel_Zeka;

        private void button2_Click(object sender, EventArgs e)
        {
            kayit frm = new kayit();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kayit where kullanici_adi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {                               
                giris_adi = dr[1].ToString();
                giris_soyadi = dr[2].ToString();
                giris_cinsiyet = dr[3].ToString();
                giris_yas = dr[4].ToString();
                giris_kuladi = dr[5].ToString();
                giris_sayisal_Zeka = dr[7].ToString();
                giris_sozel_Zeka = dr[8].ToString();
                giris_gorsel_Zeka = dr[9].ToString();
                textBox1.Clear();
                textBox2.Clear();
                anasayfa frm = new anasayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                textBox1.Clear();
                textBox2.Clear();
            }
            baglanti.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Programı Kapatmak İstiyor musunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secim == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Çıkış İşlemi İptal Edildi !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
