using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class UserAccounts
    {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Pass { get; set; }
            public string CompanyStatus { get; set; }
            public string CompanyCode { get; set; }
            public string PayrollStatus { get; set; }
            public string PayrollCode { get; set; }
        
    }
}