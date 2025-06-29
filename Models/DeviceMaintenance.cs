using System;
using System.Collections.Generic;

namespace Pool_Management.Models;

public partial class DeviceMaintenance
{
    public int Id { get; set; }

    public int? DeviceId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Description { get; set; }

    public int? PerformedBy { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Device? Device { get; set; }

    public virtual Employee? PerformedByNavigation { get; set; }
}
