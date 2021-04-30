using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Role
    {
        public int Id { get; set; }
        public String Role_Name { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
    }
}
