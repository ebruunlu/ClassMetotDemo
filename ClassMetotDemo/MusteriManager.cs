using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi + " Müşterisi eklendi.");
        }

        public void Sil(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi +" "+ musteri.Soyadi + " Müşterisi silindi.");
        }
        public void Listele(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi+" "+ musteri.Soyadi+ " "+ musteri.Tckn);
        }
    }
}
