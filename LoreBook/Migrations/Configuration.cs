namespace LoreBook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LoreBook.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LoreBook.models.DbHelper>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LoreBook.models.DbHelper context)
        {
            context.Characters.AddOrUpdate(x => x.CharacterId,
                new Character() { CharacterId = 1, Age = 20, Description = "Blah blah blah", FamilyName = "Something", FirstName = "Glenn", status = "Dead", Title = "Sir" });
        }
    }
}
