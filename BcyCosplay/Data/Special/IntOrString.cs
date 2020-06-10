using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcyCosplay.Data
{
    public struct IntString
    {
        public string String;
        public static implicit operator IntString(long Integer) => new IntString { String = Integer.ToString() };
        public static implicit operator IntString(string String) => new IntString { String = String };
    }
}
