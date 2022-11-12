using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervenaKarkulka
{
    internal class HraciPole
    {
        public int column = 0;
        public int row = 0;
        public int[,] plocha;

        public HraciPole(int[,] plocha, int row, int column)
        {
            this.plocha = plocha;
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


        // sever = 1; jih = 2; zapad = 3; vychod = 4;
        public void Pohyb(int move)
        {
            switch (move)
            {
                case 1:
                    if (this.column-- <= 1)
                    {
                        throw new Exception("Jsi mimo pole.");
                    }
                    else
                    {
                        Console.WriteLine("Jste na pozici: " + "[" + this.column + ", " + this.row + "]");
                    }
                    break;
                case 2:
                    if (this.column++ >= 4)
                    {
                        throw new Exception("Jsi mimo pole.");
                    }
                    else
                    {
                        Console.WriteLine("Jste na pozici: " + "[" + this.column + ", " + this.row + "]");
                    }
                    break;
                case 3:
                    if (this.row-- <= 1)
                    {
                        throw new Exception("Jsi mimo pole.");
                    }
                    else
                    {
                        Console.WriteLine("Jste na pozici: " + "[" + this.column + ", " + this.row + "]");
                    }
                    break;
                case 4:
                    if (this.row++ >= 4)
                    {
                        throw new Exception("Jsi mimo pole.");
                    }
                    else
                    {
                        Console.WriteLine("Jste na pozici: " + "[" + this.column + ", " + this.row + "]");
                    }
                    break;
            }
        }

    }
}
