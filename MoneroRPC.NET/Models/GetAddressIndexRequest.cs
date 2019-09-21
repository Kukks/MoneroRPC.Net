using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetAddressIndexRequest
    {
        [JsonProperty("address")] public string Address { get; set; }
    }
}