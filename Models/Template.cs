using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Template
{
    public int TemplateId { get; set; }

    public int? TemplateTypeLkpId { get; set; }

    public string? TemplateName { get; set; }

    public string? Body { get; set; }

    public string? Subject { get; set; }

    public string? Location { get; set; }

    public string? Remarks { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();

    public virtual AppLookupCode? TemplateTypeLkp { get; set; }
}
