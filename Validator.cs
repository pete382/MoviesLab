using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MoviesLab
{

    public static class Validator
    {
        private static readonly object userInput;

        public static char GetInputChr()
        {
            Console.WriteLine("Please enter a for Animated  c for Comedy, d for Drama or h for Horror, to find your TV watching list!");
            char userInput = char.Parse(Console.ReadLine());
            var Menu = new char[] { 'a', 'c', 'd', 'h' };
            

            while (Menu.Any(m => m == userInput) == false)
            {  
               Console.WriteLine("Invalid Input. Please enter a,c,d,h.");
                userInput = char.Parse(Console.ReadLine());
            }
              return userInput;
              

        }



      
            




    }
}
