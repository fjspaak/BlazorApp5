using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwForeignKey
{
    public int RelationObjectId { get; set; }

    public string? RelationName { get; set; }

    public byte? DeleteReferentialAction { get; set; }

    public string? DeleteReferentialActionDesc { get; set; }

    public byte? UpdateReferentialAction { get; set; }

    public string? UpdateReferentialActionDesc { get; set; }

    public bool? IsSystemNamed { get; set; }

    public bool? IsDisabled { get; set; }

    public int ChildTableObjectId { get; set; }

    public string? ChildTableName { get; set; }

    public string? ChildPrimaryFields { get; set; }

    public string? ChildFieldName { get; set; }

    public int ParentTableObjectId { get; set; }

    public string? ParentTableName { get; set; }

    public string? ParentPrimaryFields { get; set; }

    public string? ParentFieldName { get; set; }
}
