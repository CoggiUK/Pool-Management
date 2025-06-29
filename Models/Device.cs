using System;
using System.Collections.Generic;

namespace Pool_Management.Models;

public partial class Device
{
    public int Id { get; set; }

    public int? PoolId { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public DateOnly? WarrantyUntil { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<DeviceIssue> DeviceIssues { get; set; } = new List<DeviceIssue>();

    public virtual ICollection<DeviceMaintenance> DeviceMaintenances { get; set; } = new List<DeviceMaintenance>();

    public virtual Pool? Pool { get; set; }
}
