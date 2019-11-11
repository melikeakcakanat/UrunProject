using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixApp.Model
{
    public class Urunler:BaseEntity
    {
        
        public int CariId { get; set; }
        [ForeignKey("CariId")]
        public virtual Cariler Cariler { get; set; } //lazy loading otomatik olarak yüklü geliyor. // iger loading te ise çağrmadan gelmiyor..
        public int UrunGrupId { get; set; }
        [ForeignKey("UrunGrupId")]
        public virtual UrunGrup UrunGrup { get; set; }
        public int MarkaId { get; set; }
        [ForeignKey("MarkaId")]
        public virtual Markalar Markalar { get; set; }
        public int RenkId { get; set; }
        [ForeignKey("RenkId")]
        public virtual Renkler Renkler { get; set; }
        public int BedenId { get; set; }
        [ForeignKey("BedenId")]
        public virtual Bedenler Bedenler { get; set; }
        public int SezonId { get; set; }
        [ForeignKey("SezonId")]
        public virtual Sezonlar Sezonlar { get; set; } // sezonlar(hepsi için geçerli) bölümü değişken olabiliyor..
        public string Aciklama { get; set; }
        public string Barkod { get; set; }
        public string UrunKodu { get; set; }
        public int UrunGrupNo { get; set; }
        public DateTime Tarih { get; set; }
        public virtual ICollection<UrunAl> UrunAls { get; set; }
    }
}
