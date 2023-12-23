using CSU.Application.Common.Interfaces;
using CSU.Domain.Users;
using CSU.Infrastructure.Common.Persistence;

using Microsoft.EntityFrameworkCore;

namespace CSU.Infrastructure.Users.Persistance
{
    public class UserRepository : IUserRepository
    {
        private readonly CsuDbContext _dataContext;

        public UserRepository(CsuDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _dataContext.Users.SingleOrDefaultAsync(u => u.Email == email);
        }

        public async Task CreateAsync(User user)
        {
            await _dataContext.Users.AddAsync(user);
        }
    }
}
