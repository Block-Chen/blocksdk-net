using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockSDK
{
    public class Ethereum : BaseEthereum
    {
        public Ethereum(string apiToken = "", string endpoint = "https://testnet-api.blocksdk.com")
         : base("eth",apiToken, endpoint, "v3")
        {
        }

    }
}