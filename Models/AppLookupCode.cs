using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppLookupCode
{
    public int AppLookupCodeId { get; set; }

    public string? LookupCodeTable { get; set; }

    public int? LookupCodeId { get; set; }

    public string? LookupName { get; set; }

    public string? CodeReference { get; set; }

    public bool IsEnabled { get; set; }

    public string? Remarks { get; set; }

    public string? ExternalReference { get; set; }

    public Guid? AppLookupCodeGuid { get; set; }

    public string? Configurations { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<AppDataObjectPage> AppDataObjectPages { get; set; } = new List<AppDataObjectPage>();

    public virtual ICollection<AppDataObject> AppDataObjectPriorityLkps { get; set; } = new List<AppDataObject>();

    public virtual ICollection<AppDataObject> AppDataObjectUpdateFrequencyLkps { get; set; } = new List<AppDataObject>();

    public virtual ICollection<AppFormConfig> AppFormConfigMasterHub1PageLayoutTypeLkps { get; set; } = new List<AppFormConfig>();

    public virtual ICollection<AppFormConfig> AppFormConfigMasterHub2PageLayoutTypeLkps { get; set; } = new List<AppFormConfig>();

    public virtual ICollection<AppFunction> AppFunctions { get; set; } = new List<AppFunction>();

    public virtual ICollection<AppImage> AppImages { get; set; } = new List<AppImage>();

    public virtual ICollection<AppJobLine> AppJobLines { get; set; } = new List<AppJobLine>();

    public virtual ICollection<AppView> AppViewAppViewTypeLkps { get; set; } = new List<AppView>();

    public virtual ICollection<AppViewField> AppViewFieldControlTypeLkps { get; set; } = new List<AppViewField>();

    public virtual ICollection<AppViewField> AppViewFieldDataTypeLkps { get; set; } = new List<AppViewField>();

    public virtual ICollection<AppView> AppViewLayoutTypeLkps { get; set; } = new List<AppView>();

    public virtual ICollection<AppView> AppViewPriorityLkps { get; set; } = new List<AppView>();

    public virtual ICollection<DbTableField> DbTableFieldDataTypeLkps { get; set; } = new List<DbTableField>();

    public virtual ICollection<DbTableField> DbTableFieldHashTypeLkps { get; set; } = new List<DbTableField>();

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<Kpi> Kpis { get; set; } = new List<Kpi>();

    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();

    public virtual ICollection<Overview> OverviewOverviewResetEventLkps { get; set; } = new List<Overview>();

    public virtual ICollection<Overview> OverviewOverviewTypeLkps { get; set; } = new List<Overview>();

    public virtual ICollection<RegistryKey> RegistryKeys { get; set; } = new List<RegistryKey>();

    public virtual ICollection<Schedule> ScheduleScheduleDayFilterLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleScheduleDayOrderLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleScheduleDayTypeLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleScheduleEventLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleScheduleHourFilterLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleScheduleMinuteFilterLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleSchedulePeriodFilterLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleSchedulePeriodTypeLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<Schedule> ScheduleScheduleTriggerTypeLkps { get; set; } = new List<Schedule>();

    public virtual ICollection<ServiceProvider> ServiceProviders { get; set; } = new List<ServiceProvider>();

    public virtual ICollection<Subscription> SubscriptionDeliveryTypeLkps { get; set; } = new List<Subscription>();

    public virtual ICollection<Subscription> SubscriptionRenderFormatLkps { get; set; } = new List<Subscription>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();

    public virtual ICollection<Subscription> SubscriptionSubscriptionTypeLkps { get; set; } = new List<Subscription>();

    public virtual ICollection<Template> Templates { get; set; } = new List<Template>();

    public virtual ICollection<User> UserCustomLoginStatusLkps { get; set; } = new List<User>();

    public virtual ICollection<User> UserDefaultLoginStatusLkps { get; set; } = new List<User>();

    public virtual ICollection<User> UserUserTypeLkps { get; set; } = new List<User>();
}
