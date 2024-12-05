using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSchedulePlannedTimeEvent
{
    public int? ScheduleId { get; set; }

    public int? DateId { get; set; }

    public string? TimeCode { get; set; }

    public int? ScheduleDayOrderLkpId { get; set; }

    public int? ScheduleHourFilterLkpId { get; set; }

    public int? SchedulePeriodTypeLkpId { get; set; }

    public int? PeriodId { get; set; }

    public int? DayId { get; set; }

    public int? HourId { get; set; }

    public int? MinuteId { get; set; }

    public int? SecondId { get; set; }

    public int? CalendarMonthId { get; set; }

    public int? CalendarQuarterId { get; set; }

    public int? CalendarYearId { get; set; }

    public int? WeekId { get; set; }

    public int? WeekP444id { get; set; }

    public int? WeekP445id { get; set; }

    public int? WeekQuarterId { get; set; }

    public int? WeekYearId { get; set; }
}
