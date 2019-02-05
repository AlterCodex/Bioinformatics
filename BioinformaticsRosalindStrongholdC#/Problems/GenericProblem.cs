using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioinformaticsRosalindStrongHold.Problems
{
    public abstract class GenericProblem
    {
        public abstract string Solve(Readers.AdnReader Reader);
        public abstract Readers.AdnReader getReader(Stream Origin);
    }
}
