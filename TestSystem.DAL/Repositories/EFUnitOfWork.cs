using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.DAL.DB;
using TestSystem.DAL.Entities;
using TestSystem.DAL.Interfaces;

namespace TestSystem.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private TestContext db;
        public UserRepository userRepository;
        private TestRepository testRepository;
        private RoleRepository roleRepository;
        private CategoryRepository categoryRepository;
        private QuestionRepository questionRepository;
        private AnswerRepository answerRepository;
        private UserAnswerRepository userAnswerRepository;
        private UserTimeOfTestRepository userTimeOfTestRepository; 
        public EFUnitOfWork(string connectionString)
        {
            db = new TestContext(connectionString);
        }
        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }
        public IRepository<Test> Tests
        {
            get
            {
                if (testRepository == null)
                    testRepository = new TestRepository(db);
                return testRepository;
            }
        }
        public IRepository<Role> Roles
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new RoleRepository(db);
                return roleRepository;
            }
        }
        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(db);
                return categoryRepository;
            }
        }
        public IRepository<Question> Questions
        {
            get
            {
                if (questionRepository == null)
                    questionRepository = new QuestionRepository(db);
                return questionRepository;
            }
        }
        public IRepository<Answer> Answers
        {
            get
            {
                if (answerRepository == null)
                    answerRepository = new AnswerRepository(db);
                return answerRepository;
            }
        }
        public IRepository<UserAnswer> UserAnswers
        {
            get
            {
                if (userAnswerRepository == null)
                    userAnswerRepository = new UserAnswerRepository(db);
                return userAnswerRepository;
            }
        }
        public IRepository<UserTimeOfTest> UserTimeOfTests
        {
            get
            {
                if (userTimeOfTestRepository == null)
                    userTimeOfTestRepository = new UserTimeOfTestRepository(db);
                return userTimeOfTestRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
