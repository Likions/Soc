using Microsoft.AspNetCore.Identity;
using System.Data.Common;

namespace SocNetCurs.Models
{
    public class User: IdentityUser
    {
        public string Name { get;set; }
    }
}
