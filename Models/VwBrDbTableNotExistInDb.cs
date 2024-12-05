using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwBrDbTableNotExistInDb
{
    public int DbTableId { get; set; }

    public string? DbTableName { get; set; }

    public string? PrimaryFields { get; set; }

    public string? Description { get; set; }
}
