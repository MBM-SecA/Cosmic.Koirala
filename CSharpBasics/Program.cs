﻿using System;
using System.IO;
using System.Linq;
using LearnCollections;
public class Program
{
    static void Main()
    {
        var countriesText = File.ReadAllText("Countries.txt");
        string[] countries = countriesText.Split("\r\n");
        var countriesWithNInitial = countries.Where(x => x.StartsWith("N")).Select(x=>x);
        foreach(var country in countriesWithNInitial)
        {
            Console.WriteLine(country);
        }
        // FileIO fileIO = new FileIO();
        // fileIO.LearnDirectories();
    //     var square = new Square(35);
    //     square.Display();

    //    var rectangle = new Rectangle(44,32);
    //   rectangle.Display();

    }
}
//     class ABC
//     {
//         static void Main1()
//         {
//            // Console.Write("Enter your name:");
//             //string x = Console.ReadLine();
//             //Console.WriteLine("hi," + x);
//             //1. Value types
//             //1.1 Numbers
//             //1.1.1 Integers
//             byte a= 43;
//             short b= 345;
//             int c= 12345;
//             long d= 4234785312;
//             //1.1.2 Floating numbers
//             float e= 123.4f;
//             double f= 12345.4;
//             decimal g= 231231.42341m;
//             //1.2 Characters
//             char h = 'c';
//             //1.3 boolean
//             bool i = true;
            
//             //2. Reference type
//             string j="cosmickoirala"; 
//             object k=31232.433;

//         }
//         //function name pascal casing
//         //variable name camel casing

//         (float, int, string) GetNumber(int x, string y)
//         {
//             return(45.6f,456,"");
//         }
//     }
