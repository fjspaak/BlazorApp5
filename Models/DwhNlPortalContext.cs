using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp5.Models;

public partial class DwhNlPortalContext : DbContext
{
    public DwhNlPortalContext()
    {
    }

    public DwhNlPortalContext(DbContextOptions<DwhNlPortalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppDataObject> AppDataObjects { get; set; }

    public virtual DbSet<AppDataObjectPage> AppDataObjectPages { get; set; }

    public virtual DbSet<AppDataObjectStatistic> AppDataObjectStatistics { get; set; }

    public virtual DbSet<AppDataObjectUser> AppDataObjectUsers { get; set; }

    public virtual DbSet<AppDataObjectUserIsRead> AppDataObjectUserIsReads { get; set; }

    public virtual DbSet<AppForm> AppForms { get; set; }

    public virtual DbSet<AppFormConfig> AppFormConfigs { get; set; }

    public virtual DbSet<AppFunction> AppFunctions { get; set; }

    public virtual DbSet<AppFunctionLog> AppFunctionLogs { get; set; }

    public virtual DbSet<AppFunctionUser> AppFunctionUsers { get; set; }

    public virtual DbSet<AppFunctionUserIsExecute> AppFunctionUserIsExecutes { get; set; }

    public virtual DbSet<AppImage> AppImages { get; set; }

    public virtual DbSet<AppJob> AppJobs { get; set; }

    public virtual DbSet<AppJobConfiguration> AppJobConfigurations { get; set; }

    public virtual DbSet<AppJobDependency> AppJobDependencies { get; set; }

    public virtual DbSet<AppJobExecutionException> AppJobExecutionExceptions { get; set; }

    public virtual DbSet<AppJobExecutionLog> AppJobExecutionLogs { get; set; }

    public virtual DbSet<AppJobLine> AppJobLines { get; set; }

    public virtual DbSet<AppLookupCode> AppLookupCodes { get; set; }

    public virtual DbSet<AppQuickLaunch> AppQuickLaunches { get; set; }

    public virtual DbSet<AppRowReference> AppRowReferences { get; set; }

    public virtual DbSet<AppShortCut> AppShortCuts { get; set; }

    public virtual DbSet<AppView> AppViews { get; set; }

    public virtual DbSet<AppViewDependency> AppViewDependencies { get; set; }

    public virtual DbSet<AppViewField> AppViewFields { get; set; }

    public virtual DbSet<AppViewFieldDependency> AppViewFieldDependencies { get; set; }

    public virtual DbSet<AppViewFieldUser> AppViewFieldUsers { get; set; }

    public virtual DbSet<AppViewStatistic> AppViewStatistics { get; set; }

    public virtual DbSet<ContractType> ContractTypes { get; set; }

    public virtual DbSet<CostCentre> CostCentres { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerLevel> CustomerLevels { get; set; }

    public virtual DbSet<CustomerOrganisation1> CustomerOrganisations1 { get; set; }

    public virtual DbSet<CustomerOrganisationLevel> CustomerOrganisationLevels { get; set; }

    public virtual DbSet<CustomerUser> CustomerUsers { get; set; }

    public virtual DbSet<CustomerUserIsRead> CustomerUserIsReads { get; set; }

    public virtual DbSet<DataSource> DataSources { get; set; }

    public virtual DbSet<Database> Databases { get; set; }

    public virtual DbSet<DateSetting> DateSettings { get; set; }

    public virtual DbSet<DateValue> DateValues { get; set; }

    public virtual DbSet<DbRelation> DbRelations { get; set; }

    public virtual DbSet<DbRelationField> DbRelationFields { get; set; }

    public virtual DbSet<DbTable> DbTables { get; set; }

    public virtual DbSet<DbTableField> DbTableFields { get; set; }

    public virtual DbSet<DbTableFieldStatistic> DbTableFieldStatistics { get; set; }

    public virtual DbSet<DbTableStatistic> DbTableStatistics { get; set; }

    public virtual DbSet<DimOrganisatieBak> DimOrganisatieBaks { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<ElmahError> ElmahErrors { get; set; }

    public virtual DbSet<Folder> Folders { get; set; }

    public virtual DbSet<FolderUser> FolderUsers { get; set; }

    public virtual DbSet<FolderUserIsRead> FolderUserIsReads { get; set; }

    public virtual DbSet<JobPosition> JobPositions { get; set; }

    public virtual DbSet<JobPositionGroup> JobPositionGroups { get; set; }

    public virtual DbSet<Kpi> Kpis { get; set; }

    public virtual DbSet<KpiUser> KpiUsers { get; set; }

    public virtual DbSet<KpiUserIsRead> KpiUserIsReads { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Organisation> Organisations { get; set; }

    public virtual DbSet<OrganisationLevel> OrganisationLevels { get; set; }

    public virtual DbSet<OrganisationUser> OrganisationUsers { get; set; }

    public virtual DbSet<OrganisationUserIsRead> OrganisationUserIsReads { get; set; }

    public virtual DbSet<Overview> Overviews { get; set; }

    public virtual DbSet<OverviewField> OverviewFields { get; set; }

    public virtual DbSet<OverviewFieldOverview> OverviewFieldOverviews { get; set; }

    public virtual DbSet<OverviewFieldOverviewSection> OverviewFieldOverviewSections { get; set; }

    public virtual DbSet<OverviewSection> OverviewSections { get; set; }

    public virtual DbSet<OverviewUser> OverviewUsers { get; set; }

    public virtual DbSet<OverviewUserIsRead> OverviewUserIsReads { get; set; }

    public virtual DbSet<RegistryKey> RegistryKeys { get; set; }

    public virtual DbSet<RegistryReference> RegistryReferences { get; set; }

    public virtual DbSet<RegistryTree> RegistryTrees { get; set; }

    public virtual DbSet<RequestLog> RequestLogs { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleLog> ScheduleLogs { get; set; }

    public virtual DbSet<SchedulePlannedTimeEvent> SchedulePlannedTimeEvents { get; set; }

    public virtual DbSet<Security> Securities { get; set; }

    public virtual DbSet<SecurityRule> SecurityRules { get; set; }

    public virtual DbSet<SecurityRuleUser> SecurityRuleUsers { get; set; }

    public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<SubscriptionDefinitionLog> SubscriptionDefinitionLogs { get; set; }

    public virtual DbSet<SubscriptionExecutionLog> SubscriptionExecutionLogs { get; set; }

    public virtual DbSet<SubscriptionField> SubscriptionFields { get; set; }

    public virtual DbSet<SubscriptionRule> SubscriptionRules { get; set; }

    public virtual DbSet<SubscriptionRuleUser> SubscriptionRuleUsers { get; set; }

    public virtual DbSet<SubscriptionUser> SubscriptionUsers { get; set; }

    public virtual DbSet<Sysssislog> Sysssislogs { get; set; }

    public virtual DbSet<SystemMessage> SystemMessages { get; set; }

    public virtual DbSet<SystemSetting> SystemSettings { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserStatistic> UserStatistics { get; set; }

    public virtual DbSet<UserUserGroup> UserUserGroups { get; set; }

    public virtual DbSet<UserUserProfile> UserUserProfiles { get; set; }

    public virtual DbSet<UserUserVirtual> UserUserVirtuals { get; set; }

    public virtual DbSet<VwAppDataObjectPageSelectAll> VwAppDataObjectPageSelectAlls { get; set; }

    public virtual DbSet<VwAppDataObjectSelectAll> VwAppDataObjectSelectAlls { get; set; }

    public virtual DbSet<VwAppDataObjectUserAdmin> VwAppDataObjectUserAdmins { get; set; }

    public virtual DbSet<VwAppDataObjectUserIsRead> VwAppDataObjectUserIsReads { get; set; }

    public virtual DbSet<VwAppFunctionUserAdmin> VwAppFunctionUserAdmins { get; set; }

    public virtual DbSet<VwAppFunctionUserIsExecute> VwAppFunctionUserIsExecutes { get; set; }

    public virtual DbSet<VwAppFunctionUserIsRead> VwAppFunctionUserIsReads { get; set; }

    public virtual DbSet<VwAppViewCreateView> VwAppViewCreateViews { get; set; }

    public virtual DbSet<VwAppViewFieldLabel> VwAppViewFieldLabels { get; set; }

    public virtual DbSet<VwAppViewFieldNotInSourceCommand> VwAppViewFieldNotInSourceCommands { get; set; }

    public virtual DbSet<VwAppViewSelectAll> VwAppViewSelectAlls { get; set; }

    public virtual DbSet<VwBrDbTableFieldMissingInDb> VwBrDbTableFieldMissingInDbs { get; set; }

    public virtual DbSet<VwBrDbTableFieldNotExistInDb> VwBrDbTableFieldNotExistInDbs { get; set; }

    public virtual DbSet<VwBrDbTableMissingInDb> VwBrDbTableMissingInDbs { get; set; }

    public virtual DbSet<VwBrDbTableMissingInDbBdw> VwBrDbTableMissingInDbBdws { get; set; }

    public virtual DbSet<VwBrDbTableMissingInDbDmsa> VwBrDbTableMissingInDbDmsas { get; set; }

    public virtual DbSet<VwBrDbTableMissingInDbDsa> VwBrDbTableMissingInDbDsas { get; set; }

    public virtual DbSet<VwBrDbTableMissingInDbIsa> VwBrDbTableMissingInDbIsas { get; set; }

    public virtual DbSet<VwBrDbTableNotExistInDb> VwBrDbTableNotExistInDbs { get; set; }

    public virtual DbSet<VwCustomerHierachy> VwCustomerHierachies { get; set; }

    public virtual DbSet<VwCustomerSubscriptionOverview> VwCustomerSubscriptionOverviews { get; set; }

    public virtual DbSet<VwCustomerUserCustomLevel> VwCustomerUserCustomLevels { get; set; }

    public virtual DbSet<VwCustomerUserIsRead> VwCustomerUserIsReads { get; set; }

    public virtual DbSet<VwDateConvertStringToDate> VwDateConvertStringToDates { get; set; }

    public virtual DbSet<VwDateGetMonth> VwDateGetMonths { get; set; }

    public virtual DbSet<VwDateGetP444> VwDateGetP444s { get; set; }

    public virtual DbSet<VwDateGetP445> VwDateGetP445s { get; set; }

    public virtual DbSet<VwDateGetQuater> VwDateGetQuaters { get; set; }

    public virtual DbSet<VwDateGetWeek> VwDateGetWeeks { get; set; }

    public virtual DbSet<VwDateGetYear> VwDateGetYears { get; set; }

    public virtual DbSet<VwDateValueDayId> VwDateValueDayIds { get; set; }

    public virtual DbSet<VwDbTableFieldMetaFieldSetValue> VwDbTableFieldMetaFieldSetValues { get; set; }

    public virtual DbSet<VwDbTableFieldSelectAll> VwDbTableFieldSelectAlls { get; set; }

    public virtual DbSet<VwErrorByWeek> VwErrorByWeeks { get; set; }

    public virtual DbSet<VwFolderList> VwFolderLists { get; set; }

    public virtual DbSet<VwFolderSelectAll> VwFolderSelectAlls { get; set; }

    public virtual DbSet<VwFolderUserIsRead> VwFolderUserIsReads { get; set; }

    public virtual DbSet<VwForbiddenFilterWord> VwForbiddenFilterWords { get; set; }

    public virtual DbSet<VwForeignKey> VwForeignKeys { get; set; }

    public virtual DbSet<VwKpiUserAdmin> VwKpiUserAdmins { get; set; }

    public virtual DbSet<VwKpiUserIsRead> VwKpiUserIsReads { get; set; }

    public virtual DbSet<VwLoginLastWeek> VwLoginLastWeeks { get; set; }

    public virtual DbSet<VwOrganisationChild> VwOrganisationChilds { get; set; }

    public virtual DbSet<VwOrganisationHierachy> VwOrganisationHierachies { get; set; }

    public virtual DbSet<VwOrganisationUserCustomLevel> VwOrganisationUserCustomLevels { get; set; }

    public virtual DbSet<VwOrganisationUserIsRead> VwOrganisationUserIsReads { get; set; }

    public virtual DbSet<VwOverviewUsageByMonth> VwOverviewUsageByMonths { get; set; }

    public virtual DbSet<VwOverviewUserAdmin> VwOverviewUserAdmins { get; set; }

    public virtual DbSet<VwOverviewUserIsRead> VwOverviewUserIsReads { get; set; }

    public virtual DbSet<VwPeriodTypeLastCompletePeriod> VwPeriodTypeLastCompletePeriods { get; set; }

    public virtual DbSet<VwRegistryKey> VwRegistryKeys { get; set; }

    public virtual DbSet<VwRegistryTreeList> VwRegistryTreeLists { get; set; }

    public virtual DbSet<VwSchedulePlannedTimeEvent> VwSchedulePlannedTimeEvents { get; set; }

    public virtual DbSet<VwSecurity> VwSecurities { get; set; }

    public virtual DbSet<VwSecurityAuditList> VwSecurityAuditLists { get; set; }

    public virtual DbSet<VwSecurityByCustomer> VwSecurityByCustomers { get; set; }

    public virtual DbSet<VwSecurityByCustomerLevel> VwSecurityByCustomerLevels { get; set; }

    public virtual DbSet<VwSecurityByOrganisation> VwSecurityByOrganisations { get; set; }

    public virtual DbSet<VwSecurityByOrganisationLevel> VwSecurityByOrganisationLevels { get; set; }

    public virtual DbSet<VwSecurityByOverview> VwSecurityByOverviews { get; set; }

    public virtual DbSet<VwSecurityByProfile> VwSecurityByProfiles { get; set; }

    public virtual DbSet<VwSecurityByUser> VwSecurityByUsers { get; set; }

    public virtual DbSet<VwSecurityExceptionNoOrgManyOverview> VwSecurityExceptionNoOrgManyOverviews { get; set; }

    public virtual DbSet<VwSecurityRuleAppDataObject> VwSecurityRuleAppDataObjects { get; set; }

    public virtual DbSet<VwSecurityRuleAppFunction> VwSecurityRuleAppFunctions { get; set; }

    public virtual DbSet<VwSecurityRuleCustomer> VwSecurityRuleCustomers { get; set; }

    public virtual DbSet<VwSecurityRuleFolder> VwSecurityRuleFolders { get; set; }

    public virtual DbSet<VwSecurityRuleGetUser> VwSecurityRuleGetUsers { get; set; }

    public virtual DbSet<VwSecurityRuleKpi> VwSecurityRuleKpis { get; set; }

    public virtual DbSet<VwSecurityRuleOrganisation> VwSecurityRuleOrganisations { get; set; }

    public virtual DbSet<VwSecurityRuleOverview> VwSecurityRuleOverviews { get; set; }

    public virtual DbSet<VwSecurityRuleUserProfile> VwSecurityRuleUserProfiles { get; set; }

    public virtual DbSet<VwSecurityShowAll> VwSecurityShowAlls { get; set; }

    public virtual DbSet<VwSubscription> VwSubscriptions { get; set; }

    public virtual DbSet<VwSubscriptionEmailToSend> VwSubscriptionEmailToSends { get; set; }

    public virtual DbSet<VwSubscriptionField> VwSubscriptionFields { get; set; }

    public virtual DbSet<VwSubscriptionRuleGetUser> VwSubscriptionRuleGetUsers { get; set; }

    public virtual DbSet<VwSubscriptionUser> VwSubscriptionUsers { get; set; }

    public virtual DbSet<VwSubscriptionUserAllocation> VwSubscriptionUserAllocations { get; set; }

    public virtual DbSet<VwTableFieldList> VwTableFieldLists { get; set; }

    public virtual DbSet<VwTableFieldListDiffDataType> VwTableFieldListDiffDataTypes { get; set; }

    public virtual DbSet<VwTableList> VwTableLists { get; set; }

    public virtual DbSet<VwTableListRowCount> VwTableListRowCounts { get; set; }

    public virtual DbSet<VwTableListWithField> VwTableListWithFields { get; set; }

    public virtual DbSet<VwUsageByDate> VwUsageByDates { get; set; }

    public virtual DbSet<VwUsageByHour> VwUsageByHours { get; set; }

    public virtual DbSet<VwUserOrganisationAllocation> VwUserOrganisationAllocations { get; set; }

    public virtual DbSet<VwViewFieldList> VwViewFieldLists { get; set; }

    public virtual DbSet<VwViewList> VwViewLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=DWH_NL_PORTAL;User=ReportAdmin;Password=ReportAdmin;encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AppDataObject>(entity =>
        {
            entity.ToTable("AppDataObject");

            entity.HasIndex(e => e.AppFormConfigId, "IX_AppDataObject_AppFormConfigID");

            entity.HasIndex(e => e.AppImageId, "IX_AppDataObject_AppImageID");

            entity.HasIndex(e => e.CodeReference, "IX_AppDataObject_CodeReference");

            entity.HasIndex(e => e.DataSourceId, "IX_AppDataObject_DataSourceID");

            entity.HasIndex(e => e.PageAppViewId, "IX_AppDataObject_PageAppViewID");

            entity.HasIndex(e => e.PriorityLkpId, "IX_AppDataObject_PriorityLkpID");

            entity.HasIndex(e => e.TitleAppViewId, "IX_AppDataObject_TitleAppViewID");

            entity.Property(e => e.AppDataObjectId)
                .ValueGeneratedNever()
                .HasColumnName("AppDataObjectID");
            entity.Property(e => e.AllowedSecurityId).HasColumnName("AllowedSecurityID");
            entity.Property(e => e.AppDataObjectGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("AppDataObjectGUID");
            entity.Property(e => e.AppDataObjectName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppImageId).HasColumnName("AppImageID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DeleteCommand)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HasActivePaging).HasDefaultValue(false);
            entity.Property(e => e.IsDeleteAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsInsertAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsTableObject).HasDefaultValue(false);
            entity.Property(e => e.IsUpdateAllowed).HasDefaultValue(true);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.NewAppFormId).HasColumnName("NewAppFormID");
            entity.Property(e => e.NewAppViewId).HasColumnName("NewAppViewID");
            entity.Property(e => e.PageAppViewId).HasColumnName("PageAppViewID");
            entity.Property(e => e.PrimaryFields)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PriorityLkpId).HasColumnName("PriorityLkpID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RootRegistryTreeId).HasColumnName("RootRegistryTreeID");
            entity.Property(e => e.SearchFields)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SecurityAppViewId).HasColumnName("SecurityAppViewID");
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TitleAppViewId).HasColumnName("TitleAppViewID");
            entity.Property(e => e.UpdateFrequencyLkpId).HasColumnName("UpdateFrequencyLkpID");

            entity.HasOne(d => d.AppFormConfig).WithMany(p => p.AppDataObjects)
                .HasForeignKey(d => d.AppFormConfigId)
                .HasConstraintName("FK_AppDataObject_AppFormConfig");

            entity.HasOne(d => d.AppImage).WithMany(p => p.AppDataObjects)
                .HasForeignKey(d => d.AppImageId)
                .HasConstraintName("FK_AppDataObject_AppImage");

            entity.HasOne(d => d.DataSource).WithMany(p => p.AppDataObjects)
                .HasForeignKey(d => d.DataSourceId)
                .HasConstraintName("FK_AppDataObject_DataSource");

            entity.HasOne(d => d.NewAppView).WithMany(p => p.AppDataObjectNewAppViews)
                .HasForeignKey(d => d.NewAppViewId)
                .HasConstraintName("FK_AppDataObject_AppView_New");

            entity.HasOne(d => d.PageAppView).WithMany(p => p.AppDataObjectPageAppViews)
                .HasForeignKey(d => d.PageAppViewId)
                .HasConstraintName("FK_AppDataObject_AppView_Page");

            entity.HasOne(d => d.PriorityLkp).WithMany(p => p.AppDataObjectPriorityLkps)
                .HasForeignKey(d => d.PriorityLkpId)
                .HasConstraintName("FK_AppDataObject_AppLookupCode_Priority");

            entity.HasOne(d => d.RootRegistryTree).WithMany(p => p.AppDataObjects)
                .HasForeignKey(d => d.RootRegistryTreeId)
                .HasConstraintName("FK_AppDataObject_RegistryTree_Root");

            entity.HasOne(d => d.SecurityAppView).WithMany(p => p.AppDataObjectSecurityAppViews)
                .HasForeignKey(d => d.SecurityAppViewId)
                .HasConstraintName("FK_AppDataObject_AppView_Security");

            entity.HasOne(d => d.TitleAppView).WithMany(p => p.AppDataObjectTitleAppViews)
                .HasForeignKey(d => d.TitleAppViewId)
                .HasConstraintName("FK_AppDataObject_AppView_Title");

            entity.HasOne(d => d.UpdateFrequencyLkp).WithMany(p => p.AppDataObjectUpdateFrequencyLkps)
                .HasForeignKey(d => d.UpdateFrequencyLkpId)
                .HasConstraintName("FK_AppDataObject_AppLookupCode_UpdateFrequency");
        });

        modelBuilder.Entity<AppDataObjectPage>(entity =>
        {
            entity.ToTable("AppDataObjectPage");

            entity.HasIndex(e => e.AppFormConfigId, "IX_AppDataObjectPage_AppFormConfigID");

            entity.HasIndex(e => e.AppFormId, "IX_AppDataObjectPage_AppFormID");

            entity.HasIndex(e => e.AppImageId, "IX_AppDataObjectPage_AppImageID");

            entity.HasIndex(e => e.AppViewId, "IX_AppDataObjectPage_AppViewID");

            entity.HasIndex(e => e.ChildAppDataObjectId, "IX_AppDataObjectPage_ChildAppDataObjectID");

            entity.HasIndex(e => e.CodeReference, "IX_AppDataObjectPage_CodeReference");

            entity.HasIndex(e => e.OverviewId, "IX_AppDataObjectPage_OverviewID");

            entity.HasIndex(e => e.ParentAppDataObjectId, "IX_AppDataObjectPage_ParentAppDataObjectID");

            entity.Property(e => e.AppDataObjectPageId)
                .ValueGeneratedNever()
                .HasColumnName("AppDataObjectPageID");
            entity.Property(e => e.AllowCopy).HasDefaultValue(true);
            entity.Property(e => e.AllowPaste).HasDefaultValue(true);
            entity.Property(e => e.AppDataObjectPageGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("AppDataObjectPageGUID");
            entity.Property(e => e.AppDataObjectPageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppFormId).HasColumnName("AppFormID");
            entity.Property(e => e.AppImageId).HasColumnName("AppImageID");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.ChildAppDataObjectId).HasColumnName("ChildAppDataObjectID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleteAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsInsertAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsUpdateAllowed).HasDefaultValue(true);
            entity.Property(e => e.LinkedTable)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.ParentAppDataObjectId).HasColumnName("ParentAppDataObjectID");
            entity.Property(e => e.PriorityLkpId).HasColumnName("PriorityLkpID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.AppFormConfig).WithMany(p => p.AppDataObjectPages)
                .HasForeignKey(d => d.AppFormConfigId)
                .HasConstraintName("FK_AppDataObjectPage_AppFormConfig");

            entity.HasOne(d => d.AppForm).WithMany(p => p.AppDataObjectPages)
                .HasForeignKey(d => d.AppFormId)
                .HasConstraintName("FK_AppDataObjectPage_AppForm");

            entity.HasOne(d => d.AppImage).WithMany(p => p.AppDataObjectPages)
                .HasForeignKey(d => d.AppImageId)
                .HasConstraintName("FK_AppDataObjectPage_AppImage");

            entity.HasOne(d => d.AppView).WithMany(p => p.AppDataObjectPages)
                .HasForeignKey(d => d.AppViewId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_AppDataObjectPage_AppView");

            entity.HasOne(d => d.ChildAppDataObject).WithMany(p => p.AppDataObjectPageChildAppDataObjects)
                .HasForeignKey(d => d.ChildAppDataObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppDataObjectPage_AppDataObject_Child");

            entity.HasOne(d => d.Overview).WithMany(p => p.AppDataObjectPages)
                .HasForeignKey(d => d.OverviewId)
                .HasConstraintName("FK_AppDataObjectPage_Overview");

            entity.HasOne(d => d.ParentAppDataObject).WithMany(p => p.AppDataObjectPageParentAppDataObjects)
                .HasForeignKey(d => d.ParentAppDataObjectId)
                .HasConstraintName("FK_AppDataObjectPage_AppDataObject_Parent");

            entity.HasOne(d => d.PriorityLkp).WithMany(p => p.AppDataObjectPages)
                .HasForeignKey(d => d.PriorityLkpId)
                .HasConstraintName("FK_AppDataObjectPage_AppLookupCode_Priority");
        });

        modelBuilder.Entity<AppDataObjectStatistic>(entity =>
        {
            entity.HasKey(e => e.AppDataObjectStatisticsId);

            entity.HasIndex(e => e.AppDataObjectId, "IX_AppDataObjectStatistics_AppDataObjectID");

            entity.HasIndex(e => e.DateId, "IX_AppDataObjectStatistics_DateID");

            entity.Property(e => e.AppDataObjectStatisticsId).HasColumnName("AppDataObjectStatisticsID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.AppDataObject).WithMany(p => p.AppDataObjectStatistics)
                .HasForeignKey(d => d.AppDataObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppDataObjectStatistics_AppDataObject");
        });

        modelBuilder.Entity<AppDataObjectUser>(entity =>
        {
            entity.ToTable("AppDataObject_User");

            entity.HasIndex(e => e.AppDataObjectId, "IX_AppDataObject_User_AppDataObjectID");

            entity.HasIndex(e => e.ExpireDate, "IX_AppDataObject_User_ExpireDate");

            entity.HasIndex(e => e.SecurityId, "IX_AppDataObject_User_SecurityID");

            entity.HasIndex(e => e.UserId, "IX_AppDataObject_User_UserID");

            entity.HasIndex(e => new { e.UserId, e.AppDataObjectId }, "UNQ_AppDataObject_User").IsUnique();

            entity.Property(e => e.AppDataObjectUserId).HasColumnName("AppDataObjectUserID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AppDataObject).WithMany(p => p.AppDataObjectUsers)
                .HasForeignKey(d => d.AppDataObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppDataObject_User_AppObject");

            entity.HasOne(d => d.Security).WithMany(p => p.AppDataObjectUsers)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppDataObject_User_Security");

            entity.HasOne(d => d.User).WithMany(p => p.AppDataObjectUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AppDataObject_User_User");
        });

        modelBuilder.Entity<AppDataObjectUserIsRead>(entity =>
        {
            entity.ToTable("AppDataObject_User_IsRead");

            entity.HasIndex(e => e.AppDataObjectId, "IX_AppDataObject_User_IsRead_AppDataObjectID");

            entity.HasIndex(e => new { e.AppDataObjectId, e.UserId }, "IX_AppDataObject_User_IsRead_ObjectID_UserID");

            entity.HasIndex(e => new { e.UserId, e.AppDataObjectId }, "UNQ_AppDataObject_User_IsRead").IsUnique();

            entity.Property(e => e.AppDataObjectUserIsReadId).HasColumnName("AppDataObjectUserIsReadID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<AppForm>(entity =>
        {
            entity.ToTable("AppForm");

            entity.HasIndex(e => e.CodeReference, "IX_AppForm_CodeReference");

            entity.Property(e => e.AppFormId)
                .ValueGeneratedNever()
                .HasColumnName("AppFormID");
            entity.Property(e => e.AppFormGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("AppFormGUID");
            entity.Property(e => e.AppFormName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsIframeRequired).HasColumnName("IsIFrameRequired");
            entity.Property(e => e.IsSelectableForAppView).HasDefaultValue(true);
            entity.Property(e => e.IsSelectableForFolder).HasDefaultValue(true);
            entity.Property(e => e.IsSelectableForObjectPage).HasDefaultValue(true);
            entity.Property(e => e.IsSelectableForOverview).HasDefaultValue(true);
            entity.Property(e => e.IsValidForAppDataObjectPage).HasColumnName("IsValidFor_AppDataObjectPage");
            entity.Property(e => e.IsValidForAppFromConfig).HasColumnName("IsValidFor_AppFromConfig");
            entity.Property(e => e.IsValidForAppViewResult).HasColumnName("IsValidFor_AppView_Result");
            entity.Property(e => e.IsValidForFolder).HasColumnName("IsValidFor_Folder");
            entity.Property(e => e.IsValidForOverviewParameter).HasColumnName("IsValidFor_Overview_Parameter");
            entity.Property(e => e.IsValidForOverviewResult).HasColumnName("IsValidFor_Overview_Result");
            entity.Property(e => e.IsValidForSystemSetting).HasColumnName("IsValidFor_SystemSetting");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppFormConfig>(entity =>
        {
            entity.ToTable("AppFormConfig");

            entity.HasIndex(e => e.CodeReference, "IX_AppFormConfig_CodeReference");

            entity.HasIndex(e => e.ExpireDate, "IX_AppFormConfig_ExpireDate");

            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppFormConfigName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppFormId).HasColumnName("AppFormID");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.Hub1AppDataObjectPageId).HasColumnName("Hub1_AppDataObjectPageID");
            entity.Property(e => e.Hub1Detail1AppActionId).HasColumnName("Hub1_Detail1_AppActionID");
            entity.Property(e => e.Hub1Detail1AppDataObjectPageId).HasColumnName("Hub1_Detail1_AppDataObjectPageID");
            entity.Property(e => e.Hub1Detail1Height).HasColumnName("Hub1_Detail1_Height");
            entity.Property(e => e.Hub1Detail1IsVisibilityChangeable)
                .HasDefaultValue(true)
                .HasColumnName("Hub1_Detail1_IsVisibilityChangeable");
            entity.Property(e => e.Hub1Detail1IsVisible)
                .HasDefaultValue(true)
                .HasColumnName("Hub1_Detail1_IsVisible");
            entity.Property(e => e.Hub1Detail1Width).HasColumnName("Hub1_Detail1_Width");
            entity.Property(e => e.Hub1Detail2AppActionId).HasColumnName("Hub1_Detail2_AppActionID");
            entity.Property(e => e.Hub1Detail2AppDataObjectPageId).HasColumnName("Hub1_Detail2_AppDataObjectPageID");
            entity.Property(e => e.Hub1Detail2Height).HasColumnName("Hub1_Detail2_Height");
            entity.Property(e => e.Hub1Detail2IsVisibilityChangeable)
                .HasDefaultValue(true)
                .HasColumnName("Hub1_Detail2_IsVisibilityChangeable");
            entity.Property(e => e.Hub1Detail2IsVisible).HasColumnName("Hub1_Detail2_IsVisible");
            entity.Property(e => e.Hub1Detail2Width).HasColumnName("Hub1_Detail2_Width");
            entity.Property(e => e.Hub1IsHorizontal)
                .HasDefaultValue(true)
                .HasColumnName("Hub1_IsHorizontal");
            entity.Property(e => e.Hub1IsPagesVisibilityChangeable)
                .HasDefaultValue(true)
                .HasColumnName("Hub1_IsPagesVisibilityChangeable");
            entity.Property(e => e.Hub1IsPagesVisible)
                .HasDefaultValue(true)
                .HasColumnName("Hub1_IsPagesVisible");
            entity.Property(e => e.Hub2AppDataObjectPageId).HasColumnName("Hub2_AppDataObjectPageID");
            entity.Property(e => e.Hub2Detail1AppActionId).HasColumnName("Hub2_Detail1_AppActionID");
            entity.Property(e => e.Hub2Detail1AppDataObjectPageId).HasColumnName("Hub2_Detail1_AppDataObjectPageID");
            entity.Property(e => e.Hub2Detail1Height).HasColumnName("Hub2_Detail1_Height");
            entity.Property(e => e.Hub2Detail1IsVisibilityChangeable)
                .HasDefaultValue(true)
                .HasColumnName("Hub2_Detail1_IsVisibilityChangeable");
            entity.Property(e => e.Hub2Detail1IsVisible)
                .HasDefaultValue(true)
                .HasColumnName("Hub2_Detail1_IsVisible");
            entity.Property(e => e.Hub2Detail1Width).HasColumnName("Hub2_Detail1_Width");
            entity.Property(e => e.Hub2Detail2AppActionId).HasColumnName("Hub2_Detail2_AppActionID");
            entity.Property(e => e.Hub2Detail2AppDataObjectPageId).HasColumnName("Hub2_Detail2_AppDataObjectPageID");
            entity.Property(e => e.Hub2Detail2Height).HasColumnName("Hub2_Detail2_Height");
            entity.Property(e => e.Hub2Detail2IsVisibilityChangeable)
                .HasDefaultValue(true)
                .HasColumnName("Hub2_Detail2_IsVisibilityChangeable");
            entity.Property(e => e.Hub2Detail2IsVisible).HasColumnName("Hub2_Detail2_IsVisible");
            entity.Property(e => e.Hub2Detail2Width).HasColumnName("Hub2_Detail2_Width");
            entity.Property(e => e.Hub2IsHorizontal)
                .HasDefaultValue(true)
                .HasColumnName("Hub2_IsHorizontal");
            entity.Property(e => e.Hub2IsPagesVisibilityChangeable)
                .HasDefaultValue(true)
                .HasColumnName("Hub2_IsPagesVisibilityChangeable");
            entity.Property(e => e.Hub2IsPagesVisible)
                .HasDefaultValue(true)
                .HasColumnName("Hub2_IsPagesVisible");
            entity.Property(e => e.MasterHub1Height).HasColumnName("Master_Hub1_Height");
            entity.Property(e => e.MasterHub1IsVisibilityChangeable)
                .HasDefaultValue(true)
                .HasColumnName("Master_Hub1_IsVisibilityChangeable");
            entity.Property(e => e.MasterHub1IsVisible)
                .HasDefaultValue(true)
                .HasColumnName("Master_Hub1_IsVisible");
            entity.Property(e => e.MasterHub1PageLayoutTypeLkpId).HasColumnName("Master_Hub1_PageLayoutTypeLkpId");
            entity.Property(e => e.MasterHub1Width).HasColumnName("Master_Hub1_Width");
            entity.Property(e => e.MasterHub2Height).HasColumnName("Master_Hub2_Height");
            entity.Property(e => e.MasterHub2IsVisibilityChangeable).HasColumnName("Master_Hub2_IsVisibilityChangeable");
            entity.Property(e => e.MasterHub2IsVisible).HasColumnName("Master_Hub2_IsVisible");
            entity.Property(e => e.MasterHub2PageLayoutTypeLkpId).HasColumnName("Master_Hub2_PageLayoutTypeLkpId");
            entity.Property(e => e.MasterHub2Width).HasColumnName("Master_Hub2_Width");
            entity.Property(e => e.MasterIsHorizontalHubs)
                .HasDefaultValue(true)
                .HasColumnName("Master_IsHorizontalHubs");
            entity.Property(e => e.MasterIsHorizontalListVsHub).HasColumnName("Master_IsHorizontalListVsHub");
            entity.Property(e => e.MasterIsListVisibilityChangeable)
                .HasDefaultValue(true)
                .HasColumnName("Master_IsListVisibilityChangeable");
            entity.Property(e => e.MasterIsListVisible).HasColumnName("Master_IsListVisible");
            entity.Property(e => e.MasterIsOverviewSelectionVisible)
                .HasDefaultValue(true)
                .HasColumnName("Master_IsOverviewSelectionVisible");
            entity.Property(e => e.MasterListHeight).HasColumnName("Master_ListHeight");
            entity.Property(e => e.MasterListWidth).HasColumnName("Master_ListWidth");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.RandomId).HasColumnName("RandomID");
            entity.Property(e => e.ReportResultShowParameters)
                .HasDefaultValue(true)
                .HasColumnName("ReportResult_ShowParameters");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AppForm).WithMany(p => p.AppFormConfigs)
                .HasForeignKey(d => d.AppFormId)
                .HasConstraintName("FK_AppFormConfig_AppForm");

            entity.HasOne(d => d.Folder).WithMany(p => p.AppFormConfigs)
                .HasForeignKey(d => d.FolderId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_AppFormConfig_Folder");

            entity.HasOne(d => d.MasterHub1PageLayoutTypeLkp).WithMany(p => p.AppFormConfigMasterHub1PageLayoutTypeLkps)
                .HasForeignKey(d => d.MasterHub1PageLayoutTypeLkpId)
                .HasConstraintName("FK_AppFormConfig_AppLookupCode_Master_Hub1_PageLayoutType");

            entity.HasOne(d => d.MasterHub2PageLayoutTypeLkp).WithMany(p => p.AppFormConfigMasterHub2PageLayoutTypeLkps)
                .HasForeignKey(d => d.MasterHub2PageLayoutTypeLkpId)
                .HasConstraintName("FK_AppFormConfig_AppLookupCode_Master_Hub2_PageLayoutType");

            entity.HasOne(d => d.User).WithMany(p => p.AppFormConfigs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AppFormConfig_User");
        });

        modelBuilder.Entity<AppFunction>(entity =>
        {
            entity.ToTable("AppFunction");

            entity.HasIndex(e => e.AppDataObjectId, "IX_AppFunction_AppDataObjectID");

            entity.HasIndex(e => e.AppFunctionTypeLkpId, "IX_AppFunction_AppFunctionTypeLkpID");

            entity.HasIndex(e => e.CodeReference, "IX_AppFunction_CodeReference");

            entity.HasIndex(e => e.ExecuteAppViewId, "IX_AppFunction_ExecuteAppViewID");

            entity.HasIndex(e => e.FolderId, "IX_AppFunction_FolderID");

            entity.HasIndex(e => e.ParameterAppViewId, "IX_AppFunction_ParameterAppViewID");

            entity.Property(e => e.AppFunctionId)
                .ValueGeneratedNever()
                .HasColumnName("AppFunctionID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppDataObjectPageId).HasColumnName("AppDataObjectPageID");
            entity.Property(e => e.AppFunctionGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("AppFunctionGUID");
            entity.Property(e => e.AppFunctionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppFunctionTypeLkpId).HasColumnName("AppFunctionTypeLkpID");
            entity.Property(e => e.AppImageId).HasColumnName("AppImageID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExecuteAppViewId).HasColumnName("ExecuteAppViewID");
            entity.Property(e => e.ExecutionTypeLkpId).HasColumnName("ExecutionTypeLkpID");
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsSystem).HasDefaultValue(true);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParameterAppViewId).HasColumnName("ParameterAppViewID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.AppDataObject).WithMany(p => p.AppFunctions)
                .HasForeignKey(d => d.AppDataObjectId)
                .HasConstraintName("FK_AppFunction_AppDataObject");

            entity.HasOne(d => d.AppDataObjectPage).WithMany(p => p.AppFunctions)
                .HasForeignKey(d => d.AppDataObjectPageId)
                .HasConstraintName("FK_AppFunction_AppDataObjectPage");

            entity.HasOne(d => d.AppFunctionTypeLkp).WithMany(p => p.AppFunctions)
                .HasForeignKey(d => d.AppFunctionTypeLkpId)
                .HasConstraintName("FK_AppFunction_AppLookupCode_Type");

            entity.HasOne(d => d.AppImage).WithMany(p => p.AppFunctions)
                .HasForeignKey(d => d.AppImageId)
                .HasConstraintName("FK_AppFunction_AppImage");

            entity.HasOne(d => d.ExecuteAppView).WithMany(p => p.AppFunctionExecuteAppViews)
                .HasForeignKey(d => d.ExecuteAppViewId)
                .HasConstraintName("FK_AppFunction_AppView_Execute");

            entity.HasOne(d => d.Folder).WithMany(p => p.AppFunctions)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_AppFunction_Folder");

            entity.HasOne(d => d.ParameterAppView).WithMany(p => p.AppFunctionParameterAppViews)
                .HasForeignKey(d => d.ParameterAppViewId)
                .HasConstraintName("FK_AppFunction_AppView_Parameter");
        });

        modelBuilder.Entity<AppFunctionLog>(entity =>
        {
            entity.ToTable("AppFunctionLog");

            entity.HasIndex(e => e.AppFunctionId, "IX_AppFunctionLog_AppFunctionID");

            entity.HasIndex(e => e.UserId, "IX_AppFunctionLog_UserID");

            entity.Property(e => e.AppFunctionLogId).HasColumnName("AppFunctionLogID");
            entity.Property(e => e.AppFunctionId).HasColumnName("AppFunctionID");
            entity.Property(e => e.ExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OutputId).HasColumnName("OutputID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AppFunction).WithMany(p => p.AppFunctionLogs)
                .HasForeignKey(d => d.AppFunctionId)
                .HasConstraintName("FK_AppFunctionLog_AppFunction");

            entity.HasOne(d => d.User).WithMany(p => p.AppFunctionLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AppFunctionLog_User");
        });

        modelBuilder.Entity<AppFunctionUser>(entity =>
        {
            entity.ToTable("AppFunction_User");

            entity.HasIndex(e => e.AppFunctionId, "IX_AppFunction_User_AppFunctionID");

            entity.HasIndex(e => e.ExpireDate, "IX_AppFunction_User_ExpireDate");

            entity.HasIndex(e => e.SecurityId, "IX_AppFunction_User_SecurityID");

            entity.HasIndex(e => e.UserId, "IX_AppFunction_User_UserID");

            entity.HasIndex(e => new { e.UserId, e.AppFunctionId }, "UNQ_AppFunction_User").IsUnique();

            entity.Property(e => e.AppFunctionUserId).HasColumnName("AppFunctionUserID");
            entity.Property(e => e.AppFunctionId).HasColumnName("AppFunctionID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AppFunction).WithMany(p => p.AppFunctionUsers)
                .HasForeignKey(d => d.AppFunctionId)
                .HasConstraintName("FK_AppFunction_User_AppFunction");

            entity.HasOne(d => d.Security).WithMany(p => p.AppFunctionUsers)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppFunction_User_Security");

            entity.HasOne(d => d.User).WithMany(p => p.AppFunctionUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AppFunction_User_User");
        });

        modelBuilder.Entity<AppFunctionUserIsExecute>(entity =>
        {
            entity.ToTable("AppFunction_User_IsExecute");

            entity.HasIndex(e => e.AppFunctionId, "IX_AppFunction_User_IsExecute_AppFunctionID");

            entity.HasIndex(e => new { e.AppFunctionId, e.UserId }, "IX_AppFunction_User_IsExecute_AppFunctionID_UserID");

            entity.HasIndex(e => new { e.UserId, e.AppFunctionId }, "UNQ_AppFunction_User_IsExecute").IsUnique();

            entity.Property(e => e.AppFunctionUserIsExecuteId).HasColumnName("AppFunctionUserIsExecuteID");
            entity.Property(e => e.AppFunctionId).HasColumnName("AppFunctionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<AppImage>(entity =>
        {
            entity.ToTable("AppImage");

            entity.HasIndex(e => e.AppImageTypeLkpId, "IX_AppImage_AppImageTypeLkpID");

            entity.HasIndex(e => e.CodeReference, "IX_AppImage_CodeReference");

            entity.Property(e => e.AppImageId).HasColumnName("AppImageID");
            entity.Property(e => e.AppImageFileAddress)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.AppImageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppImageTypeLkpId).HasColumnName("AppImageTypeLkpID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsSystem).HasDefaultValue(true);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.AppImageTypeLkp).WithMany(p => p.AppImages)
                .HasForeignKey(d => d.AppImageTypeLkpId)
                .HasConstraintName("FK_AppImage_AppLookupCode_ImageType");
        });

        modelBuilder.Entity<AppJob>(entity =>
        {
            entity.ToTable("AppJob");

            entity.Property(e => e.AppJobId).HasColumnName("AppJobID");
            entity.Property(e => e.AppJobGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("AppJobGUID");
            entity.Property(e => e.AppJobName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.LastExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.LastExecutionGuid).HasColumnName("LastExecutionGUID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.StartAppJobLineId)
                .HasDefaultValue(0)
                .HasColumnName("StartAppJobLineID");
        });

        modelBuilder.Entity<AppJobConfiguration>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ConfigurationFilter).HasMaxLength(255);
            entity.Property(e => e.ConfiguredValue).HasMaxLength(255);
            entity.Property(e => e.ConfiguredValueType).HasMaxLength(20);
            entity.Property(e => e.PackagePath).HasMaxLength(255);
        });

        modelBuilder.Entity<AppJobDependency>(entity =>
        {
            entity.ToTable("AppJobDependency");

            entity.HasIndex(e => e.ChildAppJobId, "IX_EtlTaskDependency_ChildEtlTaskID");

            entity.HasIndex(e => e.ParentAppJobId, "IX_EtlTaskDependency_ParentEtlTaskID");

            entity.HasIndex(e => new { e.ParentAppJobId, e.ChildAppJobId }, "UNQ_AppJobDependency_Parent_Child").IsUnique();

            entity.Property(e => e.AppJobDependencyId).HasColumnName("AppJobDependencyID");
            entity.Property(e => e.ChildAppJobId).HasColumnName("ChildAppJobID");
            entity.Property(e => e.FlowAppJobId).HasColumnName("FlowAppJobID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParentAppJobId).HasColumnName("ParentAppJobID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.ChildAppJob).WithMany(p => p.AppJobDependencyChildAppJobs)
                .HasForeignKey(d => d.ChildAppJobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppJobDependency_AppJob_Child");

            entity.HasOne(d => d.FlowAppJob).WithMany(p => p.AppJobDependencyFlowAppJobs)
                .HasForeignKey(d => d.FlowAppJobId)
                .HasConstraintName("FK_AppJobDependency_AppJob_Flow");

            entity.HasOne(d => d.ParentAppJob).WithMany(p => p.AppJobDependencyParentAppJobs)
                .HasForeignKey(d => d.ParentAppJobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppJobDependency_AppJob_Parent");
        });

        modelBuilder.Entity<AppJobExecutionException>(entity =>
        {
            entity.HasKey(e => e.AppJobExecutionExceptionId).HasName("PK_EtlTaskExecutionException");

            entity.ToTable("AppJobExecutionException");

            entity.Property(e => e.AppJobExecutionExceptionId).HasColumnName("AppJobExecutionExceptionID");
            entity.Property(e => e.AppJobGuid).HasColumnName("AppJobGUID");
            entity.Property(e => e.ExceptionId).HasColumnName("ExceptionID");
            entity.Property(e => e.ExecutionGuid).HasColumnName("ExecutionGUID");
            entity.Property(e => e.RecordId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RecordID");
            entity.Property(e => e.RowValue)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppJobExecutionLog>(entity =>
        {
            entity.ToTable("AppJobExecutionLog");

            entity.Property(e => e.AppJobExecutionLogId).HasColumnName("AppJobExecutionLogID");
            entity.Property(e => e.AppJobGuid).HasColumnName("AppJobGUID");
            entity.Property(e => e.AppJobId).HasColumnName("AppJobID");
            entity.Property(e => e.Computer)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.ExecutionGuid).HasColumnName("ExecutionGUID");
            entity.Property(e => e.MasterExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.MasterExecutionGuid).HasColumnName("MasterExecutionGUID");
            entity.Property(e => e.Operator)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.PackagePath)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.AppJob).WithMany(p => p.AppJobExecutionLogs)
                .HasForeignKey(d => d.AppJobId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_AppJobExecutionLog_AppJob");
        });

        modelBuilder.Entity<AppJobLine>(entity =>
        {
            entity.ToTable("AppJobLine");

            entity.Property(e => e.AppJobLineId).HasColumnName("AppJobLineID");
            entity.Property(e => e.AppJobLineGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("AppJobLineGUID");
            entity.Property(e => e.AppJobLineName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppJobLineTypeLkpId).HasColumnName("AppJobLineTypeLkpID");
            entity.Property(e => e.ChildAppJobId).HasColumnName("ChildAppJobID");
            entity.Property(e => e.Command)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExecuteAppFunctionId).HasColumnName("ExecuteAppFunctionID");
            entity.Property(e => e.ExecuteAppViewId).HasColumnName("ExecuteAppViewID");
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.Location)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OnFailureActionLkpId).HasColumnName("OnFailureActionLkpID");
            entity.Property(e => e.OnSuccessActionLkpId).HasColumnName("OnSuccessActionLkpID");
            entity.Property(e => e.ParentAppJobId).HasColumnName("ParentAppJobID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

            entity.HasOne(d => d.AppJobLineTypeLkp).WithMany(p => p.AppJobLines)
                .HasForeignKey(d => d.AppJobLineTypeLkpId)
                .HasConstraintName("FK_AppJobLine_AppLookupCode_AppJobLineType");

            entity.HasOne(d => d.ChildAppJob).WithMany(p => p.AppJobLineChildAppJobs)
                .HasForeignKey(d => d.ChildAppJobId)
                .HasConstraintName("FK_AppJobLine_AppJob_Child");

            entity.HasOne(d => d.ExecuteAppFunction).WithMany(p => p.AppJobLines)
                .HasForeignKey(d => d.ExecuteAppFunctionId)
                .HasConstraintName("FK_AppJobLine_AppFunction_Execute");

            entity.HasOne(d => d.ExecuteAppView).WithMany(p => p.AppJobLines)
                .HasForeignKey(d => d.ExecuteAppViewId)
                .HasConstraintName("FK_AppJobLine_AppView_Execute");

            entity.HasOne(d => d.ParentAppJob).WithMany(p => p.AppJobLineParentAppJobs)
                .HasForeignKey(d => d.ParentAppJobId)
                .HasConstraintName("FK_AppJobLine_AppJob");

            entity.HasOne(d => d.Subscription).WithMany(p => p.AppJobLines)
                .HasForeignKey(d => d.SubscriptionId)
                .HasConstraintName("FK_AppJobLine_Subscription");
        });

        modelBuilder.Entity<AppLookupCode>(entity =>
        {
            entity.ToTable("AppLookupCode");

            entity.HasIndex(e => e.CodeReference, "IX_AppLookupCode_CodeReference");

            entity.HasIndex(e => e.LookupCodeId, "IX_AppLookupCode_LookupCodeID");

            entity.HasIndex(e => e.LookupCodeTable, "IX_AppLookupCode_LookupCodeTable");

            entity.Property(e => e.AppLookupCodeId)
                .ValueGeneratedNever()
                .HasColumnName("AppLookupCodeID");
            entity.Property(e => e.AppLookupCodeGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("AppLookupCodeGUID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Configurations)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.LookupCodeId).HasColumnName("LookupCodeID");
            entity.Property(e => e.LookupCodeTable)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LookupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppQuickLaunch>(entity =>
        {
            entity.ToTable("AppQuickLaunch");

            entity.Property(e => e.AppQuickLaunchId)
                .ValueGeneratedNever()
                .HasColumnName("AppQuickLaunchID");
            entity.Property(e => e.AppQuickLaunchName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppRowReference>(entity =>
        {
            entity.ToTable("AppRowReference");

            entity.HasIndex(e => e.AppDataObjectId, "IX_AppRowReference_AppDataObjectID");

            entity.HasIndex(e => e.AppFormConfigId, "IX_AppRowReference_AppFormConfigID");

            entity.HasIndex(e => e.AppShortCutId, "IX_AppRowReference_AppShortCutID");

            entity.Property(e => e.AppRowReferenceId).HasColumnName("AppRowReferenceID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppShortCutId).HasColumnName("AppShortCutID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.RowReference)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.AppDataObject).WithMany(p => p.AppRowReferences)
                .HasForeignKey(d => d.AppDataObjectId)
                .HasConstraintName("FK_AppRowReference_AppDataObject");

            entity.HasOne(d => d.AppFormConfig).WithMany(p => p.AppRowReferences)
                .HasForeignKey(d => d.AppFormConfigId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AppRowReference_AppFormConfig");

            entity.HasOne(d => d.AppShortCut).WithMany(p => p.AppRowReferences)
                .HasForeignKey(d => d.AppShortCutId)
                .HasConstraintName("FK_AppRowReference_AppShortCut");
        });

        modelBuilder.Entity<AppShortCut>(entity =>
        {
            entity.ToTable("AppShortCut");

            entity.HasIndex(e => e.AppFormConfigId, "IX_AppShortCut_AppFormConfigID");

            entity.HasIndex(e => e.AppImageId, "IX_AppShortCut_AppImageID");

            entity.HasIndex(e => e.FolderId, "IX_AppShortCut_FolderID");

            entity.HasIndex(e => e.UserId, "IX_AppShortCut_UserID");

            entity.Property(e => e.AppShortCutId).HasColumnName("AppShortCutID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppImageId).HasColumnName("AppImageID");
            entity.Property(e => e.AppShortCutName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RowReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AppFormConfig).WithMany(p => p.AppShortCuts)
                .HasForeignKey(d => d.AppFormConfigId)
                .HasConstraintName("FK_AppShortCut_AppFormConfig");

            entity.HasOne(d => d.AppImage).WithMany(p => p.AppShortCuts)
                .HasForeignKey(d => d.AppImageId)
                .HasConstraintName("FK_AppShortCut_AppImage");

            entity.HasOne(d => d.Folder).WithMany(p => p.AppShortCuts)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_AppShortCut_Folder");

            entity.HasOne(d => d.User).WithMany(p => p.AppShortCuts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AppShortCut_User");
        });

        modelBuilder.Entity<AppView>(entity =>
        {
            entity.ToTable("AppView");

            entity.HasIndex(e => e.AppDataObjectId, "IX_AppView_AppDataObjectID");

            entity.HasIndex(e => e.AppViewTypeLkpId, "IX_AppView_AppViewTypeLkpID");

            entity.HasIndex(e => e.CodeReference, "IX_AppView_CodeReference");

            entity.HasIndex(e => e.LayoutTypeLkpId, "IX_AppView_LayoutTypeLkpID");

            entity.HasIndex(e => e.ParameterAppViewId, "IX_AppView_ParameterAppViewID");

            entity.HasIndex(e => e.ResultAppFormId, "IX_AppView_ResultAppFormID");

            entity.Property(e => e.AppViewId)
                .ValueGeneratedNever()
                .HasColumnName("AppViewID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppViewGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("AppViewGUID");
            entity.Property(e => e.AppViewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppViewTypeLkpId).HasColumnName("AppViewTypeLkpID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorrectionAppFunctionId).HasColumnName("CorrectionAppFunctionID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsSelectableAsOverview).HasDefaultValue(true);
            entity.Property(e => e.LayoutTypeLkpId).HasColumnName("LayoutTypeLkpID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParameterAppViewId).HasColumnName("ParameterAppViewID");
            entity.Property(e => e.ParameterFields)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PriorityLkpId).HasColumnName("PriorityLkpID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ResultAppFormId).HasColumnName("ResultAppFormID");
            entity.Property(e => e.SearchFields)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ShowPaging).HasDefaultValue(true);
            entity.Property(e => e.ShowRowLink).HasDefaultValue(true);
            entity.Property(e => e.ShowRowSelector).HasDefaultValue(true);
            entity.Property(e => e.SourceCommand)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SrcCmdCompiledForSelect)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SrcCmdCompiledWithFields)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.HasOne(d => d.AppDataObject).WithMany(p => p.AppViews)
                .HasForeignKey(d => d.AppDataObjectId)
                .HasConstraintName("FK_AppView_AppObject");

            entity.HasOne(d => d.AppViewTypeLkp).WithMany(p => p.AppViewAppViewTypeLkps)
                .HasForeignKey(d => d.AppViewTypeLkpId)
                .HasConstraintName("FK_AppView_AppLookupCode_AppViewType");

            entity.HasOne(d => d.CorrectionAppFunction).WithMany(p => p.AppViews)
                .HasForeignKey(d => d.CorrectionAppFunctionId)
                .HasConstraintName("FK_AppView_AppFunction_Correction");

            entity.HasOne(d => d.LayoutTypeLkp).WithMany(p => p.AppViewLayoutTypeLkps)
                .HasForeignKey(d => d.LayoutTypeLkpId)
                .HasConstraintName("FK_AppView_AppLookupCode_Layout");

            entity.HasOne(d => d.ParameterAppView).WithMany(p => p.InverseParameterAppView)
                .HasForeignKey(d => d.ParameterAppViewId)
                .HasConstraintName("FK_AppView_AppView");

            entity.HasOne(d => d.PriorityLkp).WithMany(p => p.AppViewPriorityLkps)
                .HasForeignKey(d => d.PriorityLkpId)
                .HasConstraintName("FK_AppView_AppLookupCode_Priority");

            entity.HasOne(d => d.ResultAppForm).WithMany(p => p.AppViews)
                .HasForeignKey(d => d.ResultAppFormId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_AppView_AppForm_Result");
        });

        modelBuilder.Entity<AppViewDependency>(entity =>
        {
            entity.ToTable("AppViewDependency");

            entity.HasIndex(e => e.ChildAppViewId, "IX_AppViewDependency_ChildAppViewID");

            entity.HasIndex(e => e.ParentAppViewId, "IX_AppViewDependency_ParentAppViewID");

            entity.HasIndex(e => new { e.ParentAppViewId, e.ChildAppViewId }, "UNQ_AppViewDependency_Parent_Child").IsUnique();

            entity.Property(e => e.AppViewDependencyId)
                .ValueGeneratedNever()
                .HasColumnName("AppViewDependencyID");
            entity.Property(e => e.ChildAppDataObjectId).HasColumnName("ChildAppDataObjectID");
            entity.Property(e => e.ChildAppViewId).HasColumnName("ChildAppViewID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParentAppDataObjectId).HasColumnName("ParentAppDataObjectID");
            entity.Property(e => e.ParentAppViewId).HasColumnName("ParentAppViewID");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.ChildAppView).WithMany(p => p.AppViewDependencyChildAppViews)
                .HasForeignKey(d => d.ChildAppViewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppViewDependency_AppView");

            entity.HasOne(d => d.ParentAppView).WithMany(p => p.AppViewDependencyParentAppViews)
                .HasForeignKey(d => d.ParentAppViewId)
                .HasConstraintName("FK_AppViewDependency_AppView_Parent");
        });

        modelBuilder.Entity<AppViewField>(entity =>
        {
            entity.ToTable("AppViewField");

            entity.HasIndex(e => e.ChildAppViewId, "IX_AppViewField_ChildAppViewID");

            entity.HasIndex(e => e.ControlTypeLkpId, "IX_AppViewField_ControlTypeLkpID");

            entity.HasIndex(e => e.DataTypeLkpId, "IX_AppViewField_DataTypeLkpID");

            entity.HasIndex(e => e.ParentAppViewId, "IX_AppViewField_ParentAppViewID");

            entity.Property(e => e.AppViewFieldId)
                .ValueGeneratedNever()
                .HasColumnName("AppViewFieldID");
            entity.Property(e => e.AppViewFieldName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ChildAppViewId).HasColumnName("ChildAppViewID");
            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.ControlTypeLkpId).HasColumnName("ControlTypeLkpID");
            entity.Property(e => e.CummulativeHeight).HasColumnType("decimal(10, 6)");
            entity.Property(e => e.DataTypeLkpId).HasColumnName("DataTypeLkpID");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DefaultValueRefName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FunctionReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsDefaultOverwritableBak)
                .HasDefaultValue(true)
                .HasColumnName("IsDefaultOverwritable_bak");
            entity.Property(e => e.IsEmptyValueAllowedBak)
                .HasDefaultValue(true)
                .HasColumnName("IsEmptyValueAllowed_bak");
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsNullValueAllowed).HasDefaultValue(true);
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.NavigationReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ParentAppViewId).HasColumnName("ParentAppViewID");
            entity.Property(e => e.RelativeWidth).HasColumnType("decimal(10, 6)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SourceFieldName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ValueList)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.ChildAppView).WithMany(p => p.AppViewFieldChildAppViews)
                .HasForeignKey(d => d.ChildAppViewId)
                .HasConstraintName("FK_AppViewField_AppView_Child");

            entity.HasOne(d => d.ControlTypeLkp).WithMany(p => p.AppViewFieldControlTypeLkps)
                .HasForeignKey(d => d.ControlTypeLkpId)
                .HasConstraintName("FK_AppViewField_AppLookupCode_ControlTypeID");

            entity.HasOne(d => d.DataTypeLkp).WithMany(p => p.AppViewFieldDataTypeLkps)
                .HasForeignKey(d => d.DataTypeLkpId)
                .HasConstraintName("FK_AppViewField_AppLookupCode_DataTypeID");

            entity.HasOne(d => d.ParentAppView).WithMany(p => p.AppViewFieldParentAppViews)
                .HasForeignKey(d => d.ParentAppViewId)
                .HasConstraintName("FK_AppViewField_AppView_Parent");
        });

        modelBuilder.Entity<AppViewFieldDependency>(entity =>
        {
            entity.ToTable("AppViewFieldDependency");

            entity.HasIndex(e => e.ChildAppViewFieldId, "IX_AppViewFieldDependency_ChildAppViewFieldID");

            entity.HasIndex(e => e.ParentAppViewFieldId, "IX_AppViewFieldDependency_ParentAppViewFieldID");

            entity.HasIndex(e => new { e.ParentAppViewFieldId, e.ChildAppViewFieldId }, "UNQ_AppViewFieldDependency_Parent_Child").IsUnique();

            entity.Property(e => e.AppViewFieldDependencyId).HasColumnName("AppViewFieldDependencyID");
            entity.Property(e => e.ChildAppViewFieldId).HasColumnName("ChildAppViewFieldID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParentAppViewFieldId).HasColumnName("ParentAppViewFieldID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.ChildAppViewField).WithMany(p => p.AppViewFieldDependencyChildAppViewFields)
                .HasForeignKey(d => d.ChildAppViewFieldId)
                .HasConstraintName("FK_AppViewFieldDependency_AppViewField_Child");

            entity.HasOne(d => d.ParentAppViewField).WithMany(p => p.AppViewFieldDependencyParentAppViewFields)
                .HasForeignKey(d => d.ParentAppViewFieldId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AppViewFieldDependency_AppViewField_Parent");
        });

        modelBuilder.Entity<AppViewFieldUser>(entity =>
        {
            entity.ToTable("AppViewField_User");

            entity.HasIndex(e => e.AppViewFieldId, "IX_AppViewField_User_AppViewFieldID");

            entity.HasIndex(e => new { e.UserId, e.DefaultValueRefName }, "IX_AppViewField_User_Ref").IsUnique();

            entity.Property(e => e.AppViewFieldUserId).HasColumnName("AppViewFieldUserID");
            entity.Property(e => e.AppViewFieldId).HasColumnName("AppViewFieldID");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DefaultValueRefName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AppViewField).WithMany(p => p.AppViewFieldUsers)
                .HasForeignKey(d => d.AppViewFieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppViewField_User_AppViewField");

            entity.HasOne(d => d.User).WithMany(p => p.AppViewFieldUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AppViewField_User_User");
        });

        modelBuilder.Entity<AppViewStatistic>(entity =>
        {
            entity.HasKey(e => e.AppViewStatisticsId);

            entity.HasIndex(e => e.AppViewId, "IX_AppViewStatistics_AppViewID");

            entity.Property(e => e.AppViewStatisticsId).HasColumnName("AppViewStatisticsID");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.AppView).WithMany(p => p.AppViewStatistics)
                .HasForeignKey(d => d.AppViewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppViewStatistics_AppView");
        });

        modelBuilder.Entity<ContractType>(entity =>
        {
            entity.ToTable("ContractType");

            entity.Property(e => e.ContractTypeId).HasColumnName("ContractTypeID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ContractTypeCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ContractTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CostCentre>(entity =>
        {
            entity.ToTable("CostCentre");

            entity.Property(e => e.CostCentreId)
                .ValueGeneratedNever()
                .HasColumnName("CostCentreID");
            entity.Property(e => e.CostCentreCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CostCentreName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.HasIndex(e => e.AccountManagerUserId, "IX_Customer_AccountManagerUserID");

            entity.HasIndex(e => e.CompleteCid, "IX_Customer_Complete_CID");

            entity.HasIndex(e => e.CustomerLevelId, "IX_Customer_CustomerLevelID");

            entity.HasIndex(e => e.CustomerOrganisationId, "IX_Customer_CustomerOrganisationID");

            entity.HasIndex(e => e.L1Cid, "IX_Customer_L1_CID");

            entity.HasIndex(e => e.L2Cid, "IX_Customer_L2_CID");

            entity.HasIndex(e => e.L3Cid, "IX_Customer_L3_CID");

            entity.HasIndex(e => e.L4Cid, "IX_Customer_L4_CID");

            entity.HasIndex(e => e.L5Cid, "IX_Customer_L5_CID");

            entity.HasIndex(e => e.L6Cid, "IX_Customer_L6_CID");

            entity.HasIndex(e => e.L7Cid, "IX_Customer_L7_CID");

            entity.HasIndex(e => e.L8Cid, "IX_Customer_L8_CID");

            entity.HasIndex(e => e.ParentCustomerId, "IX_Customer_ParentCustomerID");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.AccountManagerUserId).HasColumnName("AccountManagerUserID");
            entity.Property(e => e.CompleteCid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Complete_CID");
            entity.Property(e => e.CompleteCustomerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CompleteCustomerId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CompleteCustomerID");
            entity.Property(e => e.CompleteCustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CustomerLevelId).HasColumnName("CustomerLevelID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOrganisationId).HasColumnName("CustomerOrganisationID");
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.L1Cid).HasColumnName("L1_CID");
            entity.Property(e => e.L2Cid).HasColumnName("L2_CID");
            entity.Property(e => e.L3Cid).HasColumnName("L3_CID");
            entity.Property(e => e.L4Cid).HasColumnName("L4_CID");
            entity.Property(e => e.L5Cid).HasColumnName("L5_CID");
            entity.Property(e => e.L6Cid).HasColumnName("L6_CID");
            entity.Property(e => e.L7Cid).HasColumnName("L7_CID");
            entity.Property(e => e.L8Cid).HasColumnName("L8_CID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParentCustomerId).HasColumnName("ParentCustomerID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.CustomerLevel).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CustomerLevelId)
                .HasConstraintName("FK_Customer_CustomerLevel");

            entity.HasOne(d => d.CustomerOrganisation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.CustomerOrganisationId)
                .HasConstraintName("FK_Customer_CustomerOrganisation");

            entity.HasOne(d => d.ParentCustomer).WithMany(p => p.InverseParentCustomer)
                .HasForeignKey(d => d.ParentCustomerId)
                .HasConstraintName("FK_Customer_Customer");

            entity.HasMany(d => d.Organisations).WithMany(p => p.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerOrganisation",
                    r => r.HasOne<Organisation>().WithMany()
                        .HasForeignKey("OrganisationId")
                        .HasConstraintName("FK_Customer_Organisation_Organisation"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Customer_Organisation_Customer"),
                    j =>
                    {
                        j.HasKey("CustomerId", "OrganisationId");
                        j.ToTable("Customer_Organisation");
                        j.HasIndex(new[] { "CustomerId" }, "IX_Customer_Organisation_CustomerID");
                        j.HasIndex(new[] { "OrganisationId" }, "IX_Customer_Organisation_OrganisationID");
                        j.IndexerProperty<int>("CustomerId").HasColumnName("CustomerID");
                        j.IndexerProperty<int>("OrganisationId").HasColumnName("OrganisationID");
                    });
        });

        modelBuilder.Entity<CustomerLevel>(entity =>
        {
            entity.ToTable("CustomerLevel");

            entity.Property(e => e.CustomerLevelId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerLevelID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerLevelCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CustomerLevelName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerOrganisation1>(entity =>
        {
            entity.HasKey(e => e.CustomerOrganisationId);

            entity.ToTable("CustomerOrganisation");

            entity.HasIndex(e => e.CustomerOrganisationLevelId, "IX_CustomerOrganisation_LevelID");

            entity.HasIndex(e => e.ParentCustomerOrganisationId, "IX_CustomerOrganisation_ParentCustomerOrganisationID");

            entity.HasIndex(e => e.RootCustomerId, "IX_CustomerOrganisation_RootCustomerID");

            entity.Property(e => e.CustomerOrganisationId).HasColumnName("CustomerOrganisationID");
            entity.Property(e => e.CustomerOrganisationCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOrganisationLevelId).HasColumnName("CustomerOrganisationLevelID");
            entity.Property(e => e.CustomerOrganisationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParentCustomerOrganisationId).HasColumnName("ParentCustomerOrganisationID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RootCustomerId).HasColumnName("RootCustomerID");

            entity.HasOne(d => d.CustomerOrganisationLevel).WithMany(p => p.CustomerOrganisation1s)
                .HasForeignKey(d => d.CustomerOrganisationLevelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_CustomerOrganisation_CustomerOrganisationLevel");

            entity.HasOne(d => d.ParentCustomerOrganisation).WithMany(p => p.InverseParentCustomerOrganisation)
                .HasForeignKey(d => d.ParentCustomerOrganisationId)
                .HasConstraintName("FK_CustomerOrganisation_CustomerOrganisation");

            entity.HasOne(d => d.RootCustomer).WithMany(p => p.CustomerOrganisation1s)
                .HasForeignKey(d => d.RootCustomerId)
                .HasConstraintName("FK_CustomerOrganisation_Customer");
        });

        modelBuilder.Entity<CustomerOrganisationLevel>(entity =>
        {
            entity.ToTable("CustomerOrganisationLevel");

            entity.Property(e => e.CustomerOrganisationLevelId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerOrganisationLevelID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOrganisationLevelCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CustomerOrganisationLevelName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerUser>(entity =>
        {
            entity.ToTable("Customer_User");

            entity.HasIndex(e => e.CustomerId, "IX_Customer_User_CustomerID");

            entity.HasIndex(e => e.ExpireDate, "IX_Customer_User_ExpireDate");

            entity.HasIndex(e => e.SecurityId, "IX_Customer_User_SecurityID");

            entity.HasIndex(e => e.UserId, "IX_Customer_User_UserID");

            entity.HasIndex(e => new { e.UserId, e.CustomerId }, "UNQ_Customer_User").IsUnique();

            entity.Property(e => e.CustomerUserId).HasColumnName("CustomerUserID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerUsers)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Customer_User_Customer");

            entity.HasOne(d => d.Security).WithMany(p => p.CustomerUsers)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_User_Security");

            entity.HasOne(d => d.User).WithMany(p => p.CustomerUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Customer_User_User");
        });

        modelBuilder.Entity<CustomerUserIsRead>(entity =>
        {
            entity.ToTable("Customer_User_IsRead");

            entity.HasIndex(e => e.CustomerId, "IX_Customer_User_IsRead_CustomerID");

            entity.HasIndex(e => new { e.CustomerId, e.UserId }, "IX_Customer_User_IsRead_CustomerID_UserID");

            entity.HasIndex(e => new { e.UserId, e.CustomerId }, "UNQ_Customer_User_IsRead").IsUnique();

            entity.Property(e => e.CustomerUserIsReadId).HasColumnName("CustomerUserIsReadID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<DataSource>(entity =>
        {
            entity.ToTable("DataSource");

            entity.Property(e => e.DataSourceId)
                .ValueGeneratedNever()
                .HasColumnName("DataSourceID");
            entity.Property(e => e.ConnectionString)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.DataSourceName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Prompt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(128)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Database>(entity =>
        {
            entity.ToTable("Database");

            entity.HasIndex(e => e.DataSourceId, "IX_Database_DataSourceID");

            entity.Property(e => e.DatabaseId)
                .ValueGeneratedNever()
                .HasColumnName("DatabaseID");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.DataSource).WithMany(p => p.Databases)
                .HasForeignKey(d => d.DataSourceId)
                .HasConstraintName("FK_Database_DataSource");
        });

        modelBuilder.Entity<DateSetting>(entity =>
        {
            entity.HasKey(e => e.DateSettingId).HasName("PK_ApprovalDate");

            entity.ToTable("DateSetting");

            entity.Property(e => e.DateSettingId).HasColumnName("DateSettingID");
            entity.Property(e => e.ApprovalDateId).HasColumnName("ApprovalDateID");
            entity.Property(e => e.ApprovalDateValue).HasColumnType("datetime");
            entity.Property(e => e.ApprovalMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ExportAppViewId).HasColumnName("ExportAppViewID");
            entity.Property(e => e.FirstDayOfMonthDateId).HasColumnName("FirstDayOfMonth_DateID");
            entity.Property(e => e.FirstDayOfP444DateId).HasColumnName("FirstDayOfP444_DateID");
            entity.Property(e => e.FirstDayOfP445DateId).HasColumnName("FirstDayOfP445_DateID");
            entity.Property(e => e.FirstDayOfQ445DateId).HasColumnName("FirstDayOfQ445_DateID");
            entity.Property(e => e.FirstDayOfQuarterDateId).HasColumnName("FirstDayOfQuarter_DateID");
            entity.Property(e => e.FirstDayOfWeekDateId).HasColumnName("FirstDayOfWeek_DateID");
            entity.Property(e => e.FirstDayOfYearDateId).HasColumnName("FirstDayOfYear_DateID");
            entity.Property(e => e.FirstDayOfYearOfWeekDateId).HasColumnName("FirstDayOfYearOfWeek_DateID");
        });

        modelBuilder.Entity<DateValue>(entity =>
        {
            entity.HasKey(e => e.DateId);

            entity.ToTable("DateValue");

            entity.HasIndex(e => new { e.Period445Name, e.DateId }, "IX_DateValue_Period445Name_DateID");

            entity.HasIndex(e => new { e.Quater445Number, e.DateId }, "IX_DateValue_Quater445Number_DateID");

            entity.HasIndex(e => new { e.WeekNumberOfYear, e.DateId }, "IX_DateValue_WeekNumberOfYear_DateID");

            entity.HasIndex(e => new { e.WeekNumber, e.DateId }, "IX_DateValue_WeekNumber_DateID");

            entity.HasIndex(e => new { e.YearOfWeekNumber, e.DateId }, "IX_DateValue_YearOfWeekNumber_DateID");

            entity.HasIndex(e => new { e.Year, e.DateId }, "IX_DateValue_Year_DateID");

            entity.Property(e => e.DateId).ValueGeneratedNever();
            entity.Property(e => e.BookDateId).HasColumnName("BookDateID");
            entity.Property(e => e.CalendarMonthAllNrOfDays).HasColumnName("CalendarMonth_AllNrOfDays");
            entity.Property(e => e.CalendarMonthFirstAllDayId).HasColumnName("CalendarMonth_First_AllDayID");
            entity.Property(e => e.CalendarMonthFirstHoliDayId).HasColumnName("CalendarMonth_First_HoliDayID");
            entity.Property(e => e.CalendarMonthFirstNonWorkingDayId).HasColumnName("CalendarMonth_First_NonWorkingDayID");
            entity.Property(e => e.CalendarMonthFirstWeekDayId).HasColumnName("CalendarMonth_First_WeekDayID");
            entity.Property(e => e.CalendarMonthFirstWeekendDayId).HasColumnName("CalendarMonth_First_WeekendDayID");
            entity.Property(e => e.CalendarMonthFirstWorkingDayId).HasColumnName("CalendarMonth_First_WorkingDayID");
            entity.Property(e => e.CalendarMonthHoliNrOfDays).HasColumnName("CalendarMonth_HoliNrOfDays");
            entity.Property(e => e.CalendarMonthLastAllDayId).HasColumnName("CalendarMonth_Last_AllDayID");
            entity.Property(e => e.CalendarMonthLastHoliDayId).HasColumnName("CalendarMonth_Last_HoliDayID");
            entity.Property(e => e.CalendarMonthLastNonWorkingDayId).HasColumnName("CalendarMonth_Last_NonWorkingDayID");
            entity.Property(e => e.CalendarMonthLastWeekDayId).HasColumnName("CalendarMonth_Last_WeekDayID");
            entity.Property(e => e.CalendarMonthLastWeekendDayId).HasColumnName("CalendarMonth_Last_WeekendDayID");
            entity.Property(e => e.CalendarMonthLastWorkingDayId).HasColumnName("CalendarMonth_Last_WorkingDayID");
            entity.Property(e => e.CalendarMonthNonWorkingNrOfDays).HasColumnName("CalendarMonth_NonWorkingNrOfDays");
            entity.Property(e => e.CalendarMonthWeekNrOfDays).HasColumnName("CalendarMonth_WeekNrOfDays");
            entity.Property(e => e.CalendarMonthWeekendNrOfDays).HasColumnName("CalendarMonth_WeekendNrOfDays");
            entity.Property(e => e.CalendarMonthWorkingNrOfDays).HasColumnName("CalendarMonth_WorkingNrOfDays");
            entity.Property(e => e.CalendarQuarterAllNrOfDays).HasColumnName("CalendarQuarter_AllNrOfDays");
            entity.Property(e => e.CalendarQuarterFirstAllDayId).HasColumnName("CalendarQuarter_First_AllDayID");
            entity.Property(e => e.CalendarQuarterFirstHoliDayId).HasColumnName("CalendarQuarter_First_HoliDayID");
            entity.Property(e => e.CalendarQuarterFirstNonWorkingDayId).HasColumnName("CalendarQuarter_First_NonWorkingDayID");
            entity.Property(e => e.CalendarQuarterFirstWeekDayId).HasColumnName("CalendarQuarter_First_WeekDayID");
            entity.Property(e => e.CalendarQuarterFirstWeekendDayId).HasColumnName("CalendarQuarter_First_WeekendDayID");
            entity.Property(e => e.CalendarQuarterFirstWorkingDayId).HasColumnName("CalendarQuarter_First_WorkingDayID");
            entity.Property(e => e.CalendarQuarterHoliNrOfDays).HasColumnName("CalendarQuarter_HoliNrOfDays");
            entity.Property(e => e.CalendarQuarterLastAllDayId).HasColumnName("CalendarQuarter_Last_AllDayID");
            entity.Property(e => e.CalendarQuarterLastHoliDayId).HasColumnName("CalendarQuarter_Last_HoliDayID");
            entity.Property(e => e.CalendarQuarterLastNonWorkingDayId).HasColumnName("CalendarQuarter_Last_NonWorkingDayID");
            entity.Property(e => e.CalendarQuarterLastWeekDayId).HasColumnName("CalendarQuarter_Last_WeekDayID");
            entity.Property(e => e.CalendarQuarterLastWeekendDayId).HasColumnName("CalendarQuarter_Last_WeekendDayID");
            entity.Property(e => e.CalendarQuarterLastWorkingDayId).HasColumnName("CalendarQuarter_Last_WorkingDayID");
            entity.Property(e => e.CalendarQuarterNonWorkingNrOfDays).HasColumnName("CalendarQuarter_NonWorkingNrOfDays");
            entity.Property(e => e.CalendarQuarterWeekNrOfDays).HasColumnName("CalendarQuarter_WeekNrOfDays");
            entity.Property(e => e.CalendarQuarterWeekendNrOfDays).HasColumnName("CalendarQuarter_WeekendNrOfDays");
            entity.Property(e => e.CalendarQuarterWorkingNrOfDays).HasColumnName("CalendarQuarter_WorkingNrOfDays");
            entity.Property(e => e.CalendarYearAllNrOfDays).HasColumnName("CalendarYear_AllNrOfDays");
            entity.Property(e => e.CalendarYearFirstAllDayId).HasColumnName("CalendarYear_First_AllDayID");
            entity.Property(e => e.CalendarYearFirstHoliDayId).HasColumnName("CalendarYear_First_HoliDayID");
            entity.Property(e => e.CalendarYearFirstNonWorkingDayId).HasColumnName("CalendarYear_First_NonWorkingDayID");
            entity.Property(e => e.CalendarYearFirstWeekDayId).HasColumnName("CalendarYear_First_WeekDayID");
            entity.Property(e => e.CalendarYearFirstWeekendDayId).HasColumnName("CalendarYear_First_WeekendDayID");
            entity.Property(e => e.CalendarYearFirstWorkingDayId).HasColumnName("CalendarYear_First_WorkingDayID");
            entity.Property(e => e.CalendarYearHoliNrOfDays).HasColumnName("CalendarYear_HoliNrOfDays");
            entity.Property(e => e.CalendarYearLastAllDayId).HasColumnName("CalendarYear_Last_AllDayID");
            entity.Property(e => e.CalendarYearLastHoliDayId).HasColumnName("CalendarYear_Last_HoliDayID");
            entity.Property(e => e.CalendarYearLastNonWorkingDayId).HasColumnName("CalendarYear_Last_NonWorkingDayID");
            entity.Property(e => e.CalendarYearLastWeekDayId).HasColumnName("CalendarYear_Last_WeekDayID");
            entity.Property(e => e.CalendarYearLastWeekendDayId).HasColumnName("CalendarYear_Last_WeekendDayID");
            entity.Property(e => e.CalendarYearLastWorkingDayId).HasColumnName("CalendarYear_Last_WorkingDayID");
            entity.Property(e => e.CalendarYearNonWorkingNrOfDays).HasColumnName("CalendarYear_NonWorkingNrOfDays");
            entity.Property(e => e.CalendarYearWeekNrOfDays).HasColumnName("CalendarYear_WeekNrOfDays");
            entity.Property(e => e.CalendarYearWeekendNrOfDays).HasColumnName("CalendarYear_WeekendNrOfDays");
            entity.Property(e => e.CalendarYearWorkingNrOfDays).HasColumnName("CalendarYear_WorkingNrOfDays");
            entity.Property(e => e.DateName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.DateValue1)
                .HasColumnType("datetime")
                .HasColumnName("DateValue");
            entity.Property(e => e.DayName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Event)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FiscalPeriodCode)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.IsDataLoadedCorrectly).HasDefaultValue(false);
            entity.Property(e => e.IsSelectable).HasDefaultValue(false);
            entity.Property(e => e.MonthCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Period444Name)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Period445Name)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Quater445Code)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.QuaterCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.QuaterName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.WeekAllNrOfDays).HasColumnName("Week_AllNrOfDays");
            entity.Property(e => e.WeekFirstAllDayId).HasColumnName("Week_First_AllDayID");
            entity.Property(e => e.WeekFirstHoliDayId).HasColumnName("Week_First_HoliDayID");
            entity.Property(e => e.WeekFirstNonWorkingDayId).HasColumnName("Week_First_NonWorkingDayID");
            entity.Property(e => e.WeekFirstWeekDayId).HasColumnName("Week_First_WeekDayID");
            entity.Property(e => e.WeekFirstWeekendDayId).HasColumnName("Week_First_WeekendDayID");
            entity.Property(e => e.WeekFirstWorkingDayId).HasColumnName("Week_First_WorkingDayID");
            entity.Property(e => e.WeekHoliNrOfDays).HasColumnName("Week_HoliNrOfDays");
            entity.Property(e => e.WeekLastAllDayId).HasColumnName("Week_Last_AllDayID");
            entity.Property(e => e.WeekLastHoliDayId).HasColumnName("Week_Last_HoliDayID");
            entity.Property(e => e.WeekLastNonWorkingDayId).HasColumnName("Week_Last_NonWorkingDayID");
            entity.Property(e => e.WeekLastWeekDayId).HasColumnName("Week_Last_WeekDayID");
            entity.Property(e => e.WeekLastWeekendDayId).HasColumnName("Week_Last_WeekendDayID");
            entity.Property(e => e.WeekLastWorkingDayId).HasColumnName("Week_Last_WorkingDayID");
            entity.Property(e => e.WeekName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.WeekNonWorkingNrOfDays).HasColumnName("Week_NonWorkingNrOfDays");
            entity.Property(e => e.WeekP444AllNrOfDays).HasColumnName("WeekP444_AllNrOfDays");
            entity.Property(e => e.WeekP444FirstAllDayId).HasColumnName("WeekP444_First_AllDayID");
            entity.Property(e => e.WeekP444FirstHoliDayId).HasColumnName("WeekP444_First_HoliDayID");
            entity.Property(e => e.WeekP444FirstNonWorkingDayId).HasColumnName("WeekP444_First_NonWorkingDayID");
            entity.Property(e => e.WeekP444FirstWeekDayId).HasColumnName("WeekP444_First_WeekDayID");
            entity.Property(e => e.WeekP444FirstWeekendDayId).HasColumnName("WeekP444_First_WeekendDayID");
            entity.Property(e => e.WeekP444FirstWorkingDayId).HasColumnName("WeekP444_First_WorkingDayID");
            entity.Property(e => e.WeekP444HoliNrOfDays).HasColumnName("WeekP444_HoliNrOfDays");
            entity.Property(e => e.WeekP444LastAllDayId).HasColumnName("WeekP444_Last_AllDayID");
            entity.Property(e => e.WeekP444LastHoliDayId).HasColumnName("WeekP444_Last_HoliDayID");
            entity.Property(e => e.WeekP444LastNonWorkingDayId).HasColumnName("WeekP444_Last_NonWorkingDayID");
            entity.Property(e => e.WeekP444LastWeekDayId).HasColumnName("WeekP444_Last_WeekDayID");
            entity.Property(e => e.WeekP444LastWeekendDayId).HasColumnName("WeekP444_Last_WeekendDayID");
            entity.Property(e => e.WeekP444LastWorkingDayId).HasColumnName("WeekP444_Last_WorkingDayID");
            entity.Property(e => e.WeekP444NonWorkingNrOfDays).HasColumnName("WeekP444_NonWorkingNrOfDays");
            entity.Property(e => e.WeekP444WeekNrOfDays).HasColumnName("WeekP444_WeekNrOfDays");
            entity.Property(e => e.WeekP444WeekendNrOfDays).HasColumnName("WeekP444_WeekendNrOfDays");
            entity.Property(e => e.WeekP444WorkingNrOfDays).HasColumnName("WeekP444_WorkingNrOfDays");
            entity.Property(e => e.WeekP445AllNrOfDays).HasColumnName("WeekP445_AllNrOfDays");
            entity.Property(e => e.WeekP445FirstAllDayId).HasColumnName("WeekP445_First_AllDayID");
            entity.Property(e => e.WeekP445FirstHoliDayId).HasColumnName("WeekP445_First_HoliDayID");
            entity.Property(e => e.WeekP445FirstNonWorkingDayId).HasColumnName("WeekP445_First_NonWorkingDayID");
            entity.Property(e => e.WeekP445FirstWeekDayId).HasColumnName("WeekP445_First_WeekDayID");
            entity.Property(e => e.WeekP445FirstWeekendDayId).HasColumnName("WeekP445_First_WeekendDayID");
            entity.Property(e => e.WeekP445FirstWorkingDayId).HasColumnName("WeekP445_First_WorkingDayID");
            entity.Property(e => e.WeekP445HoliNrOfDays).HasColumnName("WeekP445_HoliNrOfDays");
            entity.Property(e => e.WeekP445LastAllDayId).HasColumnName("WeekP445_Last_AllDayID");
            entity.Property(e => e.WeekP445LastHoliDayId).HasColumnName("WeekP445_Last_HoliDayID");
            entity.Property(e => e.WeekP445LastNonWorkingDayId).HasColumnName("WeekP445_Last_NonWorkingDayID");
            entity.Property(e => e.WeekP445LastWeekDayId).HasColumnName("WeekP445_Last_WeekDayID");
            entity.Property(e => e.WeekP445LastWeekendDayId).HasColumnName("WeekP445_Last_WeekendDayID");
            entity.Property(e => e.WeekP445LastWorkingDayId).HasColumnName("WeekP445_Last_WorkingDayID");
            entity.Property(e => e.WeekP445NonWorkingNrOfDays).HasColumnName("WeekP445_NonWorkingNrOfDays");
            entity.Property(e => e.WeekP445WeekNrOfDays).HasColumnName("WeekP445_WeekNrOfDays");
            entity.Property(e => e.WeekP445WeekendNrOfDays).HasColumnName("WeekP445_WeekendNrOfDays");
            entity.Property(e => e.WeekP445WorkingNrOfDays).HasColumnName("WeekP445_WorkingNrOfDays");
            entity.Property(e => e.WeekQuarterAllNrOfDays).HasColumnName("WeekQuarter_AllNrOfDays");
            entity.Property(e => e.WeekQuarterFirstAllDayId).HasColumnName("WeekQuarter_First_AllDayID");
            entity.Property(e => e.WeekQuarterFirstHoliDayId).HasColumnName("WeekQuarter_First_HoliDayID");
            entity.Property(e => e.WeekQuarterFirstNonWorkingDayId).HasColumnName("WeekQuarter_First_NonWorkingDayID");
            entity.Property(e => e.WeekQuarterFirstWeekDayId).HasColumnName("WeekQuarter_First_WeekDayID");
            entity.Property(e => e.WeekQuarterFirstWeekendDayId).HasColumnName("WeekQuarter_First_WeekendDayID");
            entity.Property(e => e.WeekQuarterFirstWorkingDayId).HasColumnName("WeekQuarter_First_WorkingDayID");
            entity.Property(e => e.WeekQuarterHoliNrOfDays).HasColumnName("WeekQuarter_HoliNrOfDays");
            entity.Property(e => e.WeekQuarterLastAllDayId).HasColumnName("WeekQuarter_Last_AllDayID");
            entity.Property(e => e.WeekQuarterLastHoliDayId).HasColumnName("WeekQuarter_Last_HoliDayID");
            entity.Property(e => e.WeekQuarterLastNonWorkingDayId).HasColumnName("WeekQuarter_Last_NonWorkingDayID");
            entity.Property(e => e.WeekQuarterLastWeekDayId).HasColumnName("WeekQuarter_Last_WeekDayID");
            entity.Property(e => e.WeekQuarterLastWeekendDayId).HasColumnName("WeekQuarter_Last_WeekendDayID");
            entity.Property(e => e.WeekQuarterLastWorkingDayId).HasColumnName("WeekQuarter_Last_WorkingDayID");
            entity.Property(e => e.WeekQuarterNonWorkingNrOfDays).HasColumnName("WeekQuarter_NonWorkingNrOfDays");
            entity.Property(e => e.WeekQuarterWeekNrOfDays).HasColumnName("WeekQuarter_WeekNrOfDays");
            entity.Property(e => e.WeekQuarterWeekendNrOfDays).HasColumnName("WeekQuarter_WeekendNrOfDays");
            entity.Property(e => e.WeekQuarterWorkingNrOfDays).HasColumnName("WeekQuarter_WorkingNrOfDays");
            entity.Property(e => e.WeekWeekNrOfDays).HasColumnName("Week_WeekNrOfDays");
            entity.Property(e => e.WeekWeekendNrOfDays).HasColumnName("Week_WeekendNrOfDays");
            entity.Property(e => e.WeekWorkingNrOfDays).HasColumnName("Week_WorkingNrOfDays");
            entity.Property(e => e.WeekYearAllNrOfDays).HasColumnName("WeekYear_AllNrOfDays");
            entity.Property(e => e.WeekYearFirstAllDayId).HasColumnName("WeekYear_First_AllDayID");
            entity.Property(e => e.WeekYearFirstHoliDayId).HasColumnName("WeekYear_First_HoliDayID");
            entity.Property(e => e.WeekYearFirstNonWorkingDayId).HasColumnName("WeekYear_First_NonWorkingDayID");
            entity.Property(e => e.WeekYearFirstWeekDayId).HasColumnName("WeekYear_First_WeekDayID");
            entity.Property(e => e.WeekYearFirstWeekendDayId).HasColumnName("WeekYear_First_WeekendDayID");
            entity.Property(e => e.WeekYearFirstWorkingDayId).HasColumnName("WeekYear_First_WorkingDayID");
            entity.Property(e => e.WeekYearHoliNrOfDays).HasColumnName("WeekYear_HoliNrOfDays");
            entity.Property(e => e.WeekYearLastAllDayId).HasColumnName("WeekYear_Last_AllDayID");
            entity.Property(e => e.WeekYearLastHoliDayId).HasColumnName("WeekYear_Last_HoliDayID");
            entity.Property(e => e.WeekYearLastNonWorkingDayId).HasColumnName("WeekYear_Last_NonWorkingDayID");
            entity.Property(e => e.WeekYearLastWeekDayId).HasColumnName("WeekYear_Last_WeekDayID");
            entity.Property(e => e.WeekYearLastWeekendDayId).HasColumnName("WeekYear_Last_WeekendDayID");
            entity.Property(e => e.WeekYearLastWorkingDayId).HasColumnName("WeekYear_Last_WorkingDayID");
            entity.Property(e => e.WeekYearNonWorkingNrOfDays).HasColumnName("WeekYear_NonWorkingNrOfDays");
            entity.Property(e => e.WeekYearWeekNrOfDays).HasColumnName("WeekYear_WeekNrOfDays");
            entity.Property(e => e.WeekYearWeekendNrOfDays).HasColumnName("WeekYear_WeekendNrOfDays");
            entity.Property(e => e.WeekYearWorkingNrOfDays).HasColumnName("WeekYear_WorkingNrOfDays");
        });

        modelBuilder.Entity<DbRelation>(entity =>
        {
            entity.HasKey(e => e.DbRelationId).HasName("PK_Relation");

            entity.ToTable("DbRelation");

            entity.HasIndex(e => e.ChildDbTableId, "IX_DbRelation_ChildDbTableID");

            entity.HasIndex(e => e.ParentDbTableId, "IX_DbRelation_ParentDbTableID");

            entity.Property(e => e.DbRelationId).HasColumnName("DbRelationID");
            entity.Property(e => e.ChildDbTableId).HasColumnName("ChildDbTableID");
            entity.Property(e => e.ChildTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DbRelationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ParentDbTableId).HasColumnName("ParentDbTableID");
            entity.Property(e => e.ParentTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SetToNullWhenNotInSource).HasDefaultValue(true);

            entity.HasOne(d => d.ChildDbTable).WithMany(p => p.DbRelationChildDbTables)
                .HasForeignKey(d => d.ChildDbTableId)
                .HasConstraintName("FK_DbRelation_DbTable_Child");

            entity.HasOne(d => d.ParentDbTable).WithMany(p => p.DbRelationParentDbTables)
                .HasForeignKey(d => d.ParentDbTableId)
                .HasConstraintName("FK_DbRelation_DbTable_Parent");
        });

        modelBuilder.Entity<DbRelationField>(entity =>
        {
            entity.HasKey(e => e.DbRelationFieldId).HasName("PK_RelationField");

            entity.ToTable("DbRelationField");

            entity.HasIndex(e => e.ChildDbTableFieldId, "IX_DbRelationField_ChildDbTableFieldID");

            entity.HasIndex(e => e.DbRelationId, "IX_DbRelationField_DbRelationID");

            entity.HasIndex(e => e.ParentDbTableFieldId, "IX_DbRelationField_ParentDbTableFieldID");

            entity.Property(e => e.DbRelationFieldId).HasColumnName("DbRelationFieldID");
            entity.Property(e => e.ChildDbTableFieldId).HasColumnName("ChildDbTableFieldID");
            entity.Property(e => e.DbRelationId).HasColumnName("DbRelationID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ParentDbTableFieldId).HasColumnName("ParentDbTableFieldID");

            entity.HasOne(d => d.ChildDbTableField).WithMany(p => p.DbRelationFieldChildDbTableFields)
                .HasForeignKey(d => d.ChildDbTableFieldId)
                .HasConstraintName("FK_DbRelationField_DbTableField_Child");

            entity.HasOne(d => d.DbRelation).WithMany(p => p.DbRelationFields)
                .HasForeignKey(d => d.DbRelationId)
                .HasConstraintName("FK_DbRelationField_DbRelation");

            entity.HasOne(d => d.ParentDbTableField).WithMany(p => p.DbRelationFieldParentDbTableFields)
                .HasForeignKey(d => d.ParentDbTableFieldId)
                .HasConstraintName("FK_DbRelationField_DbTableField_Parent");
        });

        modelBuilder.Entity<DbTable>(entity =>
        {
            entity.ToTable("DbTable");

            entity.HasIndex(e => e.DatabaseId, "IX_DbTable_DatabaseID");

            entity.Property(e => e.DbTableId)
                .ValueGeneratedNever()
                .HasColumnName("DbTableID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.DbTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FieldNameMetaCreationDate)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FieldName_MetaCreationDate");
            entity.Property(e => e.FieldNameMetaCreationUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FieldName_MetaCreationUser");
            entity.Property(e => e.FieldNameMetaIsCurrent)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FieldName_MetaIsCurrent");
            entity.Property(e => e.FieldNameMetaMutationDate)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FieldName_MetaMutationDate");
            entity.Property(e => e.FieldNameMetaMutationUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FieldName_MetaMutationUser");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.PrimaryFields)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.Database).WithMany(p => p.DbTables)
                .HasForeignKey(d => d.DatabaseId)
                .HasConstraintName("FK_DbTable_Database");
        });

        modelBuilder.Entity<DbTableField>(entity =>
        {
            entity.ToTable("DbTableField");

            entity.HasIndex(e => e.DataTypeLkpId, "IX_DbTableField_DataTypeLkpID");

            entity.HasIndex(e => e.DbTableId, "IX_DbTableField_DbTableID");

            entity.Property(e => e.DbTableFieldId).HasColumnName("DbTableFieldID");
            entity.Property(e => e.DataTypeLkpId).HasColumnName("DataTypeLkpID");
            entity.Property(e => e.DbTableFieldName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DbTableId).HasColumnName("DbTableID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HashTypeLkpId).HasColumnName("HashTypeLkpID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SourceField)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.DataTypeLkp).WithMany(p => p.DbTableFieldDataTypeLkps)
                .HasForeignKey(d => d.DataTypeLkpId)
                .HasConstraintName("FK_DbTableField_AppLookupCode_DataTypeID");

            entity.HasOne(d => d.DbTable).WithMany(p => p.DbTableFields)
                .HasForeignKey(d => d.DbTableId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DbTableField_DbTable");

            entity.HasOne(d => d.HashTypeLkp).WithMany(p => p.DbTableFieldHashTypeLkps)
                .HasForeignKey(d => d.HashTypeLkpId)
                .HasConstraintName("FK_DbTableField_AppLookupCode_HashTypeID");
        });

        modelBuilder.Entity<DbTableFieldStatistic>(entity =>
        {
            entity.HasKey(e => e.DbTableFieldStatisticsId);

            entity.HasIndex(e => e.DbTableFieldId, "IX_DbTableFieldStatistics_DbTableFieldID");

            entity.Property(e => e.DbTableFieldStatisticsId).HasColumnName("DbTableFieldStatisticsID");
            entity.Property(e => e.AvgValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.DbTableFieldId).HasColumnName("DbTableFieldID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaxValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MinValue)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.DbTableField).WithMany(p => p.DbTableFieldStatistics)
                .HasForeignKey(d => d.DbTableFieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DbTableFieldStatistics_DbTableField");
        });

        modelBuilder.Entity<DbTableStatistic>(entity =>
        {
            entity.HasKey(e => e.DbTableStatisticsId);

            entity.HasIndex(e => e.DbTableId, "IX_DbTableStatistics_DbTableID");

            entity.Property(e => e.DbTableStatisticsId).HasColumnName("DbTableStatisticsID");
            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.DbTableId).HasColumnName("DbTableID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.DbTable).WithMany(p => p.DbTableStatistics)
                .HasForeignKey(d => d.DbTableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DbTableStatistics_DbTable");
        });

        modelBuilder.Entity<DimOrganisatieBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DimOrganisatie_BAK");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.BranchCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.KostenPlaatsCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.KostenPlaatsId).HasColumnName("KostenPlaatsID");
            entity.Property(e => e.KostenPlaatsNaam)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.LevelCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.MetaBeginDatum).HasColumnType("datetime");
            entity.Property(e => e.MetaCreatieDatum).HasColumnType("datetime");
            entity.Property(e => e.MetaEindDatum).HasColumnType("datetime");
            entity.Property(e => e.MetaHashType0)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MetaMutatieDatum).HasColumnType("datetime");
            entity.Property(e => e.MetaProcesId)
                .HasMaxLength(38)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MetaProcesID");
            entity.Property(e => e.OrganisatieCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.OrganisatieId).HasColumnName("OrganisatieID");
            entity.Property(e => e.OrganisatieNaam)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.ParentOrganisatieId).HasColumnName("ParentOrganisatieID");
            entity.Property(e => e.VolledigeOrganisatieCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.VolledigeOrganisatieId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VolledigeOrganisatieID");
            entity.Property(e => e.VolledigeOrganisatieNaam)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ZoneCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.ToTable("Document");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DocumentGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("DocumentGUID");
            entity.Property(e => e.DocumentName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DocumentTypeLkpId).HasColumnName("DocumentTypeLkpID");
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ElmahError>(entity =>
        {
            entity.HasKey(e => e.ErrorId).IsClustered(false);

            entity.ToTable("ELMAH_Error");

            entity.HasIndex(e => new { e.Application, e.TimeUtc, e.Sequence }, "IX_ELMAH_Error_App_Time_Seq").IsDescending(false, true, true);

            entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Application).HasMaxLength(60);
            entity.Property(e => e.Host).HasMaxLength(50);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
            entity.Property(e => e.Source).HasMaxLength(60);
            entity.Property(e => e.TimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(100);
            entity.Property(e => e.User).HasMaxLength(50);
        });

        modelBuilder.Entity<Folder>(entity =>
        {
            entity.ToTable("Folder");

            entity.HasIndex(e => e.AppDataObjectId, "IX_Folder_AppDataObjectID");

            entity.HasIndex(e => e.AppFormConfigId, "IX_Folder_AppFormConfigID");

            entity.HasIndex(e => e.AppFormId, "IX_Folder_AppFormID");

            entity.HasIndex(e => e.AppImageId, "IX_Folder_AppImageID");

            entity.HasIndex(e => e.AppViewId, "IX_Folder_AppViewID");

            entity.HasIndex(e => e.CodeReference, "IX_Folder_CodeReference");

            entity.HasIndex(e => e.FolderTypeLkpId, "IX_Folder_FolderTypeLkpID");

            entity.HasIndex(e => e.OverviewId, "IX_Folder_OverviewID");

            entity.HasIndex(e => e.ParentFolderId, "IX_Folder_ParentFolderID");

            entity.Property(e => e.FolderId)
                .ValueGeneratedNever()
                .HasColumnName("FolderID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppFormId).HasColumnName("AppFormID");
            entity.Property(e => e.AppImageId).HasColumnName("AppImageID");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FolderName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FolderTypeLkpId).HasColumnName("FolderTypeLkpID");
            entity.Property(e => e.FullPathFolderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FullPathFolderID");
            entity.Property(e => e.FullPathFolderName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FullPathSortOrderCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsSecInherited).HasDefaultValue(true);
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.ParentFolderId).HasColumnName("ParentFolderID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RowReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.AppDataObject).WithMany(p => p.Folders)
                .HasForeignKey(d => d.AppDataObjectId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Folder_AppDataObject");

            entity.HasOne(d => d.AppFormConfig).WithMany(p => p.Folders)
                .HasForeignKey(d => d.AppFormConfigId)
                .HasConstraintName("FK_Folder_AppFormConfig");

            entity.HasOne(d => d.AppForm).WithMany(p => p.Folders)
                .HasForeignKey(d => d.AppFormId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Folder_AppForm");

            entity.HasOne(d => d.AppImage).WithMany(p => p.Folders)
                .HasForeignKey(d => d.AppImageId)
                .HasConstraintName("FK_Folder_AppImage");

            entity.HasOne(d => d.AppView).WithMany(p => p.Folders)
                .HasForeignKey(d => d.AppViewId)
                .HasConstraintName("FK_Folder_AppView");

            entity.HasOne(d => d.FolderTypeLkp).WithMany(p => p.Folders)
                .HasForeignKey(d => d.FolderTypeLkpId)
                .HasConstraintName("FK_Folder_AppLookupCode");

            entity.HasOne(d => d.Overview).WithMany(p => p.Folders)
                .HasForeignKey(d => d.OverviewId)
                .HasConstraintName("FK_Folder_Overview_Result");

            entity.HasOne(d => d.ParentFolder).WithMany(p => p.InverseParentFolder)
                .HasForeignKey(d => d.ParentFolderId)
                .HasConstraintName("FK_Folder_Folder");
        });

        modelBuilder.Entity<FolderUser>(entity =>
        {
            entity.ToTable("Folder_User");

            entity.HasIndex(e => e.ExpireDate, "IX_Folder_User_ExpireDate");

            entity.HasIndex(e => e.FolderId, "IX_Folder_User_FolderID");

            entity.HasIndex(e => e.SecurityId, "IX_Folder_User_SecurityID");

            entity.HasIndex(e => e.UserId, "IX_Folder_User_UserID");

            entity.HasIndex(e => new { e.UserId, e.FolderId }, "UNQ_Folder_User").IsUnique();

            entity.Property(e => e.FolderUserId).HasColumnName("FolderUserID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Folder).WithMany(p => p.FolderUsers)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_Folder_User_Folder");

            entity.HasOne(d => d.Security).WithMany(p => p.FolderUsers)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Folder_User_Security");

            entity.HasOne(d => d.User).WithMany(p => p.FolderUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Folder_User_User");
        });

        modelBuilder.Entity<FolderUserIsRead>(entity =>
        {
            entity.ToTable("Folder_User_IsRead");

            entity.HasIndex(e => e.FolderId, "IX_Folder_User_IsRead_FolderID");

            entity.HasIndex(e => new { e.FolderId, e.UserId }, "IX_Folder_User_IsRead_FolderID_UserID");

            entity.HasIndex(e => new { e.UserId, e.FolderId }, "UNQ_Folder_User_IsRead").IsUnique();

            entity.Property(e => e.FolderUserIsReadId).HasColumnName("FolderUserIsReadID");
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<JobPosition>(entity =>
        {
            entity.ToTable("JobPosition");

            entity.HasIndex(e => e.JobPositionGroupId, "IX_JobPosition_JobPositionGroupID");

            entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JobPositionCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.JobPositionGroupId).HasColumnName("JobPositionGroupID");
            entity.Property(e => e.JobPositionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.JobPositionGroup).WithMany(p => p.JobPositions)
                .HasForeignKey(d => d.JobPositionGroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_JobPosition_JobPositionGroup");
        });

        modelBuilder.Entity<JobPositionGroup>(entity =>
        {
            entity.ToTable("JobPositionGroup");

            entity.Property(e => e.JobPositionGroupId).HasColumnName("JobPositionGroupID");
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JobPositionGroupCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.JobPositionGroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Kpi>(entity =>
        {
            entity.ToTable("Kpi");

            entity.HasIndex(e => e.CodeReference, "IX_Kpi_CodeReference");

            entity.Property(e => e.KpiId)
                .ValueGeneratedNever()
                .HasColumnName("KpiID");
            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DataFields)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Formula)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Frequency)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsAggregable).HasDefaultValue(true);
            entity.Property(e => e.IsAggregableByOrganisation).HasDefaultValue(true);
            entity.Property(e => e.IsAggregableByTime).HasDefaultValue(true);
            entity.Property(e => e.IsBiggerBetter).HasDefaultValue(true);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.KpiGroup)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KpiName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.NewsMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Scale)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ScaleLkpId).HasColumnName("ScaleLkpID");
            entity.Property(e => e.Scope)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Units)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.ScaleLkp).WithMany(p => p.Kpis)
                .HasForeignKey(d => d.ScaleLkpId)
                .HasConstraintName("FK_Kpi_AppLookupCode_Scale");
        });

        modelBuilder.Entity<KpiUser>(entity =>
        {
            entity.ToTable("Kpi_User");

            entity.HasIndex(e => e.KpiId, "IX_Kpi_User_KpiID");

            entity.HasIndex(e => e.SecurityId, "IX_Kpi_User_SecurityID");

            entity.HasIndex(e => e.UserId, "IX_Kpi_User_UserID");

            entity.HasIndex(e => new { e.UserId, e.KpiId }, "UNQ_Kpi_User").IsUnique();

            entity.Property(e => e.KpiUserId).HasColumnName("KpiUserID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.KpiId).HasColumnName("KpiID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Kpi).WithMany(p => p.KpiUsers)
                .HasForeignKey(d => d.KpiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Kpi_User_Kpi");

            entity.HasOne(d => d.Security).WithMany(p => p.KpiUsers)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Kpi_User_Security");

            entity.HasOne(d => d.User).WithMany(p => p.KpiUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Kpi_User_User");
        });

        modelBuilder.Entity<KpiUserIsRead>(entity =>
        {
            entity.ToTable("Kpi_User_IsRead");

            entity.HasIndex(e => e.KpiId, "IX_Kpi_User_IsRead_KpiID");

            entity.HasIndex(e => new { e.KpiId, e.UserId }, "IX_Kpi_User_IsRead_KpiID_UserID");

            entity.HasIndex(e => new { e.UserId, e.KpiId }, "UNQ_Kpi_User_IsRead").IsUnique();

            entity.Property(e => e.KpiUserIsReadId).HasColumnName("KpiUserIsReadID");
            entity.Property(e => e.KpiId).HasColumnName("KpiID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.ToTable("Login");

            entity.HasIndex(e => e.UserId, "IX_Login_UserID");

            entity.Property(e => e.LoginId).HasColumnName("LoginID");
            entity.Property(e => e.ComputerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeviceTypeLkpId).HasColumnName("DeviceTypeLkpID");
            entity.Property(e => e.IpAdress)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.LoginDate).HasColumnType("datetime");
            entity.Property(e => e.LogoutDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.DeviceTypeLkp).WithMany(p => p.Logins)
                .HasForeignKey(d => d.DeviceTypeLkpId)
                .HasConstraintName("FK_Login_AppLookupCode_DeviceType");

            entity.HasOne(d => d.User).WithMany(p => p.Logins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_User_Login");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.ToTable("Message");

            entity.HasIndex(e => e.ExpireDate, "IX_Message_ExpireDate");

            entity.HasIndex(e => e.OverviewId, "IX_Message_OverviewID");

            entity.HasIndex(e => e.ParentMessageId, "IX_Message_ParentMessageID");

            entity.HasIndex(e => e.UserId, "IX_Message_UserID");

            entity.Property(e => e.MessageId)
                .ValueGeneratedNever()
                .HasColumnName("MessageID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MessageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.ParentMessageId).HasColumnName("ParentMessageID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Overview).WithMany(p => p.Messages)
                .HasForeignKey(d => d.OverviewId)
                .HasConstraintName("FK_Message_Overview");

            entity.HasOne(d => d.ParentMessage).WithMany(p => p.InverseParentMessage)
                .HasForeignKey(d => d.ParentMessageId)
                .HasConstraintName("FK_Message_Message");

            entity.HasOne(d => d.User).WithMany(p => p.Messages)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Message_User");
        });

        modelBuilder.Entity<Organisation>(entity =>
        {
            entity.ToTable("Organisation");

            entity.HasIndex(e => e.CostCentreId, "IX_Organisation_CostCentreID");

            entity.HasIndex(e => e.ManagerUserId, "IX_Organisation_ManagerUserID");

            entity.HasIndex(e => e.OrganisationLevelId, "IX_Organisation_OrganisationLevelID");

            entity.HasIndex(e => e.ParentOrganisationId, "IX_Organisation_ParentOrganisationID");

            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.BusinessPhone)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CompleteOid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Complete_OID");
            entity.Property(e => e.CompleteOrganisationCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CompleteOrganisationId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CompleteOrganisationID");
            entity.Property(e => e.CompleteOrganisationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CostCentreId).HasColumnName("CostCentreID");
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsSelectable).HasDefaultValue(true);
            entity.Property(e => e.L1Oid).HasColumnName("L1_OID");
            entity.Property(e => e.L2Oid).HasColumnName("L2_OID");
            entity.Property(e => e.L3Oid).HasColumnName("L3_OID");
            entity.Property(e => e.L4Oid).HasColumnName("L4_OID");
            entity.Property(e => e.L5Oid).HasColumnName("L5_OID");
            entity.Property(e => e.L6Oid).HasColumnName("L6_OID");
            entity.Property(e => e.L7Oid).HasColumnName("L7_OID");
            entity.Property(e => e.L8Oid).HasColumnName("L8_OID");
            entity.Property(e => e.ManagerUserId).HasColumnName("ManagerUserID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationLevelId).HasColumnName("OrganisationLevelID");
            entity.Property(e => e.OrganisationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ParentOrganisationId).HasColumnName("ParentOrganisationID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.CostCentre).WithMany(p => p.Organisations)
                .HasForeignKey(d => d.CostCentreId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CostCentre_Organisation");

            entity.HasOne(d => d.ManagerUser).WithMany(p => p.Organisations)
                .HasForeignKey(d => d.ManagerUserId)
                .HasConstraintName("FK_Organisation_User_Manager");

            entity.HasOne(d => d.OrganisationLevel).WithMany(p => p.Organisations)
                .HasForeignKey(d => d.OrganisationLevelId)
                .HasConstraintName("FK_OrganisationLevel_Organisation");

            entity.HasOne(d => d.ParentOrganisation).WithMany(p => p.InverseParentOrganisation)
                .HasForeignKey(d => d.ParentOrganisationId)
                .HasConstraintName("FK_Organisation_Organisation");
        });

        modelBuilder.Entity<OrganisationLevel>(entity =>
        {
            entity.ToTable("OrganisationLevel");

            entity.Property(e => e.OrganisationLevelId)
                .ValueGeneratedNever()
                .HasColumnName("OrganisationLevelID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationLevelCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationLevelName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrganisationUser>(entity =>
        {
            entity.ToTable("Organisation_User");

            entity.HasIndex(e => e.ExpireDate, "IX_Organisation_User_ExpireDate");

            entity.HasIndex(e => e.OrganisationId, "IX_Organisation_User_OrganisationID");

            entity.HasIndex(e => e.SecurityId, "IX_Organisation_User_SecurityID");

            entity.HasIndex(e => e.UserId, "IX_Organisation_User_UserID");

            entity.HasIndex(e => new { e.UserId, e.OrganisationId }, "UNQ_Organisation_User").IsUnique();

            entity.Property(e => e.OrganisationUserId).HasColumnName("OrganisationUserID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Organisation).WithMany(p => p.OrganisationUsers)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_Organisation_User_Organisation");

            entity.HasOne(d => d.Security).WithMany(p => p.OrganisationUsers)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Organisation_User_Security");

            entity.HasOne(d => d.User).WithMany(p => p.OrganisationUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Organisation_User_User");
        });

        modelBuilder.Entity<OrganisationUserIsRead>(entity =>
        {
            entity.ToTable("Organisation_User_IsRead");

            entity.HasIndex(e => e.OrganisationId, "IX_Organisation_User_IsRead_OrganisationID");

            entity.HasIndex(e => new { e.OrganisationId, e.UserId }, "IX_Organisation_User_IsRead_OrganisationID_UserID");

            entity.HasIndex(e => new { e.UserId, e.OrganisationId }, "UNQ_Organisation_User_IsRead").IsUnique();

            entity.Property(e => e.OrganisationUserIsReadId).HasColumnName("OrganisationUserIsReadID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Overview>(entity =>
        {
            entity.ToTable("Overview");

            entity.HasIndex(e => e.AppDataObjectId, "IX_Overview_AppDataObjectID");

            entity.HasIndex(e => e.FolderId, "IX_Overview_FolderID");

            entity.HasIndex(e => e.OverviewTypeLkpId, "IX_Overview_OverviewTypeLkpID");

            entity.HasIndex(e => e.ParameterAppFormId, "IX_Overview_ParameterAppFormID");

            entity.HasIndex(e => e.ParameterAppViewId, "IX_Overview_ParameterAppViewID");

            entity.HasIndex(e => e.ResultAppFormId, "IX_Overview_ResultAppFormID");

            entity.HasIndex(e => e.ResultAppViewId, "IX_Overview_ResultAppViewID");

            entity.HasIndex(e => e.ServiceProviderId, "IX_Overview_ServiceProviderID");

            entity.Property(e => e.OverviewId)
                .ValueGeneratedNever()
                .HasColumnName("OverviewID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HelpReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsExportPdfAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsExportRdlAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsExportXlsAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsExportXmlAllowed).HasDefaultValue(true);
            entity.Property(e => e.IsSecInherited).HasDefaultValue(true);
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.OverviewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OverviewResetEventLkpId).HasColumnName("OverviewResetEventLkpID");
            entity.Property(e => e.OverviewTypeLkpId).HasColumnName("OverviewTypeLkpID");
            entity.Property(e => e.ParameterAppFormId).HasColumnName("ParameterAppFormID");
            entity.Property(e => e.ParameterAppViewId).HasColumnName("ParameterAppViewID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ResultAppFormId).HasColumnName("ResultAppFormID");
            entity.Property(e => e.ResultAppViewId).HasColumnName("ResultAppViewID");
            entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");
            entity.Property(e => e.ShowParameterLink).HasDefaultValue(true);
            entity.Property(e => e.ShowPortalParameters).HasDefaultValue(true);
            entity.Property(e => e.ShowProviderParameters).HasDefaultValue(true);
            entity.Property(e => e.ShowProviderToolbar).HasDefaultValue(true);
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.AppDataObject).WithMany(p => p.Overviews)
                .HasForeignKey(d => d.AppDataObjectId)
                .HasConstraintName("FK_Overview_AppDataObject");

            entity.HasOne(d => d.Folder).WithMany(p => p.Overviews)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_Overview_Folder_Classification");

            entity.HasOne(d => d.OverviewResetEventLkp).WithMany(p => p.OverviewOverviewResetEventLkps)
                .HasForeignKey(d => d.OverviewResetEventLkpId)
                .HasConstraintName("FK_Overview_AppLookupCode_OverviewResetEvent");

            entity.HasOne(d => d.OverviewTypeLkp).WithMany(p => p.OverviewOverviewTypeLkps)
                .HasForeignKey(d => d.OverviewTypeLkpId)
                .HasConstraintName("FK_Overview_AppLookupCode_OverviewType");

            entity.HasOne(d => d.ParameterAppForm).WithMany(p => p.OverviewParameterAppForms)
                .HasForeignKey(d => d.ParameterAppFormId)
                .HasConstraintName("FK_Overview_AppForm_Parameter");

            entity.HasOne(d => d.ParameterAppView).WithMany(p => p.OverviewParameterAppViews)
                .HasForeignKey(d => d.ParameterAppViewId)
                .HasConstraintName("FK_Overview_AppView_Parameter");

            entity.HasOne(d => d.ResultAppForm).WithMany(p => p.OverviewResultAppForms)
                .HasForeignKey(d => d.ResultAppFormId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Overview_AppForm_Result");

            entity.HasOne(d => d.ResultAppView).WithMany(p => p.OverviewResultAppViews)
                .HasForeignKey(d => d.ResultAppViewId)
                .HasConstraintName("FK_Overview_AppView_Result");

            entity.HasOne(d => d.ServiceProvider).WithMany(p => p.Overviews)
                .HasForeignKey(d => d.ServiceProviderId)
                .HasConstraintName("FK_Overview_ServiceProvider");
        });

        modelBuilder.Entity<OverviewField>(entity =>
        {
            entity.ToTable("OverviewField");

            entity.Property(e => e.OverviewFieldId).HasColumnName("OverviewFieldID");
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewFieldName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OverviewFieldOverview>(entity =>
        {
            entity.HasKey(e => e.OverviewOverviewFieldId);

            entity.ToTable("OverviewField_Overview");

            entity.HasIndex(e => e.OverviewFieldId, "IX_OverviewField_Overview_OverviewFieldID");

            entity.HasIndex(e => e.OverviewId, "IX_OverviewField_Overview_OverviewID");

            entity.HasIndex(e => new { e.OverviewId, e.OverviewFieldId }, "UNQ_OverviewField_Overview").IsUnique();

            entity.Property(e => e.OverviewOverviewFieldId).HasColumnName("OverviewOverviewFieldID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewFieldId).HasColumnName("OverviewFieldID");
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.OverviewField).WithMany(p => p.OverviewFieldOverviews)
                .HasForeignKey(d => d.OverviewFieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OverviewField_OverviewField_Overview");

            entity.HasOne(d => d.Overview).WithMany(p => p.OverviewFieldOverviews)
                .HasForeignKey(d => d.OverviewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Overview_OverviewField_Overview");
        });

        modelBuilder.Entity<OverviewFieldOverviewSection>(entity =>
        {
            entity.ToTable("OverviewField_OverviewSection");

            entity.HasIndex(e => e.OverviewFieldId, "IX_OverviewField_OverviewSection_OverviewFieldID");

            entity.HasIndex(e => e.OverviewSectionId, "IX_OverviewField_OverviewSection_OverviewSectionID");

            entity.Property(e => e.OverviewFieldOverviewSectionId).HasColumnName("OverviewFieldOverviewSectionID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewFieldId).HasColumnName("OverviewFieldID");
            entity.Property(e => e.OverviewSectionId).HasColumnName("OverviewSectionID");
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.OverviewField).WithMany(p => p.OverviewFieldOverviewSections)
                .HasForeignKey(d => d.OverviewFieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OverviewField_OverviewSection_OverviewField");

            entity.HasOne(d => d.OverviewSection).WithMany(p => p.OverviewFieldOverviewSections)
                .HasForeignKey(d => d.OverviewSectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OverviewField_OverviewSection_OverviewSection");
        });

        modelBuilder.Entity<OverviewSection>(entity =>
        {
            entity.ToTable("OverviewSection");

            entity.HasIndex(e => e.OverviewId, "IX_OverviewSection_OverviewID");

            entity.Property(e => e.OverviewSectionId)
                .ValueGeneratedNever()
                .HasColumnName("OverviewSectionID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.OverviewSectionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.Overview).WithMany(p => p.OverviewSections)
                .HasForeignKey(d => d.OverviewId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OverviewSection_Overview");
        });

        modelBuilder.Entity<OverviewUser>(entity =>
        {
            entity.ToTable("Overview_User");

            entity.HasIndex(e => e.ExpireDate, "IX_Overview_User_ExpireDate");

            entity.HasIndex(e => e.OverviewId, "IX_Overview_User_OverviewID");

            entity.HasIndex(e => e.SecurityId, "IX_Overview_User_SecurityID");

            entity.HasIndex(e => e.UserId, "IX_Overview_User_UserID");

            entity.HasIndex(e => new { e.UserId, e.OverviewId }, "UNQ_Overview_User").IsUnique();

            entity.Property(e => e.OverviewUserId).HasColumnName("OverviewUserID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Overview).WithMany(p => p.OverviewUsers)
                .HasForeignKey(d => d.OverviewId)
                .HasConstraintName("FK_Overview_User_Overview");

            entity.HasOne(d => d.Security).WithMany(p => p.OverviewUsers)
                .HasForeignKey(d => d.SecurityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Overview_User_Security");

            entity.HasOne(d => d.User).WithMany(p => p.OverviewUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Overview_User_User");
        });

        modelBuilder.Entity<OverviewUserIsRead>(entity =>
        {
            entity.ToTable("Overview_User_IsRead");

            entity.HasIndex(e => e.OverviewId, "IX_Overview_User_IsRead_OverviewID");

            entity.HasIndex(e => new { e.OverviewId, e.UserId }, "IX_Overview_User_IsRead_OverviewID_UserID");

            entity.HasIndex(e => new { e.UserId, e.OverviewId }, "UNQ_Overview_User_IsRead").IsUnique();

            entity.Property(e => e.OverviewUserIsReadId).HasColumnName("OverviewUserIsReadID");
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<RegistryKey>(entity =>
        {
            entity.ToTable("RegistryKey");

            entity.HasIndex(e => e.RegistryKeyId, "UNQ_RegistryKey_Tree_KeyName").IsUnique();

            entity.Property(e => e.RegistryKeyId).HasColumnName("RegistryKeyID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.RegistryKeyGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RegistryKeyGUID");
            entity.Property(e => e.RegistryKeyName).HasMaxLength(255);
            entity.Property(e => e.RegistryKeyTypeLkpId).HasColumnName("RegistryKeyTypeLkpID");
            entity.Property(e => e.RegistryTreeId).HasColumnName("RegistryTreeID");
            entity.Property(e => e.Remarks).HasMaxLength(4000);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ValueBinary)
                .HasMaxLength(128)
                .IsFixedLength()
                .HasColumnName("Value_BINARY");
            entity.Property(e => e.ValueBit).HasColumnName("Value_BIT");
            entity.Property(e => e.ValueDatetime)
                .HasColumnType("datetime")
                .HasColumnName("Value_DATETIME");
            entity.Property(e => e.ValueDecimal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Value_DECIMAL");
            entity.Property(e => e.ValueInt).HasColumnName("Value_INT");
            entity.Property(e => e.ValueMemo).HasColumnName("Value_MEMO");
            entity.Property(e => e.ValueString)
                .HasMaxLength(255)
                .HasColumnName("Value_STRING");
            entity.Property(e => e.ValueUi).HasColumnName("Value_UI");
            entity.Property(e => e.ValueXml)
                .HasColumnType("xml")
                .HasColumnName("Value_XML");

            entity.HasOne(d => d.RegistryKeyTypeLkp).WithMany(p => p.RegistryKeys)
                .HasForeignKey(d => d.RegistryKeyTypeLkpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistryKey_AppLookupCode_RegistryKeyType");

            entity.HasOne(d => d.RegistryTree).WithMany(p => p.RegistryKeys)
                .HasForeignKey(d => d.RegistryTreeId)
                .HasConstraintName("FK_RegistryKey_RegistryTree");

            entity.HasOne(d => d.User).WithMany(p => p.RegistryKeys)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RegistryKey_User");
        });

        modelBuilder.Entity<RegistryReference>(entity =>
        {
            entity.ToTable("RegistryReference");

            entity.Property(e => e.RegistryReferenceId)
                .ValueGeneratedNever()
                .HasColumnName("RegistryReferenceID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.RegistryReferenceGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RegistryReferenceGUID");
            entity.Property(e => e.RegistryReferenceName).HasMaxLength(255);
            entity.Property(e => e.RegistryTreeId).HasColumnName("RegistryTreeID");
            entity.Property(e => e.RowReference).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Value).HasMaxLength(4000);

            entity.HasOne(d => d.AppDataObject).WithMany(p => p.RegistryReferences)
                .HasForeignKey(d => d.AppDataObjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistryReference_AppDataObject");

            entity.HasOne(d => d.RegistryTree).WithMany(p => p.RegistryReferences)
                .HasForeignKey(d => d.RegistryTreeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RegistryReference_RegistryTree");

            entity.HasOne(d => d.User).WithMany(p => p.RegistryReferences)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RegistryReference_User");
        });

        modelBuilder.Entity<RegistryTree>(entity =>
        {
            entity.ToTable("RegistryTree");

            entity.Property(e => e.RegistryTreeId)
                .ValueGeneratedNever()
                .HasColumnName("RegistryTreeID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FullPathRegistryTreeId)
                .HasMaxLength(255)
                .HasColumnName("FullPathRegistryTreeID");
            entity.Property(e => e.FullPathRegistryTreeName).HasMaxLength(255);
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParentRegistryTreeId).HasColumnName("ParentRegistryTreeID");
            entity.Property(e => e.RegistryTreeGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RegistryTreeGUID");
            entity.Property(e => e.RegistryTreeName).HasMaxLength(255);
            entity.Property(e => e.Remarks).HasMaxLength(4000);

            entity.HasOne(d => d.ParentRegistryTree).WithMany(p => p.InverseParentRegistryTree)
                .HasForeignKey(d => d.ParentRegistryTreeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RegistryTree_RegistryTree_Parent");
        });

        modelBuilder.Entity<RequestLog>(entity =>
        {
            entity.ToTable("RequestLog");

            entity.HasIndex(e => e.LoginId, "IX_RequestLog_LoginID");

            entity.HasIndex(e => e.OverviewId, "IX_RequestLog_OverviewID");

            entity.Property(e => e.RequestLogId).HasColumnName("RequestLogID");
            entity.Property(e => e.IsSucessfull).HasDefaultValue(true);
            entity.Property(e => e.LoginId).HasColumnName("LoginID");
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.ParameterConfig).IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");

            entity.HasOne(d => d.Login).WithMany(p => p.RequestLogs)
                .HasForeignKey(d => d.LoginId)
                .HasConstraintName("FK_Login_RequestLog");

            entity.HasOne(d => d.Overview).WithMany(p => p.RequestLogs)
                .HasForeignKey(d => d.OverviewId)
                .HasConstraintName("FK_Overview_RequestLog");

            entity.HasOne(d => d.User).WithMany(p => p.RequestLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FL_USER");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.ToTable("Schedule");

            entity.Property(e => e.ScheduleId)
                .ValueGeneratedNever()
                .HasColumnName("ScheduleID");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.DayInterval).HasDefaultValue(1);
            entity.Property(e => e.ExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HourInterval).HasDefaultValue(1);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.LastExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.LoginUserId).HasColumnName("LoginUserID");
            entity.Property(e => e.MaxNrOfExecutions).HasDefaultValue(0);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MinuteInterval).HasDefaultValue(1);
            entity.Property(e => e.NextExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.PeriodInterval).HasDefaultValue(1);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleDayFilterLkpId).HasColumnName("ScheduleDayFilterLkpID");
            entity.Property(e => e.ScheduleDayOrderLkpId).HasColumnName("ScheduleDayOrderLkpID");
            entity.Property(e => e.ScheduleDayTypeLkpId).HasColumnName("ScheduleDayTypeLkpID");
            entity.Property(e => e.ScheduleEndDate).HasColumnType("datetime");
            entity.Property(e => e.ScheduleEventLkpId).HasColumnName("ScheduleEventLkpID");
            entity.Property(e => e.ScheduleGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ScheduleGUID");
            entity.Property(e => e.ScheduleHourFilterLkpId).HasColumnName("ScheduleHourFilterLkpID");
            entity.Property(e => e.ScheduleMinuteFilterLkpId).HasColumnName("ScheduleMinuteFilterLkpID");
            entity.Property(e => e.ScheduleName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SchedulePeriodFilterLkpId).HasColumnName("SchedulePeriodFilterLkpID");
            entity.Property(e => e.SchedulePeriodTypeLkpId).HasColumnName("SchedulePeriodTypeLkpID");
            entity.Property(e => e.ScheduleStartDate).HasColumnType("datetime");
            entity.Property(e => e.ScheduleTriggerTypeLkpId).HasColumnName("ScheduleTriggerTypeLkpID");
            entity.Property(e => e.SelectedDates)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SelectedDays)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SelectedHours)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SelectedMinutes)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SelectedPeriods)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.SelectedTimes)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.AppView).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.AppViewId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Schedule_AppView");

            entity.HasOne(d => d.ScheduleDayFilterLkp).WithMany(p => p.ScheduleScheduleDayFilterLkps)
                .HasForeignKey(d => d.ScheduleDayFilterLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_DayFilter");

            entity.HasOne(d => d.ScheduleDayOrderLkp).WithMany(p => p.ScheduleScheduleDayOrderLkps)
                .HasForeignKey(d => d.ScheduleDayOrderLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_DayOrder");

            entity.HasOne(d => d.ScheduleDayTypeLkp).WithMany(p => p.ScheduleScheduleDayTypeLkps)
                .HasForeignKey(d => d.ScheduleDayTypeLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_ScheduleDayType");

            entity.HasOne(d => d.ScheduleEventLkp).WithMany(p => p.ScheduleScheduleEventLkps)
                .HasForeignKey(d => d.ScheduleEventLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_ScheduleEvent");

            entity.HasOne(d => d.ScheduleHourFilterLkp).WithMany(p => p.ScheduleScheduleHourFilterLkps)
                .HasForeignKey(d => d.ScheduleHourFilterLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_HourFilter");

            entity.HasOne(d => d.ScheduleMinuteFilterLkp).WithMany(p => p.ScheduleScheduleMinuteFilterLkps)
                .HasForeignKey(d => d.ScheduleMinuteFilterLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_MinuteFilter");

            entity.HasOne(d => d.SchedulePeriodFilterLkp).WithMany(p => p.ScheduleSchedulePeriodFilterLkps)
                .HasForeignKey(d => d.SchedulePeriodFilterLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_SchedulePeriodFilter");

            entity.HasOne(d => d.SchedulePeriodTypeLkp).WithMany(p => p.ScheduleSchedulePeriodTypeLkps)
                .HasForeignKey(d => d.SchedulePeriodTypeLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_SchedulePeriodType");

            entity.HasOne(d => d.ScheduleTriggerTypeLkp).WithMany(p => p.ScheduleScheduleTriggerTypeLkps)
                .HasForeignKey(d => d.ScheduleTriggerTypeLkpId)
                .HasConstraintName("FK_Schedule_AppLookupCode_ScheduleTriggerType");
        });

        modelBuilder.Entity<ScheduleLog>(entity =>
        {
            entity.ToTable("ScheduleLog");

            entity.Property(e => e.ScheduleLogId).HasColumnName("ScheduleLogID");
            entity.Property(e => e.ExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.ExecutionGuid).HasColumnName("ExecutionGUID");
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

            entity.HasOne(d => d.Schedule).WithMany(p => p.ScheduleLogs)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("FK_ScheduleLog_Schedule");
        });

        modelBuilder.Entity<SchedulePlannedTimeEvent>(entity =>
        {
            entity.ToTable("SchedulePlannedTimeEvent");

            entity.HasIndex(e => e.ExecutionDate, "IX_SchedulePlannedTimeEvent_ExecutionDate");

            entity.HasIndex(e => e.ScheduleId, "IX_SchedulePlannedTimeEvent_ScheduleID");

            entity.Property(e => e.SchedulePlannedTimeEventId).HasColumnName("SchedulePlannedTimeEventID");
            entity.Property(e => e.ExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

            entity.HasOne(d => d.Schedule).WithMany(p => p.SchedulePlannedTimeEvents)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("FK_SchedulePlannedTimeEvent_Schedule");
        });

        modelBuilder.Entity<Security>(entity =>
        {
            entity.ToTable("Security");

            entity.HasIndex(e => e.IsDenied, "IX_Security_IsDenied");

            entity.HasIndex(e => new { e.IsRead, e.IsUpdate, e.IsAdmin }, "IX_Security_IsRead_IsUpdate_IsAdmin");

            entity.HasIndex(e => e.SecurityCode, "IX_Security_SecurityCode");

            entity.Property(e => e.SecurityId)
                .ValueGeneratedNever()
                .HasColumnName("SecurityID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsAdmin).HasDefaultValue(false);
            entity.Property(e => e.IsDelete).HasDefaultValue(false);
            entity.Property(e => e.IsDenied).HasDefaultValue(false);
            entity.Property(e => e.IsExecute).HasDefaultValue(false);
            entity.Property(e => e.IsInsert).HasDefaultValue(false);
            entity.Property(e => e.IsOwner).HasDefaultValue(false);
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.IsUpdate).HasDefaultValue(false);
            entity.Property(e => e.IsValid).HasDefaultValue(true);
            entity.Property(e => e.RedirectedSecurityId).HasColumnName("RedirectedSecurityID");
            entity.Property(e => e.SecurityCode)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SecurityRule>(entity =>
        {
            entity.ToTable("SecurityRule");

            entity.HasIndex(e => e.ContractTypeId, "IX_SecurityRule_ContractTypeID");

            entity.HasIndex(e => e.ExpireDate, "IX_SecurityRule_ExpireDate");

            entity.HasIndex(e => e.OrganisationId, "IX_SecurityRule_OrganisationID");

            entity.HasIndex(e => e.SecuredCustomerId, "IX_SecurityRule_SecuredCustomerID");

            entity.HasIndex(e => e.SecuredFolderId, "IX_SecurityRule_SecuredFolderID");

            entity.HasIndex(e => e.SecuredOrganisationId, "IX_SecurityRule_SecuredOrganisationID");

            entity.HasIndex(e => e.SecuredOverviewId, "IX_SecurityRule_SecuredOverviewID");

            entity.HasIndex(e => e.UserGroupId, "IX_SecurityRule_UserGroupID");

            entity.Property(e => e.SecurityRuleId)
                .ValueGeneratedNever()
                .HasColumnName("SecurityRuleID");
            entity.Property(e => e.ContractTypeId).HasColumnName("ContractTypeID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsInUserSelection).HasDefaultValue(true);
            entity.Property(e => e.JobPositionGroupId).HasColumnName("JobPositionGroupID");
            entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");
            entity.Property(e => e.LoginStatusLkpId).HasColumnName("LoginStatusLkpID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OrganisationLevelId).HasColumnName("OrganisationLevelID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SecuredAppDataObjectId).HasColumnName("SecuredAppDataObjectID");
            entity.Property(e => e.SecuredAppFunctionId).HasColumnName("SecuredAppFunctionID");
            entity.Property(e => e.SecuredCustomerId).HasColumnName("SecuredCustomerID");
            entity.Property(e => e.SecuredFolderId).HasColumnName("SecuredFolderID");
            entity.Property(e => e.SecuredKpiId).HasColumnName("SecuredKpiID");
            entity.Property(e => e.SecuredOrganisationId).HasColumnName("SecuredOrganisationID");
            entity.Property(e => e.SecuredOverviewId).HasColumnName("SecuredOverviewID");
            entity.Property(e => e.SecuredUserProfileId).HasColumnName("SecuredUserProfileID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.ContractType).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.ContractTypeId)
                .HasConstraintName("FK_SecurityRule_ContractType");

            entity.HasOne(d => d.JobPositionGroup).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.JobPositionGroupId)
                .HasConstraintName("FK_SecurityRule_JobPositionGroup");

            entity.HasOne(d => d.JobPosition).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.JobPositionId)
                .HasConstraintName("FK_SecurityRule_JobPosition");

            entity.HasOne(d => d.Organisation).WithMany(p => p.SecurityRuleOrganisations)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_SecurityRule_Organisation_Select");

            entity.HasOne(d => d.OrganisationLevel).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.OrganisationLevelId)
                .HasConstraintName("FK_SecurityRule_OrganisationLevel");

            entity.HasOne(d => d.SecuredAppDataObject).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.SecuredAppDataObjectId)
                .HasConstraintName("FK_SecurityRule_AppDataObject_Secured");

            entity.HasOne(d => d.SecuredAppFunction).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.SecuredAppFunctionId)
                .HasConstraintName("FK_SecurityRule_AppFunction");

            entity.HasOne(d => d.SecuredCustomer).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.SecuredCustomerId)
                .HasConstraintName("FK_SecurityRule_Customer");

            entity.HasOne(d => d.SecuredFolder).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.SecuredFolderId)
                .HasConstraintName("FK_SecurityRule_Folder_Secured");

            entity.HasOne(d => d.SecuredKpi).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.SecuredKpiId)
                .HasConstraintName("FK_SecurityRule_Kpi_Secured");

            entity.HasOne(d => d.SecuredOrganisation).WithMany(p => p.SecurityRuleSecuredOrganisations)
                .HasForeignKey(d => d.SecuredOrganisationId)
                .HasConstraintName("FK_SecurityRule_Organisation_Secured");

            entity.HasOne(d => d.SecuredOverview).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.SecuredOverviewId)
                .HasConstraintName("FK_SecurityRule_Overview_Secured");

            entity.HasOne(d => d.Security).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.SecurityId)
                .HasConstraintName("FK_SecurityRule_Security");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("FK_SecurityRule_UserGroup");

            entity.HasOne(d => d.User).WithMany(p => p.SecurityRules)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_SecurityRule_User");
        });

        modelBuilder.Entity<SecurityRuleUser>(entity =>
        {
            entity.HasKey(e => new { e.SecurityRuleId, e.UserId });

            entity.ToTable("SecurityRule_User");

            entity.HasIndex(e => e.SecurityRuleId, "IX_SecurityRule_User_SecurityRuleID");

            entity.HasIndex(e => e.UserId, "IX_SecurityRule_User_UserID");

            entity.HasIndex(e => new { e.UserId, e.SecurityRuleId }, "IX_SecurityRule_User_UserID_SecurityRuleID");

            entity.Property(e => e.SecurityRuleId).HasColumnName("SecurityRuleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.SecurityRule).WithMany(p => p.SecurityRuleUsers)
                .HasForeignKey(d => d.SecurityRuleId)
                .HasConstraintName("FK_SecurityRule_User_SecurityRule");
        });

        modelBuilder.Entity<ServiceProvider>(entity =>
        {
            entity.ToTable("ServiceProvider");

            entity.Property(e => e.ServiceProviderId)
                .ValueGeneratedNever()
                .HasColumnName("ServiceProviderID");
            entity.Property(e => e.ConnectionString)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.DbMailProviderName).HasMaxLength(255);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.LinkedServerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Prompt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.ServiceProviderName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ServiceProviderTypeLkpId).HasColumnName("ServiceProviderTypeLkpID");
            entity.Property(e => e.TempDbConnectionString)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("TempDb_ConnectionString");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.HasOne(d => d.ServiceProviderTypeLkp).WithMany(p => p.ServiceProviders)
                .HasForeignKey(d => d.ServiceProviderTypeLkpId)
                .HasConstraintName("FK_ServiceProvider_AppLookupCode");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.ToTable("Subscription");

            entity.HasIndex(e => e.OverviewId, "IX_Subscription_OverviewID");

            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryTypeLkpId).HasColumnName("DeliveryTypeLkpID");
            entity.Property(e => e.EmailBlindCopyRecipients).HasMaxLength(4000);
            entity.Property(e => e.EmailBodyFormat).HasMaxLength(16);
            entity.Property(e => e.EmailCopyRecipients).HasMaxLength(4000);
            entity.Property(e => e.EmailFromAddress).HasMaxLength(255);
            entity.Property(e => e.EmailImportance).HasMaxLength(16);
            entity.Property(e => e.EmailRecipients).HasMaxLength(4000);
            entity.Property(e => e.EmailReplyToAddress).HasMaxLength(255);
            entity.Property(e => e.EmailSendTypeLkpId).HasColumnName("EmailSendTypeLkpID");
            entity.Property(e => e.EmailSensitivity).HasMaxLength(16);
            entity.Property(e => e.EmailSubject).HasMaxLength(255);
            entity.Property(e => e.EventScheduleName).HasMaxLength(255);
            entity.Property(e => e.EventTypeName).HasMaxLength(255);
            entity.Property(e => e.ExternalReference).HasMaxLength(255);
            entity.Property(e => e.GlobalReference).HasMaxLength(255);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.Location).HasMaxLength(1024);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.Remarks).HasMaxLength(4000);
            entity.Property(e => e.RenderFormatLkpId).HasColumnName("RenderFormatLkpID");
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");
            entity.Property(e => e.SortOrderCode).HasMaxLength(32);
            entity.Property(e => e.SubscriptionGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("SubscriptionGUID");
            entity.Property(e => e.SubscriptionName).HasMaxLength(255);
            entity.Property(e => e.SubscriptionTypeLkpId).HasColumnName("SubscriptionTypeLkpID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.WaitForSecPostExecution).HasColumnName("WaitForSec_PostExecution");
            entity.Property(e => e.WaitForSecPreExecution).HasColumnName("WaitForSec_PreExecution");

            entity.HasOne(d => d.AppView).WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.AppViewId)
                .HasConstraintName("FK_Subscription_AppView");

            entity.HasOne(d => d.DeliveryTypeLkp).WithMany(p => p.SubscriptionDeliveryTypeLkps)
                .HasForeignKey(d => d.DeliveryTypeLkpId)
                .HasConstraintName("FK_Subscription_AppLookupCode_DeliveryType");

            entity.HasOne(d => d.Overview).WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.OverviewId)
                .HasConstraintName("FK_Subscription_Overview");

            entity.HasOne(d => d.RenderFormatLkp).WithMany(p => p.SubscriptionRenderFormatLkps)
                .HasForeignKey(d => d.RenderFormatLkpId)
                .HasConstraintName("FK_Subscription_AppLookupCode_RenderFormat");

            entity.HasOne(d => d.Schedule).WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.ScheduleId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Subscription_Schedule");

            entity.HasOne(d => d.ServiceProvider).WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.ServiceProviderId)
                .HasConstraintName("FK_Subscription_ServiceProvider");

            entity.HasOne(d => d.SubscriptionTypeLkp).WithMany(p => p.SubscriptionSubscriptionTypeLkps)
                .HasForeignKey(d => d.SubscriptionTypeLkpId)
                .HasConstraintName("FK_Subscription_AppLookupCode_SubscriptionType");

            entity.HasOne(d => d.Template).WithMany(p => p.Subscriptions)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("FK_Subscription_Template");
        });

        modelBuilder.Entity<SubscriptionDefinitionLog>(entity =>
        {
            entity.ToTable("SubscriptionDefinitionLog");

            entity.Property(e => e.SubscriptionDefinitionLogId).HasColumnName("SubscriptionDefinitionLogID");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.DeliveryTypeLkpId).HasColumnName("DeliveryTypeLkpID");
            entity.Property(e => e.EmailBlindCopyRecipients)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.EmailBody)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.EmailBodyFormat)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.EmailCopyRecipients)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.EmailFromAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmailImportance)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.EmailRecipients)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.EmailReplyToAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmailSensitivity)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.EmailSubject)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.Parameters)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RenderFormatLkpId).HasColumnName("RenderFormatLkpID");
            entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.SubscriptionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionTypeLkpId).HasColumnName("SubscriptionTypeLkpID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");
            entity.Property(e => e.UpdateActionId).HasColumnName("UpdateActionID");
        });

        modelBuilder.Entity<SubscriptionExecutionLog>(entity =>
        {
            entity.ToTable("SubscriptionExecutionLog");

            entity.Property(e => e.SubscriptionExecutionLogId).HasColumnName("SubscriptionExecutionLogID");
            entity.Property(e => e.DeliveryTypeLkpId).HasColumnName("DeliveryTypeLkpID");
            entity.Property(e => e.EmailBodyFormat).HasMaxLength(16);
            entity.Property(e => e.EmailFromAddress).HasMaxLength(255);
            entity.Property(e => e.EmailImportance).HasMaxLength(16);
            entity.Property(e => e.EmailProviderName).HasMaxLength(255);
            entity.Property(e => e.EmailReplyToAddress).HasMaxLength(255);
            entity.Property(e => e.EmailSensitivity).HasMaxLength(16);
            entity.Property(e => e.EmailSubject).HasMaxLength(255);
            entity.Property(e => e.ErrorCode).HasMaxLength(255);
            entity.Property(e => e.EventScheduleName).HasMaxLength(255);
            entity.Property(e => e.EventTypeName).HasMaxLength(255);
            entity.Property(e => e.ExecutionCode).HasMaxLength(255);
            entity.Property(e => e.ExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.ExecutionGuid).HasColumnName("ExecutionGUID");
            entity.Property(e => e.ExecutionMessage).HasMaxLength(4000);
            entity.Property(e => e.Location).HasMaxLength(1024);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.Parameters).HasMaxLength(4000);
            entity.Property(e => e.RenderFormatLkpId).HasColumnName("RenderFormatLkpID");
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

            entity.HasOne(d => d.Subscription).WithMany(p => p.SubscriptionExecutionLogs)
                .HasForeignKey(d => d.SubscriptionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_SubscriptionExecutionLog_Subscription");
        });

        modelBuilder.Entity<SubscriptionField>(entity =>
        {
            entity.ToTable("SubscriptionField");

            entity.HasIndex(e => e.SubscriptionFieldId, "UNQ_SubscriptionField_Subscription_AppViewField").IsUnique();

            entity.Property(e => e.SubscriptionFieldId).HasColumnName("SubscriptionFieldID");
            entity.Property(e => e.AppViewFieldId).HasColumnName("AppViewFieldID");
            entity.Property(e => e.FixedValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceAppViewId).HasColumnName("ReferenceAppViewID");
            entity.Property(e => e.ReferenceName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

            entity.HasOne(d => d.AppViewField).WithMany(p => p.SubscriptionFields)
                .HasForeignKey(d => d.AppViewFieldId)
                .HasConstraintName("FK_SubscriptionField_AppViewField");

            entity.HasOne(d => d.ReferenceAppView).WithMany(p => p.SubscriptionFields)
                .HasForeignKey(d => d.ReferenceAppViewId)
                .HasConstraintName("FK_SubscriptionField_AppView_Reference");

            entity.HasOne(d => d.Subscription).WithMany(p => p.SubscriptionFields)
                .HasForeignKey(d => d.SubscriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubscriptionField_Subscription");
        });

        modelBuilder.Entity<SubscriptionRule>(entity =>
        {
            entity.ToTable("SubscriptionRule");

            entity.Property(e => e.SubscriptionRuleId)
                .ValueGeneratedNever()
                .HasColumnName("SubscriptionRuleID");
            entity.Property(e => e.ContractTypeId).HasColumnName("ContractTypeID");
            entity.Property(e => e.EmailRecepientTypeLkpId).HasColumnName("EmailRecepientTypeLkpID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsInUserSelection).HasDefaultValue(true);
            entity.Property(e => e.JobPositionGroupId).HasColumnName("JobPositionGroupID");
            entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OrganisationLevelId).HasColumnName("OrganisationLevelID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.ContractType).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.ContractTypeId)
                .HasConstraintName("FK_SubscriptionRule_ContractType");

            entity.HasOne(d => d.EmailRecepientTypeLkp).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.EmailRecepientTypeLkpId)
                .HasConstraintName("FK_SubscriptionRule_AppLookupCode_EmailRecepientType");

            entity.HasOne(d => d.JobPositionGroup).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.JobPositionGroupId)
                .HasConstraintName("FK_SubscriptionRule_JobPositionGroup");

            entity.HasOne(d => d.JobPosition).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.JobPositionId)
                .HasConstraintName("FK_SubscriptionRule_JobPosition");

            entity.HasOne(d => d.Organisation).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.OrganisationId)
                .HasConstraintName("FK_SubscriptionRule_Organisation_Select");

            entity.HasOne(d => d.OrganisationLevel).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.OrganisationLevelId)
                .HasConstraintName("FK_SubscriptionRule_OrganisationLevel");

            entity.HasOne(d => d.Subscription).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.SubscriptionId)
                .HasConstraintName("FK_SubscriptionRule_Subscription");

            entity.HasOne(d => d.UserGroup).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("FK_SubscriptionRule_UserGroup");

            entity.HasOne(d => d.User).WithMany(p => p.SubscriptionRules)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_SubscriptionRule_User");
        });

        modelBuilder.Entity<SubscriptionRuleUser>(entity =>
        {
            entity.ToTable("SubscriptionRule_User");

            entity.Property(e => e.SubscriptionRuleUserId).HasColumnName("SubscriptionRuleUserID");
            entity.Property(e => e.SubscriptionRuleId).HasColumnName("SubscriptionRuleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.SubscriptionRule).WithMany(p => p.SubscriptionRuleUsers)
                .HasForeignKey(d => d.SubscriptionRuleId)
                .HasConstraintName("FK_SubscriptionRule_User_SubscriptionRule");

            entity.HasOne(d => d.User).WithMany(p => p.SubscriptionRuleUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubscriptionRule_User_User");
        });

        modelBuilder.Entity<SubscriptionUser>(entity =>
        {
            entity.ToTable("Subscription_User");

            entity.HasIndex(e => new { e.UserId, e.SubscriptionId }, "UNQ_Subscription_User").IsUnique();

            entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");
            entity.Property(e => e.EmailRecepientTypeLkpId).HasColumnName("EmailRecepientTypeLkpID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Subscription).WithMany(p => p.SubscriptionUsers)
                .HasForeignKey(d => d.SubscriptionId)
                .HasConstraintName("FK_Subscription_User_Subscription");

            entity.HasOne(d => d.User).WithMany(p => p.SubscriptionUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Subscription_User_User");
        });

        modelBuilder.Entity<Sysssislog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sysssisl__3213E83F201A37B3");

            entity.ToTable("sysssislog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Computer)
                .HasMaxLength(128)
                .HasColumnName("computer");
            entity.Property(e => e.Databytes)
                .HasColumnType("image")
                .HasColumnName("databytes");
            entity.Property(e => e.Datacode).HasColumnName("datacode");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("endtime");
            entity.Property(e => e.Event)
                .HasMaxLength(128)
                .HasColumnName("event");
            entity.Property(e => e.Executionid).HasColumnName("executionid");
            entity.Property(e => e.Message)
                .HasMaxLength(2048)
                .HasColumnName("message");
            entity.Property(e => e.Operator)
                .HasMaxLength(128)
                .HasColumnName("operator");
            entity.Property(e => e.Source)
                .HasMaxLength(1024)
                .HasColumnName("source");
            entity.Property(e => e.Sourceid).HasColumnName("sourceid");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("starttime");
        });

        modelBuilder.Entity<SystemMessage>(entity =>
        {
            entity.ToTable("SystemMessage");

            entity.Property(e => e.SystemMessageId).HasColumnName("SystemMessageID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SystemMessage1)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SystemMessage");
        });

        modelBuilder.Entity<SystemSetting>(entity =>
        {
            entity.ToTable("SystemSetting");

            entity.Property(e => e.SystemSettingId)
                .ValueGeneratedNever()
                .HasColumnName("SystemSettingID");
            entity.Property(e => e.AdministratorEmail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AdministratorTelephone)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ApprovalMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.DataApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.DataLastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.DisabledUserMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.HelpdeskEmail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HelpdeskTelephone)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ImageMasterDirectory)
                .HasMaxLength(1024)
                .IsUnicode(false);
            entity.Property(e => e.IsApplicationOffline).HasDefaultValue(false);
            entity.Property(e => e.IsSearchEnabled).HasDefaultValue(true);
            entity.Property(e => e.LogoAppImageId).HasColumnName("LogoAppImageID");
            entity.Property(e => e.OffLineMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.OpeningAppFormId).HasColumnName("OpeningAppFormID");
            entity.Property(e => e.PortalColorCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.PortalTitle)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ShowWelcomeMessage).HasDefaultValue(true);
            entity.Property(e => e.StaticReportPath)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WelcomeMessage)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.LogoAppImage).WithMany(p => p.SystemSettings)
                .HasForeignKey(d => d.LogoAppImageId)
                .HasConstraintName("FK_SystemSetting_AppImage");

            entity.HasOne(d => d.OpeningAppForm).WithMany(p => p.SystemSettings)
                .HasForeignKey(d => d.OpeningAppFormId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_SystemSetting_AppForm");
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity.ToTable("Template");

            entity.Property(e => e.TemplateId)
                .ValueGeneratedNever()
                .HasColumnName("TemplateID");
            entity.Property(e => e.Location).HasMaxLength(1024);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(4000);
            entity.Property(e => e.Subject).HasMaxLength(255);
            entity.Property(e => e.TemplateName).HasMaxLength(128);
            entity.Property(e => e.TemplateTypeLkpId).HasColumnName("TemplateTypeLkpID");

            entity.HasOne(d => d.TemplateTypeLkp).WithMany(p => p.Templates)
                .HasForeignKey(d => d.TemplateTypeLkpId)
                .HasConstraintName("FK_Template_AppLookupCode_TemplateType");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TestRR");

            entity.ToTable("Test");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RowRef)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.ContractTypeId, "IX_User_ContractTypeID");

            entity.HasIndex(e => e.CustomOrganisationLevelId, "IX_User_CustomOrganisationLevelID");

            entity.HasIndex(e => e.DefaultCustomerLevelId, "IX_User_DefaultCustomerLevelID");

            entity.HasIndex(e => e.DefaultFolderId, "IX_User_DefaultFolderID");

            entity.HasIndex(e => e.DefaultOrganisationLevelId, "IX_User_DefaultOrganisationLevelID");

            entity.HasIndex(e => e.DefaultOverviewId, "IX_User_DefaultOverviewID");

            entity.HasIndex(e => e.JobPositionId, "IX_User_JobPositionID");

            entity.HasIndex(e => e.ManagerUserId, "IX_User_ManagerUserID");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.BusinessPhone)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ContractEndDate).HasColumnType("datetime");
            entity.Property(e => e.ContractTypeId).HasColumnName("ContractTypeID");
            entity.Property(e => e.CustomAllAppFunctionSecurityId).HasColumnName("CustomAllAppFunctionSecurityID");
            entity.Property(e => e.CustomAllCustomersSecurityId).HasColumnName("CustomAllCustomersSecurityID");
            entity.Property(e => e.CustomAllFoldersSecurityId).HasColumnName("CustomAllFoldersSecurityID");
            entity.Property(e => e.CustomAllOrganisationsSecurityId).HasColumnName("CustomAllOrganisationsSecurityID");
            entity.Property(e => e.CustomAllOverviewsSecurityId).HasColumnName("CustomAllOverviewsSecurityID");
            entity.Property(e => e.CustomCustomerLevelId).HasColumnName("CustomCustomerLevelID");
            entity.Property(e => e.CustomLoginStatusLkpId).HasColumnName("CustomLoginStatusLkpID");
            entity.Property(e => e.CustomOrganisationLevelId).HasColumnName("CustomOrganisationLevelID");
            entity.Property(e => e.DefaultAllAppFunctionSecurityId).HasColumnName("DefaultAllAppFunctionSecurityID");
            entity.Property(e => e.DefaultAllCustomersSecurityId).HasColumnName("DefaultAllCustomersSecurityID");
            entity.Property(e => e.DefaultAllFoldersSecurityId).HasColumnName("DefaultAllFoldersSecurityID");
            entity.Property(e => e.DefaultAllOrganisationsSecurityId).HasColumnName("DefaultAllOrganisationsSecurityID");
            entity.Property(e => e.DefaultAllOverviewsSecurityId).HasColumnName("DefaultAllOverviewsSecurityID");
            entity.Property(e => e.DefaultCustomerLevelId).HasColumnName("DefaultCustomerLevelID");
            entity.Property(e => e.DefaultFolderId).HasColumnName("DefaultFolderID");
            entity.Property(e => e.DefaultLoginStatusLkpId).HasColumnName("DefaultLoginStatusLkpID");
            entity.Property(e => e.DefaultOrganisationLevelId).HasColumnName("DefaultOrganisationLevelID");
            entity.Property(e => e.DefaultOverviewId).HasColumnName("DefaultOverviewID");
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GlobalReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HomePhone)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.IsParameterTrackingEnabled).HasDefaultValue(true);
            entity.Property(e => e.JobPositionId).HasColumnName("JobPositionID");
            entity.Property(e => e.LoginName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ManagerUserId).HasColumnName("ManagerUserID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SystemMessageId).HasColumnName("SystemMessageID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserTypeLkpId).HasColumnName("UserTypeLkpID");
            entity.Property(e => e.ViewPriorityLkpId).HasColumnName("ViewPriorityLkpID");

            entity.HasOne(d => d.ContractType).WithMany(p => p.Users)
                .HasForeignKey(d => d.ContractTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_User_ContractType");

            entity.HasOne(d => d.CustomCustomerLevel).WithMany(p => p.UserCustomCustomerLevels)
                .HasForeignKey(d => d.CustomCustomerLevelId)
                .HasConstraintName("FK_User_CustomerLevel_Custom");

            entity.HasOne(d => d.CustomLoginStatusLkp).WithMany(p => p.UserCustomLoginStatusLkps)
                .HasForeignKey(d => d.CustomLoginStatusLkpId)
                .HasConstraintName("FK_User_AppLookupCode_CustomLoginStatus");

            entity.HasOne(d => d.CustomOrganisationLevel).WithMany(p => p.UserCustomOrganisationLevels)
                .HasForeignKey(d => d.CustomOrganisationLevelId)
                .HasConstraintName("FK_User_OrganisationLevel_Custom");

            entity.HasOne(d => d.DefaultCustomerLevel).WithMany(p => p.UserDefaultCustomerLevels)
                .HasForeignKey(d => d.DefaultCustomerLevelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_User_CustomerLevel_Default");

            entity.HasOne(d => d.DefaultFolder).WithMany(p => p.Users)
                .HasForeignKey(d => d.DefaultFolderId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_User_Folder");

            entity.HasOne(d => d.DefaultLoginStatusLkp).WithMany(p => p.UserDefaultLoginStatusLkps)
                .HasForeignKey(d => d.DefaultLoginStatusLkpId)
                .HasConstraintName("FK_User_AppLookupCode_DefaultLoginStatus");

            entity.HasOne(d => d.DefaultOrganisationLevel).WithMany(p => p.UserDefaultOrganisationLevels)
                .HasForeignKey(d => d.DefaultOrganisationLevelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_User_OrganisationLevel_Default");

            entity.HasOne(d => d.DefaultOverview).WithMany(p => p.Users)
                .HasForeignKey(d => d.DefaultOverviewId)
                .HasConstraintName("FK_User_Overview");

            entity.HasOne(d => d.JobPosition).WithMany(p => p.Users)
                .HasForeignKey(d => d.JobPositionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_User_JobPosition");

            entity.HasOne(d => d.ManagerUser).WithMany(p => p.InverseManagerUser)
                .HasForeignKey(d => d.ManagerUserId)
                .HasConstraintName("FK_User_ManagerUser");

            entity.HasOne(d => d.SystemMessage).WithMany(p => p.Users)
                .HasForeignKey(d => d.SystemMessageId)
                .HasConstraintName("FK_User_SystemMessage");

            entity.HasOne(d => d.UserTypeLkp).WithMany(p => p.UserUserTypeLkps)
                .HasForeignKey(d => d.UserTypeLkpId)
                .HasConstraintName("FK_User_AppLookupCode_UserType");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.ToTable("UserGroup");

            entity.Property(e => e.UserGroupId)
                .ValueGeneratedNever()
                .HasColumnName("UserGroupID");
            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.UserGroupCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.UserGroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserStatistic>(entity =>
        {
            entity.HasKey(e => e.UserStatisticsId);

            entity.HasIndex(e => new { e.DateId, e.UserId }, "IX_UserStatistics_DateID_UserID")
                .IsUnique()
                .HasFillFactor(60);

            entity.HasIndex(e => new { e.DateId, e.UserId }, "UNQ_UserStatistics_DateID_UserID").IsUnique();

            entity.Property(e => e.UserStatisticsId).HasColumnName("UserStatisticsID");
            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OrgCustomAllocations)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.OrgDefaultAllocations)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserStatistics)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserStatistics_User");
        });

        modelBuilder.Entity<UserUserGroup>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.UserGroupId });

            entity.ToTable("User_UserGroup");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);

            entity.HasOne(d => d.UserGroup).WithMany(p => p.UserUserGroups)
                .HasForeignKey(d => d.UserGroupId)
                .HasConstraintName("FK_User_UserGroup_UserGroup");

            entity.HasOne(d => d.User).WithMany(p => p.UserUserGroups)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_User_UserGroup_User");
        });

        modelBuilder.Entity<UserUserProfile>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ProfileUserId });

            entity.ToTable("User_UserProfile");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ProfileUserId).HasColumnName("ProfileUserID");
        });

        modelBuilder.Entity<UserUserVirtual>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.VirtualUserId });

            entity.ToTable("User_UserVirtual");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.VirtualUserId).HasColumnName("VirtualUserID");
        });

        modelBuilder.Entity<VwAppDataObjectPageSelectAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppDataObjectPage_SelectAll");

            entity.Property(e => e.AppDataObjectPageId).HasColumnName("AppDataObjectPageID");
            entity.Property(e => e.AppDataObjectPageName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppFormConfigName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.AppFormId).HasColumnName("AppFormID");
            entity.Property(e => e.AppFormName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.AppViewName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ChildAppDataObjectId).HasColumnName("ChildAppDataObjectID");
            entity.Property(e => e.ChildAppDataObjectName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.LinkedTable)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ParameterAppViewId).HasColumnName("ParameterAppViewID");
            entity.Property(e => e.ParentAppDataObjectId).HasColumnName("ParentAppDataObjectID");
            entity.Property(e => e.ParentAppDataObjectName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<VwAppDataObjectSelectAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppDataObject_SelectAll");

            entity.Property(e => e.AllowedSecurityId).HasColumnName("AllowedSecurityID");
            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppDataObjectName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppFormConfigName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DataSourceId).HasColumnName("DataSourceID");
            entity.Property(e => e.DataSourceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.PageAppViewId).HasColumnName("PageAppViewID");
            entity.Property(e => e.PageAppViewName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.PrimaryFields)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.SearchFields)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.TitleAppViewId).HasColumnName("TitleAppViewID");
            entity.Property(e => e.TitleAppViewName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<VwAppDataObjectUserAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppDataObject_User_Admin");

            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppDataObjectUserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AppDataObjectUserID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwAppDataObjectUserIsRead>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppDataObject_User_IsRead");

            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwAppFunctionUserAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppFunction_User_Admin");

            entity.Property(e => e.AppFunctionId).HasColumnName("AppFunctionID");
            entity.Property(e => e.AppFunctionUserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AppFunctionUserID");
            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwAppFunctionUserIsExecute>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppFunction_User_IsExecute");

            entity.Property(e => e.AppFunctionId).HasColumnName("AppFunctionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwAppFunctionUserIsRead>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppFunction_User_IsRead");

            entity.Property(e => e.AppFunctionId).HasColumnName("AppFunctionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwAppViewCreateView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppView_CreateView");

            entity.Property(e => e.Sql1)
                .HasMaxLength(246)
                .IsUnicode(false);
            entity.Property(e => e.Sql2)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Sql3)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAppViewFieldLabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppViewField_Label");

            entity.Property(e => e.FieldLabel)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.FieldName)
                .HasMaxLength(38)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAppViewFieldNotInSourceCommand>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppViewField_NotInSourceCommand");

            entity.Property(e => e.AppViewFieldId).HasColumnName("AppViewFieldID");
            entity.Property(e => e.AppViewFieldName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ChildAppViewId).HasColumnName("ChildAppViewID");
            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.ControlTypeLkpId).HasColumnName("ControlTypeLkpID");
            entity.Property(e => e.CummulativeHeight).HasColumnType("decimal(10, 6)");
            entity.Property(e => e.DataTypeLkpId).HasColumnName("DataTypeLkpID");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DefaultValueRefName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FunctionReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaHashValue)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.NavigationReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ParentAppViewId).HasColumnName("ParentAppViewID");
            entity.Property(e => e.RelativeWidth).HasColumnType("decimal(10, 6)");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SourceFieldName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ValueList)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwAppViewSelectAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAppView_SelectAll");

            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppDataObjectName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.AppViewName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.LayoutTypeLkpId).HasColumnName("LayoutTypeLkpID");
            entity.Property(e => e.LayoutTypeLkpName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ParameterAppViewId).HasColumnName("ParameterAppViewID");
            entity.Property(e => e.ParameterAppViewName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.PriorityLkpId).HasColumnName("PriorityLkpID");
            entity.Property(e => e.PriorityLkpName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.SearchFields)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.SourceCommand)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<VwBrDbTableFieldMissingInDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBR_DbTableField_MissingInDb");

            entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");
            entity.Property(e => e.DataTypeName).HasMaxLength(128);
            entity.Property(e => e.DbTableId).HasColumnName("DbTableID");
            entity.Property(e => e.FieldName).HasMaxLength(128);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.TableName).HasMaxLength(128);
        });

        modelBuilder.Entity<VwBrDbTableFieldNotExistInDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBR_DbTableField_NotExistInDb");

            entity.Property(e => e.DataTypeLkpId).HasColumnName("DataTypeLkpID");
            entity.Property(e => e.DbTableId).HasColumnName("DbTableID");
            entity.Property(e => e.DbTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FieldName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwBrDbTableMissingInDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBR_DbTable_MissingInDb");

            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.TableName).HasMaxLength(128);
        });

        modelBuilder.Entity<VwBrDbTableMissingInDbBdw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBR_DbTable_MissingInDb_BDW");

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName).HasMaxLength(128);
            entity.Property(e => e.RowId).HasColumnName("RowID");
        });

        modelBuilder.Entity<VwBrDbTableMissingInDbDmsa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBR_DbTable_MissingInDb_DMSA");

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName).HasMaxLength(128);
            entity.Property(e => e.RowId).HasColumnName("RowID");
        });

        modelBuilder.Entity<VwBrDbTableMissingInDbDsa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBR_DbTable_MissingInDb_DSA");

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName).HasMaxLength(128);
            entity.Property(e => e.RowId).HasColumnName("RowID");
        });

        modelBuilder.Entity<VwBrDbTableMissingInDbIsa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBR_DbTable_MissingInDb_ISA");

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName).HasMaxLength(128);
            entity.Property(e => e.RowId).HasColumnName("RowID");
        });

        modelBuilder.Entity<VwBrDbTableNotExistInDb>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBR_DbTable_NotExistInDb");

            entity.Property(e => e.DbTableId).HasColumnName("DbTableID");
            entity.Property(e => e.DbTableName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryFields)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCustomerHierachy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomer_Hierachy");

            entity.Property(e => e.CustomerCompleteId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Customer_CompleteID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerLevelId).HasColumnName("CustomerLevelID");
            entity.Property(e => e.L1Cid).HasColumnName("L1_CID");
            entity.Property(e => e.L2Cid).HasColumnName("L2_CID");
            entity.Property(e => e.L3Cid).HasColumnName("L3_CID");
            entity.Property(e => e.L4Cid).HasColumnName("L4_CID");
            entity.Property(e => e.L5Cid).HasColumnName("L5_CID");
            entity.Property(e => e.L6Cid).HasColumnName("L6_CID");
            entity.Property(e => e.L7Cid).HasColumnName("L7_CID");
            entity.Property(e => e.L8Cid).HasColumnName("L8_CID");
            entity.Property(e => e.ParentCustomerId).HasColumnName("ParentCustomerID");
            entity.Property(e => e.RecursionId).HasColumnName("RecursionID");
        });

        modelBuilder.Entity<VwCustomerSubscriptionOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomer_SubscriptionOverview");

            entity.Property(e => e.CompleteCustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmailBlindCopyRecipients).HasMaxLength(4000);
            entity.Property(e => e.EmailCopyRecipients).HasMaxLength(4000);
            entity.Property(e => e.EmailRecipients).HasMaxLength(4000);
            entity.Property(e => e.LastExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.NextExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.OverviewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.ScheduleName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.SubscriptionName).HasMaxLength(255);
            entity.Property(e => e.SubscriptionReference).HasMaxLength(255);
            entity.Property(e => e.SubscriptionType)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwCustomerUserCustomLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomer_User_CustomLevel");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwCustomerUserIsRead>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCustomer_User_IsRead");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwDateConvertStringToDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDate_ConvertStringToDate");

            entity.Property(e => e.CastToDateValue)
                .HasColumnType("datetime")
                .HasColumnName("CastToDate_Value");
            entity.Property(e => e.DateString)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.StrToDateValue)
                .HasColumnType("datetime")
                .HasColumnName("StrToDate_Value");
        });

        modelBuilder.Entity<VwDateGetMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDate_GetMonths");

            entity.Property(e => e.FirstDateId).HasColumnName("FirstDateID");
            entity.Property(e => e.FirstWeekFirstDateId).HasColumnName("FirstWeekFirstDateID");
            entity.Property(e => e.FirstWeekId).HasColumnName("FirstWeekID");
            entity.Property(e => e.LastDateId).HasColumnName("LastDateID");
            entity.Property(e => e.LastWeekId).HasColumnName("LastWeekID");
            entity.Property(e => e.LastWeekLastDateId).HasColumnName("LastWeekLastDateID");
            entity.Property(e => e.MonthCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.MonthName)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDateGetP444>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDate_GetP444");

            entity.Property(e => e.FirstDateId).HasColumnName("FirstDateID");
            entity.Property(e => e.FirstWeekFirstDateId).HasColumnName("FirstWeekFirstDateID");
            entity.Property(e => e.FirstWeekId).HasColumnName("FirstWeekID");
            entity.Property(e => e.LastDateId).HasColumnName("LastDateID");
            entity.Property(e => e.LastWeekId).HasColumnName("LastWeekID");
            entity.Property(e => e.LastWeekLastDateId).HasColumnName("LastWeekLastDateID");
            entity.Property(e => e.P444numberOfYear).HasColumnName("P444NumberOfYear");
            entity.Property(e => e.Period444Name)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDateGetP445>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDate_GetP445");

            entity.Property(e => e.FirstDateId).HasColumnName("FirstDateID");
            entity.Property(e => e.FirstWeekFirstDateId).HasColumnName("FirstWeekFirstDateID");
            entity.Property(e => e.FirstWeekId).HasColumnName("FirstWeekID");
            entity.Property(e => e.LastDateId).HasColumnName("LastDateID");
            entity.Property(e => e.LastWeekId).HasColumnName("LastWeekID");
            entity.Property(e => e.LastWeekLastDateId).HasColumnName("LastWeekLastDateID");
            entity.Property(e => e.P445numberOfYear).HasColumnName("P445NumberOfYear");
            entity.Property(e => e.Period445Name)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDateGetQuater>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDate_GetQuaters");

            entity.Property(e => e.FirstDateId).HasColumnName("FirstDateID");
            entity.Property(e => e.FirstWeekFirstDateId).HasColumnName("FirstWeekFirstDateID");
            entity.Property(e => e.FirstWeekId).HasColumnName("FirstWeekID");
            entity.Property(e => e.LastDateId).HasColumnName("LastDateID");
            entity.Property(e => e.LastWeekId).HasColumnName("LastWeekID");
            entity.Property(e => e.LastWeekLastDateId).HasColumnName("LastWeekLastDateID");
            entity.Property(e => e.QuaterCode)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.QuaterName)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwDateGetWeek>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDate_GetWeeks");

