using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex
{
    public class MarketAPI : ServiceProxyBase
    {
        public MarketAPI(string token = "") : base(string.Empty,token)
        {

        }
    }
}
