namespace telefonrehberi
{
    public partial class Form1 : Form
    {
        Kullaniciislem kullan�c�_ = new Kullaniciislem();
        public Form1()
        {
            InitializeComponent();
        }
        static public string kisirehber;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullaniciislem kullan�c�_ = new Kullaniciislem();
            string kullaniciadi = textKullaniciad�.Text;
            string kullan�c�sifre = textSifre.Text;
            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(kullan�c�sifre))
                MessageBox.Show("Kullan�c� Ad� ve �ifre BO� BIRAKILAMAZ");

            else
            {
                bool giris_konrol=kullan�c�_.uye_giris(kullaniciadi, kullan�c�sifre);
                if (giris_konrol)
                {
                    kisirehber = kullaniciadi;
                    this.Hide
                        ();
                    Form2 yeniform = new Form2();
                    yeniform.Show();

                }
                else
                    MessageBox.Show("Kullan�c� Ad� veya �ifre HATALI!!");
            }
        }

        private void btnuyeekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 yeniform = new Form3();
            yeniform.Show();
        }
    }
}