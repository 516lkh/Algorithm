using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    public class _1_1OddEven
    {
        public string solution(int num)
        {
            if (num % 2 == 0) return "Even";
            else return "Odd";
        }
    }

    public class _1_2Average
    {
        public double solution(int[] arr)
        {
            if (arr.Length == 0) { return 0; }

            double average = 0;
            foreach(int i in arr)
            {
                average += (double)i;
            }
            if (average == 0) return average;
            else return average / arr.Length;
        }
    }

    public class _1_3ciphers
    {
        public int solution(int n)
        {
            int answer = 0;
            while (n > 0)
            {
                answer += n % 10;
                n /= 10;
            }
        }
    }
}
