using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class OrganisationUserIsRead
{
    public int OrganisationUserIsReadId { get; set; }

    public int OrganisationId { get; set; }

    public int UserId { get; set; }
}
