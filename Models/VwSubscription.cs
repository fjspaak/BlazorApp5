using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSubscription
{
    public int SubscriptionId { get; set; }

    public string? SubscriptionName { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public int? OverviewId { get; set; }

    public string? OverviewName { get; set; }

    public string? OverviewLocation { get; set; }

    public int? ServiceProviderId { get; set; }

    public int? ServiceProviderTypeLkpId { get; set; }

    public bool? OverviewIsEnabled { get; set; }

    public int? ScheduleId { get; set; }

    public string? ScheduleName { get; set; }

    public DateTime? LastExecutionDate { get; set; }

    public DateTime? NextExecutionDate { get; set; }

    public string? EmailRecipients { get; set; }

    public string? EmailReplyToAddress { get; set; }

    public string? EmailImportance { get; set; }

    public string? EmailBody { get; set; }

    public string? EmailSubject { get; set; }

    public string? SubscriptionLocation { get; set; }

    public bool SubscriptionIsEnabled { get; set; }

    public bool SentReportLink { get; set; }

    public int? RenderFormatLkpId { get; set; }

    public string? RenderFormatName { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public string? Parameters { get; set; }

    public string? ExtensionSettings { get; set; }
}
