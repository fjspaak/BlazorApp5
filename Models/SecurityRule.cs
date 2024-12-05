using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SecurityRule
{
    public int SecurityRuleId { get; set; }

    public int? UserGroupId { get; set; }

    public int? OrganisationId { get; set; }

    public int? OrganisationLevelId { get; set; }

    public int? UserId { get; set; }

    public int? JobPositionId { get; set; }

    public int? JobPositionGroupId { get; set; }

    public int? ContractTypeId { get; set; }

    public int? SecuredFolderId { get; set; }

    public int? SecuredOverviewId { get; set; }

    public int? SecuredOrganisationId { get; set; }

    public int? SecuredCustomerId { get; set; }

    public int? SecuredAppDataObjectId { get; set; }

    public int? SecuredKpiId { get; set; }

    public int? SecuredAppFunctionId { get; set; }

    public int? SecuredUserProfileId { get; set; }

    public int? SecurityId { get; set; }

    public bool IsInUserSelection { get; set; }

    public bool IsUserSelectionAnd { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public int? LoginStatusLkpId { get; set; }

    public virtual ContractType? ContractType { get; set; }

    public virtual JobPosition? JobPosition { get; set; }

    public virtual JobPositionGroup? JobPositionGroup { get; set; }

    public virtual Organisation? Organisation { get; set; }

    public virtual OrganisationLevel? OrganisationLevel { get; set; }

    public virtual AppDataObject? SecuredAppDataObject { get; set; }

    public virtual AppFunction? SecuredAppFunction { get; set; }

    public virtual Customer? SecuredCustomer { get; set; }

    public virtual Folder? SecuredFolder { get; set; }

    public virtual Kpi? SecuredKpi { get; set; }

    public virtual Organisation? SecuredOrganisation { get; set; }

    public virtual Overview? SecuredOverview { get; set; }

    public virtual Security? Security { get; set; }

    public virtual ICollection<SecurityRuleUser> SecurityRuleUsers { get; set; } = new List<SecurityRuleUser>();

    public virtual User? User { get; set; }

    public virtual UserGroup? UserGroup { get; set; }
}
