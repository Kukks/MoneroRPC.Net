using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class CreateAccountRequest
    {
        [JsonProperty("label")] public string Label { get; set; }
    }
}