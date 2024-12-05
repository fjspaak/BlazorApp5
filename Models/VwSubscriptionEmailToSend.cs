using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class VwSubscriptionEmailToSend
{
    public int? SubscriptionId { get; set; }

    public long? RowId { get; set; }

    public string? RpUserId { get; set; }

    public string? RpUserName { get; set; }

    public string? RpEmail { get; set; }

    public string? CrUserId { get; set; }

    public string? CrUserName { get; set; }

    public string? CrEmail { get; set; }

    public string? BcUserId { get; set; }

    public string? BcUserName { get; set; }

    public string? BcEmail { get; set; }
}
