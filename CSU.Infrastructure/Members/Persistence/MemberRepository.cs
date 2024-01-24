using CSU.Application.Common.Interfaces;
using CSU.Domain.Members;
using CSU.Infrastructure.Common.Persistence;

using Microsoft.EntityFrameworkCore;

namespace CSU.Infrastructure.Members.Persistence
{
    public class MemberRepository : IMemberRepository
    {
        private readonly CsuDbContext _dataContext;

        public MemberRepository(CsuDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateAsync(Member member)
        {
            await _dataContext.Members.AddAsync(member);
        }

        public async Task<Member?> GetByIdAsync(Guid id)
        {
            var result = await _dataContext.Members
                .SingleOrDefaultAsync(m => m.Id == id);

            return result;
        }

        public async Task<List<Member>> GetAll(int type, int position)
        {
            IQueryable<Member> query = _dataContext.Members;

            if (type != -1)
            {
                query = query.Where(m => m.Type == type);
            }

            if (position != -1)
            {
                query = query.Where(m => m.Position == position);
            }

            var result = await query.ToListAsync();

            return result;
        }
    }
}
