using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetAccountsRequest
    {
        [JsonProperty("tag")] public string Tag { get; set; }
    }
}