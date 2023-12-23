using Ardalis.SmartEnum;

namespace CSU.Domain.Users
{
    public class UserRole : SmartEnum<UserRole>
    {
        public static readonly UserRole Admin = new(nameof(Admin), 0);
        public static readonly UserRole ContentCreator = new(nameof(ContentCreator), 1);
        public static readonly UserRole User = new(nameof(User), 2);

        public UserRole(string name, int value) : base(name, value)
        {
        }
    }
}
