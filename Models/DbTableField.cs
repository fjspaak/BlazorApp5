using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DbTableField
{
    public int DbTableFieldId { get; set; }

    public int? DbTableId { get; set; }

    public int? DataTypeLkpId { get; set; }

    public string? DbTableFieldName { get; set; }

    public bool IsUnique { get; set; }

    public bool IsValueRequired { get; set; }

    public bool IsPartOfPrimaryKey { get; set; }

    public int? ObjectId { get; set; }

    public int? HashTypeLkpId { get; set; }

    public string? Description { get; set; }

    public bool IsDenormalized { get; set; }

    public string? SourceField { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppLookupCode? DataTypeLkp { get; set; }

    public virtual ICollection<DbRelationField> DbRelationFieldChildDbTableFields { get; set; } = new List<DbRelationField>();

    public virtual ICollection<DbRelationField> DbRelationFieldParentDbTableFields { get; set; } = new List<DbRelationField>();

    public virtual DbTable? DbTable { get; set; }

    public virtual ICollection<DbTableFieldStatistic> DbTableFieldStatistics { get; set; } = new List<DbTableFieldStatistic>();

    public virtual AppLookupCode? HashTypeLkp { get; set; }
}
