using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace BlockSDK
{
    public class Base
    {
        public string ChainName { get; set; }
        public string ApiToken { get; set; }
        public string Endpoint { get; set; }
        public string Version { get; set; }

        private HttpClient client;

        public Base(string chainName,string apiToken = "", string endpoint = "https://testnet-api.blocksdk.com", string version = "v3")
        {
            this.ChainName = chainName;
            this.ApiToken = apiToken;
            this.Endpoint = endpoint;
            this.Version = version;
            this.client = new HttpClient();
            this.client.DefaultRequestHeaders.Add("x-api-token", this.ApiToken);
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Dictionary<string, object>> Request(string method, string path, Dictionary<string, object> data = null)
        {
            var url = this.Endpoint + "/" + this.Version + "/" + this.ChainName + path;

            if (method == "GET" && data != null && data.Count > 0)
            {
                url += "?";
                foreach (KeyValuePair<string, object> item in data)
                {
                    url += $"{item.Key}={item.Value.ToString().ToLower()}&";
                }
            }

            HttpResponseMessage response;
            StringContent content = null;
            if (method == "POST" || method == "DELETE")
            {
                content = new StringContent(JsonConvert.SerializeObject(data), System.Text.Encoding.UTF8, "application/json");
            }

            switch (method)
            {
                case "GET":
                    response = await this.client.GetAsync(url);
                    break;
                case "POST":
                    response = await this.client.PostAsync(url, content);
                    break;
                case "DELETE":
                    response = await this.client.DeleteAsync(url);
                    break;
                default:
                    throw new NotSupportedException($"Method {method} is not supported.");
            }

            string result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
        }
    }
}
