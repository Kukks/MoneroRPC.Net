using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class MakeUriResponse
    {
        [JsonProperty("uri")] public string Uri { get; set; }
    }
}