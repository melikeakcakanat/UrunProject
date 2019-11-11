using MixApp.Bilgi;
using MixApp.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixApp
{
    public partial class frmAnasayfa : Form
    {
        Formlar F = new Formlar();
        public static int IAktarma = -1;
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            pnlBir.Visible = true;
            pnlIki.Visible = false;
            pnlUc.Visible = false;
            groupBox1.Text = "Bir işlemleri";
        }
        private void btnBir_Click(object sender, EventArgs e)
        {
            pnlBir.Visible = true;
            pnlIki.Visible = false;
            pnlUc.Visible = false;
            groupBox1.Text = "Bir işlemleri";

        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            pnlBir.Visible = false;
            pnlIki.Visible = true;
            pnlUc.Visible = false;
            groupBox1.Text = "İki işlemleri";

        }

        private void btnUc_Click(object sender, EventArgs e)
        {
            pnlBir.Visible = false;
            pnlIki.Visible = false;
            pnlUc.Visible = true;
            groupBox1.Text = "Üç işlemleri";

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit(); Program kapatılığında Garbage collecetor rami temizler.
            //Application.ExitThread(); Garbege collector bu programla bağlantılı olan programları kapatır.
        }

        private void btnCariGiris_Click(object sender, EventArgs e)
        {
            F.CariGirisİslemi();
        }

        private void btnUrunGrupGiris_Click(object sender, EventArgs e)
        {
            F.UrunGrupGiris();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            F.Renk();
        }

        private void btnBeden_Click(object sender, EventArgs e)
        {
            F.Beden();
        }

        private void btnSezon_Click(object sender, EventArgs e)
        {
            F.Sezon();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            F.MarkaGiris();
        }

        private void btnUrunKayit_Click(object sender, EventArgs e)
        {
            F.UrunKayit();
        }

        private void btnAlis_Click(object sender, EventArgs e)
        {
            F.Alis();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            F.Satis();
        }

        private void btnAlisListe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUrunKayitListe_Click(object sender, EventArgs e)
        {
            F.UrunKayitListesi();
        }
    }
}
