using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Insulter
{
    public class ApiReader
    {
        public string Url { get; set; }
        public string Params { get; set; }
        public ApiReader(string url, string parameters) {
            Url = url;
            Params = parameters;
        }
        public ApiReader(string url) : this(url,"") { }


        public JsonObject getResult() {
            JsonObject json = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Url);

            // Add an Accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response
            HttpResponseMessage response = client.GetAsync(Params).Result;
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body
                string resultString = response.Content.ReadAsStringAsync().Result;
                json = (JsonObject) JsonNode.Parse(resultString);
            }
            else {
                Console.WriteLine("",(int) response.StatusCode, response.ReasonPhrase);
            }
            client.Dispose();

            return json;
        }
    }
}
