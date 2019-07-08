using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoreBook.Models;  

namespace LoreBookDAL.models
{
    public class DbHelper : DbContext
    {
        public DbHelper() : base("name=DbHelper") { }

        // Entities
        public DbSet<Character> Characters { get; set; }
        public DbSet<Family> Families { get; set; }

    }
}
