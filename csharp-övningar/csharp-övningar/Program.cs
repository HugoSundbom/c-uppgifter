using System;

namespace csharp_övningar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* UPPGIFT 1
            Console.WriteLine("Hello World!");
            */
            /* UPPGIFT2
            Console.WriteLine("Once upon a time");
            Console.WriteLine("I was falling in love");
            Console.WriteLine("Now I’m only falling apart");
            */
            /* UPPGIFT 3
            Console.WriteLine("Once upon a time\nI was falling in love\nNow I’m only falling apart");
            */
            /* UPPGIFT 4
            string text = "Live and Sleep!";
            Console.WriteLine(text);
            */
            /* UPPGIFT 5
            string name = "Ada Lovelace";
            Console.WriteLine("hej" + name);
            */
            /* UPPGIFT 6
            string input = Console.ReadLine();
            Console.WriteLine(input);
            */
            /* UPPGIFT 7
            string input = Console.ReadLine();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(input);
            }
            */
            /* UPPGIFT 8
            Console.WriteLine("Vad heter du?");
            string input = Console.ReadLine();
            Console.WriteLine("hej" + input);
            */
            /* UPPGIFT 9
            Console.WriteLine("Hur mår du?");
            Console.ReadLine();
            Console.WriteLine("Varför mår du så då?");
            Console.ReadLine();
            Console.WriteLine("Adios");
            */
            // UPPGIFT 10
            Console.WriteLine("Nu ska jag berätta en historia om dig.\nVad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Vad jobbar du med?");
            string job = Console.ReadLine();
            Console.WriteLine("Det var en gång " + name + "som jobbade som " + job + ". " + name + "föll ut för ett stup och dog.");
        }
    }
}
