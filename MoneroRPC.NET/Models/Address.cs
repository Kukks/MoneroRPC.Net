using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class Address
    {
        [JsonProperty("address")]       public string AddressAddress { get; set; }
        [JsonProperty("address_index")] public long AddressIndex { get; set; }    
        [JsonProperty("label")]         public string Label { get; set; }         
        [JsonProperty("used")]          public bool Used { get; set; }            
    }
}