using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetBlockCountResponse
    {
        [JsonProperty("count")]  public long Count { get; set; }   
        [JsonProperty("status")] public string Status { get; set; }
    }
}