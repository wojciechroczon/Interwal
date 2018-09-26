using System;

namespace Interwal
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer ts = new Timer();

            Console.WriteLine("Podaj godziny pracy :");
            ts.Hours= int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj minuty pracy :");
            ts.Minutes = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj sekundy pracy :");
            ts.Seconds= int.Parse(Console.ReadLine());


            ts.Print();
            Console.ReadLine();



            


        }
    }
}
