using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwViewFieldList
{
    public int ObjectId { get; set; }

    public string ObjectName { get; set; } = null!;

    public string? SchemaName { get; set; }

    public string? FieldName { get; set; }

    public byte DataType { get; set; }

    public short? ColumnOrder { get; set; }
}
