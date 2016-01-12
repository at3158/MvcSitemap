using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcSitemap.Models
{
    public class User
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public DateTime RegisterOn { get; set; }

        public bool IsEnable { get; set; }

        // Navigation Properties
        public virtual ICollection<Role> Roles { get; set; }
    }

    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<MvcSitemap.Models.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<MvcSitemap.Models.Role> Roles { get; set; }
    }
}