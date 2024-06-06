using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace StoreManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public class BaseController : ControllerBase
    {
        private IMediator _mediator;



        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
