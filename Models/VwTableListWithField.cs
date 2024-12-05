using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwTableListWithField
{
    public int? ObjectId { get; set; }

    public string? ObjectName { get; set; }

    public string? SchemaName { get; set; }

    public string? FieldList { get; set; }

    public int? NrOfFields { get; set; }
}
