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

namespace telefonrehberi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        List<string> sifre_list = new List<string>();
        List<string> kullanıcı_list = new List<string>();
        private void btnhesapekle_Click(object sender, EventArgs e)
        {

            string kullanıcıadı = textyeni_ad.Text;
            string kullanıcısifre = textyeni_sifre.Text;
            string tekrarsifre = texttekrar_sifre.Text;
            if (string.IsNullOrEmpty(textyeni_ad.Text) || string.IsNullOrEmpty(textyeni_sifre.Text) || string.IsNullOrEmpty(texttekrar_sifre.Text))
                MessageBox.Show("Kullanıcı Adı ve Şifre BOŞ BIRAKILAMAZ");
            
            else
            {
                bool kontrol1 = true;
                bool kontrol = false;
                if (kullanıcısifre != tekrarsifre && kullanıcısifre.Length<8)
                {
                    MessageBox.Show("Şİfreniz en az 8 karakter uzunluğunda olmalı.\n Lütfen şifrenizi doğrulayın.");
                    kontrol1 = false;

                }

                else
                {
                    FileStream fskullanıcı = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\kullanıcı.txt", FileMode.Open, FileAccess.Read);
                    StreamReader swkullanıcı = new StreamReader(fskullanıcı);
                    FileStream fssifre = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\sifre.txt", FileMode.Open, FileAccess.Read);
                    StreamReader swsifre = new StreamReader(fssifre);
                    string sifre_kontrol = swsifre.ReadLine();
                    string kullanıcı_kontrol = swkullanıcı.ReadLine();


                    while (kullanıcı_kontrol != null)
                    {
                        kullanıcı_list.Add(kullanıcı_kontrol);
                        sifre_list.Add(sifre_kontrol);
                        kullanıcı_kontrol = swkullanıcı.ReadLine();
                        sifre_kontrol = swsifre.ReadLine();
                    }
                    swkullanıcı.Close();
                    fskullanıcı.Close();
                    swsifre.Close();
                    fssifre.Close();
                    foreach (string kullan in kullanıcı_list)
                    {
                        if (kullan == kullanıcıadı)
                        {
                            kontrol = true;
                        }
                    }

                }

                if (kontrol)
                    MessageBox.Show(kullanıcıadı + "Bu kullanıcı adı daha önce alınmış lütfen başka bir kullanıcı adı girin.");
                else if (!kontrol && kontrol1)
                {
                    kullanıcı_list.Add(kullanıcıadı);
                    sifre_list.Add(kullanıcısifre);

                    FileStream fskullanıcı = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\kullanıcı.txt", FileMode.Truncate, FileAccess.ReadWrite);
                    StreamWriter swkullanıcı = new StreamWriter(fskullanıcı);
                    FileStream fssifre = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\sifre.txt", FileMode.Truncate, FileAccess.ReadWrite);
                    StreamWriter swsifre = new StreamWriter(fssifre);
                    swkullanıcı.Flush();
                    swsifre.Flush();

                    swkullanıcı.Close();
                    swsifre.Close();
                    fskullanıcı.Close();
                    fssifre.Close();

                    FileStream fskullanıcı_ = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\kullanıcı.txt", FileMode.Open, FileAccess.Write);
                    StreamWriter swkullanıcı_ = new StreamWriter(fskullanıcı_);
                    FileStream fssifre_ = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\sifre.txt", FileMode.Open, FileAccess.Write);
                    StreamWriter swsifre_ = new StreamWriter(fssifre_);

                    foreach (string s in kullanıcı_list)
                        swkullanıcı_.WriteLine(s);
                    foreach (string k in sifre_list)
                        swsifre_.WriteLine(k);

                    swkullanıcı_.Close();
                    fskullanıcı_.Close();
                    swsifre_.Close();
                    fssifre_.Close();

                    Kullaniciislem new_kullanıcı = new Kullaniciislem();
                    new_kullanıcı.kullanıcıdosya_ekle(kullanıcıadı);

                    this.Hide();
                    Form1 yeniform = new Form1();
                    yeniform.Show();
                    MessageBox.Show("hesap oluşturuldu.");

                }
            }
        }
    }
}
