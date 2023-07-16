using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockSDK
{
    public class Avalanche : BaseEthereum
    {
        public Avalanche(string apiToken = "", string endpoint = "https://testnet-api.blocksdk.com")
         : base("avax", apiToken, endpoint, "v3")
        {
        }

    }
}