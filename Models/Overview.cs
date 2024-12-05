using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Overview
{
    public int OverviewId { get; set; }

    public int? FolderId { get; set; }

    public int? AppDataObjectId { get; set; }

    public int? ServiceProviderId { get; set; }

    public int? OverviewTypeLkpId { get; set; }

    public int? ResultAppViewId { get; set; }

    public int? ResultAppFormId { get; set; }

    public int? ParameterAppViewId { get; set; }

    public int? ParameterAppFormId { get; set; }

    public int? OverviewResetEventLkpId { get; set; }

    public string? OverviewCode { get; set; }

    public string? OverviewName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public string? Location { get; set; }

    public string? HelpReference { get; set; }

    public string? GlobalReference { get; set; }

    public bool IsSystem { get; set; }

    public bool IsHidden { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsSecInherited { get; set; }

    public bool ShowToAllUsers { get; set; }

    public bool ShowParameterLink { get; set; }

    public bool ShowProviderParameters { get; set; }

    public bool ShowPortalParameters { get; set; }

    public bool ShowProviderToolbar { get; set; }

    public bool ExecuteOnOpening { get; set; }

    public bool IsExportXlsAllowed { get; set; }

    public bool IsExportPdfAllowed { get; set; }

    public bool IsExportRdlAllowed { get; set; }

    public bool IsExportXmlAllowed { get; set; }

    public string? SortOrderCode { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppDataObject? AppDataObject { get; set; }

    public virtual ICollection<AppDataObjectPage> AppDataObjectPages { get; set; } = new List<AppDataObjectPage>();

    public virtual Folder? Folder { get; set; }

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<OverviewFieldOverview> OverviewFieldOverviews { get; set; } = new List<OverviewFieldOverview>();

    public virtual AppLookupCode? OverviewResetEventLkp { get; set; }

    public virtual ICollection<OverviewSection> OverviewSections { get; set; } = new List<OverviewSection>();

    public virtual AppLookupCode? OverviewTypeLkp { get; set; }

    public virtual ICollection<OverviewUser> OverviewUsers { get; set; } = new List<OverviewUser>();

    public virtual AppForm? ParameterAppForm { get; set; }

    public virtual AppView? ParameterAppView { get; set; }

    public virtual ICollection<RequestLog> RequestLogs { get; set; } = new List<RequestLog>();

    public virtual AppForm? ResultAppForm { get; set; }

    public virtual AppView? ResultAppView { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ServiceProvider? ServiceProvider { get; set; }

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
