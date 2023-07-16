using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockSDK
{
  
    public class EthereumClassic : BaseEthereum
    {
        public EthereumClassic(string apiToken = "", string endpoint = "https://testnet-api.blocksdk.com")
         : base("etc", apiToken, endpoint, "v3")
        {
        }

    }
}