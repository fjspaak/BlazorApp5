using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwUsageByDate
{
    public int DateId { get; set; }

    public int? DayNumberOfWeek { get; set; }

    public string? DayName { get; set; }

    public int? WeekNumber { get; set; }

    public int? NrOfLogins { get; set; }

    public int? NrOfUnqueVisitors { get; set; }

    public int? NrOfRequestsUniqueUsers { get; set; }

    public int? NrOfRequests { get; set; }

    public int? NrOfRequestsUniqueReports { get; set; }

    public int? RequestDurationMax { get; set; }

    public int? RequestDurationMin { get; set; }

    public int? RequestDurationAvg { get; set; }
}
