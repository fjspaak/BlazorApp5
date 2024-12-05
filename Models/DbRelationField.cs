using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DbRelationField
{
    public int DbRelationFieldId { get; set; }

    public int? DbRelationId { get; set; }

    public int? ParentDbTableFieldId { get; set; }

    public int? ChildDbTableFieldId { get; set; }

    public int? ObjectId { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual DbTableField? ChildDbTableField { get; set; }

    public virtual DbRelation? DbRelation { get; set; }

    public virtual DbTableField? ParentDbTableField { get; set; }
}
