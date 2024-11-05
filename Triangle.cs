using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        //одно поле, помимо a,b и c, у меня это угол
        public double nurk;
        public Triangle() { } //один конструктор без параметров
        public Triangle(double A, double B, double C, double Nurk)
        {
            a = A;
            b = B;
            c = C;
            nurk = Nurk;
        }

        public string outputA()
        { 
            return Convert.ToString(a); 
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputnurk()
        {
            return Convert.ToString(nurk);
        }
        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b +c) / 2;
            s = Math.Sqrt((p * (p -a) * (p - b) * (p -c)));
            return s;
        }
        //один метод для нахождения полупериметра
        public double Poolperimeetrit()
        {
            return (a + b + c) / 2;
        }

        //одно свойство
        public double PindalaArvutamine()
        {
            return 0.5 * a * b * Math.Sin(nurk); 
        }
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public bool ExistTriange
        {
            get
            {
                if((a > b + c) && (b > a + c) && (c > a + b))
                return false;
                else return true;
            }
        }
        public string TriangleType
        {
            get
            {
                if (ExistTriange)
                {
                    if (a==b && b == c && a==c)
                    {
                        return "Võrdkülgne";
                    }
                    else if (a==b || b==c || a==c)
                    {
                        return "Võrdhaarne";
                    }
                    else
                    {
                        return "Skaleeni kolmnurk";
                    }
                }
                else
                {
                    return "Tundmatu tüüp";
                }
            }
        }
    }
}
