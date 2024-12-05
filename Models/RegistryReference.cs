using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class RegistryReference
{
    public int RegistryReferenceId { get; set; }

    public int AppDataObjectId { get; set; }

    public int? RegistryTreeId { get; set; }

    public int? UserId { get; set; }

    public string? RowReference { get; set; }

    public string? RegistryReferenceName { get; set; }

    public string? Value { get; set; }

    public bool IsSystem { get; set; }

    public Guid? RegistryReferenceGuid { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppDataObject AppDataObject { get; set; } = null!;

    public virtual RegistryTree? RegistryTree { get; set; }

    public virtual User? User { get; set; }
}
