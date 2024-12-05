using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwBrDbTableFieldMissingInDb
{
    public int ObjectId { get; set; }

    public int? DbTableId { get; set; }

    public string TableName { get; set; } = null!;

    public string? FieldName { get; set; }

    public byte DataTypeId { get; set; }

    public string? DataTypeName { get; set; }

    public byte Precision { get; set; }

    public byte Scale { get; set; }

    public short Length { get; set; }

    public short? ColumnOrder { get; set; }
}
