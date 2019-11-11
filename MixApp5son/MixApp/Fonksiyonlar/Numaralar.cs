using MixApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixApp.Fonksiyonlar
{
    class Numaralar
    {
        MixDbContext db = new MixDbContext();
        public string uGrupNo()
        {
            try
            {
                double Numara = Convert.ToDouble((from s in db.Urunlers orderby s.Id descending select s).First().UrunGrupNo);
                Numara++;
                string num = Numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "0000001";
            }
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
    }
}
