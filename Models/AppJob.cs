using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppJob
{
    public int AppJobId { get; set; }

    public Guid AppJobGuid { get; set; }

    public string AppJobName { get; set; } = null!;

    public int? StartAppJobLineId { get; set; }

    public string Description { get; set; } = null!;

    public string? Remarks { get; set; }

    public DateTime? LastExecutionDate { get; set; }

    public Guid? LastExecutionGuid { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<AppJobDependency> AppJobDependencyChildAppJobs { get; set; } = new List<AppJobDependency>();

    public virtual ICollection<AppJobDependency> AppJobDependencyFlowAppJobs { get; set; } = new List<AppJobDependency>();

    public virtual ICollection<AppJobDependency> AppJobDependencyParentAppJobs { get; set; } = new List<AppJobDependency>();

    public virtual ICollection<AppJobExecutionLog> AppJobExecutionLogs { get; set; } = new List<AppJobExecutionLog>();

    public virtual ICollection<AppJobLine> AppJobLineChildAppJobs { get; set; } = new List<AppJobLine>();

    public virtual ICollection<AppJobLine> AppJobLineParentAppJobs { get; set; } = new List<AppJobLine>();
}
