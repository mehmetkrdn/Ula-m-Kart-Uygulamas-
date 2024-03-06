using System.Diagnostics.Tracing;
using System.Runtime;

namespace UlaşımKartı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulaşımkartı kart = new ulaşımkartı();
            int tercih;
            Console.WriteLine("1) Para yükleme");
            Console.WriteLine("2) Kart Güncelleme");
            Console.WriteLine("3) Kart Silme");
            Console.WriteLine("Hangi işlemi yapmak istiyorsunuz");
            tercih = Convert.ToInt32(Console.ReadLine());
            if (tercih==1)
            {
                kart.Parayükleme();
            }
            if (tercih==2)
            {
                kart.update();
            }
            if (tercih == 3) 
            {
                kart.delete();
            }         
            Console.ReadLine();
        }
    }
    class ulaşımkartı
    {
        public void Parayükleme()
        {
            Console.WriteLine("Para yüklemek istediğinize eminseniz evet yazınıız");
            string onay = Console.ReadLine();
            int bakiye = 0;
            int moneyadd;
            Console.WriteLine("Kartınıza ne kadar bakiye yüklemek istiyorsunuz? 10-20-50-100-200");
            moneyadd = Convert.ToInt32(Console.ReadLine());
            
            while (onay=="evet"&&onay=="Evet")
            {
                switch (moneyadd)
                {
                    case 10:
                        Console.WriteLine("Kartınıza 10 tl yüklendi");
                        bakiye = bakiye + 10;
                        Console.WriteLine("Kartınızın bakiyesi= " + bakiye + "TL");
                        break;
                    case 20:
                        Console.WriteLine("Kartınıza 20 tl yüklendi");
                        bakiye = bakiye + 20;
                        Console.WriteLine("Kartınızın bakiyesi= " + bakiye + "TL");
                        break;
                    case 50:
                        Console.WriteLine("Kartınıza 50 tl yüklendi");
                        bakiye = bakiye + 50;
                        Console.WriteLine("Kartınızın bakiyesi= " + bakiye + "TL"); break;
                    case 100:
                        Console.WriteLine("Kartınıza 100 tl yüklendi");
                        bakiye = bakiye + 100;
                        Console.WriteLine("Kartınızın bakiyesi= " + bakiye + "TL"); break;
                    case 200:
                        Console.WriteLine("Kartınıza 200 tl yüklendi");
                        bakiye = bakiye + 200;
                        Console.WriteLine("Kartınızın bakiyesi= " + bakiye + "TL"); break;
                        Console.WriteLine("Para yüklemeye devam etmek ister misiniz");
                        string işlem = Console.ReadLine();
                        if (işlem=="evet" && işlem=="Evet")
                        {
                            onay = "evet";
                        }
                        else if (işlem=="hayır"&&işlem=="Hayır")
                        {
                            onay = "hayır";
                        }
                }
            }
            Console.WriteLine("işlemleriniz başarıyla tamamlanmıştır iyi günler dileriz");
        }
        public void update()
        {
            Console.WriteLine("Kartınız güncellenmiştir!");
        }
        public void delete()
        {
            Console.WriteLine("Kartınız silinmiştir!");
        }
    }
    
}