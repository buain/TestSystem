using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.DAL.DB;
using TestSystem.DAL.Entities;
using TestSystem.DAL.Interfaces;

namespace TestSystem.DAL.Repositories
{
    public class TestRepository : IRepository<Test>
    {
        private TestContext db;

        public TestRepository(TestContext context)
        {
            db = context;
        }

        public IEnumerable<Test> GetAll()
        {
            return db.Tests;
        }

        public Test Get(int id)
        {
            return db.Tests.Find(id);
        }

        public void Create(Test test)
        {
            db.Tests.Add(test);
        }

        public void Update(Test test)
        {
            db.Entry(test).State = EntityState.Modified;
        }

        public IEnumerable<Test> Find(Func<Test, Boolean> predicate)
        {
            return db.Tests.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Test test = db.Tests.Find(id);
            if (test != null)
                db.Tests.Remove(test);
        }
    }
}
