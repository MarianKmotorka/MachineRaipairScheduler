using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Features.V1;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Controllers.V1
{
    [ApiController]
    [Authorize(Roles = Roles.SysAdmin, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MachinesController : ControllerBase
    {
        private IMediator _mediator;

        public MachinesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.Machine.CreateMachine)]
        public async Task<ActionResult<CreateMachine.CommandResponse>> CreateMachine([FromBody]CreateMachine.Command request)
        {
            var result = await _mediator.Send(request);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
    }
}
