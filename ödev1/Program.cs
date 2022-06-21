using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    internal class Program : ProgramBase
    {
        static void Main(string[] args)

        {
            //Q1
            Console.WriteLine("Question1");

            double x = 5;
            double y = 3;

            double functionF = (-2 * (x * x) + (x * y) -4) / (-1 * x);
            double functionG = (-1 * (x * x) + 5);

            Console.WriteLine("f(x,y)=" + functionF);
            Console.WriteLine("g(x)=" + functionG);


            //Q2

            Console.WriteLine("Question 2");
            Console.WriteLine("volume (v), radius (r), height (h)");
            Console.WriteLine("r = {2.5} h = {9.4}, " + "calculate V = Pi * (r * r) * h ");
            double r = 2.5;
            double h = 9.4;
            const double pi = 3.14d;
            double functionV = (pi * (r * r) * h);
            Console.WriteLine("V(r,h)=" + functionV);

            //Q3

            Console.WriteLine("Question3");
            Console.WriteLine("distance (d), time (t), speed (s)");
            Console.WriteLine("d = {157.8 km}, t = {2.2 hour}," + "s = ?");
            float d = 157.8f;
            float t = 2.2f;
            float functionS = d / t;
            Console.WriteLine("S(d,t)=" + functionS);
            // NOT: soruda "round yöntemiyle floatı int'e convert et" demiş,
            // hallettim ama round yöntemiyle halledemedim sanırım o yüzden biraz karıştı.
            // Çünkü formülün sonucunu bilmeden convert edemedim. İlla 71.7'yi int e çevir demek zorunda kaldım.
            // Aslında yapmaya çalıştığım ama yapamadığım şuydu:
            // "functionS"'in sonucunu "s" olarak tanımlayıp, "s"i int olarak veya yuvarlayarak oku"
            // demeye çalışmıştım.
            // Yani rakamla uğraşmak istemedim, bu formülü kendin çöz, sonucu da yuvarla demek istedim ama yapamadım.
            float s = 71.7f;
            int ss;
            ss = (int)s;
            Console.WriteLine(ss);

            //Q4
            //xyz = abc 
            Console.WriteLine("Question4");
            Console.WriteLine("a = 3, b = 4, c = 5");
            Console.WriteLine("find g(b,c) and f(a,b,c) for given values");
            int a = 3;
            int b = 4;
            int c = 5;
            int functionG1 = ((2 * b * c) + ((b * b * b) + c) / ((c * c) - (2 * b)));
            int functionF1 = (((a + b + c) / ((a + b) - c)) + (((b * b) - (c * c)) / (b - a)));
            Console.WriteLine("g(b,c)=" + functionG1);
            Console.WriteLine("f(a,b,c)=" + functionF1);
            /*bunda da "Use Math.round function to find the integer value nearest to the computed result."
            demiş ama hepsini int aldım kolay olsun diye.
            Bir de .round almayı oturtamadım sanırım. Bunların round'unu birlikte alabilir miyiz?
            */

            //Q5
            //Write a program
            //Reads number of month, week, and day.
            //Computes and prints total days.
            //Displays the total days in terms of number of weeks and the remaining number of days.

            /*
            // Bu soruyu kendi öğrendiklerimden neyle yapacağımı bulamadım 
            O yüzden internetten bir örnek buldum.
            Ama bunun garip bir şekilde sayımında sıkıntı var, mesela 30 gün yazıyorsun,
            yıl ve hafta doğru ama 0 gün diye çıkartıyor. Sebebini anlamadım? 
            Bunu aşağıdaki gibi modifiye ettim.
            
            İNTERNETTEN BULDUĞUM:
            Console.WriteLine("Question5");
            int ndays, year, week, DAYSINWEEK = 7;
            Console.WriteLine("Enter number of days to convert them to months and years");
            ndays = int.Parse(Console.ReadLine());
            year = ndays / 365;
            week = (ndays % 365) / DAYSINWEEK;
            Console.WriteLine("{0} is equivalent to {1}years, {2}weeks", ndays, year, week);
            Console.ReadLine();
            */

            //MODİFİYE ETTİĞİM:
            Console.WriteLine("Question5");
            int ndays, year, month, week, days;
            Console.WriteLine("Enter number of days to convert them to months and years");
            ndays = int.Parse(Console.ReadLine());
            year = ndays / 365;
            month = ndays / 30;
            week = ndays / 7;
            days = ndays;
            Console.WriteLine("{0} is equivalent to {1}years, {2}month, {3}weeks and {4}days",
                               ndays, year, month, week, days);

            //Q6
            Console.WriteLine("Question6");
            Console.WriteLine("Please enter the project type: small, medium or large: ");
            string name = Console.ReadLine();

            if (name == "small")
            {
                Console.WriteLine("How many " + name + " projects do you want?");
                int j = Convert.ToInt32(Console.ReadLine());
                int j1 = (j * 1000);
                Console.WriteLine("Your Total Cost is: " + j1 + " TL.");
            }

            else if(name == "medium")
            { 
                Console.WriteLine("How many " + name + " projects do you want?");
                int k = Convert.ToInt32(Console.ReadLine());
                int k1 = (k * 2000);
                Console.WriteLine("Your Total Cost is: " + k1 + " TL.");
            }
            
            else if(name == "large")
            { 
                Console.WriteLine("How many " + name + " projects do you want?");
                int l = Convert.ToInt32(Console.ReadLine());
                int l1 = (l * 3500);
                Console.WriteLine("Your Total Cost is: " + l1 + " TL.");
            }
            else
            {
                Console.WriteLine("Invalid project type!");
            }

            
            //"case" ile yazamadım xD aşağıdakilere bir bakabilir miyiz nerede saçmalamışım.
            /*
            int option1 = 1000;
            int option2 = 2000;
            int option3 = 3500;

            char option1 = "S";
            char option2 = "M";
            char option3 = "L";

            {
            switch (option1)
            switch (option2)
            switch (option3)
            }
            
            {
                case 'S':
                    Console.WriteLine("How many " + small + " projects do you want?");
                    break;
                case 'M':
                     Console.WriteLine("How many " + medium + " projects do you want?");
                     break;
                case 'L':
                     Console.WriteLine("How many " + large + " projects do you want?");
                     break; 
                default:
                     Console.WriteLine("Please choose one of the following: S for small, M for medium or L for large");
                     break;
            */


        }
    }
}
