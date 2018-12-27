using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labatehpr
{
    public class HangarNullCarException : Exception
    {
        public HangarNullCarException() : base("Нет самолётика")
        { }
    }
}
