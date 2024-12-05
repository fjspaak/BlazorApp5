using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Subscription
{
    public int SubscriptionId { get; set; }

    public int? SubscriptionTypeLkpId { get; set; }

    public int? ScheduleId { get; set; }

    public int? ServiceProviderId { get; set; }

    public int? OverviewId { get; set; }

    public int? TemplateId { get; set; }

    public int? RenderFormatLkpId { get; set; }

    public int? DeliveryTypeLkpId { get; set; }

    public int? EmailSendTypeLkpId { get; set; }

    public int? AppViewId { get; set; }

    public string? SubscriptionName { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsSystem { get; set; }

    public bool IsCustom { get; set; }

    public string? EmailFromAddress { get; set; }

    public string? EmailReplyToAddress { get; set; }

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

    public string? ExternalReference { get; set; }

    public string? GlobalReference { get; set; }

    public string? EventTypeName { get; set; }

    public string? EventScheduleName { get; set; }

    public int? WaitForSecPreExecution { get; set; }

    public int? WaitForSecPostExecution { get; set; }

    public string? SortOrderCode { get; set; }

    public string? Remarks { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<AppJobLine> AppJobLines { get; set; } = new List<AppJobLine>();

    public virtual AppView? AppView { get; set; }

    public virtual AppLookupCode? DeliveryTypeLkp { get; set; }

    public virtual Overview? Overview { get; set; }

    public virtual AppLookupCode? RenderFormatLkp { get; set; }

    public virtual Schedule? Schedule { get; set; }

    public virtual ServiceProvider? ServiceProvider { get; set; }

    public virtual ICollection<SubscriptionExecutionLog> SubscriptionExecutionLogs { get; set; } = new List<SubscriptionExecutionLog>();

    public virtual ICollection<SubscriptionField> SubscriptionFields { get; set; } = new List<SubscriptionField>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();

    public virtual AppLookupCode? SubscriptionTypeLkp { get; set; }

    public virtual ICollection<SubscriptionUser> SubscriptionUsers { get; set; } = new List<SubscriptionUser>();

    public virtual Template? Template { get; set; }
}
