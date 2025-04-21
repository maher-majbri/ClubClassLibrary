using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubClassLibrary.Data;
using ClubClassLibrary.Interfaces;
using ClubClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using ClubClassLibrary.Data;

namespace ClubClassLibrary.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

      
        public async Task<Member> GetMemberByIdAsync(int id)
        {
            return await _context.Members.FindAsync(id);
        }

        public async Task<IEnumerable<Member>> GetAllMembersAsync()
        {
            return await _context.Members.ToListAsync();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }

        public IEnumerable<Member> GetMembersByJoinDate(DateTime dateFrom,DateTime dateTo)
        {
            return _context.Members
         .Where(m => m.JoinDate >= dateFrom && m.JoinDate <= dateTo)
         .ToList();
        }

        public async Task AddMemberAsync(Member member)
        {
            await _context.Members.AddAsync(member);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMemberAsync(Member member)
        {
            _context.Entry(member).State = EntityState.Modified; // Or _context.Members.Update(member) in EF Core 5+
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMemberAsync(int id)
        {
            var member = await _context.Members.FindAsync(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                await _context.SaveChangesAsync();
            }
        }
    }
}
