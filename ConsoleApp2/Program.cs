using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz2

{
    class Program
    {

        static void Main(string[] args)
        {
            int[] myarray = new int[7];
            int[] myarray1 = new int[12];
            int[] myarray2 = new int[12];
            int[] myarray3 = new int[16];
            int[] myarray5 = new int[5];

            bool isEqual = myarray.SequenceEqual(myarray1);

            Console.WriteLine(isEqual);
            {
                bool isEqual2 = myarray5.SequenceEqual(myarray2);

                Console.WriteLine(isEqual2);
            }

            {
                bool isEqual3 = myarray1.SequenceEqual(myarray2);

                Console.WriteLine(isEqual3);
            }
        }
    }
}