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
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserTimeOfTest> UserTimeOfTests { get; set; }

        static TestContext() //Инициализатор БД
        {
            Database.SetInitializer<TestContext>(new TestSystemDbInitializer());
        }
        public TestContext(string connectionString)
            : base(connectionString)
        {
        }
    }
    public class TestSystemDbInitializer : DropCreateDatabaseIfModelChanges<TestContext>
    {
        protected override void Seed(TestContext db)
        {
            db.Tests.Add(new Test { Id_Owner = 1, Title = "Test1", TimeForTest = 100 }); //Id_Owner = 1, т.е. Admin
            db.Tests.Add(new Test { Id_Owner = 1, Title = "Test2", TimeForTest = 150 });
            db.Tests.Add(new Test { Id_Owner = 1, Title = "Test3", TimeForTest = 200 });
            db.SaveChanges();
        }
    }
}
