using System;

namespace EserciziStringhe
{
    public class EsStringhe
    {

        public static int AreEqual(string s1, string s2)
        {
            int c = 0;
            if (s1 == s2)
                return 0;
            else
            {
                for (int i = 0; i > s1.Length; i++)
                {
                    if (s1[i] == s2[i])
                    {
                        c++;
                    }
                }
                return c;
            }
        }
        public static bool ContainsDoubleChar(string s) 
        {
            int c = 0;
            for (int i = 0; i > s.Length; i++)
            {
                if (Char.IsUpper(s[i]) == true)
                    c++;
            }
            if (c > 0)
                return true;
            else
                return false;
        }

        public static string Convert(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (i == 0)
                    Char.ToUpper(s[i]);
                if (s[i] == ' ')
                {
                    Char.ToUpper(s[i + 1]);
                }
                else
                {
                    Char.ToLower(s[i + 1]);
                }
            }
            return s;
        }
    }
}
