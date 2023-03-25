using DevOpsProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DevOpsProject.DataAccess
{
    public class DevContext:IdentityDbContext<AppUser,AppRole,int>
    {
    }
}
