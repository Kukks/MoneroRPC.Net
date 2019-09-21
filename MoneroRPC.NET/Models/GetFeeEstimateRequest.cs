using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public class GetFeeEstimateRequest
    {
        [JsonProperty("grace_blocks")] public int? GraceBlocks { get; set; }
    }
}