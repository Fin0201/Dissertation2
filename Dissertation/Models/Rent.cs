﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dissertation.Models
{
    public class Rent
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        [Required]
        public int ItemId { get; set; }

        [ForeignKey("RenterId")]
        public IdentityUser Renter { get; set; }

        [Required]
        public string RenterId { get; set; } // This will store the user account attending the class

        [Required]
        public string LoanLength { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }
    }
}
