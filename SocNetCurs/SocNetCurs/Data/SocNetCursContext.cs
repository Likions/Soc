using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using SocNetCurs.Models;

namespace SocNetCurs.Data
{
    public class SocNetCursContext : DbContext
    {
        public SocNetCursContext (DbContextOptions<SocNetCursContext> options)
            : base(options)
        {
        }

        public DbSet<SocNetCurs.Models.Posts> Posts { get; set; } = default!;
    }
}
