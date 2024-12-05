using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DbTable
{
    public int DbTableId { get; set; }

    public int? DatabaseId { get; set; }

    public int? AppDataObjectId { get; set; }

    public string? DbTableName { get; set; }

    public string? PrimaryFields { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int? ObjectId { get; set; }

    public bool IsHubTable { get; set; }

    public bool IsSatelliteTable { get; set; }

    public bool IsLinkedTable { get; set; }

    public bool IsHistoryTable { get; set; }

    public bool IsActive { get; set; }

    public string? FieldNameMetaIsCurrent { get; set; }

    public string? FieldNameMetaCreationDate { get; set; }

    public string? FieldNameMetaMutationDate { get; set; }

    public string? FieldNameMetaCreationUser { get; set; }

    public string? FieldNameMetaMutationUser { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual Database? Database { get; set; }

    public virtual ICollection<DbRelation> DbRelationChildDbTables { get; set; } = new List<DbRelation>();

    public virtual ICollection<DbRelation> DbRelationParentDbTables { get; set; } = new List<DbRelation>();

    public virtual ICollection<DbTableField> DbTableFields { get; set; } = new List<DbTableField>();

    public virtual ICollection<DbTableStatistic> DbTableStatistics { get; set; } = new List<DbTableStatistic>();
}
