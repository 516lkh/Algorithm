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
            Console.WriteLine(A_1_11_harshadnumber.solution(11));
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

    public class A_1_7_naturalnumberarray
    {
        public int[] solution(long n)
        {
            string number = n.ToString();
            int[] answer = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                answer[i] = (int)(n % 10);
                n /= 10;
            }

            return answer;
        }
    }

    public class A_1_8_parseint
    {
        public int solution(string s)
        {
            return int.Parse(s);
        }
    }

    public class A_1_9_squareroot
    {
        public static long solution(long n)
        {
            for (long answer = 1; answer * answer <= n; answer++)
            {
                if (answer * answer == n) return (long)((answer + 1) * (answer + 1));
            }
            return (long)-1;
        }
    }

    public class A_1_10_descendingorder
    {
        public static long solution(long n)
        {

            int[] ints = new int[n.ToString().Length];
            for (int i = 0; i < ints.Length; i++) { ints[i] = (int)(n % 10); n /= 10; }

            Array.Sort(ints);
            Array.Reverse(ints);

            string s = "";
            for (int i = 0; i < ints.Length; i++) { s += ints[i].ToString(); Console.Write(ints[i]); }

            return long.Parse(s);

        }
    }

    public class A_1_11_harshadnumber
    {
        public static bool solution(int x)
        {
            int _x = x;
            int sum = 0;

            for(int i = 0; i < _x.ToString().Length; i++)
            {
                sum += x % 10;
                x /= 10;
            }

            if (_x % sum == 0) return true;
            return false;


        }
    }

    public class A_1_12_intsum
    {
        public static long solution(int a, int b)
        {
            long answer = a;
            while (a != b)
            {
                a = a > b ? a - 1 : a + 1;
                answer += a;
            }
            return answer;
        }
    }

    public class A_1_13_Collatz
    {
        public static int solution(int num)
        {
            for(int i=0; i < 500; i++)
            {
                if (num == 1) return i;
                num = (num % 2 == 0) ? num / 2 : num * 3 + 1;
            }

            return -1;
        }
    }
}
