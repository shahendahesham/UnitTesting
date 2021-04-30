using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{

    public class RoleRepo : IRepo<Role>
    {
        private APIContext _db;

      
        public RoleRepo(APIContext db)
        {
            _db = db;
        }
        public void Add(Role data)
        {
            _db.Roles.Add(data);
            _db.SaveChanges();
        }

        public bool Delete(Role role)
        {
            //Role Std = _db.Roles.FirstOrDefault(a => a.Id == id);
            _db.Roles.Remove(role);
            int flag = _db.SaveChanges();
            if (flag == 1)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public Role Edit(Role data)
        {
            var entity = _db.Roles.FirstOrDefault(x => x.Id == data.Id);
            entity.Id = data.Id;
            entity.Role_Name = data.Role_Name;
            entity.UserRoles = data.UserRoles;
            _db.SaveChanges();
            return data;
        }

        public List<Role> GetAll()
        {
            List<Role> roles = _db.Roles.ToList();
            return roles;
        }

        public Role GetById(int id)
        {
            Role role = _db.Roles.FirstOrDefault(a => a.Id == id);
            return role;
        }
    }
}
