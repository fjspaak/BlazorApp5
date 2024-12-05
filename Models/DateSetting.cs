using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class DateSetting
{
    public int DateSettingId { get; set; }

    public int? ApprovalDateId { get; set; }

    public DateTime? ApprovalDateValue { get; set; }

    public int? FirstDayOfWeekDateId { get; set; }

    public int? FirstDayOfMonthDateId { get; set; }

    public int? FirstDayOfQuarterDateId { get; set; }

    public int? FirstDayOfYearDateId { get; set; }

    public int? FirstDayOfYearOfWeekDateId { get; set; }

    public int? FirstDayOfP444DateId { get; set; }

    public int? FirstDayOfP445DateId { get; set; }

    public int? FirstDayOfQ445DateId { get; set; }

    public int? LastApprovedWeek { get; set; }

    public int? LastApprovedP444 { get; set; }

    public int? LastApprovedP445 { get; set; }

    public int? LastApprovedQ445 { get; set; }

    public int? DefaultYearForWeek { get; set; }

    public string? ApprovalMessage { get; set; }

    public int? ExportAppViewId { get; set; }

    public int? DefaultYear { get; set; }

    public int? LastApprovedYear { get; set; }

    public int? LastApprovedYearOfWeek { get; set; }
}
