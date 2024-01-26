using System.Runtime.CompilerServices;
using System.Security;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Oluşturmak istediğiniz yığınının eleman sayisini giriniz ");
            int adet=Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack(adet);
            for(int i = 0; i < adet; i++) 
            {
                Console.WriteLine("Eklemek istediğiniz veriyi giriniz.");
                int sayi=Convert.ToInt32(Console.ReadLine());
                stack.push(sayi);
              
            }
            Console.WriteLine("-------");
            stack.print();
            Console.WriteLine("Çıkarmak istediğiniz  veriyi giriniz");
            int cıkarilacaksayi = Convert.ToInt32(Console.ReadLine());
            stack.pop(cıkarilacaksayi);
            Console.WriteLine("Listenin güncel hali : ");
            stack.print();
            Console.WriteLine("Stack'in ilk ve son elemanı değiştirilmiş hali: ");
            stack.yerdegistir();
            stack.print();

        }
    }
}