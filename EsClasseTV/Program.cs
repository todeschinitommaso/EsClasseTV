using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsClasseTV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisione TV1 = new Televisione();

            TV1.on();
            TV1.off();
        }


        public class Televisione
        {
            public string produttore;

            public string modello;

            public bool stato;

            public int[] canali = new int[1000]; //ogni slot dell'array é assegnato al corrispettivo canale eccetto lo 0

            public void on()
            {
                setStato(true);
            }

            public void off()
            {
                setStato(false);
            }

            public void inverti()
            {
                stato =! stato;
            }

            public void setStato(bool nuovoStato)
            {
                stato = nuovoStato;
            }
        }

        public struct connettori //ogni variabile riporta il numero di porte specifiche
        {
            public int hdmi;

            public int vga;

            public int RJ45;

            public int ethernet;

            //etc...
        }

    }
}
