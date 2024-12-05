using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwCustomerSubscriptionOverview
{
    public int CustomerId { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? CompleteCustomerName { get; set; }

    public int? CustomerReference { get; set; }

    public bool IsInternalCustomer { get; set; }

    public int SubscriptionId { get; set; }

    public string? SubscriptionName { get; set; }

    public string? EmailRecipients { get; set; }

    public string? EmailCopyRecipients { get; set; }

    public string? EmailBlindCopyRecipients { get; set; }

    public string? SubscriptionType { get; set; }

    public string? SubscriptionReference { get; set; }

    public bool SubscriptionIsEnabled { get; set; }

    public int? ScheduleId { get; set; }

    public string? ScheduleName { get; set; }

    public DateTime? NextExecutionDate { get; set; }

    public DateTime? LastExecutionDate { get; set; }

    public bool ScheduleIsEnabled { get; set; }

    public int? OverviewId { get; set; }

    public string? OverviewName { get; set; }

    public bool? OverviewIsEnabled { get; set; }
}
