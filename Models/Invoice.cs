using System;
using System.Collections.Generic;

namespace Pool_Management.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? BookingId { get; set; }

    public int? PackageId { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public string? PaymentMethod { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Booking? Booking { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ServicePackage? Package { get; set; }
}
