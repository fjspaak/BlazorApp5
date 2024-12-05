using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppView
{
    public int AppViewId { get; set; }

    public int? ParameterAppViewId { get; set; }

    public int? AppDataObjectId { get; set; }

    public int? ResultAppFormId { get; set; }

    public int? AppViewTypeLkpId { get; set; }

    public int? CorrectionAppFunctionId { get; set; }

    public int? LayoutTypeLkpId { get; set; }

    public int? PriorityLkpId { get; set; }

    public string? AppViewName { get; set; }

    public string? Description { get; set; }

    public string? SourceCommand { get; set; }

    public string? SearchFields { get; set; }

    public string? ParameterFields { get; set; }

    public bool IsStoredProcedure { get; set; }

    public bool IsSelectableAsOverview { get; set; }

    public bool IsValidationRule { get; set; }

    public bool IsBusinessRule { get; set; }

    public bool IsTechnicalRule { get; set; }

    public bool IsLogicalRule { get; set; }

    public bool IsFilterAllowed { get; set; }

    public bool HasMultiTableSource { get; set; }

    public int? RowHeight { get; set; }

    public bool? ShowRowSelector { get; set; }

    public bool? ShowRowLink { get; set; }

    public bool ShowPaging { get; set; }

    public int? PageSize { get; set; }

    public string? Remarks { get; set; }

    public string? CodeReference { get; set; }

    public Guid? AppViewGuid { get; set; }

    public string? SrcCmdCompiledForSelect { get; set; }

    public string? SrcCmdCompiledWithFields { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppDataObject? AppDataObject { get; set; }

    public virtual ICollection<AppDataObject> AppDataObjectNewAppViews { get; set; } = new List<AppDataObject>();

    public virtual ICollection<AppDataObject> AppDataObjectPageAppViews { get; set; } = new List<AppDataObject>();

    public virtual ICollection<AppDataObjectPage> AppDataObjectPages { get; set; } = new List<AppDataObjectPage>();

    public virtual ICollection<AppDataObject> AppDataObjectSecurityAppViews { get; set; } = new List<AppDataObject>();

    public virtual ICollection<AppDataObject> AppDataObjectTitleAppViews { get; set; } = new List<AppDataObject>();

    public virtual ICollection<AppFunction> AppFunctionExecuteAppViews { get; set; } = new List<AppFunction>();

    public virtual ICollection<AppFunction> AppFunctionParameterAppViews { get; set; } = new List<AppFunction>();

    public virtual ICollection<AppJobLine> AppJobLines { get; set; } = new List<AppJobLine>();

    public virtual ICollection<AppViewDependency> AppViewDependencyChildAppViews { get; set; } = new List<AppViewDependency>();

    public virtual ICollection<AppViewDependency> AppViewDependencyParentAppViews { get; set; } = new List<AppViewDependency>();

    public virtual ICollection<AppViewField> AppViewFieldChildAppViews { get; set; } = new List<AppViewField>();

    public virtual ICollection<AppViewField> AppViewFieldParentAppViews { get; set; } = new List<AppViewField>();

    public virtual ICollection<AppViewStatistic> AppViewStatistics { get; set; } = new List<AppViewStatistic>();

    public virtual AppLookupCode? AppViewTypeLkp { get; set; }

    public virtual AppFunction? CorrectionAppFunction { get; set; }

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<AppView> InverseParameterAppView { get; set; } = new List<AppView>();

    public virtual AppLookupCode? LayoutTypeLkp { get; set; }

    public virtual ICollection<Overview> OverviewParameterAppViews { get; set; } = new List<Overview>();

    public virtual ICollection<Overview> OverviewResultAppViews { get; set; } = new List<Overview>();

    public virtual AppView? ParameterAppView { get; set; }

    public virtual AppLookupCode? PriorityLkp { get; set; }

    public virtual AppForm? ResultAppForm { get; set; }

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual ICollection<SubscriptionField> SubscriptionFields { get; set; } = new List<SubscriptionField>();

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
}
