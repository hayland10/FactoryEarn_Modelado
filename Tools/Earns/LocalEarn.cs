using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earns
{
    public class LocalEarn : IEarn
    {
        private decimal _porcentaje;
        public LocalEarn(decimal porcentaje) {
            _porcentaje = porcentaje;
        }
        public decimal Earn(decimal amount)
        {
            return amount * _porcentaje;
        }
    }
}
