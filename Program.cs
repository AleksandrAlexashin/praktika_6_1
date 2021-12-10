using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_6
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();
            string[] stringmass = s.Split();

            int otvet = 0;
            int max = 0;
            
            for (int i = 0; i < stringmass.Length; i++)
            {
                if (stringmass[i].Length > max)

                {
                    max = stringmass[i].Length;
                    otvet = i;
                }

            }
            Console.WriteLine(stringmass[otvet] + " самое  большое слово");
            Console.WriteLine(max + " символов");




            Console.ReadKey();
        }


        
       
        
    }   
}
