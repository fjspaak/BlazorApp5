using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwAppViewCreateView
{
    public string? Sql1 { get; set; }

    public string? Sql2 { get; set; }

    public string Sql3 { get; set; } = null!;
}
