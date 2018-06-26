using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace Kondratev
{
    class Vect : Point
    {
        private int? x1 = null;
        private int? x2 = null;
        private int? y1 = null;
        private int? y2 = null;

        private int exVectX1 = 0;
        private int exVectY1 = 0;
        private int exVectX2 = 0;
        private int exVectY2 = 0;

        //private int coof = 2;

        private const int DefaultValue = 0;
        // Задание вектора начальной и конечной точкой (без параметров)
        public Vect()
        {
            x1 = DefaultValue;
            x2 = DefaultValue;
            y1 = DefaultValue;
            y2 = DefaultValue;
        } 
        // Задание вектора начальной и конечной точкой (полный набор параметров)
        public Vect(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        // Задание вектора начальной и конечной точкой (неполный набор параметров 1)
        public Vect(int value)
        {
            this.x1 = value;
            this.x2 = value;
            this.y1 = value;
            this.y2 = value;
        }
        // Задание вектора начальной и конечной точкой (неполный набор параметров 2)
        public Vect(int value, int value2)
        {
            this.x1 = value;
            this.x2 = value;
            this.y1 = value2;
            this.y2 = value2;
        }
        // Задание вектора начальной и конечной точкой (в виде строки)
        public Vect(string st)
        {
            try
            {
                char[] separ = { ' ', ',', ';' };
                string[] n = st.Split(separ);
                x1 = int.Parse(n[0]);
                y1 = int.Parse(n[1]);
                x2 = int.Parse(n[2]);
                y2 = int.Parse(n[3]);
            }
            catch
            {
                throw new IndexOutOfRangeException();
                //Console.WriteLine("Low argument for string");
            }
        }
       
        public int? X1
        {
            get { return x1; }
            set
            {
                try { x1 = value; }
                catch (FormatException ex)
                { throw ex; }
            }
        }
        
        public int? X2
        {
            get { return x2; }
            set
            {
                try { x2 = value; }
                catch (FormatException ex)
                { throw ex; }
            }
        }
        public int? Y1
        {
            get { return y1; }
            set
            {
                try { y1 = value; }
                catch (FormatException ex)
                { throw ex; }
            }
        }
        public int? Y2
        {
            get { return y2; }
            set
            {
                try { y2 = value; }
                catch (FormatException ex)
                { throw ex; }
            }
        }
        public int ExVectX1
        {
            set
            {
                try { exVectX1 = value; }
                catch (FormatException ex)
                { throw ex; }
            }
        }

        public int ExVectX2
        {
            set
            {
                try { exVectX1 = value; }
                catch (FormatException ex)
                { throw ex; }
            }
        }
        public int ExVectY1
        {
            set
            {
                try { exVectY1 = value; }
                catch (FormatException ex)
                { throw ex; }
            }
        }
        public int ExVectY2
        {
            set
            {
                try { exVectY2 = value; }
                catch (FormatException ex)
                { throw ex; }
            }
        }
        //Координаты вектора x
        public double CoordinataX
        {
            get { return ((int)x2 - (int)x1); }
        }
        //Координаты вектора x
        public double CoordinataY
        {
            get { return ((int)y2 - (int)y1); }
        }
        public double CoordinataEX
        {
            get { return ((int)exVectX2 - (int)exVectX2); }
        }
        //Координаты вектора x
        public double CoordinataEY
        {
            get { return ((int)exVectY2 - (int)exVectY1); }
        }
        //Длинна вектора
        public double Scalar
        {
            get { return Math.Sqrt(CoordinataX*CoordinataX + CoordinataY*CoordinataY); }
        }
        //Сумма векторов X (сам на себя)
        public double AddX(double CoordinataX)
        {
            return (CoordinataX + CoordinataX);
        }
        //Сумма векторов Y (сам на себя)
        public double AddY(double CoordinataY)
        {
            return (CoordinataY + CoordinataY);
        }
        // Сумма вектора Х с произвольным перегрузка
        public double AddX(double CoordinataX, double CoordinataEX)
        {
            return (CoordinataX + CoordinataEX);
        }
        // Сумма вектора Y с произвольным перегрузка
        public double AddY(double CoordinataY, double CoordinataEY)
        {
            return (CoordinataY + CoordinataEY);
        }
        //Разность векторов X (сам на себя)
        public double SubstractX(double CoordinataX)
        {
            return (CoordinataX - CoordinataX);
        }
        //Разность векторов Y (сам на себя)
        public double SubstractY(double CoordinataY)
        {
            return (CoordinataY - CoordinataY);
        }
        // Разность вектора Х с произвольным перегрузка
        public double SubstractX(double CoordinataX, double CoordinataEX)
        {
            return (CoordinataX - CoordinataEX);
        }
        // Разность вектора Y с произвольным перегрузка
        public double SubstractY(double CoordinataY, double CoordinataEY)
        {
            return (CoordinataY - CoordinataEY);
        }
        //Скалярное произведение вектров (сам на себя)
        public double Multiply(double CoordinataX, double CoordinataY)
        {
             return CoordinataX*CoordinataX + CoordinataY*CoordinataY; 
        }
        //Скалярное произведение вектров (на произвольный вектор) перегрузка
        public double Multiply(double CoordinataX, double CoordinataY, double CoordinataEX, double CoordinataEY)
        {
            return CoordinataX * CoordinataEX + CoordinataY * CoordinataEY;
        }
        //Масштабирование
        public double ScaleX(int coof1)
        {
            return CoordinataX* coof1;
        }
        //Масштабирование
        public double ScaleY(int coof1)
        {
            return CoordinataY * coof1;
        }
        //Масштабирование с перегрукой
        public double ScaleX(int coof1, int coof2)
        {
            return CoordinataX * coof1 * coof2;
        }
        //Масштабирование с перегрукой
        public double ScaleY(int coof1, int coof2)
        {
            return CoordinataY * coof1 * coof2;
        }
        //перегрузка оператора +
        public static Vect operator +(Vect v1, Vect v2)
        {
            return new Vect((int)v1.x1 + (int)v2.x1, (int)v1.x2 + (int)v2.x2, (int)v1.y1 + (int)v2.y1, (int)v1.y2 + (int)v2.y2);
        }
        public static Vect operator +(string strV1, Vect v2)
        {
            Vect v1 = new Vect(strV1);
            return new Vect((int)v1.x1 + (int)v2.x1, (int)v1.x2 + (int)v2.x2, (int)v1.y1 + (int)v2.y1, (int)v1.y2 + (int)v2.y2);
        }
        public static Vect operator +(Vect v1, string strV2)
        {
            Vect v2 = new Vect(strV2);
            return new Vect((int)v1.x1 + (int)v2.x1, (int)v1.x2 + (int)v2.x2, (int)v1.y1 + (int)v2.y1, (int)v1.y2 + (int)v2.y2);
        }
        //перегрузка оператора -
        public static Vect operator -(Vect v1, Vect v2)
        {
            return new Vect((int)v1.x1 - (int)v2.x1, (int)v1.x2 - (int)v2.x2, (int)v1.y1 - (int)v2.y1, (int)v1.y2 - (int)v2.y2);
        }
        public static Vect operator -(string strV1, Vect v2)
        {
            Vect v1 = new Vect(strV1);
            return new Vect((int)v1.x1 - (int)v2.x1, (int)v1.x2 - (int)v2.x2, (int)v1.y1 - (int)v2.y1, (int)v1.y2 - (int)v2.y2);
        }
        public static Vect operator -(Vect v1, string strV2)
        {
            Vect v2 = new Vect(strV2);
            return new Vect((int)v1.x1 - (int)v2.x1, (int)v1.x2 - (int)v2.x2, (int)v1.y1 - (int)v2.y1, (int)v1.y2 - (int)v2.y2);
        }
        //перегрузка оператора *
        public static Vect operator *(Vect v1, Vect v2)
        {
            return new Vect((int)v1.x1 * (int)v2.x1, (int)v1.x2 * (int)v2.x2, (int)v1.y1 * (int)v2.y1, (int)v1.y2 * (int)v2.y2);
        }
        public static Vect operator *(Vect v1, int coof)
        {
            return new Vect((int)v1.x1 * coof, (int)v1.x2 * coof, (int)v1.y1 * coof, (int)v1.y2 * coof);
        }
        public static Vect operator *(Vect v1, string coof )
        {
            return new Vect((int)v1.x1 * int.Parse(coof), (int)v1.x2 * int.Parse(coof), (int)v1.y1 * int.Parse(coof), (int)v1.y2 * int.Parse(coof));
        }
        //преобразования типов
        public static implicit operator string(Vect g)
        {
            string result = g.ToString();
            return result;
        }
        public static implicit operator Vect(string g)
        {
            return new Vect(g);
        }
        public static implicit operator Vect(int g)
        {
            return new Vect(Convert.ToInt32(g));
        }

        public static implicit operator int(Vect g)
        {
            int result = Convert.ToInt32(g.x1);
            return result;
        }

        public static implicit operator Vect(double g)
        {
            return new Vect((int)g);
        }

        public static implicit operator double(Vect g)
        {
            double result = (double)g.x1;
            return result;
        }
        //public static implicit operator Vect(System.Drawing.DrawLine g)
        //{
        //    return new Vect(g.x1, g.x2, g.y1, g.y2);
        //}

        //public static implicit operator System.Drawing.DrawLine(Vect v)
        //{
        //    return new System.Drawing.DrawLine((int)g.x1, (int)g.x2, (int)g.y1, (int)g.y2));
        //}
        //Вывод в виде строки
        public String ToString(String fmt)
        {
            if (!String.IsNullOrEmpty(fmt))
            {
                //fmt = "G";

                switch (fmt) //.ToUpperInvariant()
                {
                    case "G":
                        {
                          
                                return String.Format("(x1 = {0} y1 = {1}; x2 = {2} y2 = {3})", x1, y1, x2, y2);
          
                        }
                    default:
                        {
                             String msg = String.Format("is an invalid format string", fmt);
                            return msg;
                         //throw new ArgumentException("Error format data");

                        }
                }
                
            }
            return "";
        }
    }
}
