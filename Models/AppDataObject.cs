using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppDataObject
{
    public int AppDataObjectId { get; set; }

    public int? DataSourceId { get; set; }

    public int? TitleAppViewId { get; set; }

    public int? PageAppViewId { get; set; }

    public int? SecurityAppViewId { get; set; }

    public int AllowedSecurityId { get; set; }

    public int? NewAppViewId { get; set; }

    public int? NewAppFormId { get; set; }

    public int? AppFormConfigId { get; set; }

    public int? AppImageId { get; set; }

    public int? PriorityLkpId { get; set; }

    public int? UpdateFrequencyLkpId { get; set; }

    public int? RootRegistryTreeId { get; set; }

    public string? AppDataObjectName { get; set; }

    public string? TableName { get; set; }

    public string? PrimaryFields { get; set; }

    public string? SearchFields { get; set; }

    public bool IsInsertAllowed { get; set; }

    public bool IsUpdateAllowed { get; set; }

    public bool IsDeleteAllowed { get; set; }

    public bool IsSystem { get; set; }

    public bool IsEnabled { get; set; }

    public bool? IsTableObject { get; set; }

    public bool? HasActivePaging { get; set; }

    public string? CodeReference { get; set; }

    public string? DeleteCommand { get; set; }

    public string? ExternalReference { get; set; }

    public string? GlobalReference { get; set; }

    public Guid? AppDataObjectGuid { get; set; }

    public string? Remarks { get; set; }

    public int? NrOfRows { get; set; }

    public int? NrOfListAppViews { get; set; }

    public int? NrOfOverviewAppViews { get; set; }

    public int? NrOfSelectionAppViews { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<AppDataObjectPage> AppDataObjectPageChildAppDataObjects { get; set; } = new List<AppDataObjectPage>();

    public virtual ICollection<AppDataObjectPage> AppDataObjectPageParentAppDataObjects { get; set; } = new List<AppDataObjectPage>();

    public virtual ICollection<AppDataObjectStatistic> AppDataObjectStatistics { get; set; } = new List<AppDataObjectStatistic>();

    public virtual ICollection<AppDataObjectUser> AppDataObjectUsers { get; set; } = new List<AppDataObjectUser>();

    public virtual AppFormConfig? AppFormConfig { get; set; }

    public virtual ICollection<AppFunction> AppFunctions { get; set; } = new List<AppFunction>();

    public virtual AppImage? AppImage { get; set; }

    public virtual ICollection<AppRowReference> AppRowReferences { get; set; } = new List<AppRowReference>();

    public virtual ICollection<AppView> AppViews { get; set; } = new List<AppView>();

    public virtual DataSource? DataSource { get; set; }

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual AppView? NewAppView { get; set; }

    public virtual ICollection<Overview> Overviews { get; set; } = new List<Overview>();

    public virtual AppView? PageAppView { get; set; }

    public virtual AppLookupCode? PriorityLkp { get; set; }

    public virtual ICollection<RegistryReference> RegistryReferences { get; set; } = new List<RegistryReference>();

    public virtual RegistryTree? RootRegistryTree { get; set; }

    public virtual AppView? SecurityAppView { get; set; }

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual AppView? TitleAppView { get; set; }

    public virtual AppLookupCode? UpdateFrequencyLkp { get; set; }
}
