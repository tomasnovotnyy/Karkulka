﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervenaKarkulka
{
    internal class Prekazka
    {
        public int row;
        public int column;

        public Prekazka(int column, int row)
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
    }
}
