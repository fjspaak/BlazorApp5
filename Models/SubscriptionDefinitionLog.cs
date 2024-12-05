using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SubscriptionDefinitionLog
{
    public int SubscriptionDefinitionLogId { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public int? UpdateActionId { get; set; }

    public int? SubscriptionId { get; set; }

    public int? OverviewId { get; set; }

    public int? SubscriptionTypeLkpId { get; set; }

    public int? RenderFormatLkpId { get; set; }

    public int? DeliveryTypeLkpId { get; set; }

    public int? TemplateId { get; set; }

    public int? AppViewId { get; set; }

    public string? SubscriptionName { get; set; }

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

    public bool? SentReportLink { get; set; }

    public string? ExternalReference { get; set; }

    public bool? IsEnabled { get; set; }

    public bool? IsSystem { get; set; }

    public bool? IsCustom { get; set; }

    public string? Remarks { get; set; }

    public string? Parameters { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public string? GlobalReference { get; set; }
}
