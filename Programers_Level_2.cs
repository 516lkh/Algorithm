using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class P_2_이상한_문자_만들기
    {
        public string solution(string s)
        {
            string[] tp = s.Split(' ');
            string answer = "";
            string tmp;
            for (int i = 0; i < tp.Length; i++)
            {
                for (int j = 0; j < tp[i].Length; j++)
                {
                    answer += (j % 2 != 0) ? tp[i].Substring(j, 1).ToLower() : tp[i].Substring(j, 1).ToUpper();

                }
                if (i != tp.Length - 1) answer += " ";
            }
            return answer;
        }
    }
    class P_2_삼총사
    {
        public int solution(int[] number)
        {
            int count = 0;
            int i, j, k;

            for (i = 0; i < number.Length - 2; i++)
            {
                j = i + 1;
                for (; j < number.Length - 1; j++)
                {
                    k = j + 1;
                    for (; k < number.Length; k++)
                    {
                        if (number[i] + number[j] + number[k] == 0) count++;
                    }
                }
            }

            return count;
        }
    }
    class P_2_크기가_작은_부분문자열
    {
        public int solution(string t, string p)
        {
            int count = 0;
            char[] tchar = t.ToCharArray();
            char[] pchar = p.ToCharArray();

            for (long i = 0; i < tchar.Length - pchar.Length + 1; i++)
            {
                for (long j = 0; j < pchar.Length; j++) {
                    if (tchar[i + j] < pchar[j])
                    {
                        count++;
                        break;
                    }
                    else if (tchar[i + j] > pchar[j])
                    {
                        break;
                    }
                    else if (j == pchar.Length - 1) count++;
                }
            }

            return count;
        }
    }
    class P_2_최소직사각형
    {
        public int solution(int[,] sizes)
        {
            int w = 0, h = 0;

            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                if (sizes[i, 0] < sizes[i, 1])
                {
                    int tmp = sizes[i, 0];
                    sizes[i, 0] = sizes[i, 1];
                    sizes[i, 1] = tmp;
                }

                if (w < sizes[i, 0])
                {
                    w = sizes[i, 0];
                }

                if (h < sizes[i, 1])
                {
                    h = sizes[i, 1];
                }
            }

            return w * h;
        }
    }
    class P_2_시저암호
    {
        public string solution(string s, int n)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (n >= 26)
                {
                    while (n < 26)
                    {
                        n -= 26;
                    }
                }

                if (chars[i] != ' ')
                {
                    if (chars[i] > 96)
                    {
                        chars[i] = (char)(chars[i] + n);

                        if (chars[i] > 122)
                        {
                            chars[i] = (char)(chars[i] - 26);
                        }
                    }

                    else
                    {
                        chars[i] = (char)(chars[i] + n);

                        if (chars[i] > 90)
                        {
                            chars[i] = (char)(chars[i] - 26);
                        }
                    }
                }
            }

            return new string(chars);
        }
    }
    class P_2_문자열과_영단어
    {
        public int solution(string s)
        {
            s = s.Replace("zero", "0");
            s = s.Replace("one", "1");
            s = s.Replace("two", "2");
            s = s.Replace("three", "3");
            s = s.Replace("four", "4");
            s = s.Replace("five", "5");
            s = s.Replace("six", "6");
            s = s.Replace("seven", "7");
            s = s.Replace("eight", "8");
            s = s.Replace("nine", "9");

            return int.Parse(s);

        }
    }
    class P_2_문자열_내마음대로_정렬하기
    {
        public string[] solution(string[] strings, int n)
        {

            Array.Sort(strings, (x, y) => (x.ToCharArray()[n] == y.ToCharArray()[n]) ? x.CompareTo(y) : x.ToCharArray()[n].CompareTo(y.ToCharArray()[n]));

            return strings;

        }
    }
    class P_2_K번째수
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];

            int[] tmp;
            int startIndex, endIndex, length;

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                startIndex = commands[i, 0] - 1;
                endIndex = commands[i, 1] - 1;
                length = commands[i, 1] - commands[i, 0] + 1;

                tmp = new int[length];

                Array.Copy(array, startIndex, tmp, 0, length);
                Array.Sort(tmp);

                answer[i] = tmp[commands[i, 2] - 1];
            }


            return answer;
        }
    }
    class P_2_두개_뽑아서_더하기
    {
        public int[] solution(int[] numbers)
        {
            List<int> answer = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (!answer.Contains(numbers[i] + numbers[j])) answer.Add(numbers[i] + numbers[j]);
                }
            }
            answer.Sort();
            return answer.ToArray();
        }
    }
    class P_2_가장_가까운_같은_글자
    {
        public int[] solution(string s)
        {
            char[] str = s.ToCharArray();
            int[] answer = new int[s.Length];

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i-1; j >= -1; j--)
                {
                    if (j == -1)
                    {
                        answer[i] = -1;
                    }
                    else
                    {
                        if (str[i] == str[j])
                        {
                            answer[i] = i - j;
                            break;
                        }
                    }
                }

            }
            return answer;
        }
    }
    class P_2_푸드파이트_대회
    {
        public string solution(int[] food)
        {
            string answer = "";
            for(int i=1; i<food.Length; i++)
            {
                food[i] /= 2;
                for(int j=0; j < food[i]; j++)
                {
                    answer += i.ToString();
                }
            }

            char[] tmp = answer.ToCharArray();
            Array.Reverse(tmp);

            return answer + "0" + new string(tmp);
        }
    }
    class P_2_콜라문제
    {
        public int solution(int a, int b, int n)
        {
            int answer = 0;

            int own = n;

            while (own >= a)
            {
                own -= a;
                own += b;
                answer += b;
            }


            return answer;
        }
    }
    class P_2_명예의_전당
    {
        public int[] solution(int k, int[] score)
        {
            int[] answer = new int[score.Length];
            List<int> award = new List<int>();
            int count = 0;
            foreach (int s in score)
            {
                award.Add(s);
                award.Sort();
                if (award.Count > k)
                    award.RemoveAt(0);
                answer[count++] = award[0];
            }
            return answer;
        }
    }
    class P_2_2016년
    {
        public string solution(int a, int b)
        {
            int[] month = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int day = b;
            for(int i = 0; i < a-1; i++)
            {
                day += month[i];
            }

            switch (day % 7)
            {
                case 0:
                    return "THU";
                case 1:
                    return "FRI";
                case 2:
                    return "SAT";
                case 3:
                    return "SUN";
                case 4:
                    return "MON";
                case 5:
                    return "TUE";
                case 6:
                    return "WED";
            }
            return "머임";
        }
    }
    class P_2_카드뭉치
    {
        public string solution(string[] cards1, string[] cards2, string[] goal)
        {
            int i1 = 0, i2 = 0, i3 = 0;

            for (; i3 < goal.Length; i3++)
            {
                if (i1 < cards1.Length && cards1[i1] == goal[i3])
                {
                    i1++;
                    continue;
                }

                else if (i2 < cards2.Length && cards2[i2] == goal[i3])
                {
                    i2++;
                    continue;
                }

                else return "No";
            }

            return "Yes";
        }
    }
    class P_2_과일장수
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
    class P_2_모의고사
    {
        public int[] solution(int[] answers)
        {
            int[] nRules1 = new int[] { 1, 2, 3, 4, 5 };
            int[] nRules2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] nRules3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] nScores = new int[3];
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == nRules1[i % nRules1.Length]) ++nScores[0];
                if (answers[i] == nRules2[i % nRules2.Length]) ++nScores[1];
                if (answers[i] == nRules3[i % nRules3.Length]) ++nScores[2];
            }
            List<int> lstAnswer = new List<int>();
            if (nScores[0] == nScores.Max()) lstAnswer.Add(1);
            if (nScores[1] == nScores.Max()) lstAnswer.Add(2);
            if (nScores[2] == nScores.Max()) lstAnswer.Add(3);
            return lstAnswer.ToArray();
        }
    }
    class P_2_소수만들기
    {
        public int solution(int[] nums)
        {
            int answer = 0;

            for(int i = 0; i < nums.Length-2; i++)
            {
                for(int j = i + 1; j < nums.Length-1; j++)
                {
                    for(int k = j + 1; k < nums.Length; k++)
                    {
                        if (CalcPrime(nums[i] + nums[j] + nums[k]))
                        {
                            System.Console.WriteLine("[{0},{1},{2}]를 이용해서 {3}을 만들 수 있습니다.", nums[i], nums[j], nums[k], nums[i] + nums[j] + nums[k]);
                            answer++;
                        }
                    }
                }
            }

            return answer;
        }

        public bool CalcPrime(int num)
        {
            int nr = (int)Math.Sqrt(num);
            for (int i = 2; i <= nr; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
    class P_2_덧칠하기
    {
        public int solution(int n, int m, int[] section)
        {
            int answer = 1;

            int current = section[0];

            for (int i=1; i < section.Length; i++)
            {
                if (section[i] > current + m - 1)
                {
                    current = section[i];
                    answer++;
                }
            }
            return answer;
        }
    }
}
