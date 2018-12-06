using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labatehpr
{
    class HangarOccupiedPlaceException : Exception
    {
        public HangarOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит автомобиль")
   { }
    }
}
