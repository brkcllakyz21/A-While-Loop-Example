using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_While_Loop_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 0, max = 0;

            Console.WriteLine("Bir Sayı Giriniz = ");
            k = Convert.ToInt32(Console.ReadLine());
            max = k;
            while (k > 1)
            {
                if (k % 2 == 0)
                {
                    k /= 2;
                }
                else
                {
                    k *= 3;
                    k += 1;
                }
                if (k > max)
                {
                    max = k;
                }
            }

            Console.WriteLine(max);



        }
    }
}
