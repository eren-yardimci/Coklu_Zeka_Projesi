using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;  // process kullanımı için eklendi


namespace Coklu_Zeka_Projesi
{
    public partial class anasayfa : Form
    {
        public static int sayisalZeka, sozelZeka, gorselZeka,sayisal=0,sozel=0,gorsel=0,sonuc,zayif;
        string zayifLink;
        string sayisalLink = "https://youtu.be/NAflq6XAim8";
        string sozelLink = "https://www.mentalup.net/blog/sozel-zeka-nedir-nasil-gelistirilir";
        string gorselLink = "https://youtu.be/w-HiCmedUw8?si=vTtyugi9Dhrd2K8R";
        string ortakLink = "https://youtu.be/mUEkPoMMsMc";
        string dahaIyiolmaLink = "https://youtu.be/EWUxy2QMkmk";

        private void anasayfa_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldin " + Form1.giris_kuladi;
            label2.Text = Form1.giris_adi + " " + Form1.giris_soyadi + "\n(Yaş : " + Form1.giris_yas + ") ";
            sayisalZeka = Convert.ToInt32(Form1.giris_sayisal_Zeka);
            sozelZeka = Convert.ToInt32(Form1.giris_sozel_Zeka);
            gorselZeka = Convert.ToInt32(Form1.giris_gorsel_Zeka);
            Hesaplama(sayisalZeka, sozelZeka, gorselZeka);
            //CokluZekaYuzde(sayisal,sozel,gorsel);
            //ZayifZekaBul(sayisalZeka, sozelZeka, gorselZeka);
        }

        

        public anasayfa()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\eren\Desktop\Pattern-Memory-Game-2D-master\Pattern-Memory-Game-2D-master\ExecutableFile\exe\Pattern Memory Game 2D.exe";

            // Process sınıfını kullanarak yeni bir süreç oluşturun
            Process process = new Process();

