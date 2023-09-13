// See https://aka.ms/new-console-template for more information

using BlockSDK;

const string API_TOKEN = "YOU_TOKEN";
var ethereumClient = new BlockSDK.Ethereum(API_TOKEN);
var result = await ethereumClient.GetBlockChainInfo();
foreach (var item in result)
{
    Console.WriteLine(item);
}
