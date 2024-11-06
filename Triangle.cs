﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Triangle
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;
        //одно поле, помимо a,b и c, это высота
        public double h; 
        //одно поле, помимо a,b и c, у меня это угол
        public double nurk;
        public Triangle() { } //один конструктор без параметров
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double B, double C, double H, double Nurk)
        {
            a = A;
            b = B;
            c = C;
            nurk = Nurk;
            h = H;
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
        public string outputH()
        {
            return Convert.ToString(h);
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
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
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
        // Метод для нахождения высоты к стороне a
        public double HeightA()
        {
            double s = Surface();
            return (2 * s) / a;
        }

        // Метод для нахождения высоты к стороне b
        public double HeightB()
        {
            double s = Surface();
            return (2 * s) / b;
        }

        // Метод для нахождения высоты к стороне c
        public double HeightC()
        {
            double s = Surface();
            return (2 * s) / c;
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
        private double Leida_nurki(double x, double y, double z)
        {
            //нахождения арккосинуса (обратная функция косинуса)
            return Math.Acos((y * y + z * z - x * x) / (2 * y * z)) * (180 / Math.PI);
        }
        public string TriangleType_Form2
        {
            get
            {
                if (ExistTriange)
                {
                    if (a == b && b == c)
                    {
                        return "Võrdkülgne";  // Равносторонний
                    }
                    else if (a == b || b == c || a == c)
                    {
                        return "Võrdhaarne";  // Равнобедренный
                    }
                    else
                    {
                        double nurk = Leida_nurki(a, b, c);
                        double nurkB = Leida_nurki(b, a, c);
                        double nurkC = Leida_nurki(c, a, b);

                        if (nurk == 90 || nurkB == 90 || nurkC == 90)
                        {
                            return "Täisnurkne";  // Прямоугольный
                        }
                        else if (nurk < 90 && nurkB < 90 && nurkC < 90)
                        {
                            return "Teravnurkne";  // Остроугольный
                        }
                        else
                        {
                            return "Nürinurkne";  // Тупоугольный
                        }
                    }
                }
                else
                {
                    return "Tundmatu tüüp";  // Неопределенный
                }
            }
        }
        // Метод для сохранения треугольников в XML-файл
        public static void Salvesta(List<Triangle> triangles, string filePath = "kolmnurgad.xml")
        {
            using (XmlWriter xmlwriter = XmlWriter.Create(filePath))
            {
                xmlwriter.WriteStartDocument();
                xmlwriter.WriteStartElement("Triangles");

                foreach (var triangle in triangles)
                {
                    xmlwriter.WriteStartElement("Triangle");

                    // Сохранение всех полей и свойств треугольника
                    xmlwriter.WriteElementString("Сторона A", triangle.a.ToString());
                    xmlwriter.WriteElementString("Сторона B", triangle.b.ToString());
                    xmlwriter.WriteElementString("Сторона C", triangle.c.ToString());
                    xmlwriter.WriteElementString("Высота", triangle.h.ToString());
                    xmlwriter.WriteElementString("Угол", triangle.nurk.ToString());
                    xmlwriter.WriteElementString("Полупериметра", triangle.Poolperimeetrit().ToString());
                    xmlwriter.WriteElementString("Площадь", triangle.PindalaArvutamine().ToString());
                    xmlwriter.WriteElementString("Спецификатор", triangle.TriangleType_Form2);
                    xmlwriter.WriteEndElement(); // Закрываем элемент Triangle
                }
                xmlwriter.WriteEndElement(); // Закрываем элемент Triangles
                xmlwriter.WriteEndDocument(); // Завершаем документ
            }
        }
    }
}
