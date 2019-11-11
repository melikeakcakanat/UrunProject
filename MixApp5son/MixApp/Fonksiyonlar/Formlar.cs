using MixApp.Al_Sat;
using MixApp.Bilgi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixApp.Fonksiyonlar
{
    public class Formlar
    {
        #region Cari işlemler
        public void CariGirisİslemi()
        {
            frmCariGiris frm = new frmCariGiris(); // Ramda çalıştırımak için yeni nesne türettik
            //frm.MdiParent = ActiveForm;
            frm.MdiParent = Application.OpenForms["frmAnasayfa"] as frmAnasayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        #endregion

        #region ÜrünGrup
        public void UrunGrupGiris()
        {
            frmUrunGrup frm = new frmUrunGrup();
            frm.ShowDialog();
        } 
        #endregion

        public void Renk()
        {
            frmRenk frm = new frmRenk();
            frm.ShowDialog();
        }

        public void Beden()
        {
            frmBeden frm = new frmBeden();
            frm.ShowDialog();
        }
        public void Sezon()
        {
            frmSezon frm = new frmSezon();
            frm.ShowDialog();
        }
        public void MarkaGiris()
        {
            frmMarka frm = new frmMarka();
            frm.ShowDialog();
        }
        public void UrunKayit()
        {
            frmUrunKayit frm = new frmUrunKayit(); // Ramda çalıştırımak için yeni nesne türettik
            //frm.MdiParent = ActiveForm;
            frm.MdiParent = Application.OpenForms["frmAnasayfa"] as frmAnasayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        public void Alis()
        {
            frmAlis frm = new frmAlis(); // Ramda çalıştırımak için yeni nesne türettik
            //frm.MdiParent = ActiveForm;
            frm.MdiParent = Application.OpenForms["frmAnasayfa"] as frmAnasayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        public void Satis()
        {
            frmSatis frm = new frmSatis(); // Ramda çalıştırımak için yeni nesne türettik
            //frm.MdiParent = ActiveForm;
            frm.MdiParent = Application.OpenForms["frmAnasayfa"] as frmAnasayfa;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        public int UrunKayitListesi(bool secim = false)
        {
            var frm = new frmUrunKayitListe();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            return frmAnasayfa.IAktarma;
        }
        public int UrunAlListesi(bool secim = false)
        {
            var frm = new frmAlisListe();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            return frmAnasayfa.IAktarma;
        }
    }
}
