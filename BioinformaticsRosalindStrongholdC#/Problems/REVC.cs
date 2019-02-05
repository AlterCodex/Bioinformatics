using BioinformaticsRosalindStrongHold.Readers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BioinformaticsRosalindStrongHold.Problems
{
    public class REVC:GenericProblem
    {

        public override AdnReader getReader(Stream Origin)
        {
            AdnReader reader = new RawReader();
            reader.Init(Origin);
            return reader;
        }

        public override string Solve(AdnReader Reader)
        {
            string Revc = "";
            while (Reader.CanRead())
            {
                char c = Reader.ReadChar();
                switch (c)
                {
                    case 'A':
                        Revc = 'T' + Revc;
                        continue;
                    case 'C':
                        Revc = 'G' + Revc;
                        continue;
                    case 'G':
                        Revc = 'C' + Revc;
                        continue;
                    case 'T':
                        Revc = 'A' + Revc;
                        continue;
                }
            }
            return Revc;

        }
    }
}
