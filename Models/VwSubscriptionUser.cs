using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSubscriptionUser
{
    public int? SubscriptionId { get; set; }

    public string? SubscriptionName { get; set; }

    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public bool IsUserProfile { get; set; }

    public bool IsVirtualUser { get; set; }

    public bool IsSystem { get; set; }

    public int? InR { get; set; }

    public int? InCr { get; set; }

    public int? InBc { get; set; }
}
