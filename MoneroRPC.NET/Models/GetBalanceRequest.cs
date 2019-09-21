using System.Collections.Generic;
using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetBalanceRequest
    {
        [JsonProperty("account_index")] public long AccountIndex { get; set; }
        [JsonProperty("address_indices")] public List<long> AddressIndices { get; set; }
    }
}