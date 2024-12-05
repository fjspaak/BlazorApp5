using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class OrganisationUser
{
    public int OrganisationUserId { get; set; }

    public int UserId { get; set; }

    public int OrganisationId { get; set; }

    public int SecurityId { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool IsCustom { get; set; }

    public bool IsDefault { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual Organisation Organisation { get; set; } = null!;

    public virtual Security Security { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
