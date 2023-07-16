// See https://aka.ms/new-console-template for more information

using BlockSDK;

const string API_TOKEN = "YOU_API_TOKEN";

var blocksdk = new BlockSDK.Ethereum(API_TOKEN);
var response = await blocksdk.GetBlockChainInfo();


Console.WriteLine("Hello, World!");
