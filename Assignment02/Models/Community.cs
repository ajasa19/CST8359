using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
    Student name:   Asim Jasarevic
    Student number:	040922815
    Section:        CST8359_303
    Lab:			Lab 4 – The Entity Framework 
    File:           Community.cs
    Purpose:        data field model for community objects
*/

namespace Lab4.Models
{
    public class Community
    {

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Registration Number")]  
        public string Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        public ICollection<CommunityMembership> CommunityMemberships { get; set; }
    }
}
