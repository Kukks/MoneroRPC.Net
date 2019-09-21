using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetAddressIndexResponse
    {
        [JsonProperty("index")] public SubaddrIndex Index { get; set; }
    }
}