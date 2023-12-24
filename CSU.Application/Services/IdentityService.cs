using AutoMapper;

using CSU.Application.Common.Interfaces;
using CSU.Application.Interfaces;
using CSU.Application.Utils;
using CSU.Contracts.V1.Requests;
using CSU.Domain.Users;

using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace CSU.Application.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly string? secretString;

        public IdentityService(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;

            var secret = configuration.GetSection("Secret").Value;

            if (!string.IsNullOrEmpty(secret))
            {
                secretString = secret;
            }
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

        public async Task<string?> LoginAsync(LoginUserRequest request)
        {
            var existsUser = await _userRepository.GetByEmailAsync(request.Email);

            if (existsUser is null)
            {
                return null;
            }

            if (!PasswordHasherUtil.Verify(existsUser.Password, request.Password) || existsUser.IsActive is false)
            {
                return null;
            }

            return await GenerateAuthenticationResultForUser(existsUser);
        }

        private async Task<string> GenerateAuthenticationResultForUser(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(secretString!);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("userId", user.Id.ToString()),
                new Claim("role", user.Role.ToString())
            }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var tokenJWT = tokenHandler.WriteToken(token);
            user.Token = tokenJWT;

            await _userRepository.UpdateAsync(user);
            await _unitOfWork.CommitChangesAsync();

            return tokenJWT;
        }
    }
}
