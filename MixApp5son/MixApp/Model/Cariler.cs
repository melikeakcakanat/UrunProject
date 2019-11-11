using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixApp.Model
{
    public class Cariler : BaseEntity
    {
        //Data Anotation Buranın üzerindeki tanınlamalara denir 
        [StringLength(350)]
        [Required(ErrorMessage ="Bu Alan Gereklidir.")] // Forma önemli olmsa bile webde oldukça önemlidir Hata mesajı verdirir. Gerekliliklir Kullanılması Öneririlir
        [DisplayName("Cari Adı")]
        public string CariAdi { get; set; }
        [StringLength(350)]
        public string Adres { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        [StringLength(50)]
        public string VergiD { get; set; }

        [StringLength(11)]
        public string VnoTc { get; set; }
    }
}
