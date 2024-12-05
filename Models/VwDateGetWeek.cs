using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwDateGetWeek
{
    public int? WeekNumber { get; set; }

    public int? WeekNumberOfYear { get; set; }

    public int? Year { get; set; }

    public int? FirstDateId { get; set; }

    public int? LastDateId { get; set; }

    public int? NrOfDays { get; set; }

    public int? NrOfWorkingDays { get; set; }

    public int? NrOfNonWorkingDays { get; set; }

    public int? NrOfPublicHoliDays { get; set; }

    public int? FirstWeekFirstDateId { get; set; }

    public int? LastWeekLastDateId { get; set; }

    public int NrOfWeeks { get; set; }

    public int? NrOfMonths { get; set; }

    public int? NrOfP445 { get; set; }

    public int? NrOfP444 { get; set; }

    public int? NrOfYears { get; set; }
}
