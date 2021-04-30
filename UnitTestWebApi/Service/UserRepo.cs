using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public  class UserRepo : IRepo<User>
    {
        private APIContext _db;


        public UserRepo(APIContext db)
        {
            _db = db;
        }
        public void Add(User data)
        {
            _db.Users.Add(data);
            _db.SaveChanges();
            //throw new NotImplementedException();
        }

        public bool Delete(User user)
        {
            //User u = _db.Users.FirstOrDefault(a => a.Id == id);
            _db.Users.Remove(user);
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

        public User Edit(User data)
        {

            var entity = _db.Users.FirstOrDefault(x => x.Id == data.Id);

            // assign new value to existing property.
            entity.Id = data.Id;
            entity.Name = data.Name;
            entity.Email = data.Email;
            entity.Password = data.Password;

            entity.UserRoles = data.UserRoles;



            _db.SaveChanges();
            return data;
            //throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            List<User> users = _db.Users.ToList();
            return users;
            //throw new NotImplementedException();
        }

        public User GetById(int id)
        {
                User user = _db.Users.FirstOrDefault(a => a.Id == id);
            return user;
        }
        public bool Login(string email,string password)
        {
            return this._db.Set<User>().Any(a => a.Email == email && a.Password == password);
        }
    }
}
