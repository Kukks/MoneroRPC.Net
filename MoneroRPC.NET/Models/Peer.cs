using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class Peer
    {
        [JsonProperty("info")] public Info Info { get; set; }
    }
}