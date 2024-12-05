using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SubscriptionUser
{
    public int SubscriptionUserId { get; set; }

    public int UserId { get; set; }

    public int SubscriptionId { get; set; }

    public int EmailRecepientTypeLkpId { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool IsCustom { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual Subscription Subscription { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
