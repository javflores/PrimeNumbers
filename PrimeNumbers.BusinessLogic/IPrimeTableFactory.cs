using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.BusinessLogic
{
    public interface IPrimeTableFactory
    {
        PrimeTable Create(int rank);
    }
}
