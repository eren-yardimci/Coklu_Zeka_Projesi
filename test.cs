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
    public partial class test : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5H7164Q\SQLEXPRESS01;Initial Catalog=cokluzeka.dbo;Integrated Security=True;Trust Server Certificate=True"); // Veri tabanı bağlantısı
        int sayisalPuan = 0, sozelPuan = 0, gorselPuan = 0, sayisalZekaYuzde, sozelZekaYuzde,
            gorselZekaYuzde;      
        public test()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                int sayisalPuan1 = Convert.ToInt32(textBox1.Text);
                sayisalPuan += sayisalPuan1;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox2.Text) < 0 || Convert.ToDouble(textBox2.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
                int gorselPuan1 = Convert.ToInt32(textBox2.Text);
                gorselPuan += gorselPuan1;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox2.Text = "";
                textBox2.Focus();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox3.Text) < 0 || Convert.ToDouble(textBox3.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
                int sozelPuan1 = Convert.ToInt32(textBox3.Text);
                sozelPuan += sozelPuan1;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox3.Text = "";
                textBox3.Focus();
            }
        }
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox4.Text) < 0 || Convert.ToDouble(textBox4.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox4.Text = "";
                    textBox4.Focus();
                }
                int sozelPuan2 = Convert.ToInt32(textBox4.Text);
                sozelPuan += sozelPuan2;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox4.Text = "";
                textBox4.Focus();
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox5.Text) < 0 || Convert.ToInt32(textBox5.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox5.Text = "";
                    textBox5.Focus();
                }
                int sayisalPuan2 = Convert.ToInt32(textBox5.Text);
                sayisalPuan += sayisalPuan2;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox5.Text = "";
                textBox5.Focus();
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox6.Text) < 0 || Convert.ToDouble(textBox6.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox6.Text = "";
                    textBox6.Focus();
                }
                int gorselPuan2 = Convert.ToInt32(textBox6.Text);
                gorselPuan += gorselPuan2;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox6.Text = "";
                textBox6.Focus();
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox7.Text) < 0 || Convert.ToInt32(textBox7.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox7.Text = "";
                    textBox7.Focus();
                }
                int sayisalPuan3 = Convert.ToInt32(textBox7.Text);
                sayisalPuan += sayisalPuan3;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox7.Text = "";
                textBox7.Focus();
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox8.Text) < 0 || Convert.ToInt32(textBox8.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox8.Text = "";
                    textBox8.Focus();
                }
                int sayisalPuan4 = Convert.ToInt32(textBox8.Text);
                sayisalPuan += sayisalPuan4;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox8.Text = "";
                textBox8.Focus();
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox9.Text) < 0 || Convert.ToInt32(textBox9.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox9.Text = "";
                    textBox9.Focus();
                }
                int sayisalPuan5 = Convert.ToInt32(textBox9.Text);
                sayisalPuan += sayisalPuan5;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox9.Text = "";
                textBox9.Focus();
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox10.Text) < 0 || Convert.ToDouble(textBox10.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox10.Text = "";
                    textBox10.Focus();
                }
                int gorselPuan3 = Convert.ToInt32(textBox10.Text);
                gorselPuan += gorselPuan3;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox10.Text = "";
                textBox10.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true; //diğer paneli kapat.
            panel1.Visible = false;
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox11.Text) < 0 || Convert.ToDouble(textBox11.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox11.Text = "";
                    textBox11.Focus();
                }
                int gorselPuan4 = Convert.ToInt32(textBox11.Text);
                gorselPuan += gorselPuan4;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox11.Text = "";
                textBox11.Focus();
            }
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox12.Text) < 0 || Convert.ToDouble(textBox12.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox12.Text = "";
                    textBox12.Focus();
                }
                int sozelPuan3 = Convert.ToInt32(textBox12.Text);
                sozelPuan += sozelPuan3;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox12.Text = "";
                textBox12.Focus();
            }
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox13.Text) < 0 || Convert.ToDouble(textBox13.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox13.Text = "";
                    textBox13.Focus();
                }
                int gorselPuan5 = Convert.ToInt32(textBox13.Text);
                gorselPuan += gorselPuan5;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox13.Text = "";
                textBox13.Focus();
            }
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox14.Text) < 0 || Convert.ToDouble(textBox14.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox14.Text = "";
                    textBox14.Focus();
                }
                int sozelPuan4 = Convert.ToInt32(textBox14.Text);
                sozelPuan += sozelPuan4;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox14.Text = "";
                textBox14.Focus();
            }
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox15.Text) < 0 || Convert.ToDouble(textBox15.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox15.Text = "";
                    textBox15.Focus();
                }
                int gorselPuan6 = Convert.ToInt32(textBox15.Text);
                gorselPuan += gorselPuan6;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox15.Text = "";
                textBox15.Focus();
            }
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox16.Text) < 0 || Convert.ToInt32(textBox16.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox16.Text = "";
                    textBox16.Focus();
                }
                int sayisalPuan6 = Convert.ToInt32(textBox16.Text);
                sayisalPuan += sayisalPuan6;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox16.Text = "";
                textBox16.Focus();
            }
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox17.Text) < 0 || Convert.ToDouble(textBox17.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox17.Text = "";
                    textBox17.Focus();
                }
                int gorselPuan7 = Convert.ToInt32(textBox17.Text);
                gorselPuan += gorselPuan7;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox17.Text = "";
                textBox17.Focus();
            }
        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox18.Text) < 0 || Convert.ToDouble(textBox18.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox18.Text = "";
                    textBox18.Focus();
                }
                int sozelPuan5 = Convert.ToInt32(textBox18.Text);
                sozelPuan += sozelPuan5;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox18.Text = "";
                textBox18.Focus();
            }
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox19.Text) < 0 || Convert.ToDouble(textBox19.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox19.Text = "";
                    textBox19.Focus();
                }
                int gorselPuan8 = Convert.ToInt32(textBox19.Text);
                gorselPuan += gorselPuan8;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox19.Text = "";
                textBox19.Focus();
            }
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox20.Text) < 0 || Convert.ToInt32(textBox20.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox20.Text = "";
                    textBox20.Focus();
                }
                int sayisalPuan7 = Convert.ToInt32(textBox20.Text);
                sayisalPuan += sayisalPuan7;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox20.Text = "";
                textBox20.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true; //diğer paneli kapat.
            panel2.Visible = false;
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox21.Text) < 0 || Convert.ToDouble(textBox21.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox21.Text = "";
                    textBox21.Focus();
                }
                int gorselPuan9 = Convert.ToInt32(textBox21.Text);
                gorselPuan += gorselPuan9;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox21.Text = "";
                textBox21.Focus();
            }
        }
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox22.Text) < 0 || Convert.ToDouble(textBox22.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox22.Text = "";
                    textBox22.Focus();
                }
                int sozelPuan6 = Convert.ToInt32(textBox22.Text);
                sozelPuan += sozelPuan6;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox22.Text = "";
                textBox22.Focus();
            }
        }
        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox23.Text) < 0 || Convert.ToInt32(textBox23.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox23.Text = "";
                    textBox23.Focus();
                }
                int sayisalPuan8 = Convert.ToInt32(textBox23.Text);
                sayisalPuan += sayisalPuan8;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox23.Text = "";
                textBox23.Focus();
            }
        }
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox24.Text) < 0 || Convert.ToDouble(textBox24.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox24.Text = "";
                    textBox24.Focus();
                }
                int sozelPuan7 = Convert.ToInt32(textBox24.Text);
                sozelPuan += sozelPuan7;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox24.Text = "";
                textBox24.Focus();
            }
        }
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox25.Text) < 0 || Convert.ToDouble(textBox25.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox25.Text = "";
                    textBox25.Focus();
                }
                int gorselPuan10 = Convert.ToInt32(textBox25.Text);
                gorselPuan += gorselPuan10;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox25.Text = "";
                textBox25.Focus();
            }
        }
        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox26.Text) < 0 || Convert.ToInt32(textBox26.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox26.Text = "";
                    textBox26.Focus();
                }
                int sayisalPuan9 = Convert.ToInt32(textBox26.Text);
                sayisalPuan += sayisalPuan9;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox26.Text = "";
                textBox26.Focus();
            }
        }
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox27.Text) < 0 || Convert.ToDouble(textBox27.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox27.Text = "";
                    textBox27.Focus();
                }
                int sozelPuan8 = Convert.ToInt32(textBox27.Text);
                sozelPuan += sozelPuan8;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox27.Text = "";
                textBox27.Focus();
            }
        }
        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox28.Text) < 0 || Convert.ToDouble(textBox28.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox28.Text = "";
                    textBox28.Focus();
                }
                int sozelPuan9 = Convert.ToInt32(textBox28.Text);
                sozelPuan += sozelPuan9;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox28.Text = "";
                textBox28.Focus();
            }
        }
        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox29.Text) < 0 || Convert.ToInt32(textBox29.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox29.Text = "";
                    textBox29.Focus();
                }
                int sayisalPuan10 = Convert.ToInt32(textBox29.Text);
                sayisalPuan += sayisalPuan10;
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer girin");
                textBox29.Text = "";
                textBox29.Focus();
            }
        }
        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(textBox30.Text) < 0 || Convert.ToDouble(textBox30.Text) > 5)
                {
                    MessageBox.Show("Değer 0-5 arasında olmalı");
                    textBox30.Text = "";
                    textBox30.Focus();
                }
                int sozelPuan10 = Convert.ToInt32(textBox30.Text);
                sozelPuan += sozelPuan10;
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox30.Text = "";
                textBox30.Focus();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sayisalZekaYuzde = sayisalPuan/50 * 100;
            sozelZekaYuzde = sozelPuan/50 * 100;
            gorselZekaYuzde = gorselPuan/50 * 100;

            // veri tabanına update yapılamazsa burası iptal edilecek
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("update kayit set sayisal_zeka_yuzde=@sayisal_zeka_yuzde,sozel_zeka_yuzde=@sozel_zeka_yuzde,gorsel_zeka_yuzde=@gorsel_zeka_yuzde where kullanici_adi='" + kayit.kul_kuladi + "'", baglanti);
            komutGuncelle.Parameters.AddWithValue("@sayisal_zeka_yuzde", sayisalZekaYuzde);
            komutGuncelle.Parameters.AddWithValue("@sozel_zeka_yuzde", sozelZekaYuzde);
            komutGuncelle.Parameters.AddWithValue("@gorsel_zeka_yuzde", gorselZekaYuzde);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            //

            /* veri tabanına update yapılamazsa burası devreye girsin
            baglanti.Open();
            string sorgu = "insert into kayit(isim,soyisim,cinsiyet,yas,kullanici_adi,sifre,sayisal_zeka_yuzde,sozel_zeka_yuzde,gorsel_zeka_yuzde)values(@isim,@soyisim,@cinsiyet,@yas,@kullanici_adi,@sifre,@sayisal_zeka_yuzde,@sozel_zeka_yuzde,@gorsel_zeka_yuzde)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@isim", kayit.kul_adi);
            komut.Parameters.AddWithValue("@soyisim", kayit.kul_soyadi);
            komut.Parameters.AddWithValue("@cinsiyet", kayit.kul_cinsiyet);
            komut.Parameters.AddWithValue("@yas", kayit.kul_yas);
            komut.Parameters.AddWithValue("@kullanici_adi", kayit.kul_kuladi);
            komut.Parameters.AddWithValue("@sifre", kayit.kul_sifre);
            komut.Parameters.AddWithValue("@sayisal_zeka_yuzde", sayisalZekaYuzde);
            komut.Parameters.AddWithValue("@sozel_zeka_yuzde", sozelZekaYuzde);
            komut.Parameters.AddWithValue("@gorsel_zeka_yuzde", gorselZekaYuzde);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Başarıyla Oluşturulmuştur !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            */

            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();

            frm.Hesaplama(sayisalZekaYuzde, sozelZekaYuzde, gorselZekaYuzde);
            frm.CokluZekaYuzde(anasayfa.sayisal, anasayfa.sozel, anasayfa.gorsel);
            frm.ZayifZekaBul(sayisalZekaYuzde, sozelZekaYuzde, gorselZekaYuzde);
            frm.label1.Text = "Hoşgeldin " + kayit.kul_adi;
            frm.label2.Text = kayit.kul_adi + " " + kayit.kul_soyadi + "\n(Yaş : " + kayit.kul_yas + ") ";

            
            
        }
        
    }
}
