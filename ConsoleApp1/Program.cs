using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za dużo za mało");
            #region losowanie
            //1.Komputer losuje
            var generator = new Random();
            int wylosowana = generator.Next(0, 101);
#if DEBUG
            //Console.WriteLine(wylosowana); //do usunięcia w wersji finalnej
#endif
            Console.WriteLine("Wylosowałem liczbę, odgadnij ją!");
            #endregion

            int licznikRuchow = 0;
            bool trafiono = false;
            do
            {


                #region propozycja gracza
                //2.Gracz podaje propozycję
                Console.Write("Podaj Twoją propozycję: ");
                string tekst = Console.ReadLine();
                Console.WriteLine($"Podałeś tekst {tekst}");

                int propozycja = Convert.ToInt32(tekst);
                #endregion
                #region ocena komputera
                //3.Komputer ocenia
                if (wylosowana < propozycja)
                {
                    Console.WriteLine("Za dużo");
                }
                else if (wylosowana > propozycja)
                {
                    Console.WriteLine("Za mało");
                }
                else
                {
                    Console.WriteLine("Trafiłeś");
                    trafiono = true;
                }
                #endregion
                licznikRuchow++:

            }
            while (!trafiono);
            Console.WriteLine("Liczba ruchów= {licznikRuchow});
            Console.WriteLine("Koniec Gry");
        }
    }
}
