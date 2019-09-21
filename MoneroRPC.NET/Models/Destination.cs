using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class Destination
    {
        [JsonProperty("address")] public string Address { get; set; }
        [JsonProperty("amount")] public long Amount { get; set; }
    }
}