using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockSDK
{
    public class Klaytn : BaseEthereum
    {
        public Klaytn(string apiToken = "", string endpoint = "https://testnet-api.blocksdk.com")
         : base("klay", apiToken, endpoint, "v3")
        {
        }

    }
}