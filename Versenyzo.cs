using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnookerRanglista
{
    internal class Versenyzo
    {
        readonly int id;
        int helyezes;
        readonly string nev;
        readonly string orszag;
        decimal nyeremeny;

        public int Id => id;

        public int Helyezes { get => helyezes; set => helyezes = value; }

        public string Nev => nev;

        public string Orszag => orszag;

        public decimal Nyeremeny { get => nyeremeny; set => nyeremeny = value; }

        public Versenyzo(int id, int helyezes, string nev, string orszag,  decimal nyeremeny)
        {
            this.id = id;
            Helyezes = helyezes;
            this.nev = nev;
            this.orszag = orszag;
            Nyeremeny = nyeremeny;
        }
    }
}
