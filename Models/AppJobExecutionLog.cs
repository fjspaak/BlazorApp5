using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppJobExecutionLog
{
    public int AppJobExecutionLogId { get; set; }

    public Guid ExecutionGuid { get; set; }

    public int? AppJobId { get; set; }

    public Guid AppJobGuid { get; set; }

    public int? Version { get; set; }

    public DateTime? ExecutionDate { get; set; }

    public string Computer { get; set; } = null!;

    public string Operator { get; set; } = null!;

    public Guid? MasterExecutionGuid { get; set; }

    public DateTime? MasterExecutionDate { get; set; }

    public string? PackagePath { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? NrOfErrors { get; set; }

    public int? NrOfExceptions { get; set; }

    public int? NrOfWarnings { get; set; }

    public int? NrOfRowsRead { get; set; }

    public int? NrOfRowsInserted { get; set; }

    public int? NrOfRowsUpdated { get; set; }

    public int? NrOfRowsDeleted { get; set; }

    public virtual AppJob? AppJob { get; set; }
}
