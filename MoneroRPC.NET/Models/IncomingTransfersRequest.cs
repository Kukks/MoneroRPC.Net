using System.Collections.Generic;
using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class IncomingTransfersRequest
    {
        [JsonProperty("transfer_type")] public string TransferType { get; set; }
        [JsonProperty("account_index")] public long AccountIndex { get; set; }
        [JsonProperty("subaddr_indices")] public List<long> SubaddrIndices { get; set; }
        [JsonProperty("verbose")] public bool Verbose { get; set; }
    }
}