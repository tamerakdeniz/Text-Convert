using System;
using System.Runtime.CompilerServices;

namespace _2021512001_MTA_SayiYaziCevirme
{
    public partial class Form1 : Form
    {
        public int girilenSayi;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("If Yapısı Yerine Case Break Yapısı Kullanılarak Problem Çözüldü.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir Milyon Üzeri Sayı Girmeyiniz");
            var inputScreen = new InputScreen(this);
            inputScreen.ShowDialog();
            textBox1.Text = girilenSayi.ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            listBox1.Items.Add("Çevirmek İstediğiniz Sayı '" + (textBox1.Text) + "' olarak belirlendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            if (sayi > 999999) { 
                MessageBox.Show("Lütfen 9999 Altında Bir Sayı Giriniz");
                this.Close();
            }
            else { 
                

                int yuzbinBas, onbinBas, binBas, yuzBas, onBas, birBas;


                string yuzbinlerBas = "";
                string onbinlerBas = "";
                string binlerBas = "";
                string yuzlerBas = "";
                string onlarBas = "";
                string birlerBas = "";

                yuzbinBas = sayi / 100000;

                sayi = sayi % 100000;

                onbinBas = sayi / 10000;

                sayi = sayi % 10000;

                binBas = sayi / 1000;

                sayi = sayi % 1000;

                yuzBas = sayi / 100;

                sayi = sayi % 100;

                onBas = sayi / 10;

                sayi = sayi % 10;

                birBas = sayi;

                switch (yuzbinBas)

                {

                    case 1: yuzbinlerBas = " Yüz"; break;

                    case 2: yuzbinlerBas = " İki Yüz"; break;

                    case 3: yuzbinlerBas = " Üç Yüz"; break;

                    case 4: yuzbinlerBas = " Dört Yüz "; break;

                    case 5: yuzbinlerBas = " Beş Yüz"; break;

                    case 6: yuzbinlerBas = " Altı Yüz"; break;

                    case 7: yuzbinlerBas = " Yedi Yüz"; break;

                    case 8: yuzbinlerBas = " Sekiz Yüz"; break;

                    case 9: yuzbinlerBas = " Dokuz Yüz"; break;

                }

                switch (onbinBas)

                {

                    case 1: onbinlerBas = " On"; break;

                    case 2: onbinlerBas = " Yirmi"; break;

                    case 3: onbinlerBas = " Otuz"; break;

                    case 4: onbinlerBas = " Kırk"; break;

                    case 5: onbinlerBas = " Elli"; break;

                    case 6: onbinlerBas = " Altmış"; break;

                    case 7: onbinlerBas = " Yetmiş"; break;

                    case 8: onbinlerBas = " Seksen"; break;

                    case 9: onbinlerBas = " Doksan"; break;

                }

                switch (binBas)

                {

                    case 1: binlerBas = " Bin"; break;

                    case 2: binlerBas = " İki Bin"; break;

                    case 3: binlerBas = " Üç Bin"; break;

                    case 4: binlerBas = " Dört Bin"; break;

                    case 5: binlerBas = " Beş Bin"; break;

                    case 6: binlerBas = " Altı Bin"; break;

                    case 7: binlerBas = " Yedi Bin"; break;

                    case 8: binlerBas = " Sekiz Bin"; break;

                    case 9: binlerBas = " Dokuz Bin"; break;

                }

                switch (yuzBas)

                {

                    case 1: yuzlerBas = " Yüz"; break;

                    case 2: yuzlerBas = " İki Yüz"; break;

                    case 3: yuzlerBas = " Üç Yüz"; break;

                    case 4: yuzlerBas = " Dört Yüz"; break;

                    case 5: yuzlerBas = " Beş Yüz"; break;

                    case 6: yuzlerBas = " Altı Yüz"; break;

                    case 7: yuzlerBas = " Yedi Yüz"; break;

                    case 8: yuzlerBas = " Sekiz Yüz"; break;

                    case 9: yuzlerBas = " Dokuz Yüz"; break;

                }

                switch (onBas)

                {

                    case 1: onlarBas = " On"; break;

                    case 2: onlarBas = " Yirmi"; break;

                    case 3: onlarBas = " Otuz"; break;

                    case 4: onlarBas = " Kırk"; break;

                    case 5: onlarBas = " Elli"; break;

                    case 6: onlarBas = " Altmış"; break;

                    case 7: onlarBas = " Yetmiş"; break;

                    case 8: onlarBas = " Seksen"; break;

                    case 9: onlarBas = " Doksan"; break;

                }

                switch (birBas)

                {

                    case 1: birlerBas = " Bir"; break;

                    case 2: birlerBas = " İki"; break;

                    case 3: birlerBas = " Üç"; break;

                    case 4: birlerBas = " Dört"; break;

                    case 5: birlerBas = " Beş"; break;

                    case 6: birlerBas = " Altı"; break;

                    case 7: birlerBas = " Yedi"; break;

                    case 8: birlerBas = " Sekiz"; break;

                    case 9: birlerBas = " Dokuz"; break;

                }
                if (sayi > 999)
                    label3.Text = yuzbinlerBas + onbinlerBas + binlerBas + "Bin" + yuzlerBas + onlarBas + birlerBas;
                label3.Text = yuzbinlerBas + onbinlerBas + binlerBas + yuzlerBas + onlarBas + birlerBas;
                listBox2.Items.Add("Belirlediğiniz '" + textBox1.Text + "' Sayısının Yazıya Çevrilmiş Hali;");
                listBox2.Items.Add("'"+label3.Text + " ' Şeklindedir.");
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("(Tekrar Sayı Belirleyiniz)");
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}