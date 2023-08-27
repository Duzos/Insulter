using System;
using System.Text.Json.Nodes;

namespace Insulter
{
    public class Insult
    {
        public string Value { get; set; }
        private ApiReader api = new ApiReader("https://insult.mattbas.org/api/insult.json");
        public Insult() {
            this.generateInsult();
        }

        public string generateInsult() {
            JsonObject json = api.getResult();

            if (json == null) {
                Console.WriteLine("Error while getting result from insult api!");
                return string.Empty;
            }

            this.Value = json["insult"].ToString();
            return this.Value;
        }
    }
}
