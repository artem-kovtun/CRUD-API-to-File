using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDtoFIle.Models
{
    public class UserRepository
    {
        public List<User> users { get; set; }
        public UserRepository()
        {
            users = new List<User>();
        }

        public void add(User user) 
        {
            users.Add(user);
        }

        public void update(User user) 
        {
            
        }

        public User get(string email) {
            return null;
        }

        public List<User> getAll()
        {
            return users;
        }

        public void delete(string email) 
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Email.Equals(email))
                {
                    users.RemoveAt(i);
                }
            }
        }

    }
}
