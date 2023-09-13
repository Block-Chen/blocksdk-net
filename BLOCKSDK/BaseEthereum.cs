using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlockSDK
{
    public class BaseEthereum : Base
    {
        public BaseEthereum(string chainName,string apiToken = "", string endpoint = "https://testnet-api.blocksdk.com", string version = "v3")
         : base(chainName,apiToken, endpoint, version)
        {
        }

        public async Task<Dictionary<string, object>> GetBlockChainInfo()
        {
            return await this.Request("GET", "/info");
        }

        public async Task<Dictionary<string, object>> GetBlock(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/block/{request["block"]}", request);
        }

        public async Task<Dictionary<string, object>> GetAddresses(Dictionary<string, object> request)
        {
            return await this.Request("GET", "/address", request);
        }

        public async Task<Dictionary<string, object>> CreateAddress(Dictionary<string, object> request)
        {
            return await this.Request("POST", "/address", request);
        }

        public async Task<Dictionary<string, object>> GetAddressInfo(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/address/{request["address"]}/info", request);
        }

        public async Task<Dictionary<string, object>> GetAddressBalance(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/address/{request["address"]}/balance");
        }

        public async Task<Dictionary<string, object>> Send(Dictionary<string, object> request)
        {
            return await this.Request("POST", $"/address/{request["from_address"]}/send", request);
        }

        public async Task<Dictionary<string, object>> SendTransaction(Dictionary<string, object> request)
        {
            return await this.Request("POST", "/transaction/send", request);
        }

        public async Task<Dictionary<string, object>> GetTransaction(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/transaction/{request["hash"]}");
        }

        public async Task<Dictionary<string, object>> GetTokenInfo(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/token/{request["contract_address"]}/info");
        }

        public async Task<Dictionary<string, object>> SendToken(Dictionary<string, object> request)
        {
            return await this.Request("POST", $"/token/{request["contract_address"]}/{request["from_address"]}/transfer", request);
        }

        public async Task<Dictionary<string, object>> GetTokenBalance(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/token/{request["contract_address"]}/{request["from_address"]}/balance");
        }

        public async Task<Dictionary<string, object>> GetTokenTxs(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/token/{request["from_address"]}/transactions", request);
        }

        public async Task<Dictionary<string, object>> GetTokenContractTxs(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/token/{request["contract_address"]}/{request["from_address"]}/transactions", request);
        }

        public async Task<Dictionary<string, object>> GetTokenAllBalance(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/token/{request["from_address"]}/all-balance", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/nfts", request);
        }

        public async Task<Dictionary<string, object>> GetSingleOwnerNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["owner_address"]}/owner-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetSingleCreatorNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["creator_address"]}/creator-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetSingleTxs(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["from_address"]}/transactions", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNftOwnerNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/{request["owner_address"]}/owner-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNftCreatorNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/{request["creator_address"]}/creator-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNftTxs(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/{request["from_address"]}/from-transactions", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNftInfo(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/{request["token_id"]}/info", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNftTokenTxs(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/{request["token_id"]}/nft-transactions", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNftAuctionNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/auction-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNftSellerNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/{request["seller_address"]}/seller-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetSingleNftTokenBids(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/single-nft/{request["contract_address"]}/{request["token_id"]}/nft-bids", request);
        }

        public async Task<Dictionary<string, object>> GetMultiNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["contract_address"]}/nfts", request);
        }

        public async Task<Dictionary<string, object>> GetMultiOwnerNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["owner_address"]}/owner-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetMultiCreatorNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["creator_address"]}/creator-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetMultiTxs(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["from_address"]}/transactions", request);
        }

        public async Task<Dictionary<string, object>> GetMultiNftOwnerNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["contract_address"]}/{request["owner_address"]}/owner-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetMultiNftCreatorNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["contract_address"]}/{request["creator_address"]}/creator-nfts", request);
        }

        public async Task<Dictionary<string, object>> GetMultiNftTxs(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["contract_address"]}/{request["from_address"]}/from-transactions", request);
        }

        public async Task<Dictionary<string, object>> GetMultiNftInfo(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["contract_address"]}/{request["token_id"]}/info", request);
        }

        public async Task<Dictionary<string, object>> GetMultiNftTokenTxs(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["contract_address"]}/{request["token_id"]}/nft-transactions", request);
        }

        public async Task<Dictionary<string, object>> GetMultiNftSellerNfts(Dictionary<string, object> request)
        {
            return await this.Request("GET", $"/multi-nft/{request["contract_address"]}/{request["seller_address"]}/seller-nfts", request);
        }

        public async Task<Dictionary<string, object>> ReadContract(Dictionary<string, object> request)
        {
            return await this.Request("POST", $"/contract/{request["contract_address"]}/read", request);
        }

        public async Task<Dictionary<string, object>> WriteContract(Dictionary<string, object> request)
        {
            return await this.Request("POST", $"/contract/{request["contract_address"]}/write", request);
        }
    }
}