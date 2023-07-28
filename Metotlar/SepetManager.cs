using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine("Tebrikler. Sepete eklendi!");
            Console.WriteLine("---------------------------------");
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine(urunAdi);
            Console.WriteLine("Tebrikler. Sepete eklendi!");
            Console.WriteLine("---------------------------------");
        }
    }
}
