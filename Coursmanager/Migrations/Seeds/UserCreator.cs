using CourManger.Models.ValidatableObjects;
using Coursmanager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursmanager.Migrations.Seeds
{
    public class UserCreator
    {
        private readonly Coursmanager.Models.CourseManagerContext _context;
        public UserCreator(Coursmanager.Models.CourseManagerContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            var initialUsers = new List<Users>
            {
                new Users
                {
                    Account="admin",
                    Name="admin",
                    Password="123456".MD5Encoding()
                }
            };
            foreach (var action in initialUsers)
            {
                if (_context.Users.Any(r => r.Name == action.Name))
                {
                    continue;
                }
                _context.Users.Add(action);
            }
            _context.SaveChanges();
        }
    }
}