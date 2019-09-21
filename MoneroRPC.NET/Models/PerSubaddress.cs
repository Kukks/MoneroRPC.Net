using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class PerSubaddress
    {
        [JsonProperty("address")] public string Address { get; set; }
        [JsonProperty("address_index")] public long AddressIndex { get; set; }
        [JsonProperty("balance")] public decimal Balance { get; set; }
        [JsonProperty("label")] public string Label { get; set; }
        [JsonProperty("num_unspent_outputs")] public long NumUnspentOutputs { get; set; }
        [JsonProperty("unlocked_balance")] public decimal UnlockedBalance { get; set; }
    }
}