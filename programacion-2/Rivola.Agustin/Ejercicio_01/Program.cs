﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_01";
            Console.ForegroundColor = ConsoleColor.Red;

            int number;
            int acummulator=0;
            float promedio;
            int max=0;
            int min=0;
            int i;
        

            for (i = 0; i < 5; i++)
            {
                Console.Write("\nenter a number : ");
                number = int.Parse(Console.ReadLine());

                if(i==0)
                {
                    max = number;
                    min = number;
                }
                else if(number>max)
                {
                    max = number;
                }
                else if(number<min)
                {
                    min = number;
                }

                acummulator += number;
            }

            promedio = (float)acummulator / i;

            Console.WriteLine("the lower number entered is  :{0}", min);
            Console.WriteLine("the most number entered is :{0}", max);
            Console.WriteLine("El promedio es:{0}", promedio);


            Console.Read();

        }
    }
}
