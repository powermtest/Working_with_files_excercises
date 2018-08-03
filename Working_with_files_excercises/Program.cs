using System;
using System.IO;
using System.Linq;

namespace Working_with_files_excercises
{
    internal class Cwiczenie1
    {
        private static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the number of words.

            var path = @"C:\temp\12\test.txt";
            var zawartosc = File.ReadAllText(path);
            var licznikSlow = 1;
            var ileLiter = zawartosc.Count();
            Console.WriteLine("Plik zawiera " + ileLiter + " liter");
            var poprzedniZnak = zawartosc.ElementAt(0);
            //var czyPoprzedniaToNieLitera = false;
            foreach (var literka in zawartosc)
            {
                if (char.IsWhiteSpace(literka))
                {
                    if (char.IsWhiteSpace(poprzedniZnak))
                    {
                        var czyPoprzedniaToSpacja = char.IsWhiteSpace(poprzedniZnak);
                        if (czyPoprzedniaToSpacja)
                        {
                            poprzedniZnak = literka;

                            //czyPoprzedniaToNieLitera = true;
                            continue;
                        }
                    }

                    licznikSlow++;
                }
                //czyPoprzedniaToSpacja = false;
                poprzedniZnak = literka;
            }

            Console.WriteLine("Plik zawiera " + licznikSlow + " słów.");
        }
    }
}