using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labatehpr
{
    class MultiLevelHangar
    {
        List<Hangar<ITransport>> HangarStages;
        private const int countPlaces = 20;
        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            HangarStages = new List<Hangar<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                HangarStages.Add(new Hangar<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        public Hangar<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < HangarStages.Count)
                {
                    return HangarStages[ind];
                }
                return null;
            }
        }
    }
}
