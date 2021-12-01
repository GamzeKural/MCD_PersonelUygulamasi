using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.Isim = "Faik";
            P1.Soyisim = "Turan";
            P1.Emailadres = "faik.turan";
            P1.Cinsiyet = 717770001; //Bay 717770002-Kadın

            Personel P2 = new Personel();
            P1.Isim = "Ali";
            P1.Soyisim = "Gel";
            P1.Emailadres = "ali.gel";
            P1.Cinsiyet = 717770001;

            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P2.Isim + P2.Soyisim);

            Console.ReadKey();

        }
    }
}
