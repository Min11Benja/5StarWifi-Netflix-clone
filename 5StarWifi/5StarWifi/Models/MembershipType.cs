using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5StarWifi.Models
{
    public class MembershipType
    {
        //1 month id = 1
        //6 months id = 2
        //12 months id = 3
        public byte Id { get; set; }
        public decimal SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}