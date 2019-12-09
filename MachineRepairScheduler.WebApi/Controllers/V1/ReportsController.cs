using MachineRepairScheduler.WebApi.Controllers.V1.Responses;
using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Features.V1.Reports;
using MachineRepairScheduler.WebApi.Pagination;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private IMediator _mediator;

        public ReportsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = Roles.PlanningManager + "," + Roles.Technician + "," + Roles.SysAdmin)]
        [HttpGet(ApiRoutes.Reports.GetAllReports)]
        public async Task<ActionResult<PagedResponse<GetAllReports.ReportDto>>> GetAllReports([FromQuery]GetAllReports.Filter filter, [FromQuery]PaginationQuery query)
        {
            var requsterId = User.Claims.Single(x => x.Type == "id").Value;
            var result = await _mediator.Send(new GetAllReports.Query { RequesterId = requsterId, Filter = filter, PaginationQuery = query });
            return Ok(result);
        }

        [Authorize(Roles = Roles.PlanningManager + "," + Roles.SysAdmin)]
        [HttpGet(ApiRoutes.Reports.GetReport)]
        public async Task<ActionResult<GetAllReports.ReportDto>> GetReport([FromRoute]string reportId)
        {
            var result = await _mediator.Send(new GetReport.Query { ReportId = reportId });
            if (result is null) return NotFound(reportId);
            return Ok(result);
        }

        [Authorize(Roles = Roles.Technician + "," + Roles.SysAdmin)]
        [HttpPost(ApiRoutes.Reports.SetFixed)]
        public async Task<ActionResult<GenericResponse>> SetReportAsFixed([FromRoute]string reportId)
        {
            var result = await _mediator.Send(new SetAsFixed.Command { MalfunctionReportId = reportId });
            return result.Success ? Ok(result) : BadRequest(result) as ActionResult;
        }

        [Authorize(Roles = Roles.PlanningManager + "," + Roles.SysAdmin)]
        [HttpPost(ApiRoutes.Reports.AssignTechniciansToReport)]
        public async Task<ActionResult<GenericResponse>> AssignTechniciansToReport([FromRoute]string reportId, [FromBody]AssignTechniciansToReport.Command command)
        {
            command.ReportId = reportId;
            var result = await _mediator.Send(command);
            return result.Success ? Ok(result) : BadRequest(result) as ActionResult;
        }

        [Authorize(Roles = Roles.Employee)]
        [HttpPost(ApiRoutes.Reports.CreateReport)]
        public async Task<ActionResult<GenericResponse>> CreateReport([FromBody]CreateReport.Command command)
        {
            command.EmployeeId = User.Claims.Single(x => x.Type == "id").Value;
            var result = await _mediator.Send(command);

            return result.Success ? Ok(result) : BadRequest(result) as ActionResult;
        }
    }
}
