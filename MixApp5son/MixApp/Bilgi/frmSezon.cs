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
    public partial class frmSezon : Form
    {
        MixDbContext db = new MixDbContext();
        int secimId = -1;
        bool edit = false;
        public frmSezon()
        {
            InitializeComponent();
        }

        private void frmSezon_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0; // foreach döngüsü için bir indexe ihtiyaç olduğu için yaptık
            var lst = db.Sezonlars.ToList().OrderBy(x => x.Sezon);
            foreach (var k in lst)
            {
                Liste.Rows.Add(); // kendileri satır oluşturamıyor biz kendimiz oluşturuyoruz.
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.Sezon;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        void YeniKayit()
        {
            var cont = (from s in db.Sezonlars
                        where s.Sezon == txtGrupAdi.Text.ToLower()
                        select s).ToList();
            if (cont.Count == 0)
            {
                if (txtGrupAdi.Text != "")
                {
                    Sezonlar szn = new Sezonlar();
                    szn.Sezon = "*"+txtGrupAdi.Text;
                    db.Sezonlars.Add(szn);
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

        private void Temizle()
        {
            txtGrupAdi.Text = "";
            edit = false;
            secimId = -1;
        }

        void Guncelle()
        {
            Sezonlar szn = db.Sezonlars.First(x => x.Id == secimId);
            szn.Sezon = "*"+txtGrupAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı..");
            Listele();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            db.Sezonlars.Remove(db.Sezonlars.First(x => x.Id == secimId));
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
