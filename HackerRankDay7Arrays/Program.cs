using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n]; 
           
            int length = array.Length;

            for (int i = 0; i < n; i++)
            {
                
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] reversed = new int[length];
          
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }
           
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }


        }
    }
}
