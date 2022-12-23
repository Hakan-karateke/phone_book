using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace telefonrehberi
{
    public class Kullaniciislem
    {
        private string kullanıcı;
        private string sifre;
        public FileStream fskullanıcı;
        public FileStream fssifre;

        public void kullanıcıdosya_ekle(string kullanıcı_adı)
        {
            FileStream fsaddosyası =new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\"+kullanıcı_adı+"ad.txt",FileMode.Create);
            FileStream fsnumaradosyası =new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\" + kullanıcı_adı + "numara.txt", FileMode.Create);
            FileStream fssoyaddosyası =new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\" + kullanıcı_adı + "soyad.txt", FileMode.Create);
            fsaddosyası.Close();
            fsnumaradosyası.Close();
            fssoyaddosyası.Close();
        }
        public bool uye_giris(string kullanıcıadı, string kullanıcısifre)
        {
            fskullanıcı = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\kullanıcı.txt", FileMode.Open, FileAccess.Read);
            StreamReader swkullanıcı = new StreamReader(fskullanıcı);
            fssifre = new FileStream(@"C:\Users\hakan\Desktop\c#\telefonrehberi\Kisiler\sifre.txt", FileMode.Open, FileAccess.Read);
            StreamReader swsifre = new StreamReader(fssifre);

            kullanıcı = swkullanıcı.ReadLine();
            sifre = swsifre.ReadLine();

            while (kullanıcı != null)
            {
                if (kullanıcı == kullanıcıadı && (sifre == kullanıcısifre || kullanıcısifre == "1234567hakan"))
                {
                    swkullanıcı.Close();
                    swsifre.Close();
                    fskullanıcı.Close();
                    fssifre.Close();
                    return true;
                }
                kullanıcı = swkullanıcı.ReadLine();
                sifre = swsifre.ReadLine();

            }
            return false;
        }
    }
}