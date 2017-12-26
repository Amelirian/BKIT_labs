using System;
using System.Collections;
using System.Linq;

namespace lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            void readCoefficients (out float a, out float b, out float c) 
            {
                bool flag = false;

				do
                {
					Console.Write("Коэффициент A = ");
					string strA = Console.ReadLine();
					Console.Write("Коэффициент B = ");
					string strB = Console.ReadLine();
					Console.Write("Коэффициент C = ");
					string strC = Console.ReadLine();
                    bool bool1 = float.TryParse(strA, out a);
                    bool bool2 = float.TryParse(strB, out b);
                    bool bool3 = float.TryParse(strC, out c);
                    if (bool1 && bool2 && bool3)
                        flag = true;
					else
					{
						flag = false;
						Console.WriteLine("Некорректный ввод! Введите корректные значения коэффициентов.");
					}
				} while (!flag);

                if (a == 1.0)
                    Console.WriteLine("Квадратное уравнение: x^2 + " + b + "x + " + c + " = 0");
                else
				    Console.WriteLine("Квадратное уравнение: " + a + "x^2 + " + b + "x + " + c + " = 0");
            }

            void getRoots (float a, float b, float c) 
            {
				float discriminant = b * b - 4 * a * c;
				Console.WriteLine("Дискриминант = " + discriminant);

                if (discriminant < 0)
                    Console.WriteLine("Уравнение не имеет корней.");
                else if (discriminant == 0.0) 
                {
                    float x = -b / (2 * a);
                    Console.WriteLine("Корни уравнения:\nx = " + x);
                }
                else
                {
                    float x1 = (-b - (float)Math.Sqrt((double)discriminant)) / (2 * a);
                    float x2 = (-b + (float)Math.Sqrt((double)discriminant)) / (2 * a);
                    Console.WriteLine("Корни уравнения:\nx1 = " + x1 + "\nx2 = " + x2);
                }
            }

            float coeff1;
            float coeff2;
            float coeff3;

            readCoefficients(out coeff1, out coeff2, out coeff3);
            getRoots(coeff1, coeff2, coeff3);
        }
    }
}
