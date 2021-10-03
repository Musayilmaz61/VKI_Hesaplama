using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlk_Projem12
{
    class Program
    {
        static void Main(string[] args)
        {

            double boy, kilo, vki;
            Console.WriteLine("Boyunuzu Metre Cinsinden Giriniz? (örn:1,75) (!!VİRGÜL KULLANMALISINIZ!!)");
            Console.WriteLine("-----------------------------------------------------------------------------");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Kilonuzu Kg Cinsinden Giriniz? (örn:65)");
            Console.WriteLine("-------------------------------------------");
            kilo = Convert.ToDouble(Console.ReadLine());
            vki = kilo / (boy * boy);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Vücut Kitle İndeksiniz: {0}", vki);
            Console.WriteLine("-------------------------------------------");

            if (vki < 18 && vki > 0 )
            {
                Console.WriteLine("Zayıfsın Kilo Almalısın!");
            }
            else if (vki > 18  && vki  < 25 )
            {
                Console.WriteLine("Normal kilodasın :)");
            }
            else if (vki > 25 && vki < 30)
            {
                Console.WriteLine("Kilolusun diyete başla :)");
            }
            else if (vki > 30 && vki < 35)
            {
                Console.WriteLine("Obezsin kilo vermeye başlamalısın!");
            }
            else if (vki > 35 && vki < 50)
            {
                Console.WriteLine("Ciddi derecede obezsin acilen doktora gitmelisin!!!");
            }
            else
            {
                Console.WriteLine("R.İ.P");
            }
           
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Herhangi Bir Tuşa Basarak Kapatabilirsiniz...");
           
            Console.ReadKey();

        }



    }

} 
