using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppForm
{
    public int AppFormId { get; set; }

    public string? AppFormName { get; set; }

    public string? CodeReference { get; set; }

    public string? ExternalReference { get; set; }

    public string? Remarks { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsGeneric { get; set; }

    public bool IsOpeningForm { get; set; }

    public bool IsSelectableForFolder { get; set; }

    public bool IsSelectableForObjectPage { get; set; }

    public bool IsSelectableForAppView { get; set; }

    public bool IsSelectableForOverview { get; set; }

    public bool IsIframeRequired { get; set; }

    public bool IsValidForAppDataObjectPage { get; set; }

    public bool IsValidForAppFromConfig { get; set; }

    public bool IsValidForAppViewResult { get; set; }

    public bool IsValidForFolder { get; set; }

    public bool IsValidForSystemSetting { get; set; }

    public bool IsValidForOverviewResult { get; set; }

    public bool IsValidForOverviewParameter { get; set; }

    public Guid? AppFormGuid { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<AppDataObjectPage> AppDataObjectPages { get; set; } = new List<AppDataObjectPage>();

    public virtual ICollection<AppFormConfig> AppFormConfigs { get; set; } = new List<AppFormConfig>();

    public virtual ICollection<AppView> AppViews { get; set; } = new List<AppView>();

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<Overview> OverviewParameterAppForms { get; set; } = new List<Overview>();

    public virtual ICollection<Overview> OverviewResultAppForms { get; set; } = new List<Overview>();

    public virtual ICollection<SystemSetting> SystemSettings { get; set; } = new List<SystemSetting>();
}
