using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SchedulePlannedTimeEvent
{
    public int SchedulePlannedTimeEventId { get; set; }

    public int ScheduleId { get; set; }

    public DateTime ExecutionDate { get; set; }

    public bool ExecuteBeforeDataUpdate { get; set; }

    public bool ExecuteAfterDataUpdate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual Schedule Schedule { get; set; } = null!;
}
