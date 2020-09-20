using Dal.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Concrete.EntityFramework.Repository
{
    public class EfUserRepository : EfGenericRepository<Users>, IUserRepository
    {
        public EfUserRepository():base()
        {
            
        }

        public Users Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Users RegisterUser(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
