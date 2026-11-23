using System;

namespace CSharp_Lesson03_Task
{
    class Program
    {
        static void VariantlariQarisdir(string[] variantlar, Random random)
        {
            for (int i = variantlar.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                string temp = variantlar[i];
                variantlar[i] = variantlar[j];
                variantlar[j] = temp;
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();

            string[] suallar = new string[10]
            {
                "1. Console.ReadLine() hansi tip qaytarir?",
                "2. int ve double hansi yaddasda saxlanilir?",
                "3. Reference tiplerin default deyeri nedir?",
                "4. Cevirme zamani exception atmayan metod hansidir?",
                "5. Eyni string-lerin saxlandigi yaddas nece adlanir?",
                "6. Deyeri birbasa deyisdirile bilmeyen tip nece adlanir?",
                "7. Metni suretli birlesdirmek ucun hansi istifade olunur?",
                "8. Istenilen sayda parametr oturmek ucun hansi soz istifade olunur?",
                "9. Parametrin yalniz oxunmasi ucun hansi soz yazilir?",
                "10. Massivin uzunlugunu bildiren xususiyyet hansidir?"
            };

            string[] duzgunCavablar = new string[10]
            {
                "string",
                "Stack",
                "null",
                "TryParse",
                "Intern Pool",
                "Immutable",
                "StringBuilder",
                "params",
                "in",
                "Length"
            };

            string[][] variantlar = new string[10][]
            {
                new string[] { "string", "int", "char" },
                new string[] { "Stack", "Heap", "Disk" },
                new string[] { "null", "0", "false" },
                new string[] { "TryParse", "Parse", "Convert" },
                new string[] { "Intern Pool", "Heap", "Stack" },
                new string[] { "Immutable", "Mutable", "Dynamic" },
                new string[] { "StringBuilder", "String", "Char" },
                new string[] { "params", "ref", "out" },
                new string[] { "in", "ref", "out" },
                new string[] { "Length", "Count", "Size" }
            };

            int xal = 0;

            for (int i = 0; i < suallar.Length; i++)
            {
                Console.Clear();
                Console.WriteLine($"Cari xaliniz: {xal}\n");

                VariantlariQarisdir(variantlar[i], random);

                Console.WriteLine(suallar[i]);
                Console.WriteLine($"A) {variantlar[i][0]}");
                Console.WriteLine($"B) {variantlar[i][1]}");
                Console.WriteLine($"C) {variantlar[i][2]}");

                Console.Write("\nCavabinizi secin (A, B, C): ");
                string secim = Console.ReadLine().ToLower().Trim();

                string secilmisCavab = "";

                if (secim == "a")
                {
                    secilmisCavab = variantlar[i][0];
                }
                else if (secim == "b")
                {
                    secilmisCavab = variantlar[i][1];
                }
                else if (secim == "c")
                {
                    secilmisCavab = variantlar[i][2];
                }

                if (secilmisCavab == duzgunCavablar[i])
                {
                    xal += 10;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nDuzgun cavab! (+10 xal)");
                    Console.ResetColor();
                }
                else
                {
                    xal -= 10;
                    if (xal < 0)
                    {
                        xal = 0;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nSehvdir! (-10 xal) Duzgun cavab: {duzgunCavablar[i]}");
                    Console.ResetColor();
                }

                Console.WriteLine("\nNovbeti suala kecmek ucun Enter duymesini basin...");
                Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine($"Imtahan bitmisdir, siz {xal} qeder xal toplamisininz.");
        }
    }
}