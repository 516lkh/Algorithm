using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //int[] arr = A_1_29_greatestDivisor_LeastMultiple.solution(12,8);
            //foreach (int i in arr) { Console.Write(i); }
            //Console.WriteLine(A_1_30_ternary_scale.solution(45));

            Test();
        }

        public static void Test()
        {
            P_2_명예의_전당 a = new P_2_명예의_전당();

            a.solution(3, new int[] { 10,100,20,150,1,100,200 });

        }
    }
}
