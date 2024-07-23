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
    public partial class Test2 : Form
    {
        Image[] Soru1 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel1.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel2.png") };
        Image[] Soru2 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel3.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel4.png") };
        Image[] Soru3 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel6.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel7.png") };
        Image[] Soru4 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel8.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel9.png") };
        Image[] Soru5 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel10.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sozel11.png") };
        Image[] Soru6 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal1.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal2.png") };
        Image[] Soru7 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal3.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal4.png") };
        Image[] Soru8 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal5.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal6.png") };
        Image[] Soru9 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal7.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal8.png") };
        Image[] Soru10 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal9.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\sayisal10.png") };
        Image[] Soru11 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel1.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel2.png") };
        Image[] Soru12 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel3.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel4.png") };
        Image[] Soru13 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel5.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel6.png") };
        Image[] Soru14 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel7.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel8.png") };
        Image[] Soru15 = { Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel9.png"), Image.FromFile(@"C:\Users\eren\Desktop\Test_Sorularıı\Test_Soruları\gorsel10.png") };

        int sayisal = 0, sozel = 0, gorsel = 0, sayisalYuzde, sozelYuzde, gorselYuzde, zayif;
        float fsayisalYuzde, fsozelYuzde, fgorselYuzde;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5H7164Q\SQLEXPRESS01;Initial Catalog=cokluzeka.dbo;Integrated Security=True;"); // Veri tabanı bağlantısı

        public Test2()
        {
            InitializeComponent();
        }

        private void Test2_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // başla butonuyla 1 - 2 -3. soruların gelmesi
            button1.Visible = false;
            panel2.Visible = true;

            // hangi soruların geleceğinin belirlenmesi
            Random rastgele1 = new Random();
            int soru1 = rastgele1.Next(0, Soru1.Length);
            pictureBox1.Image = Soru1[soru1];
            // soruların şıklarının ayarlanması
            if (pictureBox1.Image == Soru1[0])
            {
                radioButton1.Text = "Takım:Futbolcu";
                radioButton2.Text = "Okul:Öğrenci";
                radioButton3.Text = "Hastane:Hasta";
                radioButton4.Text = "Şirket:Direktör";
            }
            else if (pictureBox1.Image == Soru1[1])
            {
                radioButton1.Text = "Hayalperest";
                radioButton2.Text = "Somurtkan";
                radioButton3.Text = "Alçak gönüllü";
                radioButton4.Text = "Buyurgan";
            }

            Random rastgele2 = new Random();
            int soru2 = rastgele2.Next(0, Soru2.Length);
            pictureBox2.Image = Soru2[soru2];
            if (pictureBox2.Image == Soru2[0])
            {
                radioButton5.Text = "Kötü";
                radioButton6.Text = "İyi";
                radioButton7.Text = "Orta";
                radioButton8.Text = "Tembel";
            }
            else if (pictureBox2.Image == Soru2[1])
            {
                radioButton5.Text = "Akıllı";
                radioButton6.Text = "Uslu";
                radioButton7.Text = "Temiz";
                radioButton8.Text = "Yaramaz";
            }
            Random rastgele3 = new Random();
            int soru3 = rastgele3.Next(0, Soru3.Length);
            pictureBox3.Image = Soru3[soru3];
            if (pictureBox3.Image == Soru3[0])
            {
                radioButton9.Text = "% 100 Kalıtımsal";
                radioButton10.Text = "% 50 Çevresel , % 50 Kalıtımsal";
                radioButton11.Text = "% 70 Kalıtımsal , % 30 Çevresel";
                radioButton12.Text = "% 60 Çevresel , % 40 Kalıtımsal";
            }
            else if (pictureBox3.Image == Soru3[1])
            {
                radioButton9.Text = "sevmediğini söylemiştir.";
                radioButton10.Text = "sevmediğini ima etmiştir.";
                radioButton11.Text = "sevdiğini söylemiştir.";
                radioButton12.Text = "sevmediğini ima etmiştir.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cevap kontrolü (1 - 2 - 3)
            if (pictureBox1.Image == Soru1[0] && radioButton4.Checked)
            {
                sozel += 5;
            }
            if (pictureBox1.Image == Soru1[1] && radioButton3.Checked)
            {
                sozel += 5;
            }
            if (pictureBox2.Image == Soru2[0] && radioButton7.Checked)
            {
                sozel += 5;
            }
            if (pictureBox2.Image == Soru2[1] && radioButton5.Checked)
            {
                sozel += 5;
            }
            if (pictureBox3.Image == Soru3[0] && radioButton11.Checked)
            {
                sozel += 5;
            }
            if (pictureBox3.Image == Soru3[1] && radioButton10.Checked)
            {
                sozel += 5;
            }
            // radiobutton seçimlerini kaldır
            SecimleriTemizle();

            Random rastgele4 = new Random();
            int soru4 = rastgele4.Next(0, Soru4.Length);
            pictureBox1.Image = Soru4[soru4];
            if (pictureBox1.Image == Soru4[0])
            {
                radioButton1.Text = "K";
                radioButton2.Text = "S";
                radioButton3.Text = "Z";
                radioButton4.Text = "U";
            }
            else if (pictureBox1.Image == Soru4[1])
            {
                radioButton1.Text = "E";
                radioButton2.Text = "İ";
                radioButton3.Text = "A";
                radioButton4.Text = "U";
            }

            Random rastgele5 = new Random();
            int soru5 = rastgele5.Next(0, Soru5.Length);
            pictureBox2.Image = Soru5[soru5];
            if (pictureBox2.Image == Soru5[0])
            {
                radioButton5.Text = "Kulak";
                radioButton6.Text = "Ceza";
                radioButton7.Text = "Yunus";
                radioButton8.Text = "Uçak";
            }
            else if (pictureBox2.Image == Soru5[1])
            {
                radioButton5.Text = "Sahaf";
                radioButton6.Text = "Bahar";
                radioButton7.Text = "Dahi";
                radioButton8.Text = "Reçete";
            }

            Random rastgele6 = new Random();
            int soru6 = rastgele6.Next(0, Soru5.Length);
            pictureBox3.Image = Soru6[soru6];
            if (pictureBox3.Image == Soru6[0])
            {
                radioButton9.Text = "317";
                radioButton10.Text = "327";
                radioButton11.Text = "607";
                radioButton12.Text = "627";
            }
            else if (pictureBox3.Image == Soru6[1])
            {
                radioButton9.Text = "319";
                radioButton10.Text = "359";
                radioButton11.Text = "509";
                radioButton12.Text = "609";
            }
            button2.Visible = false;
            button3.Visible = true;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            // cevap kontrolü(4-5-6)
            if (pictureBox1.Image == Soru4[0] && radioButton1.Checked)
            {
                sozel += 5;
            }
            if (pictureBox1.Image == Soru4[1] && radioButton1.Checked)
            {
                sozel += 5;
            }
            if (pictureBox2.Image == Soru5[0] && radioButton7.Checked)
            {
                sozel += 5;
            }
            if (pictureBox2.Image == Soru5[1] && radioButton5.Checked)
            {
                sozel += 5;
            }
            if (pictureBox3.Image == Soru6[0] && radioButton11.Checked)
            {
                sayisal += 5;
            }
            if (pictureBox3.Image == Soru6[1] && radioButton12.Checked)
            {
                sayisal += 5;
            }
            // radiobutton seçimlerini kaldır            
            SecimleriTemizle();

            Random rastgele7 = new Random();
            int soru7 = rastgele7.Next(0, Soru7.Length);
            pictureBox1.Image = Soru7[soru7];
            if (pictureBox1.Image == Soru7[0])
            {
                radioButton1.Text = "39";
                radioButton2.Text = "40";
                radioButton3.Text = "41";
                radioButton4.Text = "42";
            }
            else if (pictureBox1.Image == Soru7[1])
            {
                radioButton1.Text = "23";
                radioButton2.Text = "24";
                radioButton3.Text = "25";
                radioButton4.Text = "26";
            }

            Random rastgele8 = new Random();
            int soru8 = rastgele8.Next(0, Soru8.Length);
            pictureBox2.Image = Soru8[soru8];
            if (pictureBox2.Image == Soru8[0])
            {
                radioButton5.Text = "4";
                radioButton6.Text = "5";
                radioButton7.Text = "6";
                radioButton8.Text = "7";
            }
            else if (pictureBox2.Image == Soru8[1])
            {
                radioButton5.Text = "1";
                radioButton6.Text = "2";
                radioButton7.Text = "3";
                radioButton8.Text = "4";
            }
            Random rastgele9 = new Random();
            int soru9 = rastgele9.Next(0, Soru9.Length);
            pictureBox3.Image = Soru9[soru9];

            if (pictureBox3.Image == Soru9[0])
            {
                radioButton9.Text = "6";
                radioButton10.Text = "7";
                radioButton11.Text = "8";
                radioButton12.Text = "9";
            }
            else if (pictureBox3.Image == Soru9[1])
            {
                radioButton9.Text = "1";
                radioButton10.Text = "2";
                radioButton11.Text = "3";
                radioButton12.Text = "4";
            }
            button3.Visible = false;
            button4.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // cevap kontrolü(7-8-9)
            if (pictureBox1.Image == Soru7[0] && radioButton1.Checked)
            {
                sayisal += 5;
            }
            if (pictureBox1.Image == Soru7[1] && radioButton3.Checked)
            {
                sayisal += 5;
            }
            if (pictureBox2.Image == Soru8[0] && radioButton5.Checked)
            {
                sayisal += 5;
            }
            if (pictureBox2.Image == Soru8[1] && radioButton6.Checked)
            {
                sayisal += 5;
            }
            if (pictureBox3.Image == Soru9[0] && radioButton11.Checked)
            {
                sayisal += 5;
            }
            if (pictureBox3.Image == Soru9[1] && radioButton11.Checked)
            {
                sayisal += 5;
            }
            // radiobutton seçimlerini kaldır
            SecimleriTemizle();

            Random rastgele10 = new Random();
            int soru10 = rastgele10.Next(0, Soru10.Length);
            pictureBox1.Image = Soru10[soru10];
            if (pictureBox1.Image == Soru10[0])
            {
                radioButton1.Text = "3 - 8 - 1 - 7";
                radioButton2.Text = "7 - 2 - 6 - 5";
                radioButton3.Text = "4 - 1 - 6 - 8";
                radioButton4.Text = "5 - 3 - 2 - 8";
            }
            else if (pictureBox1.Image == Soru10[1])
            {
                radioButton1.Text = "A";
                radioButton2.Text = "B";
                radioButton3.Text = "C";
                radioButton4.Text = "D";
            }

            Random rastgele11 = new Random();
            int soru11 = rastgele11.Next(0, Soru11.Length);
            pictureBox2.Image = Soru11[soru11];
            if (pictureBox2.Image == Soru11[0])
            {
                radioButton5.Text = "A";
                radioButton6.Text = "B";
                radioButton7.Text = "C";
                radioButton8.Text = "D";
            }
            else if (pictureBox2.Image == Soru11[1])
            {
                radioButton5.Text = "A";
                radioButton6.Text = "B";
                radioButton7.Text = "C";
                radioButton8.Text = "D";
            }

            Random rastgele12 = new Random();
            int soru12 = rastgele12.Next(0, Soru12.Length);
            pictureBox3.Image = Soru12[soru12];
            if (pictureBox3.Image == Soru12[0])
            {
                radioButton9.Text = "A";
                radioButton10.Text = "B";
                radioButton11.Text = "C";
                radioButton12.Text = "D";
            }
            else if (pictureBox3.Image == Soru12[1])
            {
                radioButton9.Text = "A";
                radioButton10.Text = "B";
                radioButton11.Text = "C";
                radioButton12.Text = "D";
            }
            button4.Visible = false;
            button5.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // cevap kontrolü(10-11-12)
            if (pictureBox1.Image == Soru10[0] && radioButton1.Checked)
            {
                sayisal += 5;
            }
            if (pictureBox1.Image == Soru10[1] && radioButton3.Checked)
            {
                sayisal += 5;
            }
            if (pictureBox2.Image == Soru11[0] && radioButton5.Checked)
            {
                gorsel += 5;
            }
            if (pictureBox2.Image == Soru11[1] && radioButton8.Checked)
            {
                gorsel += 5;
            }
            if (pictureBox3.Image == Soru12[0] && radioButton10.Checked)
            {
                gorsel += 5;
            }
            if (pictureBox3.Image == Soru12[1] && radioButton9.Checked)
            {
                gorsel += 5;
            }
            // radiobutton seçimlerini kaldır
            SecimleriTemizle();

            Random rastgele13 = new Random();
            int soru13 = rastgele13.Next(0, Soru13.Length);
            pictureBox1.Image = Soru13[soru13];
            if (pictureBox1.Image == Soru13[0])
            {
                radioButton1.Text = "A";
                radioButton2.Text = "B";
                radioButton3.Text = "C";
                radioButton4.Text = "D";
            }
            else if (pictureBox1.Image == Soru13[1])
            {
                radioButton1.Text = "A";
                radioButton2.Text = "B";
                radioButton3.Text = "C";
                radioButton4.Text = "D";
            }

            Random rastgele14 = new Random();
            int soru14 = rastgele14.Next(0, Soru14.Length);
            pictureBox2.Image = Soru14[soru14];
            if (pictureBox2.Image == Soru14[0])
            {
                radioButton5.Text = "A";
                radioButton6.Text = "B";
                radioButton7.Text = "C";
                radioButton8.Text = "D";
            }
            else if (pictureBox2.Image == Soru14[1])
            {
                radioButton5.Text = "A";
                radioButton6.Text = "B";
                radioButton7.Text = "C";
                radioButton8.Text = "D";
            }

            Random rastgele15 = new Random();
            int soru15 = rastgele15.Next(0, Soru15.Length);
            pictureBox3.Image = Soru15[soru15];
            if (pictureBox3.Image == Soru15[0])
            {
                radioButton9.Text = "A";
                radioButton10.Text = "B";
                radioButton11.Text = "C";
                radioButton12.Text = "D";
            }
            else if (pictureBox3.Image == Soru15[1])
            {
                radioButton9.Text = "A";
                radioButton10.Text = "B";
                radioButton11.Text = "C";
                radioButton12.Text = "D";
            }
            button5.Visible = false;
            button6.Visible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // cevap kontrolü(13-14-15)
            if (pictureBox1.Image == Soru13[0] && radioButton3.Checked)
            {
                gorsel += 5;
            }
            if (pictureBox1.Image == Soru13[1] && radioButton1.Checked)
            {
                gorsel += 5;
            }
            if (pictureBox2.Image == Soru14[0] && radioButton8.Checked)
            {
                gorsel += 5;
            }
            if (pictureBox2.Image == Soru14[1] && radioButton7.Checked)
            {
                gorsel += 5;
            }
            if (pictureBox3.Image == Soru15[0] && radioButton12.Checked)
            {
                gorsel += 5;
            }
            if (pictureBox3.Image == Soru15[1] && radioButton10.Checked)
            {
                gorsel += 5;
            }
            // yüzde hesaplanması (float)
            fsayisalYuzde = sayisal / 25.0f * 100;
            fsozelYuzde = sozel / 25.0f * 100;
            fgorselYuzde = gorsel / 25.0f * 100;
            // yüzde güncelleme (integer)
            sayisalYuzde = (int)fsayisalYuzde;
            sozelYuzde = (int)fsozelYuzde;
            gorselYuzde = (int)fgorselYuzde;
            // veri tabanına update yapılamazsa burası iptal edilecek
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("update kayit set sayisal_zeka_yuzde=@sayisal_zeka_yuzde,sozel_zeka_yuzde=@sozel_zeka_yuzde,gorsel_zeka_yuzde=@gorsel_zeka_yuzde where kullanici_adi='" + kayit.kul_kuladi + "'", baglanti);
            komutGuncelle.Parameters.AddWithValue("@sayisal_zeka_yuzde", sayisalYuzde);
            komutGuncelle.Parameters.AddWithValue("@sozel_zeka_yuzde", sozelYuzde);
            komutGuncelle.Parameters.AddWithValue("@gorsel_zeka_yuzde", gorselYuzde);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            // anasayfaya geçiş           
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
            // verilerin yazılması
            frm.Hesaplama(sayisalYuzde, sozelYuzde, gorselYuzde);
            //frm.CokluZekaYuzde(anasayfa.sayisal, anasayfa.sozel, anasayfa.gorsel);
            frm.ZayifZekaBul(sayisalYuzde, sozelYuzde, gorselYuzde);
            frm.label1.Text = "Hoşgeldin " + kayit.kul_adi;
            frm.label2.Text = kayit.kul_adi + " " + kayit.kul_soyadi + "\n(Yaş : " + kayit.kul_yas + ") ";

        }
        public void SecimleriTemizle()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
        }
        
    }   
}
