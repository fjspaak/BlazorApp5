using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public int? ScheduleTriggerTypeLkpId { get; set; }

    public int? SchedulePeriodTypeLkpId { get; set; }

    public int? SchedulePeriodFilterLkpId { get; set; }

    public int? ScheduleDayTypeLkpId { get; set; }

    public int? ScheduleDayFilterLkpId { get; set; }

    public int? ScheduleDayOrderLkpId { get; set; }

    public int? ScheduleHourFilterLkpId { get; set; }

    public int? ScheduleMinuteFilterLkpId { get; set; }

    public int? ScheduleEventLkpId { get; set; }

    public int? AppViewId { get; set; }

    public string ScheduleName { get; set; } = null!;

    public DateTime? ScheduleStartDate { get; set; }

    public DateTime? ScheduleEndDate { get; set; }

    public TimeOnly? ExecutionTime { get; set; }

    public DateTime? ExecutionDate { get; set; }

    public string? SelectedPeriods { get; set; }

    public string? SelectedDays { get; set; }

    public string? SelectedHours { get; set; }

    public string? SelectedMinutes { get; set; }

    public string? SelectedDates { get; set; }

    public string? SelectedTimes { get; set; }

    public Guid? ScheduleGuid { get; set; }

    public string? ExternalReference { get; set; }

    public string? GlobalReference { get; set; }

    public int? PeriodInterval { get; set; }

    public int? DayInterval { get; set; }

    public int? HourInterval { get; set; }

    public int? MinuteInterval { get; set; }

    public int? LoginUserId { get; set; }

    public bool IsEnabled { get; set; }

    public string? Remarks { get; set; }

    public int? MaxNrOfExecutions { get; set; }

    public int? NrOfExecutions { get; set; }

    public DateTime? NextExecutionDate { get; set; }

    public DateTime? LastExecutionDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppView? AppView { get; set; }

    public virtual AppLookupCode? ScheduleDayFilterLkp { get; set; }

    public virtual AppLookupCode? ScheduleDayOrderLkp { get; set; }

    public virtual AppLookupCode? ScheduleDayTypeLkp { get; set; }

    public virtual AppLookupCode? ScheduleEventLkp { get; set; }

    public virtual AppLookupCode? ScheduleHourFilterLkp { get; set; }

    public virtual ICollection<ScheduleLog> ScheduleLogs { get; set; } = new List<ScheduleLog>();

    public virtual AppLookupCode? ScheduleMinuteFilterLkp { get; set; }

    public virtual AppLookupCode? SchedulePeriodFilterLkp { get; set; }

    public virtual AppLookupCode? SchedulePeriodTypeLkp { get; set; }

    public virtual ICollection<SchedulePlannedTimeEvent> SchedulePlannedTimeEvents { get; set; } = new List<SchedulePlannedTimeEvent>();

    public virtual AppLookupCode? ScheduleTriggerTypeLkp { get; set; }

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
}
