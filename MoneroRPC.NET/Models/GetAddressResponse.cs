using System.Collections.Generic;
using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetAddressResponse
    {
        [JsonProperty("address")]   public string Address { get; set; }         
        [JsonProperty("addresses")] public List<Address> Addresses { get; set; }
    }
}