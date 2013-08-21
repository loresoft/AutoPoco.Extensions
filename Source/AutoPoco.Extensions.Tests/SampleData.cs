using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoPoco.Extensions.Tests
{
    public class SampleData
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public string ShortName { get; set; }

        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        

        public int ClientNumber { get; set; }
        
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string StateProvidence { get; set; }
        public string PostalCode { get; set; }
        
        public string BusinessPhone { get; set; }
        public string BusinessFax { get; set; }
        public string MobilePhone { get; set; }
        public string OtherPhone { get; set; }
        public string WebSite { get; set; }
        
        public Guid BusinessDivisionId { get; set; }
        public bool IsCreditHold { get; set; }
        public bool IsInvoiceHold { get; set; }
        public decimal CreditLimit { get; set; }
        public bool IsActive { get; set; }
        
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
