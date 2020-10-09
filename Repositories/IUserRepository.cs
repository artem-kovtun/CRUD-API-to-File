using CRUDtoFIle.Models;
using System.Collections.Generic;

namespace CRUDtoFIle.Repositories
{
    public interface IUserRepository
    {
        List<User> Users { get; set; }
        void Add(User user);
        void Update(User user);
        User Get(string email);
        List<User> GetAll();
        void Delete(string email);
    }
}
