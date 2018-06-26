using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratev
{
    abstract class Point
    {
        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep(5000, 1000);
        }
        //protected int? x1 = null;
        //protected int? y1 = null;
        //public Point(int x1, int y1)
        //{
        //    this.x1 = x1;
        //    this.y1 = y1;
        //}
        //public int? X1
        //{
        //    get { return x1; }
        //    set
        //    {
        //        try { x1 = value; }
        //        catch (FormatException ex)
        //        { throw ex; }
        //    }
        //}

        //public int? Y1
        //{
        //    get { return y1; }
        //    set
        //    {
        //        try { y1 = value; }
        //        catch (FormatException ex)
        //        { throw ex; }
        //    }
        //}
    }
}
