using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubClassLibrary.Data;
using ClubClassLibrary.Models;

namespace ClubClassLibrary.Repositories
{
    public class UserRepository
    {

        private readonly AppDbContext _context = new AppDbContext();

        public User CheckLogin(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            return user;
        }
    }
}
