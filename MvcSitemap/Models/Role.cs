using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSitemap.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string Name { get; set; }

        public bool IsEnable { get; set; }


        // Navigation Properties
        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}