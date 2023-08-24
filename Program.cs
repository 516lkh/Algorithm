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

    public class A_1_1_OddEven
    {
        public string solution(int num)
        {
            if (num % 2 == 0) return "Even";
            else return "Odd";
        }
    }

    public class A_1_2_Average
    {
        public double solution(int[] arr)
        {
            if (arr.Length == 0) { return 0; }

            double average = 0;
            foreach (int i in arr)
            {
                average += (double)i;
            }
            if (average == 0) return average;
            else return average / arr.Length;
        }
    }

    public class A_1_3_ciphers
    {
        public int solution(int n)
        {
            int answer = 0;
            while (n > 0)
            {
                answer += n % 10;
                n /= 10;
            }
            return answer;
        }
    }

    public class A_1_4_aliquot
    {
        public int solution(int n)
        {
            if (n > 0)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0) sum += i;
                }
                return sum;
            }

            return 0;
        }
    }

    public class A_1_5_remainder1
    {
        public int solution(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 1) return i;
            }

            return -1;
        }
    }

    public class A_1_6_termx
    {
        public long[] solution(int x, int n)
        {
            long[] answer = new long[n];
            for (int i = 0; i < n; i++)
            {
                answer[i] = (long)x * (i + 1);
            }
            return answer;
        }
    }
}
