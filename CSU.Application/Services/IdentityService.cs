using AutoMapper;

using CSU.Application.Common.Interfaces;
using CSU.Application.Interfaces;
using CSU.Application.Utils;
using CSU.Contracts.V1.Requests;
using CSU.Domain.Users;

namespace CSU.Application.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public IdentityService(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> RegisterAsync(UserRegistrationRequest request)
        {
            var user = _mapper.Map<User>(request);

            var existsUser = await _userRepository.GetByEmailAsync(user.Email);

            if (existsUser is not null)
            {
                return false;
            }

            user.Password = PasswordHasherUtil.Hash(user.Password);
            await _userRepository.CreateAsync(user);
            await _unitOfWork.CommitChangesAsync();

            return true;
        }
    }
}
