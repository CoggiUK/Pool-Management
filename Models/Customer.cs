using System;
using System.Collections.Generic;

namespace Pool_Management.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<CustomerPackage> CustomerPackages { get; set; } = new List<CustomerPackage>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
