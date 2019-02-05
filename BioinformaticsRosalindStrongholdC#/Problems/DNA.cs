using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioinformaticsRosalindStrongHold.Readers;

namespace BioinformaticsRosalindStrongHold.Problems
{
    public class DNA : GenericProblem
    {
        public override AdnReader getReader(Stream Origin)
        {
            AdnReader reader = new RawReader();
            reader.Init(Origin);
            return reader;
        }

        public override string Solve(AdnReader Reader)
        {
            int A, G, C, T;
            A = 0;
            G = 0;
            C = 0;
            T = 0;
            while (Reader.CanRead())
            {
                char c = Reader.ReadChar();
                switch(c)
                {
                    case 'A':
                        A++;
                        continue;
                    case 'C':
                        C++;
                        continue;
                    case 'G':
                        G++;
                        continue;
                    case 'T':
                        T++;
                        continue;
                }
            }
            return ""+A+" "+C+" "+" "+G+" "+T;

        }
    }
}
