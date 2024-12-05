using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwAppViewSelectAll
{
    public int? AppDataObjectId { get; set; }

    public string? AppDataObjectName { get; set; }

    public int AppViewId { get; set; }

    public string? AppViewName { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public string? SourceCommand { get; set; }

    public int? ParameterAppViewId { get; set; }

    public string? ParameterAppViewName { get; set; }

    public int? LayoutTypeLkpId { get; set; }

    public string? LayoutTypeLkpName { get; set; }

    public int? PriorityLkpId { get; set; }

    public string? PriorityLkpName { get; set; }

    public string? SearchFields { get; set; }

    public bool IsStoredProcedure { get; set; }

    public bool IsListType { get; set; }

    public bool IsDetailType { get; set; }

    public bool IsTitleType { get; set; }

    public bool IsSelectionType { get; set; }

    public bool IsParameterType { get; set; }

    public bool IsPageType { get; set; }

    public bool IsDetailValidationType { get; set; }

    public bool IsActionType { get; set; }

    public bool IsValidationRule { get; set; }

    public bool IsBusinessRule { get; set; }

    public bool IsTechnicalRule { get; set; }

    public bool IsLogicalRule { get; set; }

    public string? CodeReference { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }
}
