using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class Transfer
    {
        [JsonProperty("amount")] public long Amount { get; set; }
        [JsonProperty("global_index")] public long GlobalIndex { get; set; }
        [JsonProperty("key_image")] public string KeyImage { get; set; }
        [JsonProperty("spent")] public bool Spent { get; set; }
        [JsonProperty("subaddr_index")] public long SubaddrIndex { get; set; }
        [JsonProperty("tx_hash")] public string TxHash { get; set; }
        [JsonProperty("tx_size")] public long TxSize { get; set; }
    }
}