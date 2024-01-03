using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Day1_01
    {
        public int solution(int left, int right)
        {
            int answer = 0;
            for (int i = left; i <= right; i++)
            {
                answer = (findaliquotnumber(i) % 2 == 0) ? answer + i : answer - i;
            }
            return answer;
        }

        public int findaliquotnumber(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) { count++; }
            }
            return count;
        }
    }

    public class Day1_02
    {
        public string solution(string s)
        {
            char[] answer = s.ToCharArray();
            Array.Sort(answer);
            Array.Reverse(answer);
            return new string(answer);
        }
    }

    public class Day2_01
    {
        public string solution(int[] food)
        {
            string answer = "";
            for (int i = 1; i < food.Length; i++)
            {
                food[i] /= 2;
                for (int j = 0; j < food[i]; j++)
                {
                    answer += i.ToString();
                }
            }

            char[] tmp = answer.ToCharArray();
            Array.Reverse(tmp);

            return answer + "0" + new string(tmp);
        }
    }

    public class Day2_02
    {
        public string solution(string[] seoul)
        {
            for (int i = 0; i < seoul.Length; i++)
            {
                if (seoul[i] == "Kim") return "김서방은 " + i.ToString() + "에 있다";
            }

            return "";
        }
    }
}
