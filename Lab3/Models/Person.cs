using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/********************************
Student name:   Asim Jasarevic
Student number:	040922815
Section:        CST8359_303
Lab:			Lab 3 – Razor and Request/Session
File:           Perosn.cs
Purpose:        Represent the shape of the data as public properties and business logic as methods. 

 ********************************/

namespace Lab3.Models
{
    public class Person
    {
        [Required]
        [StringLength(50)]
        public string firstName
        {
            get; 
            set;
        }
        
        [Required]
        [StringLength(50)]
        public string lastName
        {
            get; 
            set;
        }

        [Required]
        public int age
        {
            get; 
            set;
        }
        
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string emailAddress
        {
            get; 
            set;
        }
        
        [Required]
        [DataType(DataType.Date)]
        public string birthDate
        {
            get; 
            set;
        }
        
        [Required]
        [StringLength(100)]
        [BindProperty(Name = "pass")]
        public string password
        {
            get; 
            set;
        }
        
        [Required]
        [StringLength(255)]
        public string description
        {
            get; 
            set;
        }
    }
}
