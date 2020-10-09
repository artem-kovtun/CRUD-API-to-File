using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRUDtoFIle.Models;

namespace CRUDtoFIle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UserRepository repo;

        public UsersController(UserRepository repo)
        {
            this.repo = repo;
            if (!repo.users.Any())
            {
                repo.users.Add(new User { Email = "tom26@gmail.com", Name = "Tom", Age = 26 });
                repo.users.Add(new User { Email = "alice31@gmail.com", Name = "Alice", Age = 31 });
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {            
            return repo.users.ToList();
        }

    }
}
