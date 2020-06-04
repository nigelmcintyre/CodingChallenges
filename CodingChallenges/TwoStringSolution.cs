using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class TwoStringSolution
    {
        static string twoString (string s1, string s2)
        {
            string isSubstring = "";
            Dictionary<string, int> s1Dict = new Dictionary<string, int>();


            for(int i=0; i<s1.Length; i++)
            {
                if(s1Dict.ContainsKey(s1.Substring(i, i)))
                {
                    s1Dict[s1.Substring(i,i)]++;
                } else
                {
                    s1Dict.Add(s1.Substring(i, i), 1);
                }
                
            }
            for (int j = 0; j < s2.Length; j++)
            {
                if (!s1Dict.ContainsKey(s2.Substring(j, j)))
                {
                    isSubstring = "NO";
                }
                else
                {
                    isSubstring = "YES";
                    s1Dict[s2.Substring(j, j)]--;
                }
            }
            return isSubstring;
        }
    }
}
