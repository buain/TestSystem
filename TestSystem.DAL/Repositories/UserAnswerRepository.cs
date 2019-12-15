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
    public class UserAnswerRepository : IRepository<UserAnswer>
    {
        private TestContext db;

        public UserAnswerRepository(TestContext context)
        {
            db = context;
        }

        public IEnumerable<UserAnswer> GetAll()
        {
            return db.UserAnswers;
        }

        public UserAnswer Get(int id)
        {
            return db.UserAnswers.Find(id);
        }

        public void Create(UserAnswer userAnswer)
        {
            db.UserAnswers.Add(userAnswer);
        }

        public void Update(UserAnswer userAnswer)
        {
            db.Entry(userAnswer).State = EntityState.Modified;
        }

        public IEnumerable<UserAnswer> Find(Func<UserAnswer, Boolean> predicate)
        {
            return db.UserAnswers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            UserAnswer userAnswer = db.UserAnswers.Find(id);
            if (userAnswer != null)
                db.UserAnswers.Remove(userAnswer);
        }
    }
}
