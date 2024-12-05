using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class ServiceProvider
{
    public int ServiceProviderId { get; set; }

    public int? ServiceProviderTypeLkpId { get; set; }

    public string? ServiceProviderName { get; set; }

    public string? Description { get; set; }

    public string? Url { get; set; }

    public string? ConnectionString { get; set; }

    public string? LinkedServerName { get; set; }

    public string? DbMailProviderName { get; set; }

    public bool IsDefault { get; set; }

    public bool IsEnabled { get; set; }

    public string? Remarks { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? Flags { get; set; }

    public int Version { get; set; }

    public string? Prompt { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public string? TempDbConnectionString { get; set; }

    public virtual ICollection<Overview> Overviews { get; set; } = new List<Overview>();

    public virtual AppLookupCode? ServiceProviderTypeLkp { get; set; }

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
}
