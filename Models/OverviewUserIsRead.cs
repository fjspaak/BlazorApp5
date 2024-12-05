using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class OverviewUserIsRead
{
    public int OverviewUserIsReadId { get; set; }

    public int OverviewId { get; set; }

    public int UserId { get; set; }
}
