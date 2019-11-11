using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixApp.Model
{
    public class BaseEntity //bUrada yazdığım bütün özellikler Kalıtım alan sınıflarda gözükecek
    {
        public int Id { get; set; }
        public DateTime SaveDate { get; set; }
        public int SaveUSer { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUSer { get; set; }
    }
}
