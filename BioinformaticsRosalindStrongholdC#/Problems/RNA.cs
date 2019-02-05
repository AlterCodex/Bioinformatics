using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioinformaticsRosalindStrongHold.Readers;

namespace BioinformaticsRosalindStrongHold.Problems
{
    class RNA : GenericProblem
    {
        public override AdnReader getReader(Stream Origin)
        {
            AdnReader reader = new RawReader();
            reader.Init(Origin);
            return reader;
        }


        public override string Solve(AdnReader Reader)
        {
            string RNA = "";
            while (Reader.CanRead())
            {
                char c = Reader.ReadChar();
                switch (c)
                {
                    case 'T':
                        RNA += 'U';
                        continue;
                    case 'A':
                    case 'C':
                    case 'G':
                        RNA += c;
                        continue;

                }
            }
            return RNA;

        }
    }
}
