using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class Document
{
    public int DocumentId { get; set; }

    public string? DocumentName { get; set; }

    public byte[]? DocumentObject { get; set; }

    public string? Description { get; set; }

    public int? DocumentTypeLkpId { get; set; }

    public Guid? DocumentGuid { get; set; }

    public string? Remarks { get; set; }

    public string? ExternalReference { get; set; }

    public string? GlobalReference { get; set; }

    public DateTime? MetaCreationDate { get; set; }

    public DateTime? MetaMutationDate { get; set; }

    public string? MetaCreationUser { get; set; }

    public string? MetaMutationUser { get; set; }

    public string? MetaHashValue { get; set; }
}
