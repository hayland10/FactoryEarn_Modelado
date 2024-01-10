using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earns
{
    public class ForeignEarnFactory : EarnFactory
    {
        private decimal _porcetaje;
        private decimal _extra;

        public ForeignEarnFactory(decimal porcentaje, decimal extra) {
            _extra = extra;
            _porcetaje = porcentaje;
        }
        public override IEarn GetEarn()
        {
            return new ForeignEarn(_porcetaje,_extra);
        }
    }
}
