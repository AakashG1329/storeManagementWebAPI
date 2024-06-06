using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Queries.Carts.GetAllUserCarts;
using StoreManagement.Queries.Users.GetUser;

namespace StoreManagement.Controllers
{
    public class CartController :BaseController
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll(int userId)
          => Ok(await Mediator.Send(new GetAllUserCartQuery { userId= userId }));
    }
}
