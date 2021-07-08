using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static Banca.Conto;

namespace Banca
{
    class BancaManager
    {
        static List<Conto> conti = new List<Conto>();
        // non riesco a creare quello .txt (ho appena messo il percorso giu)
        static string path @ C:\Users\jgera\OneDrive\Área de Trabalho\Banca\Banca\Banca\BancaManager.cs

        //public void AggiungiConto ()
        //  {
        //   Conto conto = new Conto();
        //
        // Console.WriteLine("inserisci nome e cognome");
        //conto.Intestario = Console.ReadLine();


        //bool IsDouble = false;
        //double saldo = 0;

        //do
        //{
        //  Console.WriteLine("inserisci il saldo iniziale");
        // IsDouble = double.TryParse(Console.ReadLine(), out saldo);
        // } while (!IsDouble);

        //conto.Saldo = saldo;

        //bool IsInt = false;
        //int tipoConto = 0;

        //do
        //{
        //  Console.WriteLine($"Premi {(int)Conto.Corrente} per creare un conto {Conto.Corrente}");
        // Console.WriteLine($"Premi {(int)Conto.Risparmio} per creare un conto {Conto.Risparmio}");

        //IsInt = int.TryParse(Console.ReadLine(), out tipoConto);
        //   } while (!IsInt || tipoConto < 0 || tipoConto > 1);

        //conto.Tipo = (Conto)tipoConto;

        //conti.Add(conto);
        // }
        public static void AggiungiConto()
        {
            Console.WriteLine("inserisci nome e cognome");
            string intestatario = Console.ReadLine();

            TipoConto tipoconto = ScegliTipoConto();

            Conto conto = new Conto(intestatario, tipoconto);
            conti.Add(conto);
        }

        public static void EffettuaVersamento();
        {
            MostraConti();
            Conto conto = ScegliConto();
            conti.Remove(conto);
            bool isDouble = false;
            double importo = 0;

            do
            {
            Console.WriteLine("inserisci l'importo da versamento");
            isDouble = double.TryParse(Console.ReadLine(), out importo);

            }while(!isDouble || importo< 0 );

            conto.AggiornaSaldo(importo);
            conti.Add(conto);
        }
    public static void SalvaSuFile();
    {
    using (StreamWriter sw = new StreamWriter(path, true))
    {
        sw.Write("Conti");
        sw.WriteLine();
        foreach (Conto conto in conti)
        {
         sw.WriteLine($"intestatario: {conto.Intestatario}, Saldo: {conto.Saldo}, tipo Conto: {conto.Tipo}");
        }
    }
}

public static void EffettuaPrelievo()
{
    Conto conto = new Conto();
    do
    {
        MostraConti();
        conto = ScegliConto();
    } while (conto.Tipo == TipoConto.Risparmio);
    MostraConti().Remove(conto);
    bool isDouble = false;
    double importo = 0;
    do
    {
        Console.WriteLine("inserisci il saldo iniziale");
        isDouble = double.TryParse(Console.ReadLine(), out importo);
    } while (!isDouble || importo > 0);
    conto.AggiornaSaldo(importo);
    conti.Add(conto);
}

public static void MostraConti(List<TipoConto> conti)
{
    if (conti.Count > 0)
    {
        int count = 1;
        foreach (Conto conto in conti)
        {
            Console.WriteLine($"{count} - Intestatario: {conto.Intestatario}, Saldo: {conto.Saldo}, Tipo conto: {conto.Tipo}");
            count++;
        }
    }
    else
    {
        Console.WriteLine("nessun conto presente!");
    }
}

public static void MostraConti()
{

    MostraConti(conti);
}
public static void EliminaConto();
{
    MostraConti();
    Conto contoDaEliminare = ScegliConto();
    conti.Remove(contoDaEliminare);
}
public static void FiltraConti();
{
    Console.WriteLine("scegli il tipo di conta da filtrare");
    TipoConto tipoconto = ScegliTipoConto();
    Lista<Conto> contiFiltrati = new List<Conto>();
    foreach (Conto conto in conti)
    {
        if (conto.Tipo == tipoconto)
        {
            contiFiltrati.Add(conto);
        }
    }
    if (contiFiltrati.Count > 0)
    {
        MostraConti(contiFiltrati);
    }
    else
    {
        Console.WriteLine("non sono presenti conti di tipo {tipoConto}");
    }
}
public static TipoConto ScegliTipoConto()
{
    bool isInt = false;
    int tipoConto = 0;
    do
    {
        Console.WriteLine($"premi {(int)TipoContoCorrente} per creare un conto {TipoContoCorrente}");
        Console.WriteLine($"premi {(int)TipoContoRisparmio} per creare un conto {TipoContoRisparmio}");
        isInt = int.TryParse(Console.ReadLine(), out tipoConto);
    } while (!isInt || tipoConto < 0 || tipoConto > 1);
    return (TipoConto)tipoConto;
}
public static Conto ScegliConto
{
    bool isInt = false;
    int numConto = 0;
    do
    {
        Console.WriteLine("inserisci il numero di conto");
        isInt = int.TryParse(Console.ReadLine(), out numConto);
    }while (!isInt || numConto < 0 || numConto > conti.Count);
    return conti.ElementAt (numConto - 1);
}
    
    }
    }

