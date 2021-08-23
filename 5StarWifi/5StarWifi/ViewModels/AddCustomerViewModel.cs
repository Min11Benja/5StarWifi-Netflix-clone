using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _5StarWifi.Models;

namespace _5StarWifi.ViewModels
{
    public class AddCustomerViewModel
    {        
        public int SelectedMembershipTypeId { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}