﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore3Tier.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
