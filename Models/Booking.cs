using System;
using System.Collections.Generic;

namespace Pool_Management.Models;

public partial class Booking
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? PoolId { get; set; }

    public DateOnly? BookingDate { get; set; }

    public string? TimeSlot { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Pool? Pool { get; set; }
}
