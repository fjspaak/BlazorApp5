using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppJobDependency
{
    public int AppJobDependencyId { get; set; }

    public int? FlowAppJobId { get; set; }

    public int ParentAppJobId { get; set; }

    public int ChildAppJobId { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual AppJob ChildAppJob { get; set; } = null!;

    public virtual AppJob? FlowAppJob { get; set; }

    public virtual AppJob ParentAppJob { get; set; } = null!;
}
