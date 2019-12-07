using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Features.V1.Machines;
using MachineRepairScheduler.WebApi.Pagination;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Controllers.V1
{
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MachinesController : ControllerBase
    {
        private IMediator _mediator;

        public MachinesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.Machine.GetAllMachines)]
        public async Task<ActionResult<PagedResponse<GetAllMachines.MachineDto>>> GetAllMachines([FromQuery]GetAllMachines.Filter filter, [FromQuery]PaginationQuery paginationQuery)
        {
            var result = await _mediator.Send(new GetAllMachines.Query { Filter = filter, PaginationQuery = paginationQuery });
            return Ok(result);
        }

        [HttpGet(ApiRoutes.Machine.GetMachine)]
        public async Task<ActionResult<GetMachine.Query>> GetMachine([FromRoute]string machineId)
        {
            var result = await _mediator.Send(new GetMachine.Query { MachineId = machineId });
            return result is null ? NotFound() : Ok(result) as ActionResult;
        }

        [Authorize(Roles = Roles.SysAdmin)]
        [HttpPost(ApiRoutes.Machine.CreateMachine)]
        public async Task<ActionResult<CreateMachine.CommandResponse>> CreateMachine([FromBody]CreateMachine.Command request)
        {
            var result = await _mediator.Send(request);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [Authorize(Roles = Roles.SysAdmin)]
        [HttpPut(ApiRoutes.Machine.EditMachine)]
        public async Task<ActionResult<EditMachine.CommandResponse>> EditMachine([FromRoute]string machineId, [FromBody]EditMachine.Command command)
        {
            command.MachineId = machineId;
            var result = await _mediator.Send(command);
            return result.Success ? Ok(result) : BadRequest(result) as ActionResult;
        }

        [Authorize(Roles = Roles.SysAdmin)]
        [HttpDelete(ApiRoutes.Machine.DeleteMachine)]
        public async Task<ActionResult> DeleteMachine([FromRoute]string machineId)
        {
            return await _mediator.Send(new DeleteMachine.Command { MachineId = machineId })
                ? Ok()
                : BadRequest("Machine not found or was already deleted") as ActionResult;
        }
    }
}
