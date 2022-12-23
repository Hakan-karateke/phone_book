using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace telefonrehberi
{
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
        }

        bool numara_kontrolu(string numara)
        {
            bool s = true;
            foreach (string numara_kontrol in listNumara.Items)
                if (numara == numara_kontrol)
                {
                    MessageBox.Show("Aynı Numaradan sadece bir kullanıcı bulunabilir.");
                    s=false;

                }
            if (s)
                return true;
            else 
                return false;
        }
        void Kaydet()
        {
            FileStream fsadı = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"ad.txt", FileMode.Open, FileAccess.Write);
            StreamWriter swadı = new StreamWriter(fsadı);
            for (int i = 0; i < listAd.Items.Count; i++)
            {
                swadı.WriteLine(listAd.Items[i].ToString());
            }
            swadı.Close();
            fsadı.Close();

            FileStream fssoyad = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"soyad.txt", FileMode.Open, FileAccess.Write);
            StreamWriter swsoyad = new StreamWriter(fssoyad);
            for (int i = 0; i < listSoyad.Items.Count; i++)
            {
                swsoyad.WriteLine(listSoyad.Items[i].ToString());
            }
            swsoyad.Close();
            fssoyad.Close();

            FileStream fsnumara = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"numara.txt", FileMode.Open, FileAccess.Write);
            StreamWriter swnumara = new StreamWriter(fsnumara);
            for (int i = 0; i < listNumara.Items.Count; i++)
            {
                swnumara.WriteLine(listNumara.Items[i].ToString());
            }
            swnumara.Close();
            fsnumara.Close();

        }

        void sil()
        {
            FileStream fsadıal = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"ad.txt", FileMode.Truncate, FileAccess.ReadWrite);
            StreamWriter swadıal = new StreamWriter(fsadıal);
            FileStream fssoyadal = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"soyad.txt", FileMode.Truncate, FileAccess.ReadWrite);
            StreamWriter swsoyadal = new StreamWriter(fssoyadal);
            FileStream fsnumaraal = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"numara.txt", FileMode.Truncate, FileAccess.ReadWrite);
            StreamWriter swnumaraal = new StreamWriter(fsnumaraal);

            swadıal.Flush();
            swnumaraal.Flush();
            swsoyadal.Flush();

            swadıal.Close();
            swnumaraal.Close();
            swsoyadal.Close();
            fsadıal.Close();
            fsnumaraal.Close();
            fssoyadal.Close();



        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAd.Text) || string.IsNullOrEmpty(textSoyad.Text) || string.IsNullOrEmpty(textNumara.Text))
                MessageBox.Show("lütfen Ad, Soyad ve Numara kısımlarını doldurunuz.");
            else
            {
                if (textNumara.Text.Length != 11)
                    MessageBox.Show("Lütfen numaranızı 11 haneli olacak şekilde girin.");
                else
                {
                    bool kontrol_numara= numara_kontrolu(textNumara.Text);
                    if (kontrol_numara)
                    {
                        listAd.Items.Add(textAd.Text);
                        listSoyad.Items.Add(textSoyad.Text);
                        listNumara.Items.Add(textNumara.Text);
                        Kaydet();
                        MessageBox.Show("kişi eklendi.");
                        textAd.Clear();
                        textSoyad.Clear();
                        textNumara.Clear();
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FileStream fsadıal = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"ad.txt", FileMode.Open, FileAccess.Read);
            StreamReader swadıal = new StreamReader(fsadıal);
            FileStream fssoyadal = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"soyad.txt", FileMode.Open, FileAccess.Read);
            StreamReader swsoyadal = new StreamReader(fssoyadal); 
            FileStream fsnumaraal = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+Form1.kisirehber+"numara.txt", FileMode.Open, FileAccess.Read);
            StreamReader swnumaraal = new StreamReader(fsnumaraal);

            string ad = swadıal.ReadLine();
            string soyad = swsoyadal.ReadLine();
            string numara = swnumaraal.ReadLine();

            while (ad != null)
            {
                listAd.Items.Add(ad);
                listSoyad.Items.Add(soyad);
                listNumara.Items.Add(numara);

                ad = swadıal.ReadLine();
                soyad = swsoyadal.ReadLine();
                numara = swnumaraal.ReadLine();
            }
            swadıal.Close();
            fsadıal.Close();
            swnumaraal.Close();
            fsnumaraal.Close();
            swsoyadal.Close();
            fssoyadal.Close();
        }

        private void listAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSoyad.SelectedIndex = listAd.SelectedIndex;
            listNumara.SelectedIndex = listAd.SelectedIndex;
        }

        private void listSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAd.SelectedIndex = listSoyad.SelectedIndex;
            listNumara.SelectedIndex = listSoyad.SelectedIndex;
        }

        private void listNumara_SelectedIndexChanged(object sender, EventArgs e)
        {
            listAd.SelectedIndex = listNumara.SelectedIndex;
            listSoyad.SelectedIndex = listNumara.SelectedIndex;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int a = listAd.SelectedIndex;


                listAd.Items.RemoveAt(a);
                listNumara.Items.RemoveAt(a);
                listSoyad.Items.RemoveAt(a);

                sil();
                Kaydet();
                MessageBox.Show("Kişi Silindi.");
            }
            catch
            {
                MessageBox.Show("Lütfen sileceğiniz kişiyi seçin.");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int ara;
            if (string.IsNullOrEmpty(textAd.Text) && string.IsNullOrEmpty(textSoyad.Text) && textNumara.Text.Length!=0)
            {
                ara = listNumara.FindStringExact(textNumara.Text);
                if (ara < 0)
                    MessageBox.Show(textNumara.Text + "numarası bulunamadı.");
                else
                    listAd.SelectedIndex = ara;
            }
            else if (string.IsNullOrEmpty(textAd.Text) && string.IsNullOrEmpty(textNumara.Text) && textSoyad.Text.Length!=0)
            {
                ara = listSoyad.FindStringExact(textSoyad.Text);
                if (ara < 0)
                    MessageBox.Show(textSoyad.Text + " soyadı bulunamadı.");
                else
                    listSoyad.SelectedIndex = ara;
            }
            else if (string.IsNullOrEmpty(textSoyad.Text) && string.IsNullOrEmpty(textNumara.Text) && textAd.Text.Length!=0)
            {
                ara = listAd.FindStringExact(textAd.Text);
                if (ara < 0)
                    MessageBox.Show(textAd.Text + " adi bulunamadı.");
                else
                    listAd.SelectedIndex= ara;
            }

            else
                MessageBox.Show("Lütfen,\n Ad\n Soyad\n veya Numaradan sadece biriyle arama yapın.");
            textAd.Clear();
            textSoyad.Clear();
            textNumara.Clear();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int a = listAd.SelectedIndex;
            if (string.IsNullOrEmpty(textAd.Text) || string.IsNullOrEmpty(textSoyad.Text) || string.IsNullOrEmpty(textNumara.Text))
                MessageBox.Show("lütfen g Ad, Soyad ve Numara kısımlarını doldurunuz.");
            else
            {
                if (textNumara.Text.Length != 11)
                    MessageBox.Show("Kişi numarasını  11 haneli olarak girin.");
                else
                {
                    try
                    {
                        bool s = numara_kontrolu(textNumara.Text);
                        if (!s)
                            MessageBox.Show("numara listede mevcut!");

                        else
                        {
                            listAd.Items[a] = textAd.Text;
                            listSoyad.Items[a] = textSoyad.Text;
                            listNumara.Items[a] = textNumara.Text;
                            sil();
                            Kaydet();
                            MessageBox.Show("Kişi Güncellendi.");
                            textAd.Clear();
                            textSoyad.Clear();
                            textNumara.Clear();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("lütfen güncelleyeceğiniz kişiyi seçin.");
                    }
                }
            }
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 yeniform = new Form1();
            yeniform.Show();
            MessageBox.Show("başarıyla çıkış yapıldı.");
        }

        private void btncevir_Click(object sender, EventArgs e)
        {
            string dosyayolu = @"C:\Users\hakan\Desktop\" + Form1.kisirehber + "rehber.csv";
            FileStream fs = new FileStream(dosyayolu, FileMode.Create);
            fs.Close();
            FileStream fsveri = new FileStream(dosyayolu, FileMode.Open, FileAccess.Write);
            StreamWriter swveri = new StreamWriter(fsveri);
            int i = 0;
            foreach(string k in listAd.Items)
            {
                string veri = k + ";" + listSoyad.Items[i].ToString() + ";" + listNumara.Items[i].ToString();
                swveri.WriteLine(veri);
                i++;
            }
            swveri.Close();
            fsveri.Close();
            MessageBox.Show(" rehberiniz  .csv dosya uzantısı ile masaüstüne kaydedildi.");

            
        }
    }
}

