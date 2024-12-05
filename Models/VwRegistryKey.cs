using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwRegistryKey
{
    public int? RegistryTreeId { get; set; }

    public int? RegistryKeyId { get; set; }

    public string? FullPathRegistryTreeName { get; set; }

    public string? RegistryKeyName { get; set; }

    public string? Value { get; set; }

    public string? RegistryKeyTypeName { get; set; }

    public int? UserId { get; set; }

    public Guid? RegistryKeyGuid { get; set; }
}
