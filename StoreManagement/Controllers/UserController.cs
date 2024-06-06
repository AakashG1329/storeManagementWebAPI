using Microsoft.AspNetCore.Mvc;
using StoreManagement.Command.Users.CreateUser;
using StoreManagement.Command.Users.DeleteUser;
using StoreManagement.Command.Users.UpdateUser;
using StoreManagement.Queries.Users.GetUser;
using StoreManagement.Queries.Users.GetUserById;
using System.Net;

namespace StoreManagement.Controllers
{
    
    public class UserController : BaseController
    {

        [HttpPost("Register")]
        public async Task<IActionResult>Register(CreateUserCommand request)
            =>Ok(await Mediator.Send(request));
        [HttpPost("Update")]
        public async Task<IActionResult>Update(UpdateUserCommand request)
            =>Ok(await Mediator.Send(request));
        [HttpGet("GetById")]
        public async Task<IActionResult> Get(int id)
            => Ok(await Mediator.Send(new GetUserByIdQuery { id=id}));
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
          => Ok(await Mediator.Send(new GetUserQuery {  }));
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
         => Ok(await Mediator.Send(new DeleteUserCommand { id = id }));
    }
}
