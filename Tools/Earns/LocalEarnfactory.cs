using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earns
{
    public class LocalEarnfactory : EarnFactory
    {
        private decimal _porcentaje;
        public LocalEarnfactory(decimal porcentaje) { 
             _porcentaje = porcentaje;
        }

        public override IEarn GetEarn()
        {
            return new LocalEarn(_porcentaje);
        }
    }
}
