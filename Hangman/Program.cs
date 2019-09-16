using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ord");
            string ord = Console.ReadLine();
            
            char[] charord = ord.ToCharArray();
            char[] gissning = new char[charord.Length];
            for(int i = 0; i < gissning.Length; i++)
            {
                gissning[i] = '_';
            }

            while (true)
            {
                
                foreach (char c in gissning)
                    Console.Write(c + " ");
                Console.WriteLine();
                Console.Write("Mata in gissning: ");
                string gissa = Console.ReadLine();
                char[] gissa1 = new char[gissa.Length];
                
                for (int i = 0; i < gissa1.Length; i++)
                {
                    
                    if (gissa1[i] == charord[i])
                    {
                        gissning[i] = gissa1[i];
                    }
                }
            }
            

        }
    }
}
