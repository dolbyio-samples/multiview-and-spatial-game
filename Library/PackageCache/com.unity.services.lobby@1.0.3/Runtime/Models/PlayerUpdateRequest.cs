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
    [DataContract(Name = "PlayerUpdateRequest")]
    public class PlayerUpdateRequest
    {
        /// <summary>
        /// The body of an Update Player Data request.
        /// </summary>
        /// <param name="connectionInfo">Connection information for connecting to a relay with this player.</param>
        /// <param name="data">Custom game-specific properties to add, update, or remove from the player (e.g. &#x60;role&#x60; or &#x60;skill&#x60;).  To remove an existing property, include it in &#x60;data&#x60; but set the property object to &#x60;null&#x60;.  To update the value to &#x60;null&#x60;, set the &#x60;value&#x60; property of the object to &#x60;null&#x60;.</param>
        /// <param name="allocationId">The &#x60;allocationId&#x60; from the Relay service which associates this player in this lobby with a persistent connection.  When a disconnect notification is received, this value is used to identify the associated player in a lobby to mark them as disconnected.</param>
        [Preserve]
        public PlayerUpdateRequest(string connectionInfo = default, Dictionary<string, PlayerDataObject> data = default, string allocationId = default)
        {
            ConnectionInfo = connectionInfo;
            Data = new JsonObject(data);
            AllocationId = allocationId;
        }

        /// <summary>
        /// Connection information for connecting to a relay with this player.
        /// </summary>
        [Preserve]
        [DataMember(Name = "connectionInfo", EmitDefaultValue = false)]
        public string ConnectionInfo { get; }
        /// <summary>
        /// Custom game-specific properties to add, update, or remove from the player (e.g. &#x60;role&#x60; or &#x60;skill&#x60;).  To remove an existing property, include it in &#x60;data&#x60; but set the property object to &#x60;null&#x60;.  To update the value to &#x60;null&#x60;, set the &#x60;value&#x60; property of the object to &#x60;null&#x60;.
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public JsonObject Data { get; }
        /// <summary>
        /// The &#x60;allocationId&#x60; from the Relay service which associates this player in this lobby with a persistent connection.  When a disconnect notification is received, this value is used to identify the associated player in a lobby to mark them as disconnected.
        /// </summary>
        [Preserve]
        [DataMember(Name = "allocationId", EmitDefaultValue = false)]
        public string AllocationId { get; }

    }
}
