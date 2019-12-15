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
    public class UserTimeOfTestRepository : IRepository<UserTimeOfTest>
    {
        private TestContext db;

        public UserTimeOfTestRepository(TestContext context)
        {
            db = context;
        }

        public IEnumerable<UserTimeOfTest> GetAll()
        {
            return db.UserTimeOfTests;
        }

        public UserTimeOfTest Get(int id)
        {
            return db.UserTimeOfTests.Find(id);
        }

        public void Create(UserTimeOfTest userTimeOfTest)
        {
            db.UserTimeOfTests.Add(userTimeOfTest);
        }

        public void Update(UserTimeOfTest userTimeOfTest)
        {
            db.Entry(userTimeOfTest).State = EntityState.Modified;
        }

        public IEnumerable<UserTimeOfTest> Find(Func<UserTimeOfTest, Boolean> predicate)
        {
            return db.UserTimeOfTests.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            UserTimeOfTest userTimeOfTest = db.UserTimeOfTests.Find(id);
            if (userTimeOfTest != null)
                db.UserTimeOfTests.Remove(userTimeOfTest);
        }
    }
}
