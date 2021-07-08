using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    /*
     I conti hanno:
    Intestatario
    Tipo di Conto - > Corrente - Risparmio
    */
    class Conto
    {
        //Proprietà
        public string Intestatario { get; set; }
        public Double Saldo { get; set; }
        public TipoConto Tipo { get; set; }


        //Costruttore vuoto
        public Conto()
        {

        }
        public Conto(string intestatario, TipoConto tipoConto)
        {
            Intestatario = intestatario;
            Tipo = tipoConto;
            Saldo = 100;
        }
        public enum TipoConto
        {
            Corrente,
            Risparmio
        }

        public void AggiornaSaldo (double importo)
        {
            Saldo = Saldo + importo;

        }

    }


}



