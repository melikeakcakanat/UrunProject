using MixApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixApp.Al_Sat
{
    public partial class frmAlisListe : Form
    {
        public bool Secim = false;
        MixDbContext db = new MixDbContext();
        int secimId = -1;
        public frmAlisListe()
        {
            InitializeComponent();
        }

        private void frmAlisListe_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in db.UrunAls
                       where s.Cariler.CariAdi.Contains(txtCariBul.Text)
                       select new
                       {
                           Gno = s.UrunAlgrupNo,
                           Car = s.Cariler.CariAdi,
                           Tar = s.ATarih
                       }).Distinct();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Gno;
                Liste.Rows[i].Cells[1].Value = k.Car;
                Liste.Rows[i].Cells[2].Value = k.Tar;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        private void Sec()
        {
            try
            {
                secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && secimId > 0)
            {
                frmAnasayfa.IAktarma = secimId;
                Close();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
