using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Test
{
    public int Id { get; set; }

    public int? AppViewId { get; set; }

    public string? RowRef { get; set; }

    public DateTime? CreationDate { get; set; }
}
