using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratev
{
    public class Vect
    {
        //public Vect();

        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public int X1 { get => x1; set => x1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int Y2 { get => y2; set => y2 = value; }
        public String ToString(String fmt)
        {
            if (String.IsNullOrEmpty(fmt))
                fmt = "G";
            
            switch (fmt) //.ToUpperInvariant()
            {
                case "G":
                    return String.Format("{0} {1}", _year, _model);
                case "D":
                    return String.Format("{0} {1}, {2} dr.",
                                         _year, _model, _doors);
                case "C":
                    return String.Format("{0} {1}, {2}",
                                         _year, _model, _cylinders);
                case "A":
                    return String.Format("{0} {1}, {2} dr. {3}",
                                         _year, _model, _doors, _cylinders);
                default:
                    String msg = String.Format("'{0}' is an invalid format string",
                                               fmt);
                    throw new ArgumentException(msg);
            }
        }
    }
}
