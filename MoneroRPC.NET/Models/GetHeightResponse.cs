using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetHeightResponse
    {
        [JsonProperty("height")] public long Height { get; set; }
    }
}