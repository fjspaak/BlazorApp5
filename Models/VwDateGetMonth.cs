using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwDateGetMonth
{
    public int? MonthNumber { get; set; }

    public int? Year { get; set; }

    public int? MonthNumberOfYear { get; set; }

    public string? MonthCode { get; set; }

    public string? MonthName { get; set; }

    public int? FirstDateId { get; set; }

    public int? LastDateId { get; set; }

    public int? NrOfDays { get; set; }

    public int? NrOfWorkingDays { get; set; }

    public int? NrOfNonWorkingDays { get; set; }

    public int? NrOfPublicHoliDays { get; set; }

    public int? FirstWeekId { get; set; }

    public int? FirstWeekFirstDateId { get; set; }

    public int? LastWeekId { get; set; }

    public int? LastWeekLastDateId { get; set; }

    public int? NrOfWeeks { get; set; }

    public int? NrOfMonths { get; set; }

    public int? NrOfP445 { get; set; }

    public int? NrOfP444 { get; set; }
}
