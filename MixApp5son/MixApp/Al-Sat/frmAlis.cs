using MixApp.Fonksiyonlar;
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
    public partial class frmAlis : Form
    {
        MixDbContext db = new MixDbContext();
        Numaralar N = new Numaralar();
        Formlar F = new Formlar();

        public string[] MyArray {get;set;}
        public frmAlis()
        {
            InitializeComponent();
        }

        private void frmAlis_Load(object sender, EventArgs e)
        {
            Combo();
            txtUrunGrupNo.Text = N.uAlGrupNo();
        }

        private void Combo()
        {
            txtUrunKodu.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtUrunKodu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var srg = db.Urunlers.Select(x => x.UrunKodu).Distinct();
            foreach (string urun in srg)
            {
                veri.Add(urun);
                txtUrunKodu.Items.Add(urun);
            }
            txtUrunKodu.AutoCompleteCustomSource = veri;

            int dgv = txtUrunKodu.Items.Count;
            MyArray = new string[dgv];

            for (int i = 0; i < dgv; i++)
            {
                MyArray[i] = txtUrunKodu.Items[i].ToString();
            }

            var srg1 = db.Carilers.Select(x => x.CariAdi).Distinct();
            foreach (string cari in srg1)
            {
                txtCari.Items.Add(cari);
            }
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            if (Liste.CurrentCell.ColumnIndex == 1 && txt != null)
            {
                txt.AutoCompleteCustomSource.AddRange(MyArray);
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string uk = Liste.CurrentRow.Cells[1].Value.ToString();
                int id = db.Urunlers.First(x => x.UrunKodu == uk).Id;
                if (id > 0)
                {
                    var srg = (from s in db.Urunlers
                               where s.Id == id
                               select s).ToList();
                    foreach (var k in srg)
                    {
                        Liste.CurrentRow.Cells[2].Value = k.UrunGrup.GrupAdi;
                        Liste.CurrentRow.Cells[3].Value = k.Markalar.MArka;
                        Liste.CurrentRow.Cells[6].Value = k.Barkod;
                    }
                        
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnUrnNo = new Button();
            btnUrnNo.Size = new Size(25, txtUrunGrupNo.ClientSize.Height + 2);
            btnUrnNo.Location = new Point(txtUrunGrupNo.ClientSize.Width - btnUrnNo.Width, -1);
            btnUrnNo.Cursor = Cursors.Default;
            btnUrnNo.Image = Properties.Resources.iconfinder_forward_126569;
            txtUrunGrupNo.Controls.Add(btnUrnNo);
            btnUrnNo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            base.OnLoad(e);

            btnUrnNo.Click += btnUrnNo_Click;
        }

        private void btnUrnNo_Click(object sender, EventArgs e)    //Sanal buton !!
        {
            int id = F.UrunAlListesi(true);
            if (id > 0)
            {
                Ac(id);
            }
            frmAnasayfa.IAktarma = -1;
        }

        private void Ac(int id)
        {
            Liste.Rows.Clear();
            int i = 0;
            var bul = db.UrunAls.First(x => x.UrunAlgrupNo == id);
            txtCari.Text = bul.Cariler.CariAdi;
            txtAtarih.Text = bul.ATarih.ToShortDateString();
            txtAciklama.Text = bul.Aciklama;
            txtUrunGrupNo.Text = bul.UrunAlgrupNo.ToString().PadLeft(7, '0');
            var srg = (from s in db.UrunAls
                       where s.UrunAlgrupNo == id
                       select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.Urunler.UrunKodu;
                Liste.Rows[i].Cells[2].Value = k.Urunler.UrunGrup.GrupAdi;
                Liste.Rows[i].Cells[3].Value = k.Urunler.Markalar.MArka;
                Liste.Rows[i].Cells[4].Value = k.Adet;
                Liste.Rows[i].Cells[5].Value = k.BirimFiyat;
                //Liste.Rows[i].Cells[6].Value = k.Barkod;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
  
    private void YeniKayit()
        {
            UrunAl[] urn = new UrunAl[Liste.RowCount];
            Liste.AllowUserToAddRows = false;
            for (int i = 0; i < Liste.RowCount; i++)
            {
                try
                {
                    urn[i] = new UrunAl();
                    urn[i].Aciklama = txtAciklama.Text;
                    urn[i].CariId = db.Carilers.FirstOrDefault(x => x.CariAdi == txtCari.Text).Id;
                    urn[i].SaveDate = DateTime.Now;
                    urn[i].SaveUSer = -1;
                    urn[i].UpdateDate = DateTime.Now;
                    urn[i].UpdateUSer = -1;
                    urn[i].UrunAlgrupNo = Convert.ToInt32(txtUrunGrupNo.Text);
                    urn[i].ATarih = DateTime.Parse(txtAtarih.Text);
                    string uk = Liste.Rows[i].Cells[1].Value.ToString();
                    urn[i].UrunlerId = db.Urunlers.FirstOrDefault(x => x.UrunKodu == uk).Id;
                    urn[i].Adet = int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                    urn[i].BirimFiyat = decimal.Parse(Liste.Rows[i].Cells[5].Value.ToString());

                    db.UrunAls.Add(urn[i]);
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata Kodu" + e);
                }
                db.SaveChanges();
                StokDurum[] durum = new StokDurum[Liste.RowCount];
                durum[i] = new StokDurum();
                int urid = urn[i].UrunlerId;
                var srg = (from s in db.StokDurums
                           where s.UrunId == urid
                           select s).ToList();
                if (srg.Count()!=0)
                {
                    foreach ( var k in srg)
                    {
                        k.Adet += int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                    }
                    db.SaveChanges();
                }
                else
                {
                    durum[i].UrunId = urn[i].UrunlerId;
                    durum[i].Adet = urn[i].Adet;
                    db.StokDurums.Add(durum[i]);
                    db.SaveChanges();
                }
            }
         
            MessageBox.Show("Kayıt Başarılı..");
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
