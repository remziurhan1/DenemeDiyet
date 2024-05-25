using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetDenemeUI
{
    public partial class Hoşgeldiniz : Form
    {
        public Hoşgeldiniz()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Giris giris = new Giris();
            giris.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz
            timer1.Stop();
        }
    }

}
