using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CRUDtoFIle.Models;
using CRUDtoFIle.Repositories;

namespace CRUDtoFIle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            if (!_userRepository.Users.Any())
            {
                _userRepository.Add(new User { Email = "tom26@gmail.com", Name = "Tom", Age = 26 });
                _userRepository.Add(new User { Email = "alice31@gmail.com", Name = "Alice", Age = 31 });
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return _userRepository.GetAll();
        }

    }
}
