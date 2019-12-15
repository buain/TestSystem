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
    public class AnswerRepository : IRepository<Answer>
    {
        private TestContext db;

        public AnswerRepository(TestContext context)
        {
            db = context;
        }

        public IEnumerable<Answer> GetAll()
        {
            return db.Answers;
        }

        public Answer Get(int id)
        {
            return db.Answers.Find(id);
        }

        public void Create(Answer answer)
        {
            db.Answers.Add(answer);
        }

        public void Update(Answer answer)
        {
            db.Entry(answer).State = EntityState.Modified;
        }

        public IEnumerable<Answer> Find(Func<Answer, Boolean> predicate)
        {
            return db.Answers.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Answer answer = db.Answers.Find(id);
            if (answer != null)
                db.Answers.Remove(answer);
        }
    }
}
