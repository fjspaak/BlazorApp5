using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class RequestLog
{
    public int RequestLogId { get; set; }

    public int? LoginId { get; set; }

    public int? OverviewId { get; set; }

    public DateTime? RequestDate { get; set; }

    public int? DurationInSec { get; set; }

    public bool IsSucessfull { get; set; }

    public string? ParameterConfig { get; set; }

    public int? UserId { get; set; }

    public virtual Login? Login { get; set; }

    public virtual Overview? Overview { get; set; }

    public virtual User? User { get; set; }
}
