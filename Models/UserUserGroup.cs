using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class UserUserGroup
{
    public int UserId { get; set; }

    public int UserGroupId { get; set; }

    public string? Remarks { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual UserGroup UserGroup { get; set; } = null!;
}
