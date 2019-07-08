using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoreBook.Models
{
    public class Family
    {
        [Key]
        public int FamilyId { get; set; }
        public string FamilyName { get; set; }
        public string Heritage { get; set; }

    }
}