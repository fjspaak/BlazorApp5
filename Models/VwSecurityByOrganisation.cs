using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurityByOrganisation
{
    public int UserId { get; set; }

    public string? WerknemerCode { get; set; }

    public string? Werknemer { get; set; }

    public int OrganisatieId { get; set; }

    public string? OrganisatieCode { get; set; }

    public string? OrganisatieNaam { get; set; }

    public string OrganisatieLevel { get; set; } = null!;

    public bool IsCustom { get; set; }

    public bool IsDefault { get; set; }

    public string RechtenVerkegenVia { get; set; } = null!;
}
