using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervenaKarkulka
{
    internal class Karkulka
    {
        public bool vino = true;
        public bool babovka = true;

        public Karkulka(bool vino, bool babovka)
        {
            this.vino = vino;
            this.babovka = babovka;
        }

        public override string? ToString()
        {
            return "Karkulka ma vino: " + vino + "\n , ma babovku: " + babovka;
        }
    }
}
