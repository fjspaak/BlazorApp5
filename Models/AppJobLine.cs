using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppJobLine
{
    public int AppJobLineId { get; set; }

    public int ParentAppJobId { get; set; }

    public int? ChildAppJobId { get; set; }

    public int? AppJobLineTypeLkpId { get; set; }

    public int? ExecuteAppViewId { get; set; }

    public int? ExecuteAppFunctionId { get; set; }

    public int? SubscriptionId { get; set; }

    public int? OnSuccessActionLkpId { get; set; }

    public int? OnFailureActionLkpId { get; set; }

    public Guid AppJobLineGuid { get; set; }

    public string AppJobLineName { get; set; } = null!;

    public int Sequence { get; set; }

    public string Description { get; set; } = null!;

    public string? Command { get; set; }

    public string? Location { get; set; }

    public string? Remarks { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppLookupCode? AppJobLineTypeLkp { get; set; }

    public virtual AppJob? ChildAppJob { get; set; }

    public virtual AppFunction? ExecuteAppFunction { get; set; }

    public virtual AppView? ExecuteAppView { get; set; }

    public virtual AppJob ParentAppJob { get; set; } = null!;

    public virtual Subscription? Subscription { get; set; }
}
