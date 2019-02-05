using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioinformaticsRosalindStrongHold.Readers
{
    public abstract class AdnReader
    {
        protected Stream Origin { get; set; }
        public abstract void Init(Stream origin);
        public abstract bool CanRead();
        public abstract char ReadChar();
        public abstract byte[] ReadAll();
        public abstract List<string> ReadAllLines();
    }
}
 