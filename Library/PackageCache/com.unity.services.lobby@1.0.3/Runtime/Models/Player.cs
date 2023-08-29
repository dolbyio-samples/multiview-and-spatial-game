//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Lobbies.Http;



namespace Unity.Services.Lobbies.Models
{
    [Preserve]
    [DataContract(Name = "Player")]
    public class Player
    {
        /// <summary>
        /// Information about a specific player creating, joining, or already in a lobby.
        /// </summary>
        /// <param name="id">The unique identifier for the player.  If not provided for a create or join request, it will be set to the ID of the caller.</param>
        /// <param name="connectionInfo">Connection information for connecting to a relay with this player.</param>
        /// <param name="data">Custom game-specific properties that apply to an individual player (e.g. &#x60;role&#x60; or &#x60;skill&#x60;).</param>
        /// <param name="allocationId">The &#x60;allocationId&#x60; from the Relay service which associates this player in this lobby with a persistent connection.  When a disconnect notification is received, this value is used to identify the associated player in a lobby to mark them as disconnected.</param>
        /// <param name="joined">The time at which the player joined the lobby.</param>
        /// <param name="lastUpdated">The last time the metadata for this player was updated.</param>
        [Preserve]
        public Player(string id = default, string connectionInfo = default, Dictionary<string, PlayerDataObject> data = default, string allocationId = default, DateTime joined = default, DateTime lastUpdated = default)
        {
            Id = id;
            ConnectionInfo = connectionInfo;
            Data = data;
            AllocationId = allocationId;
            Joined = joined;
            LastUpdated = lastUpdated;
        }

        /// <summary>
        /// The unique identifier for the player.  If not provided for a create or join request, it will be set to the ID of the caller.
        /// </summary>
        [Preserve]
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id{ get; }
        /// <summary>
        /// Connection information for connecting to a relay with this player.
        /// </summary>
        [Preserve]
        [DataMember(Name = "connectionInfo", EmitDefaultValue = false)]
        public string ConnectionInfo{ get; internal set; }
        /// <summary>
        /// Custom game-specific properties that apply to an individual player (e.g. &#x60;role&#x60; or &#x60;skill&#x60;).
        /// </summary>
        [Preserve]
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, PlayerDataObject> Data{ get; set; }
        /// <summary>
        /// The &#x60;allocationId&#x60; from the Relay service which associates this player in this lobby with a persistent connection.  When a disconnect notification is received, this value is used to identify the associated player in a lobby to mark them as disconnected.
        /// </summary>
        [Preserve]
        [DataMember(Name = "allocationId", EmitDefaultValue = false)]
        public string AllocationId{ get; internal set; }
        /// <summary>
        /// The time at which the player joined the lobby.
        /// </summary>
        [Preserve]
        [DataMember(Name = "joined", EmitDefaultValue = false)]
        public DateTime Joined{ get; }
        /// <summary>
        /// The last time the metadata for this player was updated.
        /// </summary>
        [Preserve]
        [DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
        public DateTime LastUpdated{ get; set; }
    
    }
}

