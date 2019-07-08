using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoreBook.Models
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string Title { get; set; }
        [StringLength(int.MaxValue)]
        public string Description { get; set; }
        public int Age { get; set; }
        [Required]
        public string status { get; set; }

        public Character()
        {

        }
    }
}