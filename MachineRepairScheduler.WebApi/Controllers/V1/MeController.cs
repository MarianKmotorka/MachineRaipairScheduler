using MachineRepairScheduler.WebApi.Features.V1.Users;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Controllers.V1
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MeController : ControllerBase
    {
        private IMediator _mediator;

        public MeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.Me.ChangePassword)]
        public async Task<ActionResult<ChangePassword.CommandResponse>> ChangePassword([FromBody]ChangePassword.Command command)
        {
            var userId = User.Claims.Single(x => x.Type == "id").Value;
            command.UserId = userId;
            var result = await _mediator.Send(command);

            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
    }
}
