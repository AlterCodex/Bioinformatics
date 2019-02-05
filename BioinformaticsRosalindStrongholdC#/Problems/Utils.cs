using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioinformaticsRosalindStrongHold.Problems
{
    public static class Utils
    {
        public static Dictionary<int,string> Proteins { get; private set; }

        public static int PatternToNumber(string pattern)
        {
            if (pattern.Length == 0)
                return 0;
            if (pattern.Length == 1)
                return SymbolToNumber(pattern.ToCharArray()[0]);
            else
            {
                string subString = pattern.Substring(0, pattern.Length - 1);
                return 4 * PatternToNumber(subString) + SymbolToNumber(pattern.ToCharArray().Last());
            }
        }

        private static int SymbolToNumber(char p)
        {
            switch (p)
            {
                case 'A':
                    return 0;
                case 'C':
                    return 1;
                case 'G':
                    return 2;
                case 'T':
                    return 3;
                case 'U':
                    return 3;

            }
            return 0;
        }

        public static string NumberToPattern(int index, int k)
        {
            if (k == 1)
                return NumberToSymbol(index);
            int prefix = (int)(index / 4);
            int reminder = index % 4;
            return NumberToPattern(prefix, k - 1) + NumberToSymbol(reminder);
        }

        private static string NumberToSymbol(int index)
        {
            switch (index)
            {
                case 0:
                    return "A";
                case 1:
                    return "C";
                case 2:
                    return "G";
                case 3:
                    return "T";

            }
            return "A";
        }

        public static void LOAD_RNA_PROTEINS()
        {
            string[] test = Properties.Resources.RNA_PROTEINS_TABLE.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            Proteins = new Dictionary<int, string>();
            foreach (string s in test)
            {
                string[] a = s.Split(' ');
                Proteins.Add(PatternToNumber(a[0]), a[1].Trim());
            }
        }
}
}
