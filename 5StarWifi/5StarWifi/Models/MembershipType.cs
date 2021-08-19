using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5StarWifi.Models
{
    public class MembershipType
    {
        //Pay As you go Membership 30 days is type = 1
        //Membership fee for 6 months is type 2
        //Anual fee for 12 months is type 3
        public byte Id { get; set; }
        public decimal SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}