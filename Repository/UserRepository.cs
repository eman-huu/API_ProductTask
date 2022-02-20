using API_ProductTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly _Context _context;
        public UserRepository(_Context context)
        {
            _context = context;
        }

        public _User Authenticate(string username, string password)
        {
            if ((string.IsNullOrEmpty(username)) || (string.IsNullOrEmpty(password)))
            {
                return null;
            }

            var user = _context.Users.Where(x => x.UserName == username && x.UserPassword == password).FirstOrDefault();
            if (user == null)
                return null;
            user.UserPassword = null;
            return user;
        }
    }
}
