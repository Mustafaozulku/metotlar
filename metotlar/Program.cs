using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ürün ürün1 = new Ürün();
            ürün1.Adı = "elma";
            ürün1.Fiyatı = 50;
            ürün1.Açıklama = "amasya elması";

            Ürün ürün2 = new Ürün();
            ürün2.Adı = "karpuz"; 
            ürün2.Fiyatı = 80;
            ürün2.Açıklama = "diyarbakır karpuzu";

            Ürün[] ürünler = new Ürün[] {ürün1,ürün2  };

            foreach (Ürün ürün in ürünler)
            {
                Console.WriteLine(ürün.Adı);
                Console.WriteLine(ürün.Fiyatı);
                Console.WriteLine(ürün.Açıklama);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("--------------------metotlar-----------------");

            sepetMenager sepetMenager = new sepetMenager();
            sepetMenager.Ekle(ürün1);
            sepetMenager.Ekle(ürün2);

            sepetMenager.Ekle2("armut", "yeşil armut",12, 10);
            sepetMenager.Ekle2("elma", "yeşil elma", 12, 9);
            sepetMenager.Ekle2("karpuz", "diyarbakır karpuzu", 12, 8);



        }
    }
}
 