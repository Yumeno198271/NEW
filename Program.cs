using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = 46;
            int[] Fs = new int[N];
            int i;

            Fs[0] = 1;
            Fs[1] = 1;

            for (i = 2; i < N; i++)
            {
                Fs[i] = Fs[i - 1] + Fs[i - 2];
            }

            System.Console.Write(Fs[0]);

            for (i = 1; i < N; i++)
            {
                System.Console.Write("、" + Fs[i]);
            }
            System.Console.WriteLine("\n");


            Console.ReadLine();
        }

    }


}
