using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class RegistryTree
{
    public int RegistryTreeId { get; set; }

    public int ParentRegistryTreeId { get; set; }

    public string RegistryTreeName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int? LevelId { get; set; }

    public string? FullPathRegistryTreeId { get; set; }

    public string? FullPathRegistryTreeName { get; set; }

    public bool IsSystem { get; set; }

    public Guid? RegistryTreeGuid { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<AppDataObject> AppDataObjects { get; set; } = new List<AppDataObject>();

    public virtual ICollection<RegistryTree> InverseParentRegistryTree { get; set; } = new List<RegistryTree>();

    public virtual RegistryTree ParentRegistryTree { get; set; } = null!;

    public virtual ICollection<RegistryKey> RegistryKeys { get; set; } = new List<RegistryKey>();

    public virtual ICollection<RegistryReference> RegistryReferences { get; set; } = new List<RegistryReference>();
}
