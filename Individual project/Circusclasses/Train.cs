using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circusclasses
{
    public class Train
    {
        private List<Wagon> wagonList;

        public void Addwagon(Wagon wagon)
        {
            wagonList.Add(wagon);   
        }
    }
}
