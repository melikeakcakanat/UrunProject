using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MixApp.Model;

namespace MixApp.Bilgi
{
    public partial class frmCariGiris : Form
    {
        MixDbContext db = new MixDbContext();
        int secimId = -1; // hata kontrolü 
        bool edit = false; // edit false olduğu zamanda kadetsin true olsuğu zaman güncellesin
        public frmCariGiris()
        {
            InitializeComponent();
        }

        private void frmCariGiris_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            //var lst1 = db.Carilers.ToList();
            var lst = (from s in db.Carilers where s.CariAdi.Contains(txtAra.Text) || s.Adres.Contains(txtAra.Text)
                       select new
                       {
                           cari = s.CariAdi,
                           Id = s.Id,
                           tel = s.Tel,
                           Mail = s.Mail,
                           adress = s.Adres,
                       }).Distinct().OrderBy(x => x.Id);

            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.cari;
                Liste.Rows[i].Cells[2].Value = k.tel;
                Liste.Rows[i].Cells[3].Value = k.Mail;
                Liste.Rows[i].Cells[4].Value = k.adress;
                i++;
            }
            Liste.AllowUserToAddRows = false;

        }

        void YeniKaydet()
        {
            try
            {
                Cariler cr = new Cariler();
                cr.Adres = txtAdres.Text;
                cr.CariAdi = txtCariAdi.Text;
                cr.Mail = txtMail.Text;
                cr.Tel = txtTelefon.Text;
                cr.VnoTc = txtVnoTc.Text;
                cr.Web = txtWeb.Text;
                cr.VergiD = txtVergiD.Text;
                cr.SaveDate = DateTime.Now;
                cr.SaveUSer = -1;
                cr.UpdateDate = DateTime.Now;
                cr.UpdateUSer = -1;
                db.Carilers.Add(cr);
                db.SaveChanges();
                MessageBox.Show("Kayıt başarıyla oluşturuldu");
                Listele();
                Temizle();
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata Bilgisi" + e); ;
            }

        }

        void Guncelle()
        {
            Cariler cr = db.Carilers.Find(secimId);
            cr.Adres = txtAdres.Text;
            cr.CariAdi = txtCariAdi.Text;
            cr.Mail = txtMail.Text;
            cr.Tel = txtTelefon.Text;
            cr.VnoTc = txtVnoTc.Text;
            cr.Web = txtWeb.Text;
            cr.VergiD = txtVergiD.Text;
            cr.UpdateDate = DateTime.Now;
            cr.UpdateUSer = -1;
            db.SaveChanges();
            MessageBox.Show("Güncelleme başarıyla yapldı.");
            Listele();
            Temizle();
        }

        private void Temizle() // Karışık yapılarda tek tek silmektense hepsini tek seferde yok etymeliyiz
        {
            foreach (Control ct in splitContainer2.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                {
                    ct.Text = "";
                }
            }
            edit = false;
            secimId = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secimId > 0 && edit == true && MessageBox.Show("Seçili olan kayıt güncellenecektir\n Güncelleme işlemnini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Guncelle();
            }
            else if (edit == false)
            {
                YeniKaydet();
            }  
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
                btnCollapse.Text = "GİZLE";
            }
            else if (splitContainer1.Panel2Collapsed == false)
            {
                splitContainer1.Panel2Collapsed = true;
                btnCollapse.Text = "Göster";
            }
        }

        private void btnCollapce2_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2Collapsed == true)
            {
                splitContainer2.Panel2Collapsed = false;
                btnCollapse2.Text = "GİZLE";
            }
            else if (splitContainer2.Panel2Collapsed == false)
            {
                splitContainer2.Panel2Collapsed = true;
                btnCollapse2.Text = "Göster";
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId>0)
            {
                Ac(secimId);
            }
        }

        private void Ac(int secimId)
        {
            edit = true;
            Cariler cari = db.Carilers.Find(secimId);
            txtAdres.Text = cari.Adres;
            txtCariAdi.Text = cari.CariAdi;
            txtMail.Text = cari.Mail;
            txtTelefon.Text = cari.Tel;
            txtVergiD.Text = cari.VergiD;
            txtVnoTc.Text = cari.VnoTc;
            txtWeb.Text = cari.Web;
        }

        private void Sec()
        {
            try
            {
                //secimId = (int)Liste.CurrentRow.Cells[0].Value;
                secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                secimId = -1;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
           // Listele(); // isteğe bağlı otomatik arama için yapılır..
        }
    }
}
