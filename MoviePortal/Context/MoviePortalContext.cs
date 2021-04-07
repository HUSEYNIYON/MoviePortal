using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePortal.Context
{
    public class MoviePortalContext : IdentityDbContext
    {
        public MoviePortalContext(DbContextOptions options) : base(options)
        {
        }

        protected MoviePortalContext()
        {
        }
    }
}
