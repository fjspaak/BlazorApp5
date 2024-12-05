using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SystemMessage
{
    public int SystemMessageId { get; set; }

    public string? SystemMessage1 { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
