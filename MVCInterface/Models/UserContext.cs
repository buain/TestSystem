using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCInterface.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        ///<summary>
        ///Начальная инициализация БД. Создаём две роли и добавляем их в БД
        ///Создаем одного пользователя с адм.функциями
        ///</summary>
        protected override void Seed(UserContext db)
        {
            db.Roles.Add(new Role { Id = 1, RoleName = "Admin" });
            db.Roles.Add(new Role { Id = 2, RoleName = "User" });
            db.Users.Add(new User
            {
                Id = 1,
                Email = "vbuain@gmail.com",
                Password = "12345678",
                Age = 36,
                RoleId = 1 //1-адм.функции
            });
            base.Seed(db);
        }
    }
}