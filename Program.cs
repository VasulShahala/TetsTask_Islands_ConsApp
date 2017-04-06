using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetsTask_Islands_ConsApp
{
    
    
    class Program
    {
        

        static void Main(string[] args)
        {
            int arrsize;
            int[] maparray;
            string line;
            int islandcounter = 0;
            
            do
            {
                Console.WriteLine("Enter size of array");
                line = Console.ReadLine();
                if (!int.TryParse(line, out arrsize))
                {
                    Console.WriteLine("{0} is not an integer value", line);

                }

                else
                {
                    Console.WriteLine("Length of your array= " + arrsize.ToString());

                }
            }
            while (!int.TryParse(line, out arrsize));
            


            maparray = new int[arrsize];
      
             for (int i = 0; i < maparray.Length; i++)
             {
                 Console.WriteLine("Enter " + (i + 1).ToString() + " element of array");
                 try
                 {
                     maparray[i] = Convert.ToInt32(Console.ReadLine());

                 }

                catch
                 {
                     Console.WriteLine("You enter no integer value");
                 }


             }

            Console.WriteLine("Array:");
            for (int i = 0; i < maparray.Length; i++)
            {
                Console.Write(maparray[i].ToString()+ " ");
            }
            Console.WriteLine();


            var pointer = 1;
            int prev = maparray[0];
            var temp = new List<int> { maparray[0] };
            while (pointer < maparray.Length)
            {
                if (maparray[pointer] != prev)
                    temp.Add(maparray[pointer]);
                prev = maparray[pointer];
                pointer++;
            }
            maparray = temp.ToArray();



            for (int i = 0; i < maparray.Length; i++)
            {
               if(maparray[i] == 1)
               {
                    islandcounter++;
               }
            }
               

            Console.WriteLine("On map "+islandcounter.ToString()+ " islands");
            Console.ReadKey();
        }
    }
}
