using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwTableFieldListDiffDataType
{
    public int ObjectId { get; set; }

    public string ObjectName { get; set; } = null!;

    public string? FieldName { get; set; }

    public byte DataType { get; set; }

    public short Length { get; set; }

    public byte Precision { get; set; }

    public byte Scale { get; set; }
}
