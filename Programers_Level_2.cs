using System;
using System.Collections.Generic;
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

            for (i = 0; i<number.Length-2; i++)
            {
                j = i + 1;
                for (; j < number.Length-1; j++)
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

            for(int i =0; i<sizes.GetLength(0); i++)
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

            for(int i = 0; i < commands.GetLength(0); i++)
            {
                startIndex = commands[i, 0] - 1;
                endIndex = commands[i, 1] - 1;
                length = commands[i, 1] - commands[i, 0]+1;

                tmp = new int[length];

                Array.Copy(array, startIndex, tmp, 0, length);
                Array.Sort(tmp);

                answer[i] = tmp[commands[i, 2]-1];
            }


            return answer;
        }
    }
}
