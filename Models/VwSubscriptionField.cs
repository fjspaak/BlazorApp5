using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSubscriptionField
{
    public int SubscriptionId { get; set; }

    public string? SubscriptionName { get; set; }

    public int SubscriptionFieldId { get; set; }

    public int? AppViewFieldId { get; set; }

    public string? AppViewFieldName { get; set; }

    public string? SubscriptionValue { get; set; }

    public string? DefaultValue { get; set; }

    public bool UseDefaultValue { get; set; }

    public string? ReferenceName { get; set; }

    public int? ReferenceAppViewId { get; set; }

    public string? ReferenceAppViewName { get; set; }

    public int? ParameterAppViewId { get; set; }

    public string? ParameterAppViewName { get; set; }

    public int? ChildAppViewId { get; set; }

    public string? ChildAppViewName { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaMutationUser { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public string? MetaCreationUser { get; set; }
}
