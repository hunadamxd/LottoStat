using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace LottoStat
{
    class Program
    {
    

        static void Main(string[] args)
        {
            //Számok beolvasás az excel táblázatból és egybőli konvertálása int formátumba
            List<eddiginyertesszamok> Eddiginyertesszamok = new List<eddiginyertesszamok>();
            StreamReader sr = new StreamReader("otos.csv");
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                Eddiginyertesszamok.Add(new eddiginyertesszamok(int.Parse(temp[11]), int.Parse(temp[12]), int.Parse(temp[13]), int.Parse(temp[14]), int.Parse(temp[15])));
            }


            for (int i = 0; i < Eddiginyertesszamok.Count; i++)
            {
                Console.WriteLine("");
            }

            //A bekért számok listába való felvétele
            List<int> szamok = new List<int>();
            Console.WriteLine("Lottó sorsoláshoz kérlek adj meg 5 számot:");
            int db = 0;
            int szam;
            do
            {
                //Felvétel és hibakezelés
                do
                {
                    Console.Write((db + 1) + " szám: ");
                } while (!Int32.TryParse(Console.ReadLine(), out szam) || (szam < 1 || szam > 90));

                
                if (!szamok.Contains(szam))
                {
                    db++;
                    szamok.Add(szam);
                    Console.WriteLine("Következő számod:");
                }

            } while (szamok.Count < 5); 

            //saját lottoszámok ismétlődése változó
            int talalat;
            int ktalalat = 0;
            int htalalat = 0;
            int ntalalat = 0;
            int otalalat = 0;

            //
            for (int i = 0; i < Eddiginyertesszamok.Count; i++)
            {
                talalat = 0;

                
                if (szamok.Contains(Eddiginyertesszamok[i].Szam1))
                {
                    talalat++;
               
                }
               
                if (szamok.Contains(Eddiginyertesszamok[i].Szam2))
                {
                    talalat++;
                }
               
                if (szamok.Contains(Eddiginyertesszamok[i].Szam3))
                {
                    talalat++;
                }
               
                if (szamok.Contains(Eddiginyertesszamok[i].Szam4))
                {
                    talalat++;
                }
               
                if (szamok.Contains(Eddiginyertesszamok[i].Szam5))
                {
                    talalat++;
                }

                //nyereményes találatok bejegyzése
                switch (talalat)
                {
                    case 5: otalalat++; break;
                    case 4: ntalalat++; break;
                    case 3: htalalat++; break;
                    case 2: ktalalat++; break;
                    default: break;
                }
            }

            //találatok kiírása


            //Console.WriteLine("Add meg az általad szerencsésnek gondolt lottó nyerőszámokat");

            //Console.Write("1. Szám");
            //int elsoszam;
            //elsoszam = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2. Szám");
            //int masodikszam;
            //masodikszam = Convert.ToInt32(Console.ReadLine());

            //Console.Write("3. Szám");
            //int harmadikszam;
            //harmadikszam = Convert.ToInt32(Console.ReadLine());

            //Console.Write("4. Szám");
            //int negyedikszam;
            //negyedikszam = Convert.ToInt32(Console.ReadLine());

            szamok.Sort();

            //Console.Write("5. Szám");
            //int otodikszam;
            //otodikszam = Convert.ToInt32(Console.ReadLine());

            //foreach (int nyeroszamm in Eddiginyertesszamok)
            //{

            //}


            
            
           
            Console.WriteLine("{5} 2-es találat,\n" +
                "{6} 3-as találat,\n" +
                "{7} 4-es találat, és\n" +
                "{8} 5-ös találat lett volna.",
                szamok[0], szamok[1], szamok[2], szamok[3], szamok[4], ktalalat, htalalat, ntalalat, otalalat);

            Console.ReadKey();
        }

        //public void bekeres()
        //{
        //    Console.Write("1. Szám");
        //    int elsoszam;
        //    elsoszam = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("2. Szám");
        //    int masodikszam;
        //    masodikszam = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("3. Szám");
        //    int harmadikszam;
        //    harmadikszam = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("4. Szám");
        //    int negyedikszam;
        //    negyedikszam = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("5. Szám");
        //    int otodikszam;
        //    otodikszam = Convert.ToInt32(Console.ReadLine());

        //    //if (elsoszam == masodikszam || elsoszam == harmadikszam || elsoszam==negyedikszam || elsoszam==otodikszam ||masodikszam== elsoszam || masodikszam== harmadikszam|| masodikszam)
        //    //{

        //    //}

        //    if (elsoszam != masodikszam && harmadikszam != negyedikszam && negyedikszam != otodikszam)
        //    {
        //        analizis();
        //    }
        //    Console.WriteLine("Ugyan olyan számokat adtál meg, kezd újra!");
        //    bekeres();





    }
        //static void analizis()
        //{
        //    foreach (int nyeremeny in Eddiginyertesszamok)
        //    {
        //        if (elsoszam == nyeremeny)
        //        {
                        
        //        }
        //    }
        //}
    
}
