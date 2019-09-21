using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public class StatusResponse
    {
        [JsonProperty("status")]             public string Status { get; set; }    
    }
}