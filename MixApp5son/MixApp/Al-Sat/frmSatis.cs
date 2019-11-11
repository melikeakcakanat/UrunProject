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
    public partial class frmSatis : Form
    {
        MixDbContext db = new MixDbContext();
        Numaralar N = new Numaralar();


        public string[] MyArray { get; set; }
        public frmSatis()
        {
            InitializeComponent();
        }
       
        private void frmSatis_Load(object sender, EventArgs e)
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
        private void YeniKayit()
        {
            UrunSat[] urn = new UrunSat[Liste.RowCount];
            Liste.AllowUserToAddRows = false;
            for (int i = 0; i < Liste.RowCount; i++)
            {
                try
                {
                    urn[i] = new UrunSat();
                    urn[i].Aciklama = txtAciklama.Text;
                    urn[i].CariId = db.Carilers.FirstOrDefault(x => x.CariAdi == txtCari.Text).Id;
                    urn[i].SaveDate = DateTime.Now;
                    urn[i].SaveUSer = -1;
                    urn[i].UpdateDate = DateTime.Now;
                    urn[i].UpdateUSer = -1;
                    urn[i].UrunSatgrupNo = Convert.ToInt32(txtUrunGrupNo.Text);
                    urn[i].STarih = DateTime.Parse(txtAtarih.Text);
                    string uk = Liste.Rows[i].Cells[1].Value.ToString();
                    urn[i].UrunlerId = db.Urunlers.First(x => x.UrunKodu == uk).Id;
                    urn[i].Adet = int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                    urn[i].SatisFiyat = decimal.Parse(Liste.Rows[i].Cells[5].Value.ToString());
                    var kdv = Liste.Rows[i].Cells[7].Value;
                    urn[i].Kdv = kdv ==null ? 18: int.Parse(Liste.Rows[i].Cells[7].Value.ToString());
                    db.UrunSats.Add(urn[i]);
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata Kodu" + e);
                }
          
                StokDurum[] durum = new StokDurum[Liste.RowCount];
                durum[i] = new StokDurum();
                string uk1 = Liste.Rows[i].Cells[1].Value.ToString();
                int urid = db.Urunlers.First(x => x.UrunKodu == uk1).Id;
                var srg = (from s in db.StokDurums
                           where s.UrunId == urid
                           select s).ToList();
                if (srg.Count() != 0)
                {
                    foreach (var k in srg)
                    {
                        k.Adet -= int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                    }
                   
                }
                else
                {
                     MessageBox.Show("Ürün Bulunamadı..");
                    
                }
            }
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı..");
        }

        public string uAlGrupNo()
        {
            try
            {
                double Numara = Convert.ToDouble((from s in db.UrunAls orderby s.Id descending select s).First().UrunAlgrupNo);
                Numara++;
                string num = Numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "0000001";
            }
        }

        public string uSatGrupNo()
        {
            try
            {
                double Numara = Convert.ToDouble((from s in db.UrunSats
                                                  orderby s.Id descending
                                                  select s).First().UrunSatgrupNo);
                Numara++;
                string num = Numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
           
                return "0000001";
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
