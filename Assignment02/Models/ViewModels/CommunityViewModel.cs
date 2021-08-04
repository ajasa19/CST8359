using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    Student name:   Asim Jasarevic
    Student number:	040922815
    Section:        CST8359_303
    Lab:			Assignment01 – School Community
    File:           CommunityViewModel.cshtml
    Purpose:        
    Source:         aarad - ac / EFCore / lab4
*/

namespace Lab4.Models.ViewModels
{
    public class CommunityViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Community> Communities { get; set; }
        public IEnumerable<CommunityMembership> CommunityMemberships { get; set; }
    }
}