            // Başlatma Bilgilerini Ayarlayın
            process.StartInfo.FileName = filePath;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            // Süreci Başlatın
            process.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            ZayifZekaBul(sayisalZeka, sozelZeka, gorselZeka);
            panel3.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        public void Hesaplama(int sayisalhesap,int sozelhesap,int gorselhesap)  // Zeka Seviyelerinin Belirlendiği Fonksiyon
        {
            if (sayisalhesap >= 0 && sayisalhesap <= 40) //Düşük
            {
                label3.Text = "Sayısal Zeka : " + " % " + sayisalhesap;
                sayisal += 0;
            }
            else if (sayisalhesap > 40 && sayisalhesap <= 70) // Orta
            {
                label3.Text = "Sayısal Zeka : " + " % " + sayisalhesap;
                sayisal += 1;
            }
            else if (sayisalhesap > 70 && sayisalhesap <= 100) // Yüksek
            {
                label3.Text = "Sayısal Zeka : " + " % " + sayisalhesap;
                sayisal += 2;
            }
            if (sozelhesap >= 0 && sozelhesap <= 40) //Düşük
            {
                label4.Text = "Sözel Zeka : " + " % " + sozelhesap;
                sozel += 0;
            }
            else if (sozelhesap > 40 && sozelhesap <= 70) // Orta
            {
                label4.Text = "Sözel Zeka : " + " % " + sozelhesap;
                sozel += 1;
            }
            else if (sozelhesap > 70 && sozelhesap <= 100) // Yüksek
            {
                label4.Text = "Sözel Zeka : " + " % " + sozelhesap;
                sozel += 2;
            }
            if (gorselhesap >= 0 && gorselhesap <= 40) //Düşük
            {
                label5.Text = "Görsel Zeka : " + " % " + gorselhesap;
                gorsel += 0;
            }
            else if (gorselhesap > 40 && gorselhesap <= 70) // Orta
            {
                label5.Text = "Görsel Zeka : " + " % " + gorselhesap;
                gorsel += 1;
            }
            else if (gorselhesap > 70 && gorselhesap <= 100) // Yüksek
            {
                label5.Text = "Görsel Zeka : " + " % " + gorselhesap;
                gorsel += 2;
            }
        }
        public void CokluZekaYuzde(int sayisal1,int sozel2,int gorsel3)
        {
            sonuc = sayisal1 + sozel2 + gorsel3;
            if(sonuc == 0)
            {
                label6.Text = "Çoklu Zeka Seviyeniz : Çok Düşük";
            }
            else if(sonuc >= 1 && sonuc <= 2)
            {
                label6.Text = "Çoklu Zeka Seviyeniz : Düşük";
            }
            else if (sonuc >= 3 && sonuc <= 4)
            {
                label6.Text = "Çoklu Zeka Seviyeniz : Orta";
            }
            else if (sonuc == 5)
            {
                label6.Text = "Çoklu Zeka Seviyeniz : Yüksek";
            }
            else if (sonuc == 6)
            {
                label6.Text = "Çoklu Zeka Seviyeniz : Çok Yüksek";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = true;
        }
        public void ZayifZekaBul(int zayifSayisal , int zayifSozel , int zayifGorsel)
        {
            zayif = zayifSayisal;
            if(zayif > zayifSozel && zayifSozel != zayifGorsel && zayifSozel < zayifGorsel)
            {
                zayif = zayifSozel;
                label9.Text = "Diğerlerine Göre Daha Zayıf Olan Zeka Türünüz : Sözel Zeka";
                ZayifSozel();
            }
            else if(zayif > zayifGorsel && zayifSozel != zayifGorsel && zayifGorsel < zayifSozel)
            {
                zayif = zayifGorsel;
                label9.Text = "Diğerlerine Göre Daha Zayıf Olan Zeka Türünüz : Gorsel Zeka";
                ZayifGorsel();
            }
            else if (zayif > zayifSozel && zayifSozel == zayifGorsel)
            {
                label9.Text = "Diğerlerine Göre Daha Zayıf Olan Zeka Türünüz : Sözel Zeka ve Görsel Zeka";
                ZayifSozelGorsel();
            }
            else if (zayif == zayifSozel && zayif < zayifGorsel)
            {
                label9.Text = "Diğerlerine Göre Daha Zayıf Olan Zeka Türünüz : Sayısal Zeka ve Sözel Zeka";
                ZayifSayisalSozel();
            }
            else if (zayif == zayifGorsel && zayif < zayifSozel)
            {
                label9.Text = "Diğerlerine Göre Daha Zayıf Olan Zeka Türünüz : Sayısal Zeka ve Görsel Zeka";
                ZayifSayisalGorsel();
            }
            else if (zayifSayisal == 100 && zayif == zayifSozel && zayif == zayifGorsel)
            {
                label9.Text = "Diğerlerine Göre Daha Zayıf Olan Zeka Türünüz Yok.";
                ZayifZekaYok();
            }
            else if (zayif == zayifSozel && zayif == zayifGorsel)
            {
                label9.Text = "Diğerlerine Göre Daha Zayıf Olan Zeka Türünüz : Üç Zeka Türünüzde Zayıf";
                ZayifUcZeka();
            }
            else
            {
                label9.Text = "Diğerlerine Göre Daha Zayıf Olan Zeka Türünüz : Sayısal Zeka";
                ZayifSayisal();
            }
        }
        public void ZayifSayisal()
        {
            link(sayisalLink);

            string[] sayisalOneriler1 = { "Temel matematik becerilerinizi güçlendirmek için düzenli olarak matematik problemleri çözün. \nAritmetik, cebir, geometri gibi farklı konularda pratik yapmak önemlidir.",           
            "Sudoku, bulmaca oyunları, satranç gibi mantık oyunları, sayısal zeka ve problem çözme becerilerinizi artırabilir. \nBu tür oyunlar, mantıksal düşünmeyi geliştirebilir.",
            "Temel programlama becerileri edinmek, sayısal düşünmeyi geliştirmenin etkili bir yoludur. \nProgramlama dilleri, algoritmik düşünceyi güçlendirebilir." };
            string[] sayisalOneriler2 = { "Günlük hayatta karşılaştığınız problemleri matematiksel bir bakış açısıyla ele alın. \nÖrneğin, alışveriş yaparken indirim hesaplamak veya bütçe yönetimi yapmak gibi \npratik uygulamalar sayısal zekayı geliştirebilir." ,
            "Mühendislik, fizik, istatistik gibi alanlarda yazılmış kitapları okumak, karmaşık \nsayısal konuları anlamada yardımcı olabilir.",
            "Zorlu matematik problemleri çözmek, zihinsel kapasitenizi zorlayarak sayısal zekanızı geliştirebilir.",
            "Gerçek dünya problemlerini matematiksel modellerle çözmeye çalışmak, sayısal zekayı uygulamalı \nolarak geliştirebilir.",
            "Temel düzeyde makine öğrenmesi ve veri bilimi konularını öğrenmek, sayısal zekanızı daha ileri \nseviyeye taşıyabilir.",
            "Çocuklar için tasarlanmış eğlenceli matematik oyunları, yetişkinler için de eğlenceli olabilir \nve sayısal zekanın gelişimine katkıda bulunabilir."};

            Random oneri1 = new Random();
            int oneriSayi1 = oneri1.Next(0, sayisalOneriler1.Length);

            Random oneri2 = new Random();
            int oneriSayi2 = oneri2.Next(0, sayisalOneriler2.Length);


            label10.Text = sayisalOneriler1[oneriSayi1] + " \n\n"+ sayisalOneriler2[oneriSayi2];            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(zayifLink);
        }

        public void ZayifSozel()
        {
            link(sozelLink);

            string[] sozelOneriler1 = {"Düzenli olarak kitap okuma, kelime dağarcığınızı genişletir, dilbilgisini geliştirir ve \nfarklı yazım stillerini anlamanıza katkı sağlar.",           
            "Yeni kelimeler öğrenmek ve mevcut kelime dağarcığınızı güçlendirmek için kelime kartları kullanabilirsiniz.",
            "Günlük tutma, makale yazma veya kısa hikayeler yazma gibi yazma aktiviteleri, \nsözel ifade becerilerinizi geliştirmenize yardımcı olabilir.",
            "Scrabble, kelime avı oyunları, çapraz bulmacalar gibi dil oyunları, hem eğlenceli hem de \nsözel zekayı geliştirebilecek etkili araçlardır.",
            "Aktif olarak konuşmalara ve tartışmalara katılarak sözel ifade becerilerinizi güçlendirebilirsiniz.",
            "Günlük konuşmalarda, e-posta yazımlarında ve sosyal medya paylaşımlarında dikkatli ve \netkili bir dil kullanmak, sözel ifade becerilerinizi artırabilir."};
            string[] sozelOneriler2 = {"Hikayeler anlatmak veya dinlemek, sözel zeka üzerinde olumlu bir etki yapabilir. \nKendi hikayelerinizi oluşturarak ifade yeteneğinizi geliştirebilirsiniz.",
            "Podcast'leri dinlemek, farklı konularda konferanslara katılmak, dil becerilerinizi geliştirmenin yanı sıra \nyeni bilgiler edinmenize de yardımcı olabilir.",
            "Yabancı dil öğrenmek, farklı kültürleri anlamanıza ve farklı dil yapıları üzerinde \ndüşünmenize yardımcı olabilir.",
            "Şiir yazmak veya şiirleri incelemek, duygusal ifade yeteneğinizi artırabilir ve \nkreatif düşünceyi teşvik edebilir.",
            "Tiyatro oyunlarına katılmak veya drama aktiviteleriyle ilgilenmek, duygusal ifade ve \nsözel iletişim becerilerinizi geliştirebilir."};

            Random oneri1 = new Random();
            int oneriSayi1 = oneri1.Next(0, sozelOneriler1.Length);

            Random oneri2 = new Random();
            int oneriSayi2 = oneri2.Next(0, sozelOneriler2.Length);


            label10.Text = sozelOneriler1[oneriSayi1] + " \n\n" + sozelOneriler2[oneriSayi2];            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // "C:\Users\eren\Desktop\Wordle-master\exe\Wordle.exe" yolunu bir değişkene kaydedin
            string filePath = @"C:\Users\eren\Desktop\Wordle-master\exe\Wordle.exe";

            // Process sınıfını kullanarak yeni bir süreç oluşturun
            Process process = new Process();

            // Başlatma Bilgilerini Ayarlayın
            process.StartInfo.FileName = filePath;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            // Süreci Başlatın
            process.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\eren\Desktop\MathGame-master\exe\MathGame.exe";

            // Process sınıfını kullanarak yeni bir süreç oluşturun
            Process process = new Process();

            // Başlatma Bilgilerini Ayarlayın
            process.StartInfo.FileName = filePath;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;

            // Süreci Başlatın
            process.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
            sayisal = 0;
            sozel = 0;
            gorsel = 0;
            sonuc = 0;
        }

        public void ZayifGorsel()
        {
            link(gorselLink);

            string[] gorselOneriler1 = {"Sanat eserlerini inceleyerek farklı tarzları anlamak ve görsel öğeleri tanımak görsel zekayı geliştirebilir.",
            "Fotoğraf çekmek, görsel zeka üzerinde olumlu bir etki yapabilir. Çektiğiniz fotoğrafları inceleyerek \ndetayları fark etmeye çalışın.",
            "Sudoku gibi mantık bulmacaları, görsel zekayı geliştirebilir. Ayrıca, renkli bulmaca oyunları ve \n3D zeka oyunları da kullanışlı olabilir.",
            "Resim, heykel, fotoğrafçılık gibi sanat kurslarına katılmak görsel zekayı geliştirebilir. \nBu tür kurslar, görsel unsurları anlamak ve ifade etmek için pratik yapmanıza olanak tanır.",
            "Doğayı gözlemlemek, renkleri, desenleri ve formları anlamak için harika bir yoldur. \nDoğada bulunan detayları fark etmeye çalışın."};
            string[] gorselOneriler2 = {"Farklı sanat akımlarını ve dönemlerini inceleyerek, farklı sanatçıların görsel dilini anlamak ve \ndeğerlendirmek görsel zekanızı artırabilir.",
            "Görsel belleğinizi geliştirmek için hafıza oyunları oynayabilirsiniz. Bir dizi nesneyi veya \ndeseni bir süre inceleyip sonra hatırlamaya çalışmak bu konuda yardımcı olabilir.",
            "Kendi çizimlerinizi yapmak, görsel zekanızı geliştirebilir. Basit çizimlerden başlayarak \nkarmaşık tasarımlara geçebilirsiniz.",
            "Sanat galerileri, farklı sanat eserlerini gözlemleyerek görsel zekayı geliştirmek için harika bir kaynaktır.",
            "Renk teorisini anlamak ve bir resmin kompozisyonunu değerlendirmek, görsel zeka açısından önemlidir. \nRenk teorisi konusunda temel bilgiler edinmek faydalı olabilir."};

            Random oneri1 = new Random();
            int oneriSayi1 = oneri1.Next(0, gorselOneriler1.Length);

            Random oneri2 = new Random();
            int oneriSayi2 = oneri2.Next(0, gorselOneriler2.Length);

            label10.Text = gorselOneriler1[oneriSayi1] + " \n\n" + gorselOneriler2[oneriSayi2];           
        }
        public void ZayifSozelGorsel()
        {
            link(ortakLink);
            string[] sozelOneriler = { "Yeni kelimeler öğrenmek ve mevcut kelime dağarcığınızı güçlendirmek için kelime kartları kullanabilirsiniz.",
            "Yabancı dil öğrenmek, farklı kültürleri anlamanıza ve farklı dil yapıları üzerinde \ndüşünmenize yardımcı olabilir.",
            "Aktif olarak konuşmalara ve tartışmalara katılarak sözel ifade becerilerinizi güçlendirebilirsiniz.",
            "Şiir yazmak veya şiirleri incelemek, duygusal ifade yeteneğinizi artırabilir ve \nkreatif düşünceyi teşvik edebilir.",
            "Tiyatro oyunlarına katılmak veya drama aktiviteleriyle ilgilenmek, duygusal ifade ve \nsözel iletişim becerilerinizi geliştirebilir."};
            string[] gorselOneriler = { "Sudoku gibi mantık bulmacaları, görsel zekayı geliştirebilir. Ayrıca, renkli bulmaca oyunları ve \n3D zeka oyunları da kullanışlı olabilir.",
            "Doğayı gözlemlemek, renkleri, desenleri ve formları anlamak için harika bir yoldur. \nDoğada bulunan detayları fark etmeye çalışın.",
            "Farklı sanat akımlarını ve dönemlerini inceleyerek, farklı sanatçıların görsel dilini anlamak ve \ndeğerlendirmek görsel zekanızı artırabilir.",
            "Kendi çizimlerinizi yapmak, görsel zekanızı geliştirebilir. Basit çizimlerden başlayarak \nkarmaşık tasarımlara geçebilirsiniz.",
            "Sanat galerileri, farklı sanat eserlerini gözlemleyerek görsel zekayı geliştirmek için harika bir kaynaktır."};

            Random oneri1 = new Random();
            int oneriSayi1 = oneri1.Next(0, sozelOneriler.Length);

            Random oneri2 = new Random();
            int oneriSayi2 = oneri2.Next(0, gorselOneriler.Length);

            label10.Text = sozelOneriler[oneriSayi1] + " \n\n" + gorselOneriler[oneriSayi2];
        }
        public void ZayifSayisalSozel()
        {
            link(ortakLink);
            string[] sayisalOneriler = { "Temel matematik becerilerinizi güçlendirmek için düzenli olarak matematik problemleri çözün. \nAritmetik, cebir, geometri gibi farklı konularda pratik yapmak önemlidir.",
            "Sudoku, bulmaca oyunları, satranç gibi mantık oyunları, sayısal zeka ve problem çözme becerilerinizi artırabilir. \nBu tür oyunlar, mantıksal düşünmeyi geliştirebilir.",
            "Zorlu matematik problemleri çözmek, zihinsel kapasitenizi zorlayarak sayısal zekanızı geliştirebilir.",
            "Gerçek dünya problemlerini matematiksel modellerle çözmeye çalışmak, sayısal zekayı uygulamalı \nolarak geliştirebilir.",
            "Çocuklar için tasarlanmış eğlenceli matematik oyunları, yetişkinler için de eğlenceli olabilir \nve sayısal zekanın gelişimine katkıda bulunabilir."};
            string[] sozelOneriler = { "Günlük tutma, makale yazma veya kısa hikayeler yazma gibi yazma aktiviteleri, \nsözel ifade becerilerinizi geliştirmenize yardımcı olabilir.",
            "Yabancı dil öğrenmek, farklı kültürleri anlamanıza ve farklı dil yapıları üzerinde \ndüşünmenize yardımcı olabilir.",
            "Aktif olarak konuşmalara ve tartışmalara katılarak sözel ifade becerilerinizi güçlendirebilirsiniz.",
            "Şiir yazmak veya şiirleri incelemek, duygusal ifade yeteneğinizi artırabilir ve \nkreatif düşünceyi teşvik edebilir.",
            "Tiyatro oyunlarına katılmak veya drama aktiviteleriyle ilgilenmek, duygusal ifade ve \nsözel iletişim becerilerinizi geliştirebilir."};

            Random oneri1 = new Random();
            int oneriSayi1 = oneri1.Next(0, sayisalOneriler.Length);

            Random oneri2 = new Random();
            int oneriSayi2 = oneri2.Next(0, sozelOneriler.Length);

            label10.Text = sayisalOneriler[oneriSayi1] + " \n\n" + sozelOneriler[oneriSayi2];
        }
        public void ZayifSayisalGorsel() {
            link(ortakLink);
            string[] sayisalOneriler = { "Temel matematik becerilerinizi güçlendirmek için düzenli olarak matematik problemleri çözün. \nAritmetik, cebir, geometri gibi farklı konularda pratik yapmak önemlidir.",
            "Sudoku, bulmaca oyunları, satranç gibi mantık oyunları, sayısal zeka ve problem çözme becerilerinizi artırabilir. \nBu tür oyunlar, mantıksal düşünmeyi geliştirebilir.",
            "Zorlu matematik problemleri çözmek, zihinsel kapasitenizi zorlayarak sayısal zekanızı geliştirebilir.",
            "Gerçek dünya problemlerini matematiksel modellerle çözmeye çalışmak, sayısal zekayı uygulamalı \nolarak geliştirebilir.",
            "Çocuklar için tasarlanmış eğlenceli matematik oyunları, yetişkinler için de eğlenceli olabilir \nve sayısal zekanın gelişimine katkıda bulunabilir."};
            string[] gorselOneriler = { "Sudoku gibi mantık bulmacaları, görsel zekayı geliştirebilir. Ayrıca, renkli bulmaca oyunları ve \n3D zeka oyunları da kullanışlı olabilir.",
            "Doğayı gözlemlemek, renkleri, desenleri ve formları anlamak için harika bir yoldur. \nDoğada bulunan detayları fark etmeye çalışın.",
            "Farklı sanat akımlarını ve dönemlerini inceleyerek, farklı sanatçıların görsel dilini anlamak ve \ndeğerlendirmek görsel zekanızı artırabilir.",
            "Kendi çizimlerinizi yapmak, görsel zekanızı geliştirebilir. Basit çizimlerden başlayarak \nkarmaşık tasarımlara geçebilirsiniz.",
            "Sanat galerileri, farklı sanat eserlerini gözlemleyerek görsel zekayı geliştirmek için harika bir kaynaktır."};

            Random oneri1 = new Random();
            int oneriSayi1 = oneri1.Next(0, sayisalOneriler.Length);

            Random oneri2 = new Random();
            int oneriSayi2 = oneri2.Next(0, gorselOneriler.Length);

            label10.Text = sayisalOneriler[oneriSayi1] + " \n\n" + gorselOneriler[oneriSayi2];
        }
        public void ZayifUcZeka()
        {
            link(ortakLink);
            string[] oneriler1 = { "Sudoku, bulmaca oyunları, satranç gibi mantık oyunları, sayısal zeka ve problem çözme becerilerinizi artırabilir. \nBu tür oyunlar, mantıksal düşünmeyi geliştirebilir.",
            "Günlük tutma, makale yazma veya kısa hikayeler yazma gibi yazma aktiviteleri, \nsözel ifade becerilerinizi geliştirmenize yardımcı olabilir.",
            "Doğayı gözlemlemek, renkleri, desenleri ve formları anlamak için harika bir yoldur. \nDoğada bulunan detayları fark etmeye çalışın.",
            "Kendi çizimlerinizi yapmak, görsel zekanızı geliştirebilir. Basit çizimlerden başlayarak \nkarmaşık tasarımlara geçebilirsiniz."};
            string[] oneriler2 = { "Zorlu matematik problemleri çözmek, zihinsel kapasitenizi zorlayarak sayısal zekanızı geliştirebilir.," +
            "Sanat galerileri, farklı sanat eserlerini gözlemleyerek görsel zekayı geliştirmek için harika bir kaynaktır.",
            "Scrabble, kelime avı oyunları, çapraz bulmacalar gibi dil oyunları, hem eğlenceli hem de \nsözel zekayı geliştirebilecek etkili araçlardır.",
            "Şiir yazmak veya şiirleri incelemek, duygusal ifade yeteneğinizi artırabilir ve \nkreatif düşünceyi teşvik edebilir."};

            Random oneri1 = new Random();
            int oneriSayi1 = oneri1.Next(0, oneriler1.Length);

            Random oneri2 = new Random();
            int oneriSayi2 = oneri2.Next(0, oneriler2.Length);

            label10.Text = oneriler1[oneriSayi1] + " \n\n" + oneriler2[oneriSayi2];
        }
        public void ZayifZekaYok()
        {
            link(dahaIyiolmaLink);
            label10.Text = "Ama yinede kendini geliştirmen için aşağıdaki linkten daha fazlasına ulaşabilirsin.";
        }
        void link(string link)
        {
            zayifLink = link;
        }
    }
}
