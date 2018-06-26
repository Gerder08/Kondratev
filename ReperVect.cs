using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratev
{
    
    class ReperVect : Vect, IComparable, IReper
    {
        private int x;
        private int y;
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }
        int IReper.X
        {
            get { return x; }
        }
        int IReper.Y
        {
            get { return y; }
        }
            
        public ReperVect(int x1, int x2, int y1, int y2, int x,int y) : base(x1, x2, y1, y2)
        {
            X = x;
            Y = y;
        }
        //интерфейс IComparable
        public int CompareTo(object o)
        {
            Vect p = o as Vect;
            if (p != null)
                return this.X.CompareTo(p.X1);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
