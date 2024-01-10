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

    public class Day3_01
    {
        public static void Main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    public class Day3_02
    {
        public int solution(int k, int m, int[] score)
        {
            int answer = 0;
            int index = m - 1;
            Array.Sort(score);
            Array.Reverse(score);

            for (int i = 0; i < score.Length / m; i++)
            {
                answer += score[index] * m;
                index += m;
            }
            return answer;
        }
    }

    public class Day4_01
    {
        public int solution(int[] ingredient)
        {
            int answer = 0;

            List<int> list = new List<int>();

            for (int i = 0; i < ingredient.Length; i++)
            {
                list.Add(ingredient[i]);

                if (list.Count >= 4)
                {

                    if (list[list.Count - 1] == 1
                        && list[list.Count - 2] == 3
                        && list[list.Count - 3] == 2
                        && list[list.Count - 4] == 1)
                    {
                        list.RemoveRange(list.Count - 4, 4);
                        answer++;

                    }

                }

            }

            return answer;
        }
    }

    public class Day4_02
    {
        public int solution(string[] want, int[] number, string[] discount)
        {
            int answer = 0;

            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < want.Length; i++)
            {
                dic[want[i]] = 0;
            }

            for (int j = 0; j < discount.Length - 9; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if(dic.ContainsKey(discount[j + i])) dic[discount[j + i]]++;
                }

                for(int i = 0; i < want.Length; i++)
                {
                    if (dic[want[i]] < number[i]) break;
                    else if (i == want.Length - 1) answer++; 
                }

                for (int i = 0; i < want.Length; i++)
                {
                    dic[want[i]] = 0;
                }
            }

            return answer;
        }
    }

    public class Day5_01
    {
        public int solution(int n)
        {
            int answer = 0;
            while (n > 0)
            {
                answer *= 3;
                answer += n % 3;
                n /= 3;
            }
            return answer;

        }
    }

    public class Day5_02
    {
        public string solution(string[] survey, int[] choices)
        {
            string answer = "";

            int length = survey.Length;

            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            dictionary.Add('R', 0);
            dictionary.Add('T', 0);
            dictionary.Add('C', 0);
            dictionary.Add('F', 0);
            dictionary.Add('J', 0);
            dictionary.Add('M', 0);
            dictionary.Add('A', 0);
            dictionary.Add('N', 0);



            for (int i = 0; i < length; i++)
            {
                char type1 = survey[i][0];
                char type2 = survey[i][1];

                if (choices[i] < 4)
                {
                    dictionary[type1] += 4 - choices[i];
                }
                else if (choices[i] > 4)
                {
                    dictionary[type2] += choices[i] - 4;
                }
            }


            answer += (dictionary['R'] >= dictionary['T']) ? "R" : "T";
            answer += (dictionary['C'] >= dictionary['F']) ? "C" : "F";
            answer += (dictionary['J'] >= dictionary['M']) ? "J" : "M";
            answer += (dictionary['A'] >= dictionary['N']) ? "A" : "N";


            return answer;
        }
    }

    public class Day6_01
    {
        public long solution(int price, int money, int count)
        {
            long total = 0;
            for (int j = 1; j <= count; j++)
            {
                total += (long)(price * j);

            }

            if (total <= money) return 0;
            return (long)(total - money);
        }
    }

    public class Day6_02
    {
        public int[] solution(int k, int[] score)
        {
            int[] answer = new int[score.Length];
            List<int> board = new List<int>();

            for (int i = 0; i < score.Length; i++)
            {
                if (board.Count == k)
                {
                    if (board[0] > score[i])
                    {
                        answer[i] = board[0];
                        continue;
                    }
                    board.RemoveAt(0);
                }
                board.Add(score[i]);
                board.Sort();
                answer[i] = board[0];
            }
            return answer;
        }
    }

    public class Day7_01
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];

            for (int i = 0; i < lottos.Length; i++)
            {
                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j]) { answer[1]++; answer[0]++; break; }
                    if (lottos[i] == 0)
                    {
                        answer[0]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == 6) answer[i] = 1;
                else if (answer[i] == 5) answer[i] = 2;
                else if (answer[i] == 4) answer[i] = 3;
                else if (answer[i] == 3) answer[i] = 4;
                else if (answer[i] == 2) answer[i] = 5;
                else answer[i] = 6;
            }
            return answer;
        }
    }

    public class Day8_01
    {
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int[] answer = new int[2];

            for (int i = 0; i < lottos.Length; i++)
            {
                for (int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j]) { answer[1]++; answer[0]++; break; }
                    if (lottos[i] == 0)
                    {
                        answer[0]++;
                        break;
                    }
                }
            }

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == 6) answer[i] = 1;
                else if (answer[i] == 5) answer[i] = 2;
                else if (answer[i] == 4) answer[i] = 3;
                else if (answer[i] == 3) answer[i] = 4;
                else if (answer[i] == 2) answer[i] = 5;
                else answer[i] = 6;
            }
            return answer;
        }
    }

    public class Day8_02
    {
        public int solution(int k, int[] tangerine)
        {
            int answer = 0;
            int n = 0;
            int count = 1;
            List<int> list = new List<int>(10000000);
            Array.Sort(tangerine);
            for (int i = 0; i < tangerine.Length; i++)
            {
                if (n == tangerine[i])
                {
                    count++;
                }
                else
                {
                    if (tangerine[i] == 0) continue;
                    list.Add(count);
                    count = 1;
                }
                n = tangerine[i];
            }
            list.Add(count);
            list.Sort();
            list.Reverse();
            foreach (int i in list)
            {
                Console.Write(i);
            }
            foreach (int index in list)
            {
                if (k <= 0) break;
                answer++;
                k -= index;
            }
            return answer;
        }
    }
}
