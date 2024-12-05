using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityExceptionNoOrgManyOverview
{
    public int UserId { get; set; }

    public string? LoginName { get; set; }

    public string? UserName { get; set; }

    public int? NrOfRpt { get; set; }

    public int? NrOfRptOrgSec { get; set; }

    public int? NrOfRptCustSec { get; set; }

    public int NrOfOrg { get; set; }

    public int NrOfFld { get; set; }

    public int NrOfCust { get; set; }

    public string? JobPositionName { get; set; }

    public string? JobPositionGroupName { get; set; }

    public string? CompleteOrganisationName { get; set; }
}
