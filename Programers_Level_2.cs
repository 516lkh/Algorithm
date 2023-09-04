using System;
using System.Collections.Generic;
using System.Linq;
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
}
