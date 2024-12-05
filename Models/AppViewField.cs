﻿using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class AppViewField
{
    public int AppViewFieldId { get; set; }

    public int ParentAppViewId { get; set; }

    public int? ChildAppViewId { get; set; }

    public string? AppViewFieldName { get; set; }

    public string? Label { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public int? ControlTypeLkpId { get; set; }

    public int? DataTypeLkpId { get; set; }

    public string? SourceFieldName { get; set; }

    public bool IsHidden { get; set; }

    public bool IsEnabled { get; set; }

    public bool IsReadOnly { get; set; }

    public bool IsOverviewParameter { get; set; }

    public bool IsNullValueAllowed { get; set; }

    public bool IsFilterAllowed { get; set; }

    public string? ValueList { get; set; }

    public string? DefaultValueRefName { get; set; }

    public string? DefaultValue { get; set; }

    public string? SortOrderCode { get; set; }

    public string? FunctionReference { get; set; }

    public string? NavigationReference { get; set; }

    public int? RowHeight { get; set; }

    public decimal? CummulativeHeight { get; set; }

    public int? ColumnId { get; set; }

    public int? ColumnWidth { get; set; }

    public decimal? RelativeWidth { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public bool IsEmptyValueAllowedBak { get; set; }

    public bool IsDefaultOverwritableBak { get; set; }

    public virtual ICollection<AppViewFieldDependency> AppViewFieldDependencyChildAppViewFields { get; set; } = new List<AppViewFieldDependency>();

    public virtual ICollection<AppViewFieldDependency> AppViewFieldDependencyParentAppViewFields { get; set; } = new List<AppViewFieldDependency>();

    public virtual ICollection<AppViewFieldUser> AppViewFieldUsers { get; set; } = new List<AppViewFieldUser>();

    public virtual AppView? ChildAppView { get; set; }

    public virtual AppLookupCode? ControlTypeLkp { get; set; }

    public virtual AppLookupCode? DataTypeLkp { get; set; }

    public virtual AppView ParentAppView { get; set; } = null!;

    public virtual ICollection<SubscriptionField> SubscriptionFields { get; set; } = new List<SubscriptionField>();
}
