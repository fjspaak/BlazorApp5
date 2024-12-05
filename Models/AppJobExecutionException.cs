using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppJobExecutionException
{
    public int AppJobExecutionExceptionId { get; set; }

    public Guid? AppJobGuid { get; set; }

    public Guid ExecutionGuid { get; set; }

    public string RecordId { get; set; } = null!;

    public int ExceptionId { get; set; }

    public bool IsError { get; set; }

    public string? RowValue { get; set; }
}
