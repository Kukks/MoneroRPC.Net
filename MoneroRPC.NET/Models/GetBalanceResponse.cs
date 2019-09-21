using System.Collections.Generic;
using Newtonsoft.Json;

namespace MoneroRPC.NET.Models
{
    public partial class GetBalanceResponse
    {
        [JsonProperty("balance")] public decimal Balance { get; set; }
        [JsonProperty("multisig_import_needed")] public bool MultisigImportNeeded { get; set; }
        [JsonProperty("per_subaddress")] public List<PerSubaddress> PerSubaddress { get; set; }
        [JsonProperty("unlocked_balance")] public decimal UnlockedBalance { get; set; }
    }
}