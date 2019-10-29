﻿namespace AppiSimo.Client.Model.Auth
{
    using System;
    using System.Text.Json.Serialization;

    public class Profile
    {
        [JsonPropertyName("sub")] public Guid Sub { get; set; }

        [JsonPropertyName("email_verified")] public bool EmailVerified { get; set; }

        [JsonPropertyName("address")] public string Address { get; set; }

        [JsonPropertyName("gender")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Gender Gender { get; set; }

        [JsonPropertyName("given_name")] public string Name { get; set; }

        [JsonPropertyName("family_name")] public string FamilyName { get; set; }

        [JsonPropertyName("email")] public string EMail { get; set; }
    }
}