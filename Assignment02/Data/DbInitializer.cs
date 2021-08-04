using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Data;
using Lab4.Models;

/*
    Student name:   Asim Jasarevic
    Student number:	040922815
    Section:        CST8359_303
    Lab:			Assignment01 – School Community
    File:           DbInitializer.cs
    Purpose:        Create the database and required tables based on the data model classes
*/

namespace Lab4.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolCommunityContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any()) //if students table is found return if not contiune
            {
                return;   // DB has been seeded
            }

            var students = new Student[] //make new Student objects
            {
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            };
            foreach (Student s in students) //make new rows in student table based of Student objects
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var communities = new Community[] //make new Community objects
            {
            new Community{Id="A1",Title="Alpha",Budget=300},
            new Community{Id="B1",Title="Beta",Budget=130},
            new Community{Id="O1",Title="Omega",Budget=390},
            };
            foreach (Community c in communities) //make new rows in communities table based of Community objects
            {
                context.Communities.Add(c);
            }
            context.SaveChanges();

            var memberships = new CommunityMembership[] //make new CommunityMembership objects
            {
            new CommunityMembership{StudentId=1,CommunityId="A1"},
            new CommunityMembership{StudentId=1,CommunityId="B1"},
            new CommunityMembership{StudentId=1,CommunityId="O1"},
            new CommunityMembership{StudentId=2,CommunityId="A1"},
            new CommunityMembership{StudentId=2,CommunityId="B1"},
            new CommunityMembership{StudentId=3,CommunityId="A1"},
            };
            foreach (var m in memberships) //make new rows in memberships table based of CommunityMembership objects
            {
                context.CommunityMemberships.Add(m);
            }
            context.SaveChanges();

        }
    }
}
