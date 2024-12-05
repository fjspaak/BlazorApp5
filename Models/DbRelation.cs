using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DbRelation
{
    public int DbRelationId { get; set; }

    public int? ParentDbTableId { get; set; }

    public string? ParentTableName { get; set; }

    public int? ChildDbTableId { get; set; }

    public string? ChildTableName { get; set; }

    public string? DbRelationName { get; set; }

    public bool SetToNullWhenNotInSource { get; set; }

    public bool IsCascadeUpdate { get; set; }

    public bool IsCascadeDelete { get; set; }

    public bool OnDeleteSetChildToNull { get; set; }

    public bool OnDeleteSetChildToDefault { get; set; }

    public bool IsEntegrityEnforced { get; set; }

    public bool IsMaterialized { get; set; }

    public int? ObjectId { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual DbTable? ChildDbTable { get; set; }

    public virtual ICollection<DbRelationField> DbRelationFields { get; set; } = new List<DbRelationField>();

    public virtual DbTable? ParentDbTable { get; set; }
}
