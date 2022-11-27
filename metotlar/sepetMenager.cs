using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
     class sepetMenager
    {
        public void Ekle(Ürün ürün) 
        {
            Console.WriteLine("tebrikler sepete eklendi :"+ürün.Adı); 
        }

        public void Ekle2(string ürünAdı,string Açıklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("tebrikler sepete eklendi :" + ürünAdı );
        }
            
    }
}
