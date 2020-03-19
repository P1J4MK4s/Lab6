using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Example
    {
        //public int x;
        //public int y;
        //public Example(int x) { this.x = x; }
        //public static void Init(ref Example example)
        //{
        //    Example example1 = new Example(0);
        //    example1.x = example.x;
        //    example1.y = example.y;

        //    example.x = 1;
        //    example.y = 1;
        //    Console.WriteLine("x = {0} y = {1}", example.x, example.y);
        //    Console.WriteLine("x = {0} y = {1}", example1.x, example1.y);

        //}
        //public static void Sqr(ref double a, ref double b)
        //{
        //    a = Math.Pow(a, 2);
        //    b = Math.Pow(b, 2);
        //    Console.WriteLine("In method Sqr. a = {0} b = {1}", a, b);
        //}
        public static void Foo(double chislo)
        {
            bool znak, celochisl;
            double modul, squad;
            if (chislo > 0){ znak = true; }
            else { znak = false; }
            if (chislo % 1 != 0) { celochisl = false; }
            else { celochisl = true; }
            modul = Math.Abs(chislo);
            squad = Math.Pow(chislo, 2);
            Console.WriteLine("Само число = {0}, Число > 0 = {1}, Число целочисленное = {2}, Модуль числа = {3}, Квадрат числа = {4}",chislo, znak, celochisl, modul, squad);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 2; double b = 4, c;
            //Example.Sqr(ref a, ref b);
            //Console.WriteLine("a = {0} b = {1}", a, b);

            //Example example = new Example(4);
            //Console.WriteLine("x = {0} y = {1}", example.x, example.y);
            //Example.Init(ref example);
            double a = 42,b = -12.67;
            Example.Foo(a);
            Example.Foo(b);
        }
    }
}
