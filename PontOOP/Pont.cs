using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontOOP
{
    public class Pont
    {
        private int x;
        private int y;
        private static Random random = new Random();

        public Pont()
        {
            this.x = 0;
            this.y = 0;
        }

        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Pont(int n)
        {
            this.x = random.Next(-n, n + 1);
            this.y = random.Next(-n, n + 1);
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public double TavolsagAzOrigotol
        {
            get
            {
                return Math.Sqrt(this.X * this.X + this.Y * this.Y);
            }
        }

        /*
         * Javas megoldás getter és setterre
        public int getX()
        {
            return x;
        }

        public void setX(int x)
        {
            this.x = x;
        }
        */
        public override string ToString()
        {
            return String.Format("({0};{1})", this.x, this.y);
            //String interpolation
            //return $"({this.x};{this.y})";
        }
    }
}
