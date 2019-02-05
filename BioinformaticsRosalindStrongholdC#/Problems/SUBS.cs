using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioinformaticsRosalindStrongHold.Readers;

namespace BioinformaticsRosalindStrongHold.Problems
{
    public class SUBS : GenericProblem
    {
        public override AdnReader getReader(Stream Origin)
        {
            AdnReader reader = new RawReader();
            reader.Init(Origin);
            return reader;
        }

        public override string Solve(AdnReader Reader)
        {
            List<string> Lines = Reader.ReadAllLines();
            string dnaStr = Lines[0];
            string pattern = Lines[1];
            int lenAdn = dnaStr.Length;
            int lenPattern = pattern.Length;
            string result = "";
            for (int i = 0; i < lenAdn - lenPattern; i++)
            {
                if (dnaStr.Substring(i, lenPattern) == pattern)
                    result += (i+1) + " ";
            }
            return result.Trim();
        }
    }
}
