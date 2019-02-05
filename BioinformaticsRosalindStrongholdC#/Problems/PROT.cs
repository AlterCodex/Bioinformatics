using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioinformaticsRosalindStrongHold.Readers;

namespace BioinformaticsRosalindStrongHold.Problems
{
    public class PROT : GenericProblem
    {
        public override AdnReader getReader(Stream Origin)
        {
            AdnReader reader = new RawReader();
            reader.Init(Origin);
            return reader;
        }

        public override string Solve(AdnReader Reader)
        {
            string rna=System.Text.Encoding.Default.GetString(Reader.ReadAll());
            Utils.LOAD_RNA_PROTEINS();
            string resul = "";
            for (int i = 0; i <= rna.Length-3; i+=3)
            {
                resul += Utils.Proteins[Utils.PatternToNumber(rna.Substring(i, 3))];
            }
            return resul;
        }
    }
}
