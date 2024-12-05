using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwOverviewUserIsRead
{
    public int OverviewId { get; set; }

    public int UserId { get; set; }

    public bool IsFavorite { get; set; }
}
