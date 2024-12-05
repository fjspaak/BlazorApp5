using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class User
{
    public int UserId { get; set; }

    public int? DefaultOrganisationLevelId { get; set; }

    public int? CustomCustomerLevelId { get; set; }

    public int? DefaultCustomerLevelId { get; set; }

    public int? CustomOrganisationLevelId { get; set; }

    public int? JobPositionId { get; set; }

    public int? ContractTypeId { get; set; }

    public int? DefaultFolderId { get; set; }

    public int? DefaultOverviewId { get; set; }

    public int? ManagerUserId { get; set; }

    public int? ViewPriorityLkpId { get; set; }

    public string? UserName { get; set; }

    public string? LoginName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? HomePhone { get; set; }

    public string? BusinessPhone { get; set; }

    public string? MobilePhone { get; set; }

    public string? Remarks { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsSystem { get; set; }

    public bool IsUserProfile { get; set; }

    public bool IsVirtualUser { get; set; }

    public bool IsParameterTrackingEnabled { get; set; }

    public int CustomAllFoldersSecurityId { get; set; }

    public int DefaultAllFoldersSecurityId { get; set; }

    public int CustomAllOverviewsSecurityId { get; set; }

    public int DefaultAllOverviewsSecurityId { get; set; }

    public int CustomAllCustomersSecurityId { get; set; }

    public int DefaultAllCustomersSecurityId { get; set; }

    public int CustomAllOrganisationsSecurityId { get; set; }

    public int DefaultAllOrganisationsSecurityId { get; set; }

    public int CustomAllAppFunctionSecurityId { get; set; }

    public int DefaultAllAppFunctionSecurityId { get; set; }

    public int? SystemMessageId { get; set; }

    public int? CustomLoginStatusLkpId { get; set; }

    public int? DefaultLoginStatusLkpId { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public DateTime? DeletedFromSourceDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public string? GlobalReference { get; set; }

    public string? ExternalReference { get; set; }

    public int? UserTypeLkpId { get; set; }

    public virtual ICollection<AppDataObjectUser> AppDataObjectUsers { get; set; } = new List<AppDataObjectUser>();

    public virtual ICollection<AppFormConfig> AppFormConfigs { get; set; } = new List<AppFormConfig>();

    public virtual ICollection<AppFunctionLog> AppFunctionLogs { get; set; } = new List<AppFunctionLog>();

    public virtual ICollection<AppFunctionUser> AppFunctionUsers { get; set; } = new List<AppFunctionUser>();

    public virtual ICollection<AppShortCut> AppShortCuts { get; set; } = new List<AppShortCut>();

    public virtual ICollection<AppViewFieldUser> AppViewFieldUsers { get; set; } = new List<AppViewFieldUser>();

    public virtual ContractType? ContractType { get; set; }

    public virtual CustomerLevel? CustomCustomerLevel { get; set; }

    public virtual AppLookupCode? CustomLoginStatusLkp { get; set; }

    public virtual OrganisationLevel? CustomOrganisationLevel { get; set; }

    public virtual ICollection<CustomerUser> CustomerUsers { get; set; } = new List<CustomerUser>();

    public virtual CustomerLevel? DefaultCustomerLevel { get; set; }

    public virtual Folder? DefaultFolder { get; set; }

    public virtual AppLookupCode? DefaultLoginStatusLkp { get; set; }

    public virtual OrganisationLevel? DefaultOrganisationLevel { get; set; }

    public virtual Overview? DefaultOverview { get; set; }

    public virtual ICollection<FolderUser> FolderUsers { get; set; } = new List<FolderUser>();

    public virtual ICollection<User> InverseManagerUser { get; set; } = new List<User>();

    public virtual JobPosition? JobPosition { get; set; }

    public virtual ICollection<KpiUser> KpiUsers { get; set; } = new List<KpiUser>();

    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();

    public virtual User? ManagerUser { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<OrganisationUser> OrganisationUsers { get; set; } = new List<OrganisationUser>();

    public virtual ICollection<Organisation> Organisations { get; set; } = new List<Organisation>();

    public virtual ICollection<OverviewUser> OverviewUsers { get; set; } = new List<OverviewUser>();

    public virtual ICollection<RegistryKey> RegistryKeys { get; set; } = new List<RegistryKey>();

    public virtual ICollection<RegistryReference> RegistryReferences { get; set; } = new List<RegistryReference>();

    public virtual ICollection<RequestLog> RequestLogs { get; set; } = new List<RequestLog>();

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();

    public virtual ICollection<SubscriptionRuleUser> SubscriptionRuleUsers { get; set; } = new List<SubscriptionRuleUser>();

    public virtual ICollection<SubscriptionRule> SubscriptionRules { get; set; } = new List<SubscriptionRule>();

    public virtual ICollection<SubscriptionUser> SubscriptionUsers { get; set; } = new List<SubscriptionUser>();

    public virtual SystemMessage? SystemMessage { get; set; }

    public virtual ICollection<UserStatistic> UserStatistics { get; set; } = new List<UserStatistic>();

    public virtual AppLookupCode? UserTypeLkp { get; set; }

    public virtual ICollection<UserUserGroup> UserUserGroups { get; set; } = new List<UserUserGroup>();
}
