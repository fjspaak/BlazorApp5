using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwDbTableFieldSelectAll
{
    public int? DbTableId { get; set; }

    public string? DbTableName { get; set; }

    public int DbTableFieldId { get; set; }

    public string? DbTableFieldName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int? DataTypeLkpId { get; set; }

    public bool IsUnique { get; set; }

    public bool IsValueRequired { get; set; }

    public bool IsPartOfPrimaryKey { get; set; }

    public int? HashTypeLkpId { get; set; }

    public bool IsDenormalized { get; set; }

    public string? SourceField { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }
}
