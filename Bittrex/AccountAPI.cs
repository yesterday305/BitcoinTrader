using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex
{
    public class AccountAPI : ServiceProxyBase
    {
        public AccountAPI(string token = "") : base(string.Empty, token)
        {

        }
    }
}
