using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Çekilişe girecek Kişi Sayısı Giriniz :");
            string number = Console.ReadLine();
            int personNumber = Convert.ToInt32(number);
            string[] persons = new string[personNumber];

            for (int i = 0; i < personNumber; i++)
            {
                Console.WriteLine((i + 1) + ". Kişinin adını soyadını giriniz");
                persons[i] = Console.ReadLine();
            }

            Console.WriteLine("Kazanacak kişi sayısını giriniz :");
            string winnerStr = Console.ReadLine();
            int winnerNumber = Convert.ToInt32(winnerStr);

            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < winnerNumber; i++)
            {
                int randomNumber = random.Next(personNumber - 1);
                Console.WriteLine("Tebrikler " + (i + 1) + ". talihli : " + persons[randomNumber]);
            }
            Console.ReadLine();
        }
    }
}
