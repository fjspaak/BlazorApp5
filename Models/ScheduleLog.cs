using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class ScheduleLog
{
    public int ScheduleLogId { get; set; }

    public int ScheduleId { get; set; }

    public DateTime ExecutionDate { get; set; }

    public Guid? ExecutionGuid { get; set; }

    public int? ExecutionResult { get; set; }

    public virtual Schedule Schedule { get; set; } = null!;
}
