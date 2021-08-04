using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    Student name:   Asim Jasarevic
    Student number:	040922815
    Section:        CST8359_303
    Lab:			Assignment01 – School Community
    File:           CommunityMembership.cs
    Purpose:        data field model for membership objects
*/

namespace Lab4.Models
{
    public class CommunityMembership
    {

        public int id { get; set; }
        public int StudentId { get; set; }
        public string CommunityId { get; set; }

        public Student Student { get; set; }
        public Community Community { get; set; }


    }
}
