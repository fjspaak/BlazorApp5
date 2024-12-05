using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwTableList
{
    public int TableObjectId { get; set; }

    public string TableName { get; set; } = null!;

    public string? SchemaName { get; set; }

    public DateTime CreationDate { get; set; }
}
