﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _5StarWifi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]        
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        [Required]
        [StringLength(255)]
        public string Adress { get; set; }
        [StringLength(25)]
        public string Phone { get; set; }
        [Display(Name = "Subscribed")]
        public bool isSubscribedToCustomer { get; set; }
        //Asociates this Customer class with MembershipType 1, 2, 3        
        public MembershipType MembershipType { get; set; }
        //Optimization: when you only need the foreign key and not the whole object
        [Display(Name = "Duration")]
        public byte MembershipTypeId { get; set; }
        [StringLength(10)]
        public string StartDate { get; set; }
        [StringLength(10)]
        public string EndDate { get; set; }
    }
}