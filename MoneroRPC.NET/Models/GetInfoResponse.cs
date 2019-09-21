using Newtonsoft.Json;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace MoneroRPC.NET.Models
{
    public class GetInfoResponse
    {
        [J("alt_blocks_count")] public long AltBlocksCount { get; set; }
        [JsonProperty("block_size_limit")] public long BlockSizeLimit { get; set; }
        [JsonProperty("block_size_median")] public long BlockSizeMedian { get; set; }
        [JsonProperty("bootstrap_daemon_address")] public string BootstrapDaemonAddress { get; set; }
        [JsonProperty("cumulative_difficulty")] public decimal CumulativeDifficulty { get; set; }
        [JsonProperty("difficulty")] public long Difficulty { get; set; }
        [JsonProperty("free_space")] public long FreeSpace { get; set; }
        [JsonProperty("grey_peerlist_size")] public long GreyPeerlistSize { get; set; }
        [JsonProperty("height")] public long Height { get; set; }
        [JsonProperty("height_without_bootstrap")] public long HeightWithoutBootstrap { get; set; }
        [JsonProperty("incoming_connections_count")] public long IncomingConnectionsCount { get; set; }
        [JsonProperty("mainnet")] public bool Mainnet { get; set; }
        [JsonProperty("offline")] public bool Offline { get; set; }
        [JsonProperty("outgoing_connections_count")] public long OutgoingConnectionsCount { get; set; }
        [JsonProperty("rpc_connections_count")] public long RpcConnectionsCount { get; set; }
        [JsonProperty("stagenet")] public bool Stagenet { get; set; }
        [JsonProperty("start_time")] public long StartTime { get; set; }
        [JsonProperty("status")] public string Status { get; set; }
        [JsonProperty("target")] public long Target { get; set; }
        [JsonProperty("target_height")] public long TargetHeight { get; set; }
        [JsonProperty("testnet")] public bool Testnet { get; set; }
        [JsonProperty("top_block_hash")] public string TopBlockHash { get; set; }
        [JsonProperty("tx_count")] public long TxCount { get; set; }
        [JsonProperty("tx_pool_size")] public long TxPoolSize { get; set; }
        [JsonProperty("untrusted")] public bool Untrusted { get; set; }
        [JsonProperty("was_bootstrap_ever_used")] public bool WasBootstrapEverUsed { get; set; }
        [JsonProperty("white_peerlist_size")] public long WhitePeerlistSize { get; set; }
    }
}
