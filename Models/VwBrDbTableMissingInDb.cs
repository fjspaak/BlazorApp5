using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwBrDbTableMissingInDb
{
    public int ObjectId { get; set; }

    public string TableName { get; set; } = null!;
}
