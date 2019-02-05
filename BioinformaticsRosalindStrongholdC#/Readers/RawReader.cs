using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioinformaticsRosalindStrongHold.Readers
{
    public class RawReader : AdnReader
    {
        bool EndOfFile=false;
        public override bool CanRead()
        {
           return !EndOfFile;
        }

        public override void Init(Stream origin)
        {
            this.Origin = origin;
        }

        public override char ReadChar()
        {
            int b = this.Origin.ReadByte();
            if (b != -1)
            {
                char ret = Convert.ToChar(b);
                return ret;
            }
            EndOfFile = true;
            return '_';
        }

        public override byte[] ReadAll()
        {
            byte[] r = new byte[this.Origin.Length];
            this.Origin.Read(r, 0, r.Length);
            return r;
        }

        public override List<string> ReadAllLines()
        {
            List<string> Lines = new List<string>();
            StreamReader sr = new StreamReader(this.Origin);
            while (!sr.EndOfStream)
            {
                Lines.Add(sr.ReadLine());
            }
            return Lines;
        }
    }
}
