using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace AccMng.DataContext;

public class AppIdentityContext : IdentityDbContext<AppUser>
{
    public AppIdentityContext(DbContextOptions<AppIdentityContext> options) : base(options)
    {
    }
}