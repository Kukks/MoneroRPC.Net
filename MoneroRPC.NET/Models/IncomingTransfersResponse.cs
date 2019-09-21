using System.Collections.Generic;
using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class IncomingTransfersResponse
    {
        [JsonProperty("transfers")] public List<Transfer> Transfers { get; set; }
    }
}