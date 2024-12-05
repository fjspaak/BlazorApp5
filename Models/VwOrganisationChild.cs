using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwOrganisationChild
{
    public int? ParentOrganisationId { get; set; }

    public string? ParentOrganisationCode { get; set; }

    public int? ChildOrganisationId { get; set; }

    public string? ChildOrganisationCode { get; set; }

    public int? OrganisationId { get; set; }

    public string? OrganisationPath { get; set; }

    public int? DeltaLevel { get; set; }
}
