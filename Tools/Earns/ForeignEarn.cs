using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earns
{
    public class ForeignEarn : IEarn
    {
        private decimal _porcetaje;
        private decimal _extra;
        public ForeignEarn(decimal porcentaje, decimal extra) { 
            _extra = extra;
            _porcetaje = porcentaje;
        }
        public decimal Earn(decimal amount)
        {
            return (amount * _porcetaje) + _extra;
        }
    }
}
