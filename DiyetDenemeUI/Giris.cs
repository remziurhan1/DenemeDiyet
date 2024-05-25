namespace DiyetDenemeUI
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnKayitOlLogin_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            this.Hide();
        }
    }
}
