using System;
using System.Collections.Generic;

namespace Login_2
{
    class Program
    {
        static void Main()
        {
            bool ingelogd = false;
            int pogingen = 3;
            int schoen1 = 5;
            int schoen2 = 5;
            int schoen3 = 9;
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    Dictionary<string, string> goed = new Dictionary<string, string>()
            {   
                {"Gimpies", "Gimpies_Inkoop"}
            }; 
                    Console.WriteLine("Gebruikersnaam");
                    string gebruikersnaam = Console.ReadLine();
                    string wachtwoord = "";
                    Console.WriteLine("Wachtwoord: ");
                    ConsoleKeyInfo info = Console.ReadKey(true);
                    while (info.Key != ConsoleKey.Enter)
                    {
                        if (info.Key != ConsoleKey.Backspace)
                        {
                            Console.Write("*");
                            wachtwoord += info.KeyChar;
                        }
                        else if (info.Key == ConsoleKey.Backspace && wachtwoord.Length > 0)
                        {
                            wachtwoord.Remove(wachtwoord.Length - 1);
                            Console.Write("\b \b");
                        }
                        info = Console.ReadKey(true);
                    }
                    if (info.Key == ConsoleKey.Enter)
                    {
                        if (goed.ContainsKey(gebruikersnaam) && goed[gebruikersnaam].Equals(wachtwoord))
                        {
                            ingelogd = true;
                            do
                            {
                                Console.Clear();
                                string[] menukeuze = 
                                {
                                    "", "---U bent succesvol ingelogd---", "---maak uw keuze---",
                                    "1 - Voorraad schoenen bekijken", "2 - Schoenen Inkopen", "3 - Uitloggen"
                                };
                                foreach (string keus in menukeuze )
                                    Console.WriteLine(keus);
                                int keuze = Convert.ToInt32(Console.ReadLine());
                                switch (keuze)
                                { 
                                    case 1:
                                        {
                                            Console.Clear();
                                            string[] schoenenkeuze = {" 1 - Nike", " 2 - Adidas", " 3 - Puma"};
                                            foreach (string schoenenkeus in schoenenkeuze)
                                                Console.WriteLine(schoenenkeus);
                                            int schoenmerk = Convert.ToInt32(Console.ReadLine());
                                            switch (schoenmerk)
                                            {
                                                case 1:
                                                    Console.Clear();
                                                    string[] NikeJ = new string[5] {"Merk: Nike", "Soort: Jordan", "Maat: 41", "Kleur: Grijs", "Prijs: $309,99"};
                                                    foreach (string NikePrint in NikeJ)
                                                    {Console.WriteLine(NikePrint); }
                                                    Console.WriteLine("Aantal: {0}", schoen1);
                                                    Console.WriteLine( "6 - terug");
                                                    int back;
                                                    back = Convert.ToInt32(Console.ReadLine());
                                                    if (back == 6)
                                                        break;
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    string[] AdidasY = new string[5] {"Merk: Adidas", "Soort: Yeezy", "Maat: 42", "Kleur: Oranje", "Prijs: $449,99"};
                                                    foreach (string AdidasPrint in AdidasY)
                                                    {Console.WriteLine(AdidasPrint);}
                                                    Console.WriteLine("Aantal: {0}", schoen2);
                                                    Console.WriteLine("6 - terug");
                                                    int terug;
                                                    terug = Convert.ToInt32(Console.ReadLine());
                                                    if (terug == 6)
                                                        break;
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    string[] PumaB = new string[5] {"Merk: Puma", "Soort: Boost", "Maat: 41", "Kleur: Wit", "Prijs: 49,99"};
                                                    foreach (string PumaPrint in PumaB)
                                                    {Console.WriteLine(PumaPrint);}
                                                    Console.WriteLine("Aantal: {0}", schoen3);
                                                    Console.WriteLine("6 - terug");
                                                    int vorige;
                                                    vorige = Convert.ToInt32(Console.ReadLine());
                                                    if (vorige == 6)
                                                        break;
                                                    break;
                                            }
                                            break;
                                        }
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("Opties");
                                        Console.WriteLine("1 ~ Schoenen Inkopen");
                                        Console.WriteLine("2 ~ Terug gaan");
                                        int optie2 = Convert.ToInt32(Console.ReadLine());
                                        if (optie2 == 1)
                                        {
                                            Console.Clear();
                                            string[] Inkopen = new string[4] {"Welke paar schoenen wil je kopen?", "1 - Nikes", "2 - Adidas", "3 - Puma"};
                                            foreach (string InkopenPrint in Inkopen)
                                            {Console.WriteLine(InkopenPrint);}
                                            int schoenkeuze = Convert.ToInt32(Console.ReadLine());
                                            Console.Clear();
                                            Console.WriteLine("Hoeveel van deze schoenen wil je kopen? ");
                                            int aantal = Convert.ToInt32(Console.ReadLine());
                                            while (schoenkeuze > 0 && schoenkeuze <= 3 && aantal > 0)
                                            {
                                                switch (schoenkeuze)
                                                {
                                                    case 1:
                                                    {
                                                        schoen1 = optellen1(schoen1, aantal);
                                                        Console.Clear();
                                                        Console.WriteLine("Je hebt {0} paar van deze schoenen.",
                                                            schoen1);
                                                        Console.WriteLine("Druk op een knop om door te gaan");
                                                        Console.ReadKey();
                                                        break;
                                                    }
                                                    case 2:
                                                    {
                                                        schoen2 = optellen2(schoen2, aantal);
                                                        Console.Clear();
                                                        Console.WriteLine("Je hebt {0} paar van deze schoenen.",
                                                            schoen1);
                                                        Console.WriteLine("Druk op een knop om door te gaan");
                                                        Console.ReadKey();
                                                        break;
                                                    }
                                                    case 3:
                                                    {
                                                        schoen3 = optellen3(schoen3, aantal);
                                                        Console.Clear();
                                                        Console.WriteLine("Je hebt {0} paar van deze schoenen.",
                                                            schoen1);
                                                        Console.WriteLine("Druk op een knop om door te gaan");
                                                        Console.ReadKey();
                                                        break;
                                                    }
                                                }
                                                int optellen1(int schoen1, int aantal)
                                                {
                                                    schoen1 += aantal;
                                                    return schoen1;
                                                }
                                                int optellen2(int schoen2, int aantal)
                                                {
                                                    schoen2 += aantal;
                                                    return schoen2;
                                                }
                                                int optellen3(int schoen3, int aantal)
                                                {
                                                    schoen3 += aantal;
                                                    return schoen3;
                                                }
                                                break;
                                            }
                                        }
                                        else if (optie2 == 2)
                                        {
                                            break;
                                        }
                                        break;
                                    case 3:
                                        {
                                            ingelogd = false;
                                            gebruikersnaam = "";
                                            wachtwoord = "";
                                            pogingen = 4;
                                            break;                                            
                                        }
                                }
                            } while (ingelogd == true);
                        }
                        {
                            pogingen--;
                            Console.WriteLine("");
                            Console.WriteLine("Onjuist Wachtwoord of Gebruikersnaam. ");
                            Console.Clear();
                            Console.WriteLine("Je hebt nog " + pogingen + " pogingen over \n");
                        }
                    }
                    if (pogingen == 0)
                    {
                        Console.WriteLine("U heeft te vaak geprobeerd in te loggen. ");
                        Console.Clear();
                        Console.WriteLine("");
                        Environment.Exit(0);
                    }
                }
            } while (pogingen > 0 && pogingen <= 3); 
        }
    }
}