namespace DiyetDenemeUI
{
    public partial class Form1 : Form
    {
        public Form1()
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
