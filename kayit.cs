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
using System.Data.SqlClient;  // Veri tabanı için kütüphane

namespace Coklu_Zeka_Projesi
{
    public partial class kayit : Form
    {
        int sayac = 0;
        public static string kul_adi,kul_soyadi,kul_cinsiyet,kul_yas,kul_kuladi,kul_sifre;
        public kayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5H7164Q\SQLEXPRESS01;Initial Catalog=cokluzeka.dbo;Integrated Security=True;");



        public void kontrol ()
        {
            
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("select * from kayit where kullanici_adi='" + textBox5.Text + "'", baglanti);
            SqlDataReader dr = komutt.ExecuteReader();
            if (dr.Read())
            {               
                sayac += 1;             
            }
            baglanti.Close();
        }

    private void button1_Click(object sender, EventArgs e)
        {
            kontrol();
            if (textBox1.Text == "" || textBox2.Text == "" ||comboBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Kaydınız Oluşturulamamıştır Lütfen Bütün Alanları Doldurduktan Sonra Tekrar Deneyiniz !", "Eksik Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else if (sayac == 1)
            {
                MessageBox.Show("Kaydınız Oluşturulamamıştır Lütfen Başka Kullanıcı Adıyla Tekrar Deneyiniz !", "Aynı Kullanıcı Adı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox5.Clear();
                sayac = 0;
            }

            else
            {
                    kul_adi = textBox1.Text;
                    kul_soyadi = textBox2.Text;
                    kul_cinsiyet = comboBox1.Text;
                    kul_yas = textBox4.Text;
                    kul_kuladi = textBox5.Text;
                    kul_sifre = textBox6.Text;

                    baglanti.Open();
                    // veri tabanına update yapılamazsa  burası iptal edilecek
                    string sorgu = "insert into kayit(isim,soyisim,cinsiyet,yas,kullanici_adi,sifre)values(@isim,@soyisim,@cinsiyet,@yas,@kullanici_adi,@sifre)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@isim", textBox1.Text);
                    komut.Parameters.AddWithValue("@soyisim", textBox2.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
                    komut.Parameters.AddWithValue("@yas", textBox4.Text);
                    komut.Parameters.AddWithValue("@kullanici_adi", textBox5.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox6.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kaydınız Başarıyla Oluşturulmuştur !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.Text = "";
                    textBox4.Clear();                   
                    textBox5.Clear();
                    textBox6.Clear();

                    Test2 frm = new Test2();
                    frm.Show();
                    this.Close();
                    baglanti.Close();

                // TEST 1 e geçiş
                /*
                test frm = new test();
                frm.Show();
                this.Close();
                baglanti.Close();
                frm.label33.Text = kul_kuladi;
                */
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
