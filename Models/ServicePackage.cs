using System;
using System.Collections.Generic;

namespace Pool_Management.Models;

public partial class ServicePackage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? ValidDays { get; set; }

    public int? MaxSessionsPerDay { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<CustomerPackage> CustomerPackages { get; set; } = new List<CustomerPackage>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
