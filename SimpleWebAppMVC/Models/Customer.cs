using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SimpleWebAppMVC.Models;

public partial class Customer
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(70)]
    public string CustName { get; set; }

    [Required]
    [StringLength(120)]
    public string Adress { get; set; }

    [Required]
    public bool? Status { get; set; } = true;

    public int CustomerTypeId { get; set; }

    [ForeignKey("CustomerTypeId")]
    [InverseProperty("Customers")]
    public virtual CustomerType CustomerType { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();
}
