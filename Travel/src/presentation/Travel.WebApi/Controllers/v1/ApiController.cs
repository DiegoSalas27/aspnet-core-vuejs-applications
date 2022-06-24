using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Travel.WebApi.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    { 
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); // property injection
    }
}