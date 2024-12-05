using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSecurity
{
    public int? SecurityId { get; set; }

    public string SecurityCode { get; set; } = null!;

    public string? Description { get; set; }

    public int IsRead { get; set; }

    public int IsUpdate { get; set; }

    public int IsInsert { get; set; }

    public int IsDelete { get; set; }

    public int IsExecute { get; set; }

    public int IsOwner { get; set; }

    public int IsAdmin { get; set; }

    public int IsDenied { get; set; }

    public int IsValid { get; set; }

    public int? RedirectedSecurityId { get; set; }
}
