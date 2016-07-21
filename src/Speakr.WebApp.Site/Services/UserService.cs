using Speakr.WebApp.Site.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Speakr.WebApp.Site.Services
{
    public class UserService : IUserService
    {
        private ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddUser(UserDetails user)
        {
            _dbContext.Add(user);
            _dbContext.SaveChanges();
        }

        public UserDetails GetUserById(int id)
        {
            return _dbContext.UserDetails.FirstOrDefault(u => u.UserId == id);
        }

        public List<UserDetails> GetAll()
        {
            return _dbContext.UserDetails.ToList();
        }
    }
}
