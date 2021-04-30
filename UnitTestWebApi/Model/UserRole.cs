using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserRole
    {
        public int ID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Role")]
        public int RoleID { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
