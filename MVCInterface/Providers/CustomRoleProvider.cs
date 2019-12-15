using MVCInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MVCInterface.Providers
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Для одного пользователя может быть несколько ролей
        /// </summary>
        /// <param name="username" - ник(email), который передается в качестве параметра></param>
        /// <returns></returns>
        public override string[] GetRolesForUser(string username) //
        {
            string[] roles = new string[] { };
            using (UserContext db = new UserContext())
            {
                //Находим пользователя по нику, который был передан в качестве параметра:
                User user = db.Users.FirstOrDefault(u => u.Email == username);
                if(user != null) //если нашли пользователя:
                {
                    //находим роль, которой данный пользователь принадлежит:
                    Role userRole = db.Roles.Find(user.RoleId);
                    if (userRole != null) // если роль найдена:
                    {
                        //создаем новый массив из одного элемента, в к-рый включается название роли:
                        roles = new string[] { userRole.RoleName };
                    }
                }
            }
            return roles;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username" - ник(email) пользователя></param>
        /// <param name="roleName" - роль, которая передается в качестве второго параметра></param>
        /// <returns></returns>
        public override bool IsUserInRole(string username, string roleName) //
        {
            bool outputResult = false;
            using (UserContext db = new UserContext())
            {
                //Находим пользователя по нику, который был передан в качестве параметра:
                User user = db.Users.FirstOrDefault(u => u.Email == username);
                if (user != null) //если нашли пользователя:
                {
                    //находим роль, которой данный пользователь принадлежит:
                    Role userRole = db.Roles.Find(user.RoleId);
                    // если роль пользователя совпадает с той ролью, 
                    // которая передается в качестве второго параметра:
                    if (userRole != null && userRole.RoleName == roleName) 
                    {
                        outputResult = true;
                    }
                }
            }
            return outputResult;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}