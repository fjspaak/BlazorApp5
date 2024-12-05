using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppFunction
{
    public int AppFunctionId { get; set; }

    public int? ExecuteAppViewId { get; set; }

    public int? ParameterAppViewId { get; set; }

    public int? FolderId { get; set; }

    public int? AppDataObjectId { get; set; }

    public int? AppDataObjectPageId { get; set; }

    public int? AppFunctionTypeLkpId { get; set; }

    public int? ExecutionTypeLkpId { get; set; }

    public int? AppImageId { get; set; }

    public string? AppFunctionName { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsSystem { get; set; }

    public string? SortOrderCode { get; set; }

    public string? CodeReference { get; set; }

    public string? ExternalReference { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public Guid? AppFunctionGuid { get; set; }

    public virtual AppDataObject? AppDataObject { get; set; }

    public virtual AppDataObjectPage? AppDataObjectPage { get; set; }

    public virtual ICollection<AppFunctionLog> AppFunctionLogs { get; set; } = new List<AppFunctionLog>();

    public virtual AppLookupCode? AppFunctionTypeLkp { get; set; }

    public virtual ICollection<AppFunctionUser> AppFunctionUsers { get; set; } = new List<AppFunctionUser>();

    public virtual AppImage? AppImage { get; set; }

    public virtual ICollection<AppJobLine> AppJobLines { get; set; } = new List<AppJobLine>();

    public virtual ICollection<AppView> AppViews { get; set; } = new List<AppView>();

    public virtual AppView? ExecuteAppView { get; set; }

    public virtual Folder? Folder { get; set; }

    public virtual AppView? ParameterAppView { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();
}
