using System.Collections.Generic;
using Speakr.WebApp.Site.Infrastructure.Database;

namespace Speakr.WebApp.Site.Services
{
    public interface IUserService
    {
        void AddUser(UserDetails user);
        List<UserDetails> GetAll();
        UserDetails GetUserById(int id);
    }
}