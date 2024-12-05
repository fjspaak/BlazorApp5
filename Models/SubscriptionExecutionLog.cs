using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SubscriptionExecutionLog
{
    public int SubscriptionExecutionLogId { get; set; }

    public int? SubscriptionId { get; set; }

    public int? OverviewId { get; set; }

    public int? RenderFormatLkpId { get; set; }

    public int? DeliveryTypeLkpId { get; set; }

    public int? TemplateId { get; set; }

    public string? ExecutionCode { get; set; }

    public DateTime? ExecutionDate { get; set; }

    public string? EmailFromAddress { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailRecipients { get; set; }

    public string? EmailCopyRecipients { get; set; }

    public string? EmailBlindCopyRecipients { get; set; }

    public string? EmailBody { get; set; }

    public string? EmailBodyFormat { get; set; }

    public string? EmailImportance { get; set; }

    public string? EmailSensitivity { get; set; }

    public string? Location { get; set; }

    public bool SentReportLink { get; set; }

    public string? Parameters { get; set; }

    public string? ErrorCode { get; set; }

    public string? ExecutionMessage { get; set; }

    public Guid? ExecutionGuid { get; set; }

    public int? ExecutionResult { get; set; }

    public string? EmailProviderName { get; set; }

    public string? EmailReplyToAddress { get; set; }

    public string? EventTypeName { get; set; }

    public string? EventScheduleName { get; set; }

    public virtual Subscription? Subscription { get; set; }
}
