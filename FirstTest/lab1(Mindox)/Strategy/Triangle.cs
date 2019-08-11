using System;

namespace lab1_Mindox_.Strategy
{

    public class Triangle : IStrategy
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double _a, double _b, double _c)
        {
            a = _a;
            b = _b; 
            c = _c;
        }
       
        public bool IsRectangularTriangle()
        {
            double h, k, l, t1, t2;
            //определяем что  является гипотенузой, а что катетатами 
            if (a < b)
            {
                k = a;
                l = b;
            }
            else
            {
                k = b;
                l = a;
            }
            if (l < c)
            {
                h = c;
            }
            else
            {
                h = l;
                l = c;
            }
            // квадрат  гипотенузы = сумме квадртов катетов у прямоугольного треугольника 
            t1 = Math.Pow(h, 2);
            t2 = Math.Pow(l, 2) + Math.Pow(k, 2);
            return (t1 == t2) ? true : false; 
        }

        private bool IsTriangle()
        {
           return ((a + b > c) && (a + c) > b && (b + c) > a) ? true : false;      
        }

        public double СalculationArea()
        {
            double area;

            if (IsTriangle())
            {
                if (IsRectangularTriangle())
                {
                    area = 0.5 * a * b;
                    return Math.Round(area, 3);
                }
                else
                {
                    double p = (a + b + c) / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return Math.Round(area, 3);
                }
            }
            return -1; //построить треугольник нельзя 
        }
    }
}
