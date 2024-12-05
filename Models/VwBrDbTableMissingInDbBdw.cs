using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwBrDbTableMissingInDbBdw
{
    public int ObjectId { get; set; }

    public string ObjectName { get; set; } = null!;

    public int DatabaseId { get; set; }

    public int IsMissing { get; set; }

    public long? RowId { get; set; }
}
