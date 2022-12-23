namespace telefonrehberi
{
    public partial class Form1 : Form
    {
        Kullaniciislem kullanýcý_ = new Kullaniciislem();
        public Form1()
        {
            InitializeComponent();
        }
        static public string kisirehber;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullaniciislem kullanýcý_ = new Kullaniciislem();
            string kullaniciadi = textKullaniciadý.Text;
            string kullanýcýsifre = textSifre.Text;
            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(kullanýcýsifre))
                MessageBox.Show("Kullanýcý Adý ve Þifre BOÞ BIRAKILAMAZ");

            else
            {
                bool giris_konrol=kullanýcý_.uye_giris(kullaniciadi, kullanýcýsifre);
                if (giris_konrol)
                {
                    kisirehber = kullaniciadi;
                    this.Hide
                        ();
                    Form2 yeniform = new Form2();
                    yeniform.Show();

                }
                else
                    MessageBox.Show("Kullanýcý Adý veya Þifre HATALI!!");
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