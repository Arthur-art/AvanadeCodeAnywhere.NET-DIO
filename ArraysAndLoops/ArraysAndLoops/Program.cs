﻿using System;

namespace ArraysAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            int[] arrayNumber;

            arrayNumber = new int[] { 1, 2, 3, 4, 5 };

            string[] arrayString = {"Banana","Maca","Laranja","Pera" };

            Console.WriteLine(string.Join(",", arrayNumber));

            Console.WriteLine(string.Join(",", arrayString));

            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"};

            static void checkMusic(string[] music)
            {

                if (music.Length == 8)
                {
                    Console.WriteLine("SummerStrut Playlist está pronta para ir!");
                }
                else if (music.Length > 8)
                {
                    Console.WriteLine("Muitas canções!");
                }
                else if (music.Length < 8)
                {
                    Console.WriteLine("Adicione algumas músicas!");
                }
            };

            checkMusic(summerStrut);

            summerStrut[7] = "Vermillion";


            Console.WriteLine(string.Join(",",summerStrut));

            // IndexOf, Copy

            // Console.WriteLine(Array.IndexOf(summerStrut, "Juice"));


            // Encontrando valores repetidos no array

            int[] numArray = {1,2,3,4,5,6,7,8,1,2,5,5,5 };

            int cont = -1;
            foreach (int value in numArray)
            {
                cont++;

                var indexValue = Array.IndexOf(numArray, numArray[cont]);
                if (indexValue != cont)
                {
                    Console.WriteLine(value);
                }
            }


        }
    }
}
