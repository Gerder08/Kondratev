using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondratev
{
    
    public class Test
    {
        static void Main(string[] args)
        {
            string s;
            int choice;
            //Console.WriteLine(s);
            int x1 = 2;
            int x2 = 5;
            int y1 = 7;
            int y2 = 6;

            int exVectX1 = 3;
            int exVectY1 = 0;
            int exVectX2 = 0;
            int exVectY2 = -3;

            Console.WriteLine("Hello Word");
            Vect v = new Vect();
            Vect v1 = new Vect("2,6,8,-1");
            Vect v2 = new Vect (x1,x2,y1,y2);
            Vect v3  = new Vect();
            v3 = v1 + v2;
            v.ExVectX1 = exVectX1;
            v.ExVectX2 = exVectX2;
            v.ExVectY1 = exVectY1;
            v.ExVectY2 = exVectY2;
            do
            {
                Console.Clear();
                Console.WriteLine(" 1 - Set date(Все параметры)\n 2 - Set date(В виде строки)\n 3 - Set date(один аргумент)\n 4 - Set date(Без параметров)\n 5 - Get date\n 6 - Операции над вектором\n 0 - Exit\n");
                switch (choice = int.Parse(Console.ReadLine()))
                {
                    case 0:
                        {
                            Console.Clear();
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Введите x1 : ");
                            x1 = int.Parse(Console.ReadLine());
                            Console.Write("Введите x2 : ");
                            x2 = int.Parse(Console.ReadLine());
                            Console.Write("Введите y1 : ");
                            y1 = int.Parse(Console.ReadLine());
                            Console.Write("Введите y2 : ");
                            y2 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            try
                            {
                                v = new Vect(x1, x2, y1, y2);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Произошла исключительная ситуация: " + ex.Message);
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите координаты точек:");
                            s = Console.ReadLine();
                            try
                            {
                                v = new Vect(s);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Low argument for string", e);
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("value : ");
                            y1 = int.Parse(Console.ReadLine());
                            try
                            {
                                v = new Vect(y1);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Low argument for string", e);
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            v = new Vect();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            try
                            {
                                Console.Write(" Вектор :\n\t" + v.ToString("G"));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Произошла исключительная ситуация: " + ex.Message);
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Операции над вектором:");
                            double Scale = v.Scalar;
                            double X = v.CoordinataX;
                            double Y = v.CoordinataY;
                            Console.WriteLine("Координаты вектора Х = " + X);
                            Console.WriteLine("Координаты вектора Y = " + Y);
                            Console.WriteLine("Длинна вектора = " + Scale); 
                            Console.ReadKey();
                            break;
                        }
                   
                }
            } while (choice != 0);
            //Console.WriteLine("Поля не инициализированны:");
            //Console.WriteLine(v.ToString("h"));
            //Console.WriteLine("Поля пусты:");
            //Console.WriteLine(v.ToString("G"));
            ////Console.ReadKey();
            //x1 = 45;
            //x2 = 56;
            //y1 = 14;
            //y2 = 25;
            ////Vect v1 = new Vect(x1, x2, y1, y2);
            //Console.WriteLine("Поля заданы в коде:");
            //Console.WriteLine(v1.ToString("G"));
            //Console.WriteLine("Ввод данных в строке с пробелами:");
            //s = Console.ReadLine();
            //Vect v2 = new Vect(s);
            //Console.WriteLine(v2.ToString("G"));
            //Console.ReadKey();
        }

    }
}
