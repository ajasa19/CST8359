using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Lab4.Models
{
    public class Advertisement
    {
        [Key]
        public int ImageId
        {
            get;
            set;
        }

        [Required]
        [DisplayName("File Name")]
        public string FileName
        {
            get;
            set;
        }

        [Required]
        public string Url
        {
            get;
            set;
        }

        [Required]
        [Url]
        public string CommunityId
        {
            get;
            set;
        }

    }
}


