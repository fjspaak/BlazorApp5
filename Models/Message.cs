using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Message
{
    public int MessageId { get; set; }

    public int? ParentMessageId { get; set; }

    public int? UserId { get; set; }

    public int? OverviewId { get; set; }

    public string? MessageName { get; set; }

    public string? Remarks { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool IsNewsMessage { get; set; }

    public bool IsBlogMessage { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public virtual ICollection<Message> InverseParentMessage { get; set; } = new List<Message>();

    public virtual Overview? Overview { get; set; }

    public virtual Message? ParentMessage { get; set; }

    public virtual User? User { get; set; }
}
