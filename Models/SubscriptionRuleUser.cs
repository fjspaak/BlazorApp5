using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SubscriptionRuleUser
{
    public int SubscriptionRuleUserId { get; set; }

    public int SubscriptionRuleId { get; set; }

    public int UserId { get; set; }

    public virtual SubscriptionRule SubscriptionRule { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
