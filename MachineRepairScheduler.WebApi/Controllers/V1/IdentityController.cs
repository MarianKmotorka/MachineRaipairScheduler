using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Features.V1;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Controllers.V1
{
    [Authorize(Roles = Roles.SysAdmin)]
    public class IdentityController : ControllerBase
    {
        private IMediator _mediator;

        public IdentityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.Identity.RegisterEmployee)]
        public async Task<ActionResult<Register.CommandResponse>> RegisterEmployee([FromBody]Register.Command request)
        {
            request.Role = Register.Role.Employee;

            var result = await _mediator.Send(request);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpPost(ApiRoutes.Identity.RegisterTechnician)]
        public async Task<ActionResult<Register.CommandResponse>> RegisterTechnician([FromBody]Register.Command request)
        {
            request.Role = Register.Role.Technician;

            var result = await _mediator.Send(request);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpPost(ApiRoutes.Identity.RegisterPlanningManager)]
        public async Task<ActionResult<Register.CommandResponse>> RegisterPlanningManager([FromBody]Register.Command request)
        {
            request.Role = Register.Role.PlanningManager;

            var result = await _mediator.Send(request);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.Identity.Login)]
        public async Task<ActionResult<Login.CommandResponse>> Login([FromBody]Login.Command request)
        {
            var result = await _mediator.Send(request);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
    }
}
