﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 1;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 2;
            p2.y = 2;
            p2.sym = '^';
            p2.Draw();

            /*int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);*/

            int x2 = 5;
            int y2 = 3;
            char sym2 = '^';

           

            Console.ReadLine();
        }
    }
}