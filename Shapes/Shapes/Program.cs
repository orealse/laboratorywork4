﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");
            // Создать массив совместных с Shape объектов.
            Shape [] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), 
            new Circle("Beth"), new Hexagon("Linda")};

            // Перейти в цикл по всем элементам и взаимодействовать
            // с полифорным интерфейсом.
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }
            Console.ReadLine();
        }
    }
}
