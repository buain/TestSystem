using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.DAL.Entities;

namespace TestSystem.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Role> Roles { get; }
        IRepository<Test> Tests { get; }
        IRepository<Category> Categories { get; }
        IRepository<Question> Questions { get; }
        IRepository<Answer> Answers { get; }
        IRepository<UserAnswer> UserAnswers { get; }
        IRepository<UserTimeOfTest> UserTimeOfTests { get; }
        void Save();
    }
}
