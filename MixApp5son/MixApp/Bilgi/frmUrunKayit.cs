using MixApp.Fonksiyonlar;
using MixApp.Model;
using System;
using System.Collections;
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
    public partial class frmUrunKayit : Form
    {
        MixDbContext db = new MixDbContext();
        Numaralar n = new Numaralar();
        Formlar F = new Formlar();
        public string[] MyArray { get; set; }
        public string[] MyMrk { get; set; }
        public string[] MyRnk { get; set; }
        public string[] MySzn { get; set; }
        public string[] MyBdn { get; set; }
        public frmUrunKayit()
        {
            InitializeComponent();
        }

        private void frmUrunKayit_Load(object sender, EventArgs e)
        {
            Combo();
            txtUrunGrupNo.Text = n.uGrupNo();
        }

        private void Combo()
        {
            //txtCari.DataSource = db.Carilers.ToList();
            //txtCari.ValueMember = "Id";
            //txtCari.DisplayMember = "CariAdi";
            //txtCari.SelectedIndex = -1; // comboxın boş gelmesini sağlar..

            //txtUrunGrup.ValueMember = "Id";
            //txtUrunGrup.DisplayMember = "GrupAdi";
            //txtUrunGrup.DataSource = db.UrunGrups.ToList();
            AutoCompleteStringCollection veriCari = new AutoCompleteStringCollection();
            var lstCari = db.Carilers.Select(x => x.CariAdi).Distinct(); //aynı olanları almıyor
            foreach (var cr in lstCari)
            {
                veriCari.Add(cr);
                txtCari.Items.Add(cr);
            }
            txtCari.AutoCompleteCustomSource = veriCari;

            #region ÜrünGrup
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = db.UrunGrups.Select(x => x.GrupAdi).Distinct(); //aynı olanları almıyor
            foreach (var cr in lst)
            {
                veri.Add(cr);
                txtUrunGrup.Items.Add(cr);
            }
            txtUrunGrup.AutoCompleteCustomSource = veri;



            int dgv;
            dgv = txtUrunGrup.Items.Count;
            MyArray = new string[dgv];
            for (int i = 0; i < dgv; i++)
            {
                MyArray[i] = txtUrunGrup.Items[i].ToString();
            }
            #endregion


            #region Marka
            AutoCompleteStringCollection veriMrk = new AutoCompleteStringCollection(); //yazı yazınca otomatik olarak tanımlamak..
            var lstMrk = db.Markalars.Select(x => x.MArka).Distinct(); //aynı olanları almıyor
            foreach (var cr in lstMrk)
            {
                veriMrk.Add(cr);
                txtMarka.Items.Add(cr);
            }
            txtMarka.AutoCompleteCustomSource = veriMrk;

            int dgvMrk = txtMarka.Items.Count;
            MyMrk = new string[dgvMrk];
            for (int i = 0; i < dgvMrk; i++)
            {
                MyMrk[i] = txtMarka.Items[i].ToString();
            }
            #endregion

            #region Renk
            AutoCompleteStringCollection veriRnk = new AutoCompleteStringCollection(); //yazı yazınca otomatik olarak tanımlamak..
            var lstRnk = db.Renklers.Select(x => x.Renk).Distinct(); //aynı olanları almıyor
            foreach (var cr in lstRnk)
            {
                veriRnk.Add(cr);
                txtRenk.Items.Add(cr);
            }
            txtRenk.AutoCompleteCustomSource = veriRnk;



            int dgvRenk = txtRenk.Items.Count;
            MyRnk = new string[dgvRenk];
            for (int i = 0; i < dgvRenk; i++)
            {
                MyRnk[i] = txtRenk.Items[i].ToString();
            }
            #endregion

            #region Sezon
            AutoCompleteStringCollection veriSzn = new AutoCompleteStringCollection(); //yazı yazınca otomatik olarak tanımlamak..
            var lstSzn = db.Sezonlars.Select(x => x.Sezon).Distinct(); //aynı olanları almıyor
            foreach (var cr in lstSzn)
            {
                veriSzn.Add(cr);
                txtSezon.Items.Add(cr);
            }
            txtSezon.AutoCompleteCustomSource = veriSzn;



            int dgvSzn = txtSezon.Items.Count;
            MySzn = new string[dgvSzn];
            for (int i = 0; i < dgvSzn; i++)
            {
                MySzn[i] = txtSezon.Items[i].ToString();
            }
            #endregion

            #region Beden
            AutoCompleteStringCollection veriBdn = new AutoCompleteStringCollection(); //yazı yazınca otomatik olarak tanımlamak..
            var lstBdn = db.Bedenlers.Select(x => x.Beden).Distinct(); //aynı olanları almıyor
            foreach (var cr in lstBdn)
            {
                veriBdn.Add(cr);
                txtBeden.Items.Add(cr);
            }
            txtBeden.AutoCompleteCustomSource = veriBdn;



            int dgvBdn = txtBeden.Items.Count;
            MyBdn = new string[dgvBdn];
            for (int i = 0; i < dgvBdn; i++)
            {
                MyBdn[i] = txtBeden.Items[i].ToString();
            }
            #endregion
        }

        void YeniKayit()
        {
            Urunler[] urn = new Urunler[Liste.RowCount];
            Liste.AllowUserToAddRows = false;
            for (int i = 0; i < Liste.RowCount; i++)
            {
                try
                {
                    urn[i] = new Urunler();
                    urn[i].Aciklama = txtAciklama.Text;
                    urn[i].CariId = db.Carilers.FirstOrDefault(x => x.CariAdi == txtCari.Text).Id;
                    urn[i].Tarih = DateTime.Parse(txtGTarih.Text);
                    urn[i].SaveDate = DateTime.Now;
                    urn[i].SaveUSer = -1;
                    urn[i].UpdateDate = DateTime.Now;
                    urn[i].UpdateUSer = -1;
                    urn[i].UrunGrupNo = Convert.ToInt32(txtUrunGrupNo.Text);
                    urn[i].UrunKodu = "*"+Liste.Rows[i].Cells[0].Value.ToString();
                    string ugi = Liste.Rows[i].Cells[1].Value.ToString();
                    string mi = Liste.Rows[i].Cells[2].Value.ToString();
                    string ri = Liste.Rows[i].Cells[3].Value.ToString();
                    string bi = Liste.Rows[i].Cells[4].Value.ToString();
                    string si = Liste.Rows[i].Cells[5].Value.ToString();
                    urn[i].UrunGrupId = db.UrunGrups.FirstOrDefault(x => x.GrupAdi == ugi).Id;
                    urn[i].MarkaId = db.Markalars.FirstOrDefault(x => x.MArka == mi).Id;
                    urn[i].RenkId = db.Renklers.FirstOrDefault(x => x.Renk == ri).Id;
                    urn[i].BedenId = db.Bedenlers.FirstOrDefault(x => x.Beden == bi).Id;
                    urn[i].SezonId = db.Sezonlars.FirstOrDefault(x => x.Sezon == si).Id;
                    urn[i].Barkod = Liste.Rows[i].Cells[6].Value.ToString();

                    db.Urunlers.Add(urn[i]);
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata Kodu" + e);
                }
                
            }
            db.SaveChanges();
            MessageBox.Show("Kayıt İşlemi Başarılı..");
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

        private void btnUrnNo_Click(object sender, EventArgs e)
        {
            int id = F.UrunKayitListesi(true);
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
            var bul = db.Urunlers.First(x => x.UrunGrupNo == id);
            txtCari.Text = bul.Cariler.CariAdi;
            txtGTarih.Text = bul.Tarih.ToShortDateString();
            txtAciklama.Text = bul.Aciklama;
            txtUrunGrupNo.Text = bul.UrunGrupNo.ToString().PadLeft(7, '0');
            var srg = (from s in db.Urunlers
                       where s.UrunGrupNo == id
                       select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.UrunKodu;
                Liste.Rows[i].Cells[1].Value = k.UrunGrup.GrupAdi;
                Liste.Rows[i].Cells[2].Value = k.Markalar.MArka;
                Liste.Rows[i].Cells[3].Value = k.Renkler.Renk;
                Liste.Rows[i].Cells[4].Value = k.Bedenler.Beden;
                Liste.Rows[i].Cells[5].Value = k.Sezonlar.Sezon;
                Liste.Rows[i].Cells[6].Value = k.Barkod;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt.AutoCompleteCustomSource.Clear();
            if (Liste.CurrentCell.ColumnIndex == 1 && txt != null)
            {               
                txt.AutoCompleteCustomSource.AddRange(MyArray);
            }
            else if (Liste.CurrentCell.ColumnIndex == 2 && txt != null)
            {                
                txt.AutoCompleteCustomSource.AddRange(MyMrk);
            }
            else if (Liste.CurrentCell.ColumnIndex == 3 && txt != null)
            { 
                txt.AutoCompleteCustomSource.AddRange(MyRnk);
            }
            else if (Liste.CurrentCell.ColumnIndex == 4 && txt != null)
            { 
                txt.AutoCompleteCustomSource.AddRange(MyBdn);
            }
            else if (Liste.CurrentCell.ColumnIndex == 5 && txt != null)
            {
                txt.AutoCompleteCustomSource.AddRange(MySzn);
            }
            else
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;
            }

        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Liste.CurrentRow.Cells[6].Value =
                    Liste.CurrentRow.Cells[0].Value.ToString() + "+" +
                    Liste.CurrentRow.Cells[1].Value.ToString() + "+" +
                    Liste.CurrentRow.Cells[2].Value.ToString() + "+" +
                    Liste.CurrentRow.Cells[3].Value.ToString() + "+" +
                    Liste.CurrentRow.Cells[4].Value.ToString() + "+" +
                    Liste.CurrentRow.Cells[5].Value.ToString();
            }
            if (e.ColumnIndex == 0) // Aynı ürün kodundan var mı diye kontrol yapılıyor..
            {
                string uk = Liste.CurrentRow.Cells[0].Value.ToString();
                var srg = (from s in db.Urunlers
                           where s.UrunKodu == "*"+uk
                           select s).ToList();
                if (srg.Count > 0)
                {
                    MessageBox.Show("Bu ürün kodu daha önce kullanılmış..");
                    Liste.CurrentRow.Cells[0].Value = "";
                }
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
