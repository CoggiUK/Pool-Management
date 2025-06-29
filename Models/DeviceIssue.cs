using System;
using System.Collections.Generic;

namespace Pool_Management.Models;

public partial class DeviceIssue
{
    public int Id { get; set; }

    public int? DeviceId { get; set; }

    public DateTime? ReportedAt { get; set; }

    public int? ReportedBy { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Device? Device { get; set; }

    public virtual Employee? ReportedByNavigation { get; set; }
}
