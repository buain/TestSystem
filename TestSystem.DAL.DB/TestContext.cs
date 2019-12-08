using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.DAL.Entities;

namespace TestSystem.DAL.DB
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        static TestContext()
        {
            Database.SetInitializer<TestContext>(new TestDbInitializer());
        }
        public TestContext(string connectionString)
            :base(connectionString)
        {
        }
    }
    public class TestDbInitializer : DropCreateDatabaseIfTestChanges<TestContext>
    {
        protected override void Seed(TestContext db)
        {
            db.Tests.Add(new Test { Title = "Математический тест", TimeForTest = 100 });
            db.SaveChanges();
        }
    }
}
