using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace randsort
{
    class Program
    {
        static void Main(string[] args)
        {
            string smaxval;
            int maxval;
            int c0;

            while (true)
            {
                Console.Write("Enter maximum value:");
                smaxval = Console.ReadLine();

                try
                {
                    maxval = Convert.ToInt32(smaxval);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0}", e);
                }
            }
            Console.WriteLine("\r______Shuffling...______");
            int[] value = new int[maxval + 1];

            Shuffle(value,maxval);

            c0 = 0;
            while (c0 < maxval)
            {
                Console.WriteLine(value[c0]);
                c0++;
                //Console.ReadKey(true);
            }
            Console.WriteLine("Press any key to end the program...");
            Console.ReadKey(true);
        }


        static void Shuffle(int[] val, int max)
        {
            Random rnd = new Random();
            int[] hash = new int[max + 1];
            int aindx = 0;
            int bindx = 0;
            int c0 = 0, c1 = 0, c8, lim;
            const int INVALID = -1;

            while (c1 < max)
            {
                hash[c1] = c1 + 1;
                c1++;
            }

            hash[c1] = INVALID;
            lim = max;

            while (c0 < max)
            {

                c8 = rnd.Next(0, lim);
                c1 = 0;
                while (c1 <= c8)
                {
                    bindx = aindx;
                    aindx = hash[aindx];

                    c1++;
                }

                val[c0] = aindx - 1;

                hash[bindx] = hash[aindx];
                hash[aindx] = INVALID;
                c0++;
                aindx = 0;
                bindx = 0;
                lim--;
            }
        }


    }
}
