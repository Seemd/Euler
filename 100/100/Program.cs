using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i > amount;)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    List<int> intList = new List<int>();
                    intList.Add(i);
                }
            }
            
            

            
        }
    }
}
