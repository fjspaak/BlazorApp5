using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwOverviewUsageByMonth
{
    public string? OverviewName { get; set; }

    public int? Year { get; set; }

    public int? MonthNumberOfYear { get; set; }

    public string? UserName { get; set; }

    public int NrRquests { get; set; }
}
