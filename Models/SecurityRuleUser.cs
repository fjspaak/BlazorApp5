using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SecurityRuleUser
{
    public int SecurityRuleId { get; set; }

    public int UserId { get; set; }

    public virtual SecurityRule SecurityRule { get; set; } = null!;
}
