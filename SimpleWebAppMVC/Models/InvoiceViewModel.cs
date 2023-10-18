using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAppMVC.Models
{
    public class InvoiceViewModel
    {
        [FromForm]
        public Invoice Invoice { get; set; }

        [FromForm]
        public List<InvoiceDetail> InvoiceDetails { get; set; }

        public InvoiceViewModel(Invoice invoice, List<InvoiceDetail> invoiceDetails)
        {
            Invoice = invoice;
            InvoiceDetails = invoiceDetails;
        }
    }
}
