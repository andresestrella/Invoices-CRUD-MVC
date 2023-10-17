using System.Collections.Generic;

namespace SimpleWebAppMVC.Models
{
    public class InvoiceViewModel
    {
        public Invoice Invoice { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
