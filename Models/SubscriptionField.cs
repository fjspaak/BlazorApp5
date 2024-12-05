using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SubscriptionField
{
    public int SubscriptionFieldId { get; set; }

    public int SubscriptionId { get; set; }

    public int? AppViewFieldId { get; set; }

    public int? ReferenceAppViewId { get; set; }

    public string? FixedValue { get; set; }

    public string? ReferenceName { get; set; }

    public bool UseDefaultValue { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual AppViewField? AppViewField { get; set; }

    public virtual AppView? ReferenceAppView { get; set; }

    public virtual Subscription Subscription { get; set; } = null!;
}
