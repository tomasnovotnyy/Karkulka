using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervenaKarkulka
{
    internal class Vyhlidka
    {
        public int row;
        public int column;

        public Vyhlidka(int column, int row)
        {
            this.row = row;
            this.column = column;
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        public override string? ToString()
        {
            return "Dostal jsi se na vyhlídku. Sedneš si a začneš se kochat přírodou. Všude kolem sebe vidíš jen stromy, cítíš vůni kvetoucích květin a slyšíš šumění potůčku. Chvíli si tu poležíš, a pak ti dojde, že už by jsi měl zase vyrazit.";
        }
    }
}
