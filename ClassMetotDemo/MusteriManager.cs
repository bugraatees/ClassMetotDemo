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
            Console.WriteLine("Tebrikler.. Eklendi : " + musteri.Adi + musteri.Soyadi);
        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Adı : " + musteri.Adi);
            Console.WriteLine("Soyadı : " + musteri.Soyadi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteriyi Sil : " + musteri.Adi + musteri.Soyadi);
        }
    }
}