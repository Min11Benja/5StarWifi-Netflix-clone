using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _5StarWifi.Models;

namespace _5StarWifi.ViewModels
{
    public class DetailsCustomerViewModel
    {
        public Customer Customer { get; set; }        
        public MembershipType MembershipType { get; set; }
    }
}