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
            /* UPPGIFT 10
            Console.WriteLine("Nu ska jag berätta en historia om dig.\nVad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Vad jobbar du med?");
            string job = Console.ReadLine();
            Console.WriteLine("Det var en gång " + name + " som jobbade som " + job + ". " + name + " föll ut för ett stup och dog.");
            */
            /*UPPGIFT 11
            int days = 200;
            double hours = 3.5;
            string coding = "It sure is!";
            Console.WriteLine("Days to summer:");
            Console.WriteLine(days);
            Console.WriteLine("Hours to lunch:");
            Console.WriteLine(hours);
            Console.WriteLine("Coding is fun:");
            Console.WriteLine(coding);
            */
            /*UPPGIFT 12
            Console.WriteLine("skriv ett heltal");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input);
            */
            /*UPPGIFT 13
            Console.WriteLine("Skriv ett decimaltal");
            double input = Convert.ToDouble(Console.ReadLine());
            */
            /*UPPGIFT 14
            Console.WriteLine("GIVE ME THE TRUTH");
            bool input = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(input);
            */
            /*UPPGIFT 15
            Console.WriteLine("GE MIG EN STRING");
            string str = Console.ReadLine();
            Console.WriteLine("GE MIG EN INT");
            int intiger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("GE MIG EN DOUBLE");
            double dub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("GE MIG EN BOOLEAN");
            bool boo = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("STRING " + str + "\nINT " + intiger + "\nDOUBLE " + dub + "\nBOOLEAN " + boo);
            */
            /*UPPGIFT 16
            Console.WriteLine("HUR MÅNGA DAGAR?");
            int input = Convert.ToInt32(Console.ReadLine());
            int sek = input * 86400;
            Console.WriteLine(sek);
            */
            /*UPPGIFT 17
            Console.WriteLine("SKRIV 2 INTS");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int add = one + two;
            Console.WriteLine(add);
            */
            /*UPPGIFT 18
            Console.WriteLine("SKRIV 3 INTS");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int three = Convert.ToInt32(Console.ReadLine());
            int add = one + two + three;
            Console.WriteLine(add);
            */
            /*UPPGIFT 19
            Console.WriteLine("SKRIV 2 INTS");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int add = one + two;
            Console.WriteLine(one + " + " + two + " = " + add);
            */
            /*UPPGIFT 20
            Console.WriteLine("SKRIV 2 INTS");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int mult = one * two;
            Console.WriteLine(mult);
            */
            /*UPPGIFT 21
            Console.WriteLine("SKRIV 2 INTS");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int avr = (one + two)/2;
            Console.WriteLine(avr);
            */
            /*UPPGIFT 22
            Console.WriteLine("SKRIV 3 INTS");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int three = Convert.ToInt32(Console.ReadLine());
            int avr = (one + two + three) / 3;
            Console.WriteLine(avr);
            */
            /*UPPGIFT 23
            Console.WriteLine("Skriv 2 siffror");
            double one = Convert.ToDouble(Console.ReadLine());
            double two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{one} + {two} = {one + two}");
            Console.WriteLine($"{one} - {two} = {one - two}");
            Console.WriteLine($"{one} / {two} = {one / two}");
            Console.WriteLine($"{one} * {two} = {one * two}");
            */
            /*UPPGIFT 24
            Console.WriteLine("Skriv ett heltal");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 120)
            {
                Console.WriteLine("SPEEEEEEDING");
            }
            */
            /*UPPGIFT 25
            Console.WriteLine("Skriv ett heltal");
            string input = Console.ReadLine();
            if(input == "1984")
            {
                Console.WriteLine("Orwell");
            }
            */
            /*UPPGIFT 26
            Console.WriteLine("Hur gammal är du?");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input < 1900)
            {
                Console.WriteLine("Du är gammal");
            }
            */
            /*UPPGIFT 27
            Console.WriteLine("Skriv ett tal");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input < 0)
            {
                Console.WriteLine("Det är negativt");
            }
            else if(input > 0)
            {
                Console.WriteLine("Det är positivt");
            }
            */
            /*UPPGIFT 28
            Console.WriteLine("Hur gammal är du?");
            int input = Convert.ToInt32(Console.ReadLine());
            if(input >= 18)
            {
                Console.WriteLine("Du är vuxen");
            }
            else
            {
                Console.WriteLine("Du är inte vuxen");
            }
            */
            /*UPPGIFT 29
            Console.WriteLine("Skriv 2 tal");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            if(one > two)
            {
                Console.WriteLine("tal 1 är störst");
            }
            else if(one < two)
            {
                Console.WriteLine("Tal 2 är störst");
            }
            else
            {
                Console.WriteLine("De är lika");
            }
            */
            /*UPPGIFT 30
            Console.WriteLine("Hur många % fick du?");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 50)
            {
                Console.WriteLine("F");
            }
            else if (input < 60)
            {
                Console.WriteLine("1");
            }
            else if (input < 70)
            {
                Console.WriteLine("2");
            }
            else if (input < 80)
            {
                Console.WriteLine("3");
            }
            else if (input < 90)
            {
                Console.WriteLine("4");
            }
            else if (input < 100)
            {
                Console.WriteLine("5");
            }
            else if (input > 100)
            {
                Console.WriteLine("Utomordentligt");
            }
            */
            /*UPPGIFT 31
            Console.WriteLine("Skriv ett nummer");
            int input = Convert.ToInt32(Console.ReadLine());
            while(input > 2)
            {
                input = input / 2;
            }
            if(input == 1)
            {
                Console.WriteLine("Talet är udda");
            }
            else
            {
                Console.WriteLine("Talet är jämnt");
            }
            */
            /*UPPGIFT 32
            Console.WriteLine("SPEAK FRIEND AND ENTER");
            string input = Console.ReadLine();
            if(input == "Mellon")
            {
                Console.WriteLine("Enter, Friend")
            }
            else
            {
                Console.WriteLine("They've got a cave troll");
            }
            */
            /*UPPGIFT 33
            Console.WriteLine("Skriv 2 strings");
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            if(one == two)
            {
                Console.WriteLine("Echo");
            }
            else
            {
                Console.WriteLine("NEJ");
            }
            */
            //UPPGIFT 34
            Console.WriteLine("Vill du fortsätta?");
            string input = Console.ReadLine();
            while (input != "nej")
            {
                string input = Console.ReadLine();
            }
        }
    }
}
