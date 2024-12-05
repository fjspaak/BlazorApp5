using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppDataObjectPage
{
    public int AppDataObjectPageId { get; set; }

    public string? AppDataObjectPageName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int ParentAppDataObjectId { get; set; }

    public int ChildAppDataObjectId { get; set; }

    public int? AppFormId { get; set; }

    public int? AppViewId { get; set; }

    public int? OverviewId { get; set; }

    public int? AppFormConfigId { get; set; }

    public int? AppImageId { get; set; }

    public int? PriorityLkpId { get; set; }

    public string? CodeReference { get; set; }

    public string? GroupName { get; set; }

    public string? LinkedTable { get; set; }

    public bool AllowCopy { get; set; }

    public bool AllowPaste { get; set; }

    public bool IsInsertAllowed { get; set; }

    public bool IsUpdateAllowed { get; set; }

    public bool IsDeleteAllowed { get; set; }

    public bool IsEnabled { get; set; }

    public string? SortOrderCode { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public Guid? AppDataObjectPageGuid { get; set; }

    public virtual AppForm? AppForm { get; set; }

    public virtual AppFormConfig? AppFormConfig { get; set; }

    public virtual ICollection<AppFunction> AppFunctions { get; set; } = new List<AppFunction>();

    public virtual AppImage? AppImage { get; set; }

    public virtual AppView? AppView { get; set; }

    public virtual AppDataObject ChildAppDataObject { get; set; } = null!;

    public virtual Overview? Overview { get; set; }

    public virtual AppDataObject ParentAppDataObject { get; set; } = null!;

    public virtual AppLookupCode? PriorityLkp { get; set; }
}
