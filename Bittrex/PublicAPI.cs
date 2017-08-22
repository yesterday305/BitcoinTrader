using Common;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bittrex
{
   public  class PublicAPI : ServiceProxyBase
    {
        private static volatile PublicAPI _instance;
        private static readonly object SyncRoot = new Object();

        public static PublicAPI Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (SyncRoot)
                {
                    if (_instance == null)
                        _instance = new PublicAPI();
                }
                return _instance;
            }
        }
        private PublicAPI(string token = "") : base(ConfigurationManager.AppSettings["BittrexApiUrl"], token)
        {

        }

        public GetMarketSummaryResponse GetMarketSummary(string market)
        {
            var request = BuildGetRequest(string.Format("public/getmarketsummary?market={0}", market), DataFormat.Json);
            var apiResult = Execute<ApiCallResponse<List<GetMarketSummaryResponse>>>(request);
            if(apiResult != null && apiResult.result.Count > 0)
                return apiResult.result.FirstOrDefault();
            return null;
        }
    }
}
