namespace DiyetDenemeUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnKayitOlLogin = new Guna.UI2.WinForms.Guna2Button();
            btnGirisLogin = new Guna.UI2.WinForms.Guna2Button();
            txtSifreLogin = new Guna.UI2.WinForms.Guna2TextBox();
            txtKullaniciAdiLogin = new Guna.UI2.WinForms.Guna2TextBox();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(243, 2);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnKayitOlLogin
            // 
            btnKayitOlLogin.BorderRadius = 30;
            btnKayitOlLogin.CustomizableEdges = customizableEdges1;
            btnKayitOlLogin.DisabledState.BorderColor = Color.DarkGray;
            btnKayitOlLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnKayitOlLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnKayitOlLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnKayitOlLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOlLogin.ForeColor = Color.White;
            btnKayitOlLogin.Location = new Point(531, 289);
            btnKayitOlLogin.Margin = new Padding(2, 1, 2, 1);
            btnKayitOlLogin.Name = "btnKayitOlLogin";
            btnKayitOlLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnKayitOlLogin.Size = new Size(224, 68);
            btnKayitOlLogin.TabIndex = 10;
            btnKayitOlLogin.Text = "Kayit Ol";
            btnKayitOlLogin.Click += btnKayitOlLogin_Click;
            // 
            // btnGirisLogin
            // 
            btnGirisLogin.BorderRadius = 30;
            btnGirisLogin.CustomizableEdges = customizableEdges3;
            btnGirisLogin.DisabledState.BorderColor = Color.DarkGray;
            btnGirisLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGirisLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGirisLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGirisLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisLogin.ForeColor = Color.White;
            btnGirisLogin.Location = new Point(531, 195);
            btnGirisLogin.Margin = new Padding(2, 1, 2, 1);
            btnGirisLogin.Name = "btnGirisLogin";
            btnGirisLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnGirisLogin.Size = new Size(224, 73);
            btnGirisLogin.TabIndex = 9;
            btnGirisLogin.Text = "Giris";
            // 
            // txtSifreLogin
            // 
            txtSifreLogin.BorderRadius = 30;
            txtSifreLogin.CustomizableEdges = customizableEdges5;
            txtSifreLogin.DefaultText = "";
            txtSifreLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSifreLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSifreLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSifreLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSifreLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSifreLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifreLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSifreLogin.Location = new Point(531, 140);
            txtSifreLogin.Name = "txtSifreLogin";
            txtSifreLogin.PasswordChar = '\0';
            txtSifreLogin.PlaceholderText = "Sifre";
            txtSifreLogin.SelectedText = "";
            txtSifreLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSifreLogin.Size = new Size(224, 39);
            txtSifreLogin.TabIndex = 8;
            // 
            // txtKullaniciAdiLogin
            // 
            txtKullaniciAdiLogin.BorderRadius = 30;
            txtKullaniciAdiLogin.CustomizableEdges = customizableEdges7;
            txtKullaniciAdiLogin.DefaultText = "";
            txtKullaniciAdiLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtKullaniciAdiLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtKullaniciAdiLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtKullaniciAdiLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtKullaniciAdiLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtKullaniciAdiLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAdiLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtKullaniciAdiLogin.Location = new Point(531, 96);
            txtKullaniciAdiLogin.Name = "txtKullaniciAdiLogin";
            txtKullaniciAdiLogin.PasswordChar = '\0';
            txtKullaniciAdiLogin.PlaceholderText = "Kullanici Adi";
            txtKullaniciAdiLogin.SelectedText = "";
            txtKullaniciAdiLogin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtKullaniciAdiLogin.Size = new Size(224, 38);
            txtKullaniciAdiLogin.TabIndex = 7;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BorderRadius = 280;
            guna2GradientPanel1.Controls.Add(pictureBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges9;
            guna2GradientPanel1.FillColor = Color.FromArgb(94, 148, 255);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 77, 165);
            guna2GradientPanel1.Location = new Point(-243, 0);
            guna2GradientPanel1.Margin = new Padding(2, 1, 2, 1);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2GradientPanel1.Size = new Size(703, 455);
            guna2GradientPanel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKayitOlLogin);
            Controls.Add(btnGirisLogin);
            Controls.Add(txtSifreLogin);
            Controls.Add(txtKullaniciAdiLogin);
            Controls.Add(guna2GradientPanel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button btnKayitOlLogin;
        private Guna.UI2.WinForms.Guna2Button btnGirisLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtSifreLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtKullaniciAdiLogin;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}
