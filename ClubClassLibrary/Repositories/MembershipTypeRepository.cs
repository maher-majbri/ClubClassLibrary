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
    public class MembershipTypeRepository
    {

        private readonly AppDbContext _context = new AppDbContext();

    
        // ... (Implement the methods - very similar to MemberRepository)
        public async Task<MembershipType> GetMembershipTypeByIdAsync(int id)
        {
            return await _context.MembershipTypes.FindAsync(id);
        }

        public async Task<IEnumerable<MembershipType>> GetAllMembershipTypesAsync()
        {
            return await _context.MembershipTypes.ToListAsync();
        }

        public IEnumerable<MembershipType> GetAllMembershipTypes()
        {
            return  _context.MembershipTypes.ToList();
        }

        public async Task AddMembershipTypeAsync(MembershipType membershipType)
        {
            await _context.MembershipTypes.AddAsync(membershipType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMembershipTypeAsync(MembershipType membershipType)
        {
            _context.Entry(membershipType).State = EntityState.Modified; // Or _context.MembershipTypes.Update(membershipType) in EF Core 5+
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMembershipTypeAsync(int id)
        {
            var membershipType = await _context.MembershipTypes.FindAsync(id);
            if (membershipType != null)
            {
                _context.MembershipTypes.Remove(membershipType);
                await _context.SaveChangesAsync();
            }
        }
    }
}
