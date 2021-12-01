using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    public static class Helper
    {
        //Static olarak işareetlenmiş classlar örneklenemez...
        // Helper H1 = new Helper(); (Hata veriyor)

        
        /*public void Test()
        {

        }
        *
        *Static olan classlar içerisinde standart metotlar kullanılamaz.
        *(static olmayan metotlar)
        */


       /* public string Tanim { get; set; }
        * 
        * Statik olan classlar içerisinde static olmayan field tanımları yapılamaz.
        */


       /* public Helper()
        {

        }
       *
       *Her nesne örneği alındığında uygulama standart yapıcı metotu çalıştırır.
       */

        static Helper()
        {
            //Uygulama içerisinde istenildği kadar çağırılsınlar sadece ilk çağırılmada 
            //çalışırlar...
            Console.WriteLine("Helper => Static class => static CTOR");
        }

        public static void emailGonder(string aliciEmailAdres,string konu,string icerik)
        {   
            //Email gönderme işlemleri devam edecek...
            Console.WriteLine("Mail gönderim işlemi başarılı.");
        }

    }
}
