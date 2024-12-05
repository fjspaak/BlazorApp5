using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwOrganisationUserCustomLevel
{
    public int SecurityId { get; set; }

    public int UserId { get; set; }

    public int? OrganisationId { get; set; }
}
