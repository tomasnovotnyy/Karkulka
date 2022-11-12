using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervenaKarkulka
{
    internal class Game
    {

        public int spravna_odpoved = 2;
        public int pocet_navstev_louky = 0;
        Random random = new Random();

        public void Start()
        {
            int[,] plocha = new int[4, 4];
            HraciPole h1 = new HraciPole(plocha, 1, 1);
            Prekazka p1 = new Prekazka(2, 2);
            Vyhlidka v1 = new Vyhlidka(4, 3);
            Koren k1 = new Koren(2, 3);
            Louka l1 = new Louka(3, 3);
            Vlk vlk = new Vlk(3, 4);
            Karkulka karkulka = new Karkulka(true, true);
            Console.WriteLine("Karkulka je na pozici: " + "[" + h1.row + ", " + h1.column + "]" + "\nVaším úkolem je dostat se na pozici [4,4], kde sídlí babiččina chaloupka.");

            while (h1.row != 4 || h1.column != 4)
            {
                Console.WriteLine("Zvolte smer pohybu: {sever = 1; jih = 2; zapad = 3; vychod = 4}");
                h1.Pohyb(Convert.ToInt32(Console.ReadLine()));

                if (p1.row == h1.row && p1.column == h1.column)
                {
                    Console.WriteLine("Ajaj, narazil jsi na potok." + "\nTeď dostaneš otázku, pokud odpovíš správně, můžeš jít dál, pokud ne, prohrál jsi." + "\nProgramátorská konstrukce try…catch se v C# používá:" + "\n1) na ukončení cyklu" + "\n2) na odchycení výjimky" + "\n3) v C# nic takového neexistuje" + "\n4) pro zavolání konstruktoru");

                    int moje_odpoved = Convert.ToInt32(Console.ReadLine());
                    if (moje_odpoved == spravna_odpoved)
                    {
                        Console.WriteLine("Výborně. Odpověděl jsi správně, můžeš pokračovat.");
                    }
                    else
                    {
                        Console.WriteLine("Bohužel jsi neodpověděl správně, ale zdá se, že okolo prochází myslivec.");
                        if (karkulka.babovka == false && karkulka.vino == false)
                        {
                            Console.WriteLine("Ale ne, zdá se, že už nemáš žádný dárek. Bohužel tady pro tebe hra končí, sbohem příteli :(");
                            break;
                        }
                        else if (karkulka.babovka == true && karkulka.vino == true)
                        {
                            Console.WriteLine("Dej myslivcovi jeden dárek a můžeš pokračovat ve hře." + "\nCo se rozhodeš dát myslivcovi?" + "\n1) Víno" + "\n2) Bábovku");
                            int darovani_darku = Convert.ToInt32(Console.ReadLine());
                            if (darovani_darku == 1)
                            {
                                karkulka.vino = false;
                                Console.WriteLine("Rozhodl jsi se dát myslivcovi víno.");
                            }
                            else if (darovani_darku == 2)
                            {
                                karkulka.babovka = false;
                                Console.WriteLine("Rozhodl jsi se dát myslivcovi bábovku.");
                            }
                        }
                        else if (karkulka.babovka == false)
                        {
                            Console.WriteLine("Dej myslivcovi jeden dárek a můžeš pokračovat ve hře." + "\nCo se rozhodeš dát myslivcovi?" + "\n1) Víno");
                            int darovani_darku = Convert.ToInt32(Console.ReadLine());
                            if (darovani_darku == 1)
                            {
                                karkulka.vino = false;
                                Console.WriteLine("Rozhodl jsi se dát myslivcovi víno.");
                            }
                        }
                        else if (karkulka.vino == false)
                        {
                            Console.WriteLine("Dej myslivcovi jeden dárek a můžeš pokračovat ve hře." + "\nCo se rozhodeš dát myslivcovi?" + "\n1) Bábovka");
                            int darovani_darku = Convert.ToInt32(Console.ReadLine());
                            if (darovani_darku == 1)
                            {
                                karkulka.babovka = false;
                                Console.WriteLine("Rozhodl jsi se dát myslivcovi bábovku.");
                            }
                        }
                    }
                }


                if (v1.row == h1.row && v1.column == h1.column)
                {
                    Console.WriteLine(v1.ToString());
                }


                if (k1.row == h1.row && k1.column == h1.column)
                {
                    Console.WriteLine("Ajaj, jsi na políčku 'kořen'. Tento kořen tě vcucl do jiné dimenze a vrátil zpátky sem, musíš se znovu zorientovat.");
                    h1.row = random.Next(1, 5);
                    h1.column = random.Next(1, 5);
                    Console.WriteLine("Nyní jsi na pozici: " + "[" + h1.column + ", " + h1.row + "]");
                }


                if (l1.row == h1.row && l1.column == h1.column)
                {
                    if (pocet_navstev_louky >= 1)
                    {
                        Console.WriteLine("Promiň, ale jednou už jsi získal zpátky svoje dárky, podruhé už to bohužel nepůjde.");
                    }
                    else
                    {
                        Console.WriteLine("Ocitl jsi se na louce. Pokud jsi cestou ztratil jeden nebo oba ze svých dárků, zde můžeš jeden dárek získat zpátky.");
                        if (karkulka.babovka == false)
                        {
                            Console.WriteLine("Vidím, že nemáš bábovku, já ti dám novou.");
                            karkulka.babovka = true;
                            pocet_navstev_louky++;
                        }
                        else if (karkulka.vino == false)
                        {
                            Console.WriteLine("Vidím, že nemáš víno, já ti dám nové.");
                            karkulka.vino = true;
                            pocet_navstev_louky++;
                        }
                        else
                        {
                            Console.WriteLine("Vidím, že máš oba dárky, v tom přípradě ti jenom popřeju hodně štěstí.");
                        }
                    }
                }


                if (vlk.row == h1.row && vlk.column == h1.column)
                {
                    if (karkulka.babovka == false || karkulka.vino == false)
                    {
                        Console.WriteLine("Potkal jsi vlka. Musíš ještě pro další dárky pro babičku, to ale znamená, že vlk tam bude dřív než ty a sežere babičku. \nGAME OVER");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ajaj, potkal jsi vlka, ale naštěstí máš oba dva dárky, takže bys to měl stihnout k babičce dřív než vlk.");
                    }
                }
            }
        }
    }
}

