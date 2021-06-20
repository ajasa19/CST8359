using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class CommunityMembership
    {

        public int id { get; set; }

        public int StudentId { get; set; }
        public string CommunityId { get; set; }

        /*dont know if following get/set calling to object is needed but is in git example*/
        public Student Student { get; set; }
        public Community Community { get; set; }


    }
}
