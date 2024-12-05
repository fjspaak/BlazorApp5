using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Security
{
    public int SecurityId { get; set; }

    public string? SecurityCode { get; set; }

    public string? Description { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsUpdate { get; set; }

    public bool? IsInsert { get; set; }

    public bool? IsDelete { get; set; }

    public bool? IsExecute { get; set; }

    public bool? IsOwner { get; set; }

    public bool? IsAdmin { get; set; }

    public bool? IsDenied { get; set; }

    public bool? IsValid { get; set; }

    public int? RedirectedSecurityId { get; set; }

    public virtual ICollection<AppDataObjectUser> AppDataObjectUsers { get; set; } = new List<AppDataObjectUser>();

    public virtual ICollection<AppFunctionUser> AppFunctionUsers { get; set; } = new List<AppFunctionUser>();

    public virtual ICollection<CustomerUser> CustomerUsers { get; set; } = new List<CustomerUser>();

    public virtual ICollection<FolderUser> FolderUsers { get; set; } = new List<FolderUser>();

    public virtual ICollection<KpiUser> KpiUsers { get; set; } = new List<KpiUser>();

    public virtual ICollection<OrganisationUser> OrganisationUsers { get; set; } = new List<OrganisationUser>();

    public virtual ICollection<OverviewUser> OverviewUsers { get; set; } = new List<OverviewUser>();

    public virtual ICollection<SecurityRule> SecurityRules { get; set; } = new List<SecurityRule>();
}
