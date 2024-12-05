using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwOrganisationHierachy
{
    public int? OrganisationId { get; set; }

    public int? OrganisationLevelId { get; set; }

    public int? ParentOrganisationId { get; set; }

    public int? L1Oid { get; set; }

    public int? L2Oid { get; set; }

    public int? L3Oid { get; set; }

    public int? L4Oid { get; set; }

    public int? L5Oid { get; set; }

    public int? L6Oid { get; set; }

    public int? L7Oid { get; set; }

    public int? L8Oid { get; set; }

    public int? RecursionId { get; set; }

    public string? OrganisationCompleteId { get; set; }
}
