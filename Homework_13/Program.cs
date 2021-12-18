using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program will open two txt files and find the name the user type in and return the names popularity
 * Name: Spencer Unitt
 * Module: Homework 13
 */

namespace Homework_13
{


    class Program
    {
       
        static void Main(string[] args)
        {
            // functions that will help clean up the code for the main
            // calling readFile should open and read the file and assign the values to an array
            // getNames should return the name the user types in
            FindTheNames find = new FindTheNames();
            find.readFile("boynames.txt");
            find.readFile("girlnames.txt");
            find.getNames();

            Console.ReadLine();
        }

    
    }


}
