using Newtonsoft.Json;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace MoneroRPC.NET.Models
{
    public partial class GetBlockHeaderByHeightResponse
    {
        [J("block_header")] public BlockHeader BlockHeader { get; set; }
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("untrusted")] public bool Untrusted { get; set; }
    }

    public partial class CreateAddressRequest
    {
        [JsonProperty("tag")] public string Tag { get; set; }
    }
}