            entity.Property(e => e.FirstDateId).HasColumnName("FirstDateID");
            entity.Property(e => e.FirstWeekFirstDateId).HasColumnName("FirstWeekFirstDateID");
            entity.Property(e => e.LastDateId).HasColumnName("LastDateID");
            entity.Property(e => e.LastWeekLastDateId).HasColumnName("LastWeekLastDateID");
        });

        modelBuilder.Entity<VwDateGetYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDate_GetYears");

            entity.Property(e => e.FirstDayId).HasColumnName("FirstDayID");
            entity.Property(e => e.FirstWeekFirstDateId).HasColumnName("FirstWeekFirstDateID");
            entity.Property(e => e.FirstWeekId).HasColumnName("FirstWeekID");
            entity.Property(e => e.LastDayId).HasColumnName("LastDayID");
            entity.Property(e => e.LastWeekId).HasColumnName("LastWeekID");
            entity.Property(e => e.LastWeekLastDateId).HasColumnName("LastWeekLastDateID");
        });

        modelBuilder.Entity<VwDateValueDayId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDateValue_DayIDs");

            entity.Property(e => e.CalendarMonthAllNrOfDays).HasColumnName("CalendarMonth_AllNrOfDays");
            entity.Property(e => e.CalendarMonthFirstAllDayId).HasColumnName("CalendarMonth_First_AllDayID");
            entity.Property(e => e.CalendarMonthFirstHoliDayId).HasColumnName("CalendarMonth_First_HoliDayID");
            entity.Property(e => e.CalendarMonthFirstNonWorkingDayId).HasColumnName("CalendarMonth_First_NonWorkingDayID");
            entity.Property(e => e.CalendarMonthFirstWeekDayId).HasColumnName("CalendarMonth_First_WeekDayID");
            entity.Property(e => e.CalendarMonthFirstWeekendDayId).HasColumnName("CalendarMonth_First_WeekendDayID");
            entity.Property(e => e.CalendarMonthFirstWorkingDayId).HasColumnName("CalendarMonth_First_WorkingDayID");
            entity.Property(e => e.CalendarMonthHoliNrOfDays).HasColumnName("CalendarMonth_HoliNrOfDays");
            entity.Property(e => e.CalendarMonthId).HasColumnName("Calendar_MonthID");
            entity.Property(e => e.CalendarMonthLastAllDayId).HasColumnName("CalendarMonth_Last_AllDayID");
            entity.Property(e => e.CalendarMonthLastHoliDayId).HasColumnName("CalendarMonth_Last_HoliDayID");
            entity.Property(e => e.CalendarMonthLastNonWorkingDayId).HasColumnName("CalendarMonth_Last_NonWorkingDayID");
            entity.Property(e => e.CalendarMonthLastWeekDayId).HasColumnName("CalendarMonth_Last_WeekDayID");
            entity.Property(e => e.CalendarMonthLastWeekendDayId).HasColumnName("CalendarMonth_Last_WeekendDayID");
            entity.Property(e => e.CalendarMonthLastWorkingDayId).HasColumnName("CalendarMonth_Last_WorkingDayID");
            entity.Property(e => e.CalendarMonthNonWorkingNrOfDays).HasColumnName("CalendarMonth_NonWorkingNrOfDays");
            entity.Property(e => e.CalendarMonthWeekNrOfDays).HasColumnName("CalendarMonth_WeekNrOfDays");
            entity.Property(e => e.CalendarMonthWeekendNrOfDays).HasColumnName("CalendarMonth_WeekendNrOfDays");
            entity.Property(e => e.CalendarMonthWorkingNrOfDays).HasColumnName("CalendarMonth_WorkingNrOfDays");
            entity.Property(e => e.CalendarQuarterAllNrOfDays).HasColumnName("CalendarQuarter_AllNrOfDays");
            entity.Property(e => e.CalendarQuarterFirstAllDayId).HasColumnName("CalendarQuarter_First_AllDayID");
            entity.Property(e => e.CalendarQuarterFirstHoliDayId).HasColumnName("CalendarQuarter_First_HoliDayID");
            entity.Property(e => e.CalendarQuarterFirstNonWorkingDayId).HasColumnName("CalendarQuarter_First_NonWorkingDayID");
            entity.Property(e => e.CalendarQuarterFirstWeekDayId).HasColumnName("CalendarQuarter_First_WeekDayID");
            entity.Property(e => e.CalendarQuarterFirstWeekendDayId).HasColumnName("CalendarQuarter_First_WeekendDayID");
            entity.Property(e => e.CalendarQuarterFirstWorkingDayId).HasColumnName("CalendarQuarter_First_WorkingDayID");
            entity.Property(e => e.CalendarQuarterHoliNrOfDays).HasColumnName("CalendarQuarter_HoliNrOfDays");
            entity.Property(e => e.CalendarQuarterId).HasColumnName("Calendar_QuarterID");
            entity.Property(e => e.CalendarQuarterLastAllDayId).HasColumnName("CalendarQuarter_Last_AllDayID");
            entity.Property(e => e.CalendarQuarterLastHoliDayId).HasColumnName("CalendarQuarter_Last_HoliDayID");
            entity.Property(e => e.CalendarQuarterLastNonWorkingDayId).HasColumnName("CalendarQuarter_Last_NonWorkingDayID");
            entity.Property(e => e.CalendarQuarterLastWeekDayId).HasColumnName("CalendarQuarter_Last_WeekDayID");
            entity.Property(e => e.CalendarQuarterLastWeekendDayId).HasColumnName("CalendarQuarter_Last_WeekendDayID");
            entity.Property(e => e.CalendarQuarterLastWorkingDayId).HasColumnName("CalendarQuarter_Last_WorkingDayID");
            entity.Property(e => e.CalendarQuarterNonWorkingNrOfDays).HasColumnName("CalendarQuarter_NonWorkingNrOfDays");
            entity.Property(e => e.CalendarQuarterWeekNrOfDays).HasColumnName("CalendarQuarter_WeekNrOfDays");
            entity.Property(e => e.CalendarQuarterWeekendNrOfDays).HasColumnName("CalendarQuarter_WeekendNrOfDays");
            entity.Property(e => e.CalendarQuarterWorkingNrOfDays).HasColumnName("CalendarQuarter_WorkingNrOfDays");
            entity.Property(e => e.CalendarYearAllNrOfDays).HasColumnName("CalendarYear_AllNrOfDays");
            entity.Property(e => e.CalendarYearFirstAllDayId).HasColumnName("CalendarYear_First_AllDayID");
            entity.Property(e => e.CalendarYearFirstHoliDayId).HasColumnName("CalendarYear_First_HoliDayID");
            entity.Property(e => e.CalendarYearFirstNonWorkingDayId).HasColumnName("CalendarYear_First_NonWorkingDayID");
            entity.Property(e => e.CalendarYearFirstWeekDayId).HasColumnName("CalendarYear_First_WeekDayID");
            entity.Property(e => e.CalendarYearFirstWeekendDayId).HasColumnName("CalendarYear_First_WeekendDayID");
            entity.Property(e => e.CalendarYearFirstWorkingDayId).HasColumnName("CalendarYear_First_WorkingDayID");
            entity.Property(e => e.CalendarYearHoliNrOfDays).HasColumnName("CalendarYear_HoliNrOfDays");
            entity.Property(e => e.CalendarYearId).HasColumnName("Calendar_YearID");
            entity.Property(e => e.CalendarYearLastAllDayId).HasColumnName("CalendarYear_Last_AllDayID");
            entity.Property(e => e.CalendarYearLastHoliDayId).HasColumnName("CalendarYear_Last_HoliDayID");
            entity.Property(e => e.CalendarYearLastNonWorkingDayId).HasColumnName("CalendarYear_Last_NonWorkingDayID");
            entity.Property(e => e.CalendarYearLastWeekDayId).HasColumnName("CalendarYear_Last_WeekDayID");
            entity.Property(e => e.CalendarYearLastWeekendDayId).HasColumnName("CalendarYear_Last_WeekendDayID");
            entity.Property(e => e.CalendarYearLastWorkingDayId).HasColumnName("CalendarYear_Last_WorkingDayID");
            entity.Property(e => e.CalendarYearNonWorkingNrOfDays).HasColumnName("CalendarYear_NonWorkingNrOfDays");
            entity.Property(e => e.CalendarYearWeekNrOfDays).HasColumnName("CalendarYear_WeekNrOfDays");
            entity.Property(e => e.CalendarYearWeekendNrOfDays).HasColumnName("CalendarYear_WeekendNrOfDays");
            entity.Property(e => e.CalendarYearWorkingNrOfDays).HasColumnName("CalendarYear_WorkingNrOfDays");
            entity.Property(e => e.DateValue).HasColumnType("datetime");
            entity.Property(e => e.WeekAllNrOfDays).HasColumnName("Week_AllNrOfDays");
            entity.Property(e => e.WeekFirstAllDayId).HasColumnName("Week_First_AllDayID");
            entity.Property(e => e.WeekFirstHoliDayId).HasColumnName("Week_First_HoliDayID");
            entity.Property(e => e.WeekFirstNonWorkingDayId).HasColumnName("Week_First_NonWorkingDayID");
            entity.Property(e => e.WeekFirstWeekDayId).HasColumnName("Week_First_WeekDayID");
            entity.Property(e => e.WeekFirstWeekendDayId).HasColumnName("Week_First_WeekendDayID");
            entity.Property(e => e.WeekFirstWorkingDayId).HasColumnName("Week_First_WorkingDayID");
            entity.Property(e => e.WeekHoliNrOfDays).HasColumnName("Week_HoliNrOfDays");
            entity.Property(e => e.WeekId).HasColumnName("WeekID");
            entity.Property(e => e.WeekLastAllDayId).HasColumnName("Week_Last_AllDayID");
            entity.Property(e => e.WeekLastHoliDayId).HasColumnName("Week_Last_HoliDayID");
            entity.Property(e => e.WeekLastNonWorkingDayId).HasColumnName("Week_Last_NonWorkingDayID");
            entity.Property(e => e.WeekLastWeekDayId).HasColumnName("Week_Last_WeekDayID");
            entity.Property(e => e.WeekLastWeekendDayId).HasColumnName("Week_Last_WeekendDayID");
            entity.Property(e => e.WeekLastWorkingDayId).HasColumnName("Week_Last_WorkingDayID");
            entity.Property(e => e.WeekNonWorkingNrOfDays).HasColumnName("Week_NonWorkingNrOfDays");
            entity.Property(e => e.WeekP444AllNrOfDays).HasColumnName("WeekP444_AllNrOfDays");
            entity.Property(e => e.WeekP444FirstAllDayId).HasColumnName("WeekP444_First_AllDayID");
            entity.Property(e => e.WeekP444FirstHoliDayId).HasColumnName("WeekP444_First_HoliDayID");
            entity.Property(e => e.WeekP444FirstNonWorkingDayId).HasColumnName("WeekP444_First_NonWorkingDayID");
            entity.Property(e => e.WeekP444FirstWeekDayId).HasColumnName("WeekP444_First_WeekDayID");
            entity.Property(e => e.WeekP444FirstWeekendDayId).HasColumnName("WeekP444_First_WeekendDayID");
            entity.Property(e => e.WeekP444FirstWorkingDayId).HasColumnName("WeekP444_First_WorkingDayID");
            entity.Property(e => e.WeekP444HoliNrOfDays).HasColumnName("WeekP444_HoliNrOfDays");
            entity.Property(e => e.WeekP444LastAllDayId).HasColumnName("WeekP444_Last_AllDayID");
            entity.Property(e => e.WeekP444LastHoliDayId).HasColumnName("WeekP444_Last_HoliDayID");
            entity.Property(e => e.WeekP444LastNonWorkingDayId).HasColumnName("WeekP444_Last_NonWorkingDayID");
            entity.Property(e => e.WeekP444LastWeekDayId).HasColumnName("WeekP444_Last_WeekDayID");
            entity.Property(e => e.WeekP444LastWeekendDayId).HasColumnName("WeekP444_Last_WeekendDayID");
            entity.Property(e => e.WeekP444LastWorkingDayId).HasColumnName("WeekP444_Last_WorkingDayID");
            entity.Property(e => e.WeekP444NonWorkingNrOfDays).HasColumnName("WeekP444_NonWorkingNrOfDays");
            entity.Property(e => e.WeekP444WeekNrOfDays).HasColumnName("WeekP444_WeekNrOfDays");
            entity.Property(e => e.WeekP444WeekendNrOfDays).HasColumnName("WeekP444_WeekendNrOfDays");
            entity.Property(e => e.WeekP444WorkingNrOfDays).HasColumnName("WeekP444_WorkingNrOfDays");
            entity.Property(e => e.WeekP444id).HasColumnName("Week_P444ID");
            entity.Property(e => e.WeekP445AllNrOfDays).HasColumnName("WeekP445_AllNrOfDays");
            entity.Property(e => e.WeekP445FirstAllDayId).HasColumnName("WeekP445_First_AllDayID");
            entity.Property(e => e.WeekP445FirstHoliDayId).HasColumnName("WeekP445_First_HoliDayID");
            entity.Property(e => e.WeekP445FirstNonWorkingDayId).HasColumnName("WeekP445_First_NonWorkingDayID");
            entity.Property(e => e.WeekP445FirstWeekDayId).HasColumnName("WeekP445_First_WeekDayID");
            entity.Property(e => e.WeekP445FirstWeekendDayId).HasColumnName("WeekP445_First_WeekendDayID");
            entity.Property(e => e.WeekP445FirstWorkingDayId).HasColumnName("WeekP445_First_WorkingDayID");
            entity.Property(e => e.WeekP445HoliNrOfDays).HasColumnName("WeekP445_HoliNrOfDays");
            entity.Property(e => e.WeekP445LastAllDayId).HasColumnName("WeekP445_Last_AllDayID");
            entity.Property(e => e.WeekP445LastHoliDayId).HasColumnName("WeekP445_Last_HoliDayID");
            entity.Property(e => e.WeekP445LastNonWorkingDayId).HasColumnName("WeekP445_Last_NonWorkingDayID");
            entity.Property(e => e.WeekP445LastWeekDayId).HasColumnName("WeekP445_Last_WeekDayID");
            entity.Property(e => e.WeekP445LastWeekendDayId).HasColumnName("WeekP445_Last_WeekendDayID");
            entity.Property(e => e.WeekP445LastWorkingDayId).HasColumnName("WeekP445_Last_WorkingDayID");
            entity.Property(e => e.WeekP445NonWorkingNrOfDays).HasColumnName("WeekP445_NonWorkingNrOfDays");
            entity.Property(e => e.WeekP445WeekNrOfDays).HasColumnName("WeekP445_WeekNrOfDays");
            entity.Property(e => e.WeekP445WeekendNrOfDays).HasColumnName("WeekP445_WeekendNrOfDays");
            entity.Property(e => e.WeekP445WorkingNrOfDays).HasColumnName("WeekP445_WorkingNrOfDays");
            entity.Property(e => e.WeekP445id).HasColumnName("Week_P445ID");
            entity.Property(e => e.WeekQuarterAllNrOfDays).HasColumnName("WeekQuarter_AllNrOfDays");
            entity.Property(e => e.WeekQuarterFirstAllDayId).HasColumnName("WeekQuarter_First_AllDayID");
            entity.Property(e => e.WeekQuarterFirstHoliDayId).HasColumnName("WeekQuarter_First_HoliDayID");
            entity.Property(e => e.WeekQuarterFirstNonWorkingDayId).HasColumnName("WeekQuarter_First_NonWorkingDayID");
            entity.Property(e => e.WeekQuarterFirstWeekDayId).HasColumnName("WeekQuarter_First_WeekDayID");
            entity.Property(e => e.WeekQuarterFirstWeekendDayId).HasColumnName("WeekQuarter_First_WeekendDayID");
            entity.Property(e => e.WeekQuarterFirstWorkingDayId).HasColumnName("WeekQuarter_First_WorkingDayID");
            entity.Property(e => e.WeekQuarterHoliNrOfDays).HasColumnName("WeekQuarter_HoliNrOfDays");
            entity.Property(e => e.WeekQuarterId).HasColumnName("Week_QuarterID");
            entity.Property(e => e.WeekQuarterLastAllDayId).HasColumnName("WeekQuarter_Last_AllDayID");
            entity.Property(e => e.WeekQuarterLastHoliDayId).HasColumnName("WeekQuarter_Last_HoliDayID");
            entity.Property(e => e.WeekQuarterLastNonWorkingDayId).HasColumnName("WeekQuarter_Last_NonWorkingDayID");
            entity.Property(e => e.WeekQuarterLastWeekDayId).HasColumnName("WeekQuarter_Last_WeekDayID");
            entity.Property(e => e.WeekQuarterLastWeekendDayId).HasColumnName("WeekQuarter_Last_WeekendDayID");
            entity.Property(e => e.WeekQuarterLastWorkingDayId).HasColumnName("WeekQuarter_Last_WorkingDayID");
            entity.Property(e => e.WeekQuarterNonWorkingNrOfDays).HasColumnName("WeekQuarter_NonWorkingNrOfDays");
            entity.Property(e => e.WeekQuarterWeekNrOfDays).HasColumnName("WeekQuarter_WeekNrOfDays");
            entity.Property(e => e.WeekQuarterWeekendNrOfDays).HasColumnName("WeekQuarter_WeekendNrOfDays");
            entity.Property(e => e.WeekQuarterWorkingNrOfDays).HasColumnName("WeekQuarter_WorkingNrOfDays");
            entity.Property(e => e.WeekWeekNrOfDays).HasColumnName("Week_WeekNrOfDays");
            entity.Property(e => e.WeekWeekendNrOfDays).HasColumnName("Week_WeekendNrOfDays");
            entity.Property(e => e.WeekWorkingNrOfDays).HasColumnName("Week_WorkingNrOfDays");
            entity.Property(e => e.WeekYearAllNrOfDays).HasColumnName("WeekYear_AllNrOfDays");
            entity.Property(e => e.WeekYearFirstAllDayId).HasColumnName("WeekYear_First_AllDayID");
            entity.Property(e => e.WeekYearFirstHoliDayId).HasColumnName("WeekYear_First_HoliDayID");
            entity.Property(e => e.WeekYearFirstNonWorkingDayId).HasColumnName("WeekYear_First_NonWorkingDayID");
            entity.Property(e => e.WeekYearFirstWeekDayId).HasColumnName("WeekYear_First_WeekDayID");
            entity.Property(e => e.WeekYearFirstWeekendDayId).HasColumnName("WeekYear_First_WeekendDayID");
            entity.Property(e => e.WeekYearFirstWorkingDayId).HasColumnName("WeekYear_First_WorkingDayID");
            entity.Property(e => e.WeekYearHoliNrOfDays).HasColumnName("WeekYear_HoliNrOfDays");
            entity.Property(e => e.WeekYearId).HasColumnName("Week_YearID");
            entity.Property(e => e.WeekYearLastAllDayId).HasColumnName("WeekYear_Last_AllDayID");
            entity.Property(e => e.WeekYearLastHoliDayId).HasColumnName("WeekYear_Last_HoliDayID");
            entity.Property(e => e.WeekYearLastNonWorkingDayId).HasColumnName("WeekYear_Last_NonWorkingDayID");
            entity.Property(e => e.WeekYearLastWeekDayId).HasColumnName("WeekYear_Last_WeekDayID");
            entity.Property(e => e.WeekYearLastWeekendDayId).HasColumnName("WeekYear_Last_WeekendDayID");
            entity.Property(e => e.WeekYearLastWorkingDayId).HasColumnName("WeekYear_Last_WorkingDayID");
            entity.Property(e => e.WeekYearNonWorkingNrOfDays).HasColumnName("WeekYear_NonWorkingNrOfDays");
            entity.Property(e => e.WeekYearWeekNrOfDays).HasColumnName("WeekYear_WeekNrOfDays");
            entity.Property(e => e.WeekYearWeekendNrOfDays).HasColumnName("WeekYear_WeekendNrOfDays");
            entity.Property(e => e.WeekYearWorkingNrOfDays).HasColumnName("WeekYear_WorkingNrOfDays");
        });

        modelBuilder.Entity<VwDbTableFieldMetaFieldSetValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDbTableField_MetaField_SetValue");

            entity.Property(e => e.Sql1).HasMaxLength(202);
        });

        modelBuilder.Entity<VwDbTableFieldSelectAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwDbTableField_SelectAll");

            entity.Property(e => e.DataTypeLkpId).HasColumnName("DataTypeLkpID");
            entity.Property(e => e.DbTableFieldId).HasColumnName("DbTableFieldID");
            entity.Property(e => e.DbTableFieldName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.DbTableId).HasColumnName("DbTableID");
            entity.Property(e => e.DbTableName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.HashTypeLkpId).HasColumnName("HashTypeLkpID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.SourceField)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<VwErrorByWeek>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwErrorByWeek");
        });

        modelBuilder.Entity<VwFolderList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFolderList");

            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.FullPathFolderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("FullPathFolderID");
            entity.Property(e => e.FullPathFolderName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.FullPathSortOrderCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
        });

        modelBuilder.Entity<VwFolderSelectAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFolder_SelectAll");

            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.AppDataObjectName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppFormConfigId).HasColumnName("AppFormConfigID");
            entity.Property(e => e.AppFormConfigName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppFormId).HasColumnName("AppFormID");
            entity.Property(e => e.AppFormName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppImageId).HasColumnName("AppImageID");
            entity.Property(e => e.AppImageName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AppViewId).HasColumnName("AppViewID");
            entity.Property(e => e.AppViewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.FolderName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FolderTypeLkpId).HasColumnName("FolderTypeLkpID");
            entity.Property(e => e.FolderTypeLkpName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FullPathFolderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FullPathFolderID");
            entity.Property(e => e.FullPathFolderName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FullPathSortOrderCode)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParentFolderId).HasColumnName("ParentFolderID");
            entity.Property(e => e.ParentFolderName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.RowReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SortOrderCode)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwFolderUserIsRead>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFolder_User_IsRead");

            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwForbiddenFilterWord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwForbiddenFilterWords");

            entity.Property(e => e.ForbiddenFilderWord).HasMaxLength(32);
        });

        modelBuilder.Entity<VwForeignKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwForeignKeys");

            entity.Property(e => e.ChildFieldName)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ChildPrimaryFields)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ChildTableName)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ChildTableObjectId).HasColumnName("ChildTableObjectID");
            entity.Property(e => e.DeleteReferentialAction).HasColumnName("delete_referential_action");
            entity.Property(e => e.DeleteReferentialActionDesc)
                .HasMaxLength(60)
                .UseCollation("Latin1_General_CI_AS_KS_WS")
                .HasColumnName("delete_referential_action_desc");
            entity.Property(e => e.IsDisabled).HasColumnName("is_disabled");
            entity.Property(e => e.IsSystemNamed).HasColumnName("is_system_named");
            entity.Property(e => e.ParentFieldName)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ParentPrimaryFields)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ParentTableName)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ParentTableObjectId).HasColumnName("ParentTableObjectID");
            entity.Property(e => e.RelationName)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.RelationObjectId).HasColumnName("RelationObjectID");
            entity.Property(e => e.UpdateReferentialAction).HasColumnName("update_referential_action");
            entity.Property(e => e.UpdateReferentialActionDesc)
                .HasMaxLength(60)
                .UseCollation("Latin1_General_CI_AS_KS_WS")
                .HasColumnName("update_referential_action_desc");
        });

        modelBuilder.Entity<VwKpiUserAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKpi_User_Admin");

            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.KpiId).HasColumnName("KpiID");
            entity.Property(e => e.KpiUserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("KpiUserID");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwKpiUserIsRead>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwKpi_User_IsRead");

            entity.Property(e => e.KpiId).HasColumnName("KpiID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwLoginLastWeek>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwLogin_LastWeek");

            entity.Property(e => e.FirstLogin).HasColumnType("datetime");
            entity.Property(e => e.JobPositionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.LoginDateId).HasColumnName("LoginDateID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwOrganisationChild>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrganisation_Childs");

            entity.Property(e => e.ChildOrganisationCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ChildOrganisationId).HasColumnName("ChildOrganisationID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OrganisationPath)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ParentOrganisationCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ParentOrganisationId).HasColumnName("ParentOrganisationID");
        });

        modelBuilder.Entity<VwOrganisationHierachy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrganisation_Hierachy");

            entity.Property(e => e.L1Oid).HasColumnName("L1_OID");
            entity.Property(e => e.L2Oid).HasColumnName("L2_OID");
            entity.Property(e => e.L3Oid).HasColumnName("L3_OID");
            entity.Property(e => e.L4Oid).HasColumnName("L4_OID");
            entity.Property(e => e.L5Oid).HasColumnName("L5_OID");
            entity.Property(e => e.L6Oid).HasColumnName("L6_OID");
            entity.Property(e => e.L7Oid).HasColumnName("L7_OID");
            entity.Property(e => e.L8Oid).HasColumnName("L8_OID");
            entity.Property(e => e.OrganisationCompleteId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Organisation_CompleteID");
            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.OrganisationLevelId).HasColumnName("OrganisationLevelID");
            entity.Property(e => e.ParentOrganisationId).HasColumnName("ParentOrganisationID");
            entity.Property(e => e.RecursionId).HasColumnName("RecursionID");
        });

        modelBuilder.Entity<VwOrganisationUserCustomLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrganisation_User_CustomLevel");

            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwOrganisationUserIsRead>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOrganisation_User_IsRead");

            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwOverviewUsageByMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOverview_UsageByMonth");

            entity.Property(e => e.OverviewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwOverviewUserAdmin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOverview_User_Admin");

            entity.Property(e => e.ExpireDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.OverviewUserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OverviewUserID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwOverviewUserIsRead>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwOverview_User_IsRead");

            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwPeriodTypeLastCompletePeriod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPeriodType_LastCompletePeriods");

            entity.Property(e => e.AppLookupCodeId).HasColumnName("AppLookupCodeID");
            entity.Property(e => e.CodeReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EndDateId).HasColumnName("EndDateID");
            entity.Property(e => e.LastPeriodId).HasColumnName("LastPeriodID");
            entity.Property(e => e.LastPeriodName)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.LastYearId).HasColumnName("LastYearID");
            entity.Property(e => e.LookupCodeId).HasColumnName("LookupCodeID");
            entity.Property(e => e.LookupCodeTable)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LookupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StartDateId).HasColumnName("StartDateID");
        });

        modelBuilder.Entity<VwRegistryKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwRegistryKey");

            entity.Property(e => e.FullPathRegistryTreeName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RegistryKeyGuid).HasColumnName("RegistryKeyGUID");
            entity.Property(e => e.RegistryKeyId).HasColumnName("RegistryKeyID");
            entity.Property(e => e.RegistryKeyName).HasMaxLength(255);
            entity.Property(e => e.RegistryKeyTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RegistryTreeId).HasColumnName("RegistryTreeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwRegistryTreeList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwRegistryTreeList");

            entity.Property(e => e.FullPathRegistryTreeId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FullPathRegistryTreeID");
            entity.Property(e => e.FullPathRegistryTreeName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LevelId).HasColumnName("LevelID");
            entity.Property(e => e.RegistryTreeId).HasColumnName("RegistryTreeID");
        });

        modelBuilder.Entity<VwSchedulePlannedTimeEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSchedulePlannedTimeEvents");

            entity.Property(e => e.CalendarMonthId).HasColumnName("Calendar_MonthID");
            entity.Property(e => e.CalendarQuarterId).HasColumnName("Calendar_QuarterID");
            entity.Property(e => e.CalendarYearId).HasColumnName("Calendar_YearID");
            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.DayId).HasColumnName("DayID");
            entity.Property(e => e.HourId).HasColumnName("HourID");
            entity.Property(e => e.MinuteId).HasColumnName("MinuteID");
            entity.Property(e => e.PeriodId).HasColumnName("PeriodID");
            entity.Property(e => e.ScheduleDayOrderLkpId).HasColumnName("ScheduleDayOrderLkpID");
            entity.Property(e => e.ScheduleHourFilterLkpId).HasColumnName("ScheduleHourFilterLkpID");
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.SchedulePeriodTypeLkpId).HasColumnName("SchedulePeriodTypeLkpID");
            entity.Property(e => e.SecondId).HasColumnName("SecondID");
            entity.Property(e => e.TimeCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.WeekId).HasColumnName("WeekID");
            entity.Property(e => e.WeekP444id).HasColumnName("Week_P444ID");
            entity.Property(e => e.WeekP445id).HasColumnName("Week_P445ID");
            entity.Property(e => e.WeekQuarterId).HasColumnName("Week_QuarterID");
            entity.Property(e => e.WeekYearId).HasColumnName("Week_YearID");
        });

        modelBuilder.Entity<VwSecurity>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RedirectedSecurityId).HasColumnName("RedirectedSecurityID");
            entity.Property(e => e.SecurityCode)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
        });

        modelBuilder.Entity<VwSecurityAuditList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_AuditList");

            entity.Property(e => e.ContractEndDate).HasColumnType("datetime");
            entity.Property(e => e.Organisation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationLevelId).HasColumnName("OrganisationLevelID");
            entity.Property(e => e.Werknemer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WerknemerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityByCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_By_Customer");

            entity.Property(e => e.KlantCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.KlantLevel)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.KlantNaam)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Werknemer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WerknemerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityByCustomerLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_By_CustomerLevel");

            entity.Property(e => e.KlantLevel)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserID");
            entity.Property(e => e.Werknemer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WerknemerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityByOrganisation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_By_Organisation");

            entity.Property(e => e.OrganisatieCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.OrganisatieId).HasColumnName("OrganisatieID");
            entity.Property(e => e.OrganisatieLevel)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.OrganisatieNaam)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RechtenVerkegenVia)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Werknemer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WerknemerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityByOrganisationLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_By_OrganisationLevel");

            entity.Property(e => e.OrganisatieLevel)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserID");
            entity.Property(e => e.Werknemer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WerknemerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityByOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_By_Overview");

            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.OverviewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RechtenVerkegenVia)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Werknemer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WerknemerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityByProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_By_Profile");

            entity.Property(e => e.ProfielNaam)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Werknemer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WerknemerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityByUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_By_User");

            entity.Property(e => e.ContractType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ContractTypeCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Functie)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FunctieCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.FunctieGroep)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KlantLevel)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.OrganisatieLevel)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Werknemer)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WerknemerCode)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityExceptionNoOrgManyOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityException_NoOrg_ManyOverview");

            entity.Property(e => e.CompleteOrganisationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JobPositionGroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JobPositionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LoginName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NrOfRptCustSec).HasColumnName("NrOfRpt_CustSec");
            entity.Property(e => e.NrOfRptOrgSec).HasColumnName("NrOfRpt_OrgSec");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSecurityRuleAppDataObject>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_AppDataObject");

            entity.Property(e => e.AppDataObjectId).HasColumnName("AppDataObjectID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityRuleAppFunction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_AppFunction");

            entity.Property(e => e.AppFunctionId).HasColumnName("AppFunctionID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityRuleCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_Customer");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityRuleFolder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_Folder");

            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityRuleGetUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_GetUsers");

            entity.Property(e => e.SecurityRuleId).HasColumnName("SecurityRuleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityRuleKpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_Kpi");

            entity.Property(e => e.KpiId).HasColumnName("KpiID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityRuleOrganisation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_Organisation");

            entity.Property(e => e.OrganisationId).HasColumnName("OrganisationID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityRuleOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_Overview");

            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.SecurityId).HasColumnName("SecurityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityRuleUserProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurityRule_UserProfile");

            entity.Property(e => e.ProfileUserId).HasColumnName("ProfileUserID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSecurityShowAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSecurity_ShowAll");

            entity.Property(e => e.LoginName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OverviewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserGroup)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSubscription>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubscription");

            entity.Property(e => e.DeletedFromSourceDate).HasColumnType("datetime");
            entity.Property(e => e.EmailImportance).HasMaxLength(16);
            entity.Property(e => e.EmailSubject).HasMaxLength(255);
            entity.Property(e => e.LastExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.NextExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.OverviewId).HasColumnName("OverviewID");
            entity.Property(e => e.OverviewIsEnabled).HasColumnName("Overview_IsEnabled");
            entity.Property(e => e.OverviewLocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Overview_Location");
            entity.Property(e => e.OverviewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Parameters)
                .HasMaxLength(4035)
                .IsUnicode(false);
            entity.Property(e => e.RenderFormatLkpId).HasColumnName("RenderFormatLkpID");
            entity.Property(e => e.RenderFormatName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.ScheduleName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ServiceProviderId).HasColumnName("ServiceProviderID");
            entity.Property(e => e.ServiceProviderTypeLkpId).HasColumnName("ServiceProviderTypeLkpID");
            entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.SubscriptionIsEnabled).HasColumnName("Subscription_IsEnabled");
            entity.Property(e => e.SubscriptionLocation)
                .HasMaxLength(1024)
                .HasColumnName("Subscription_Location");
            entity.Property(e => e.SubscriptionName).HasMaxLength(255);
        });

        modelBuilder.Entity<VwSubscriptionEmailToSend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubscription_EmailToSend");

            entity.Property(e => e.BcEmail)
                .IsUnicode(false)
                .HasColumnName("BC_Email");
            entity.Property(e => e.BcUserId)
                .IsUnicode(false)
                .HasColumnName("BC_UserID");
            entity.Property(e => e.BcUserName)
                .IsUnicode(false)
                .HasColumnName("BC_UserName");
            entity.Property(e => e.CrEmail)
                .IsUnicode(false)
                .HasColumnName("CR_Email");
            entity.Property(e => e.CrUserId)
                .IsUnicode(false)
                .HasColumnName("CR_UserID");
            entity.Property(e => e.CrUserName)
                .IsUnicode(false)
                .HasColumnName("CR_UserName");
            entity.Property(e => e.RowId).HasColumnName("RowID");
            entity.Property(e => e.RpEmail)
                .IsUnicode(false)
                .HasColumnName("RP_Email");
            entity.Property(e => e.RpUserId)
                .IsUnicode(false)
                .HasColumnName("RP_UserID");
            entity.Property(e => e.RpUserName)
                .IsUnicode(false)
                .HasColumnName("RP_UserName");
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
        });

        modelBuilder.Entity<VwSubscriptionField>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubscriptionField");

            entity.Property(e => e.AppViewFieldId).HasColumnName("AppViewFieldID");
            entity.Property(e => e.AppViewFieldName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ChildAppViewId).HasColumnName("ChildAppViewID");
            entity.Property(e => e.ChildAppViewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MetaCreationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaCreationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.MetaMutationDate).HasColumnType("datetime");
            entity.Property(e => e.MetaMutationUser)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ParameterAppViewId).HasColumnName("ParameterAppViewID");
            entity.Property(e => e.ParameterAppViewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceAppViewId).HasColumnName("ReferenceAppViewID");
            entity.Property(e => e.ReferenceAppViewName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionFieldId).HasColumnName("SubscriptionFieldID");
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.SubscriptionName).HasMaxLength(255);
            entity.Property(e => e.SubscriptionValue)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSubscriptionRuleGetUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubscriptionRule_GetUsers");

            entity.Property(e => e.SubscriptionRuleId).HasColumnName("SubscriptionRuleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwSubscriptionUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubscription_User");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.InBc).HasColumnName("InBC");
            entity.Property(e => e.InCr).HasColumnName("InCR");
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.SubscriptionName).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSubscriptionUserAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSubscription_UserAllocation");

            entity.Property(e => e.ContractTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DefaultOrganisation)
                .HasMaxLength(274)
                .IsUnicode(false);
            entity.Property(e => e.DefaultOrganisationLevelCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.DefaultOrganisationLevelId).HasColumnName("DefaultOrganisationLevelID");
            entity.Property(e => e.DefaultOrganisationLevelName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DefaultOrganisationReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HighestOrgLevelName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.InBc).HasColumnName("InBC");
            entity.Property(e => e.InCr).HasColumnName("InCR");
            entity.Property(e => e.JobPositionGroupName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JobPositionName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NrOfOrgAllocationsAll).HasColumnName("NrOfOrgAllocations_All");
            entity.Property(e => e.NrOfOrgAllocationsCustom).HasColumnName("NrOfOrgAllocations_Custom");
            entity.Property(e => e.NrOfOrgAllocationsDefault).HasColumnName("NrOfOrgAllocations_Default");
            entity.Property(e => e.NrOfOrgAllocationsRules).HasColumnName("NrOfOrgAllocations_Rules");
            entity.Property(e => e.OrgCustomAllocations)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.OrgDefaultAllocations)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            entity.Property(e => e.SubscriptionName).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwTableFieldList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTableFieldList");

            entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");
            entity.Property(e => e.DataTypeName).HasMaxLength(128);
            entity.Property(e => e.FieldName).HasMaxLength(128);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName).HasMaxLength(128);
            entity.Property(e => e.SchemaName).HasMaxLength(128);
        });

        modelBuilder.Entity<VwTableFieldListDiffDataType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTableFieldList_DiffDataTypes");

            entity.Property(e => e.FieldName)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(128)
                .UseCollation("Latin1_General_CI_AS");
        });

        modelBuilder.Entity<VwTableList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTableList");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.SchemaName).HasMaxLength(128);
            entity.Property(e => e.TableName).HasMaxLength(128);
        });

        modelBuilder.Entity<VwTableListRowCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTableListRowCount");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.SchemaName).HasMaxLength(128);
            entity.Property(e => e.TableName).HasMaxLength(128);
        });

        modelBuilder.Entity<VwTableListWithField>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwTableListWithFields");

            entity.Property(e => e.FieldList)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName).HasMaxLength(128);
            entity.Property(e => e.SchemaName).HasMaxLength(128);
        });

        modelBuilder.Entity<VwUsageByDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUsageByDate");

            entity.Property(e => e.DayName)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.NrOfRequestsUniqueReports).HasColumnName("NrOfRequests_UniqueReports");
            entity.Property(e => e.NrOfRequestsUniqueUsers).HasColumnName("NrOfRequests_UniqueUsers");
            entity.Property(e => e.RequestDurationAvg).HasColumnName("RequestDuration_Avg");
            entity.Property(e => e.RequestDurationMax).HasColumnName("RequestDuration_Max");
            entity.Property(e => e.RequestDurationMin).HasColumnName("RequestDuration_Min");
        });

        modelBuilder.Entity<VwUsageByHour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUsageByHour");

            entity.Property(e => e.M0NrOfLogins).HasColumnName("M0_NrOfLogins");
            entity.Property(e => e.M0NrOfRequests).HasColumnName("M0_NrOfRequests");
            entity.Property(e => e.M0NrOfRequestsUniqueReports).HasColumnName("M0_NrOfRequests_UniqueReports");
            entity.Property(e => e.M0NrOfRequestsUniqueUsers).HasColumnName("M0_NrOfRequests_UniqueUsers");
            entity.Property(e => e.M0NrOfUnqueVisitors).HasColumnName("M0_NrOfUnqueVisitors");
            entity.Property(e => e.M1NrOfLogins).HasColumnName("M1_NrOfLogins");
            entity.Property(e => e.M1NrOfRequests).HasColumnName("M1_NrOfRequests");
            entity.Property(e => e.M1NrOfRequestsUniqueReports).HasColumnName("M1_NrOfRequests_UniqueReports");
            entity.Property(e => e.M1NrOfRequestsUniqueUsers).HasColumnName("M1_NrOfRequests_UniqueUsers");
            entity.Property(e => e.M1NrOfUnqueVisitors).HasColumnName("M1_NrOfUnqueVisitors");
            entity.Property(e => e.M7NrOfLogins).HasColumnName("M7_NrOfLogins");
            entity.Property(e => e.M7NrOfRequests).HasColumnName("M7_NrOfRequests");
            entity.Property(e => e.M7NrOfRequestsUniqueReports).HasColumnName("M7_NrOfRequests_UniqueReports");
            entity.Property(e => e.M7NrOfRequestsUniqueUsers).HasColumnName("M7_NrOfRequests_UniqueUsers");
            entity.Property(e => e.M7NrOfUnqueVisitors).HasColumnName("M7_NrOfUnqueVisitors");
            entity.Property(e => e.M8NrOfLogins).HasColumnName("M8_NrOfLogins");
            entity.Property(e => e.M8NrOfRequests).HasColumnName("M8_NrOfRequests");
            entity.Property(e => e.M8NrOfRequestsUniqueReports).HasColumnName("M8_NrOfRequests_UniqueReports");
            entity.Property(e => e.M8NrOfRequestsUniqueUsers).HasColumnName("M8_NrOfRequests_UniqueUsers");
            entity.Property(e => e.M8NrOfUnqueVisitors).HasColumnName("M8_NrOfUnqueVisitors");
        });

        modelBuilder.Entity<VwUserOrganisationAllocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwUser_OrganisationAllocation");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrgCustomAllocations)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrgDefaultAllocations)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwViewFieldList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwViewFieldList");

            entity.Property(e => e.FieldName).HasMaxLength(128);
            entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            entity.Property(e => e.ObjectName).HasMaxLength(128);
            entity.Property(e => e.SchemaName).HasMaxLength(128);
        });

        modelBuilder.Entity<VwViewList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwViewList");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.SchemaName).HasMaxLength(128);
            entity.Property(e => e.ViewName).HasMaxLength(128);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
