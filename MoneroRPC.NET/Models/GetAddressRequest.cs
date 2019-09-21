using System.Collections.Generic;
using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetAddressRequest
    {
        [JsonProperty("account_index")] public long AccountIndex { get; set; }      
        [JsonProperty("address_index")] public List<long> AddressIndex { get; set; }
    }
}