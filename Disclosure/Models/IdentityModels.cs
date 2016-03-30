using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Disclosure.Models
{
    public class ApplicationUser : IdentityUser
    {

    }

    public class UserDbContext : IdentityDbContext<ApplicationUser>
    {
        public UserDbContext()
            : base("DefaultConnection")
        {
        }

        public static UserDbContext Create()
        {
            return new UserDbContext();
        }
    }
}