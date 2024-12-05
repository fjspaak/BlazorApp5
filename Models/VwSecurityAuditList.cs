using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityAuditList
{
    public string? WerknemerCode { get; set; }

    public string? Werknemer { get; set; }

    public DateTime? ContractEndDate { get; set; }

    public string? Organisation { get; set; }

    public string? OrganisationCode { get; set; }

    public int? OrganisationLevelId { get; set; }
}
