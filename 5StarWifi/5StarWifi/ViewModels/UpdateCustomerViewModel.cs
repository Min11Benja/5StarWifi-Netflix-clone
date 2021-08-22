using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _5StarWifi.Models;
namespace _5StarWifi.ViewModels
{
    public class UpdateCustomerViewModel
    {
        public int SelectedMembershipTypeId { get; set; }
        public IEnumerable<MembershipType> MembershipTypesList { get; set; }  
        
        public Customer Customer { get; set; }
        public MembershipType MembershipType { get; set; }
    }
}