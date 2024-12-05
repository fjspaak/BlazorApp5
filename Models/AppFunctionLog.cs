using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppFunctionLog
{
    public int AppFunctionLogId { get; set; }

    public int AppFunctionId { get; set; }

    public int UserId { get; set; }

    public int? OutputId { get; set; }

    public int? Duration { get; set; }

    public DateTime? ExecutionDate { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual AppFunction AppFunction { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
