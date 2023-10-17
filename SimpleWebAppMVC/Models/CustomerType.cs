using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SimpleWebAppMVC.Models;

public partial class CustomerType
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(70)]
    public string Description { get; set; }

    [InverseProperty("CustomerType")]
    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
