using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubClassLibrary.Data;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubClassLibrary.Repositories
{
    public class MembershipRepository
    {

        private readonly AppDbContext _context = new AppDbContext();


        public Membership  GetById(int id)
        {
            return  _context.Memberships.Find(id);
        }


        public  IEnumerable<Membership> GetAll()
        {
            return  _context.Memberships.Include(m=>m.Member).Include(m => m.MembershipType).ToList();
        }

        public void Add(Membership membership)
        {
           _context.Memberships.Add(membership);
           _context.SaveChanges();
        }

        public void Update(Membership membership)
        {
            _context.Entry(membership).State = EntityState.Modified; // Or _context.Members.Update(member) in EF Core 5+
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var membership = _context.Memberships.Find(id);
            if (membership != null)
            {
                _context.Memberships.Remove(membership);
                _context.SaveChanges();
            }
        }
    }
}
