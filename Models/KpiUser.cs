using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class KpiUser
{
    public int KpiUserId { get; set; }

    public int KpiId { get; set; }

    public int UserId { get; set; }

    public int SecurityId { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool IsCustom { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual Kpi Kpi { get; set; } = null!;

    public virtual Security Security { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
