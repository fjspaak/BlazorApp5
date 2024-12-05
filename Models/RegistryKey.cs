using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class RegistryKey
{
    public int RegistryKeyId { get; set; }

    public int RegistryTreeId { get; set; }

    public int RegistryKeyTypeLkpId { get; set; }

    public int? UserId { get; set; }

    public string? RegistryKeyName { get; set; }

    public string? ValueString { get; set; }

    public int? ValueInt { get; set; }

    public DateTime? ValueDatetime { get; set; }

    public byte[]? ValueBinary { get; set; }

    public decimal? ValueDecimal { get; set; }

    public bool ValueBit { get; set; }

    public string? ValueMemo { get; set; }

    public Guid? ValueUi { get; set; }

    public string? ValueXml { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public bool IsSystem { get; set; }

    public Guid? RegistryKeyGuid { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppLookupCode RegistryKeyTypeLkp { get; set; } = null!;

    public virtual RegistryTree RegistryTree { get; set; } = null!;

    public virtual User? User { get; set; }
}
