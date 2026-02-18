using AZ204Notes.Application.UseCases;
using AZ204Notes.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AZ204Notes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService) 
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> Get() => _userService.GetUsers();

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = _userService.GetUser(id);
            if (user == null)
                return NotFound();
            return user;
        }
    }

}
