using System;

namespace RefaktorointiTarve
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Valitse toiminto: (1) Summaa, (2) Vähennä, (3) Kerro, (4) Jaa, (5) Lopeta");
                string valinta = Console.ReadLine() ?? "";

                if (valinta == "5")
                {
                    keepRunning = false;
                    continue;
                }

                int numero1, numero2;
                if (!KysyKaksiLukua(out numero1, out numero2))
                {
                    continue;
                }

                SuoritaToiminto(valinta, numero1, numero2);
            }
        }

        private static void SuoritaToiminto(string valinta, int numero1, int numero2)
        {
            switch (valinta)
            {
                case "1":
                    Console.WriteLine($"Tulos: {numero1 + numero2}");
                    break;
                case "2":
                    Console.WriteLine($"Tulos: {numero1 - numero2}");
                    break;
                case "3":
                    Console.WriteLine($"Tulos: {numero1 * numero2}");
                    break;
                case "4":
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Nollalla jakaminen ei ole sallittua.");
                    }
                    else
                    {
                        Console.WriteLine($"Tulos: {numero1 / (double)numero2}");
                    }
                    break;
                default:
                    Console.WriteLine("Tuntematon toiminto.");
                    break;
            }
        }

        private static bool KysyKaksiLukua(out int numero1, out int numero2)
        {
            Console.WriteLine("Anna ensimmäinen numero:");
            string input1 = Console.ReadLine() ?? "0";
            Console.WriteLine("Anna toinen numero:");
            string input2 = Console.ReadLine() ?? "0";
            bool onnistuiko1 = int.TryParse(input1, out numero1);
            bool onnistuiko2 = int.TryParse(input2, out numero2);

            if (!onnistuiko1 || !onnistuiko2)
            {
                Console.WriteLine("Virheellinen syöte!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
