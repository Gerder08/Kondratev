using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratev
{
    class ColorVect : Vect, IComparable, IColor
    {
        private string color;
        public string Color
        {
            get => color;
            set => color = value;
        }

        string IColor.MyColor
        {
            get { return color; }
        }

        public ColorVect(int x1, int x2, int y1, int y2, string color) : base(x1, x2, y1, y2)
        {
            Color = color;
        }
        //интерфейс IComparable
        public int CompareTo(object o)
        {
            Vect p = o as Vect;
            if (p != null)
                return this.Color.CompareTo(p.X1);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}

