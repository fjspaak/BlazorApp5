using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwLoginLastWeek
{
    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public string? JobPositionName { get; set; }

    public int? LoginDateId { get; set; }

    public DateTime? FirstLogin { get; set; }

    public DateTime? LastLogin { get; set; }

    public int? NrOfLogins { get; set; }
}
