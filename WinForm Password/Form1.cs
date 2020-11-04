using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 120;
        const string pass = "268943";

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;

            lblTimer.Text = saniye.ToString();

            if (saniye == 0)
            {
                timer1.Stop();
                panel1.Enabled = false;

                MessageBox.Show("Süreniz dolmuştur.");
            }

        }

        public void keyControl(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Şifre alanı sadece sayısal karakterlerden oluşmalı",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                e.Handled = true;
            }
        }

        public void Clear()
        {
            txtBoxPassword1.Clear();
            txtBoxPassword2.Clear();
            txtBoxPassword3.Clear();
            txtBoxPassword4.Clear();
            txtBoxPassword5.Clear();
            txtBoxPassword6.Clear();

        }

        private void txtBoxPassword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyControl(e);

            this.SelectNextControl((Control)sender, true, true, true, true);
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword1.Text + txtBoxPassword2.Text + txtBoxPassword3.Text + txtBoxPassword4.Text +
                txtBoxPassword5.Text + txtBoxPassword6.Text == pass)

                MessageBox.Show("Tebrikler, anasayfaya yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Yanlış Şifre! Giriş Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Clear();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni Şifre 05** *** ** 75 nolu telefona gönderilmiştir.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            saniye = 120;

            Clear();

        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }
    }
}
