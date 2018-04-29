namespace CSI418Proj.Migrations
{
    using CSI418Proj.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CSI418Proj.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CSI418Proj.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.FieldMappings.AddOrUpdate(x => x.FieldNum,
                new FieldMapping() { id = 1, FieldNum = "Field 1", FieldName = "" },
                new FieldMapping() { id = 2, FieldNum = "Field 2", FieldName = "" },
                new FieldMapping() { id = 3, FieldNum = "Field 3", FieldName = "" },
                new FieldMapping() { id = 4, FieldNum = "Field 4", FieldName = "" },
                new FieldMapping() { id = 5, FieldNum = "Field 5", FieldName = "" },
                new FieldMapping() { id = 6, FieldNum = "Field 6", FieldName = "" },
                new FieldMapping() { id = 7, FieldNum = "Field 7", FieldName = "" },
                new FieldMapping() { id = 8, FieldNum = "Field 8", FieldName = "" },
                new FieldMapping() { id = 9, FieldNum = "Field 9", FieldName = "" },
                new FieldMapping() { id = 10, FieldNum = "Field 10", FieldName = "" },
                new FieldMapping() { id = 11, FieldNum = "Field 11", FieldName = "Image Path" });
        }
    }
}
