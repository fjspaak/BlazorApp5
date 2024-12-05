using System;
using System.Collections.Generic;

namespace BlazorApp5.Models;

public partial class SystemSetting
{
    public int SystemSettingId { get; set; }

    public string? PortalTitle { get; set; }

    public string? PortalColorCode { get; set; }

    public int? OpeningAppFormId { get; set; }

    public bool? IsSearchEnabled { get; set; }

    public bool? ShowWelcomeMessage { get; set; }

    public string? WelcomeMessage { get; set; }

    public string? OffLineMessage { get; set; }

    public string? DisabledUserMessage { get; set; }

    public string? AdministratorEmail { get; set; }

    public string? AdministratorTelephone { get; set; }

    public string? HelpdeskEmail { get; set; }

    public string? HelpdeskTelephone { get; set; }

    public int? LogoAppImageId { get; set; }

    public string? ImageMasterDirectory { get; set; }

    public string? StaticReportPath { get; set; }

    public string? ApprovalMessage { get; set; }

    public DateTime? DataApprovalDate { get; set; }

    public DateTime? DataLastUpdatedDate { get; set; }

    public bool? IsApplicationOffline { get; set; }

    public virtual AppImage? LogoAppImage { get; set; }

    public virtual AppForm? OpeningAppForm { get; set; }
}
