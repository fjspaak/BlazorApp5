using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwPeriodTypeLastCompletePeriod
{
    public int AppLookupCodeId { get; set; }

    public string? LookupCodeTable { get; set; }

    public int? LookupCodeId { get; set; }

    public string? LookupName { get; set; }

    public string? CodeReference { get; set; }

    public bool IsEnabled { get; set; }

    public int? LastPeriodId { get; set; }

    public string? LastPeriodName { get; set; }

    public int? LastYearId { get; set; }

    public int? StartDateId { get; set; }

    public int? EndDateId { get; set; }
}
