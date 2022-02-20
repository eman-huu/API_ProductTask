using API_ProductTask.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ProductTask.Repository
{
    public interface IUserRepository
    {
        public _User Authenticate(string username, string password);
    }
}
