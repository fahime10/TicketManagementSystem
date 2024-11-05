using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Common
{
    public class Constants
    {
        public const string DEFAULT_PASSWORD = "NeedReset%123";
        public const string STATUS_OPEN = "OPEN";
        public const string STATUS_NEW = "NEW";
        public const string STATUS_CLOSED = "CLOSED";

        public const string ROLE_ADMIN_ID = "f651ea93-3919-4786-9adc-ed5ca6851b78";
        public const string ROLE_USER_ID = "7bcd8450-397d-479c-a05e-248ef54ca893";
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_USER = "User";

        public static readonly Dictionary<string, string> UserRoles = new Dictionary<string, string>
        {
            { ROLE_ADMIN_ID, ROLE_ADMIN },
            { ROLE_USER_ID, ROLE_USER }
        };

        public const string DEFAULT_AVATAR = "avatar.png";
    }
}
