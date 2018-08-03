using System;
using System.IO;
using System.Text;

namespace Cwiczenie2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Write a program that reads a text file and displays the longest word in the file.
            var path = @"C:\temp\12\test.txt";

            var zawartoscPliku = File.ReadAllText(path);
            var dlugoscSlowa = 0;
            //var licznik = 0;
            var maxDlugoscSlowa = 0;
            var slowo = new StringBuilder();
            var najdluzszeSlowo = string.Empty;
            foreach (var literka in zawartoscPliku)
            {
                if (char.IsLetter(literka) && !char.IsWhiteSpace(literka))
                {
                    slowo.Append(literka);
                    dlugoscSlowa++;
                    continue;
                }

                if (dlugoscSlowa > maxDlugoscSlowa)
                {
                    maxDlugoscSlowa = dlugoscSlowa;
                    najdluzszeSlowo = slowo.ToString();
                }
                dlugoscSlowa = 0;
                slowo.Clear();
            }
            Console.WriteLine("Pierwsze, najdłuższe znalezione słowo to: >>" + najdluzszeSlowo +
                              "<<, składa się ono z " + maxDlugoscSlowa + " znaków.");
        }
    }
}