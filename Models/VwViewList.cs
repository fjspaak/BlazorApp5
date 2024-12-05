using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwViewList
{
    public int ViewObjectId { get; set; }

    public string ViewName { get; set; } = null!;

    public string? SchemaName { get; set; }

    public DateTime CreationDate { get; set; }
}
