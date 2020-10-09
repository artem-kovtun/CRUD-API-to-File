using CRUDtoFIle.Repositories;
using System.Collections.Generic;

namespace CRUDtoFIle.Models
{
    public class UserRepository : IUserRepository
    {
        public List<User> Users { get; set; }
        public UserRepository()
        {
            Users = new List<User>();
        }

        public void Add(User user) 
        {
            Users.Add(user);
        }

        public void Update(User user) 
        {
            
        }

        public User Get(string email) {
            return null;
        }

        public List<User> GetAll()
        {
            return Users;
        }

        public void Delete(string email) 
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Email.Equals(email))
                {
                    Users.RemoveAt(i);
                }
            }
        }

    }
}
