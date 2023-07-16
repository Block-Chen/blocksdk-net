using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockSDK
{
    public class BinanceSmart : BaseEthereum
    {
        public BinanceSmart(string apiToken = "", string endpoint = "https://testnet-api.blocksdk.com")
         : base("bsc", apiToken, endpoint, "v3")
        {
        }

    }
}