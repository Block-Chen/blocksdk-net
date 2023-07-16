using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockSDK
{
    public class Polygon : BaseEthereum
    {
        public Polygon(string apiToken = "", string endpoint = "https://testnet-api.blocksdk.com")
         : base("matic", apiToken, endpoint, "v3")
        {
        }

    }
}