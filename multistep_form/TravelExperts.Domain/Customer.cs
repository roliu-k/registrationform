﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TravelExperts.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string CustFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string CustLastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string CustAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string CustCity { get; set; }

        [Required]
        [Display(Name = "Province")]
        public string CustProv { get; set; }

        [Required]
        [RegularExpression(@"^(?!.*[DFIOQU])[A-VXY][0-9][A-Z][- ]?[0-9][A-Z][0-9]$", ErrorMessage = "Invalid Postal Code Format")]
        [Display(Name = "Postal Code")]
        public string CustPostal { get; set; }

        [Display(Name = "Country")]
        public string CustCountry { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]?[-. ]?\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        [Display(Name = "Home Phone")]
        public string CustHomePhone { get; set; }

        [Display(Name = "Business Phone")]
        [RegularExpression(@"^[0-9]?[-. ]?\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        public string CustBusPhone { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string CustEmail { get; set; }

        public int? AgentId { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string UserLogin { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string UserPass { get; set; }

    }
}
