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

namespace MixApp.Bilgi
{
    public partial class frmUrunGrup : Form
    {
        MixDbContext db = new MixDbContext();
        int secimId = -1;
        bool edit = false;
        public frmUrunGrup()
        {
            InitializeComponent();
        }

        private void frmUrunGrup_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Temizle()
        {
            txtGrupAdi.Text = "";
            edit = false;
            secimId = -1;
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0; // foreach döngüsü için bir indexe ihtiyaç olduğu için yaptık
            var lst = db.UrunGrups.ToList().OrderBy(x=>x.GrupAdi);
            foreach(var k in lst)
            {
                Liste.Rows.Add(); // kendileri satır oluşturamıyor biz kendimiz oluşturuyoruz.
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.GrupAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        
        void YeniKayit()
        {
            var cont = (from s in db.UrunGrups
                        where s.GrupAdi.ToLower() == txtGrupAdi.Text.ToLower()
                        select s).ToList();
            if (cont.Count == 0)
            {
                if (txtGrupAdi.Text != "")
                {
                    UrunGrup urun = new UrunGrup();
                    urun.GrupAdi = "*"+txtGrupAdi.Text;
                    db.UrunGrups.Add(urun);
                    db.SaveChanges();
                    MessageBox.Show("Kayıt İşlemi Başarılı.");
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Grup Adı Boş Olamaz !!");
                }
            }
            else
            {
                MessageBox.Show("Grup adı daha önce girilmiş !!");
            }
            
        }

        void Guncelle()
        {
            UrunGrup urn = db.UrunGrups.First(x => x.Id == secimId);
            urn.GrupAdi = "*"+txtGrupAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı..");
            Listele();
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (secimId > 0 && edit == true && MessageBox.Show("Seçili olan kayıt güncellenecektir\n Güncelleme işlemnini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (edit == false)
            {
                YeniKayit();
            }
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                edit = true;
            }
            else
            {
                edit = false;
            }
        }

        private void Sec()
        {
            txtGrupAdi.Text = Liste.CurrentRow.Cells[1].Value.ToString().Substring(1);
            secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0 && edit == true && MessageBox.Show("Seçili olan kayıt silinecektir\n Silme işlemnini onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sil();
            }
            else if (edit == false)
            {
                YeniKayit();
            }
            Temizle();
        }

        private void Sil()
        {
            db.UrunGrups.Remove(db.UrunGrups.First(x => x.Id == secimId));
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı.");
            Listele();
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
