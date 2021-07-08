using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    class Menu
    {
        public static void Start ()
        {
            Console.WriteLine("Banca");

            bool vuoiContinuare = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("premi 1 ver vedere i conti");
                Console.WriteLine("premi 2 ver aggiungere un conto");
                Console.WriteLine("premi 3 ver eliminare un conto");
                Console.WriteLine("premi 4 ver filtrare i conti");
                Console.WriteLine("premi 5 ver effettuare un prelievo");
                Console.WriteLine("premi 6 ver effettuare un versamento");

                Console.WriteLine("premi 0 per uscire");

                bool isInt = true;
                int scelta = 0;
                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out scelta);
                } while (!isInt);

                switch (scelta)
                {
                    case 1:
                        BancaManager.MostraConti();
                        break;
                    case 2:
                        BancaManager.AggiungiConto();
                        break;
                    case 3:
                        BancaManager.EliminaConto();
                        break;
                    case 4:
                        BancaManager.FiltraConti();
                        break;
                    case 5:
                        BancaManager.EffettuaPrelievo();
                        break;
                    case 6:
                        BancaManager.EffettuaVersamento();
                        break;
                    case 0:
                        vuoiContinuare = false;
                        BancaManager.SalvaSuFile();
                        break;
                    default:
                        Console.WriteLine("scelta sbagliata... riprovare");
                        break;

                }
            } while (vuoiContinuare);
        }
    }
}
