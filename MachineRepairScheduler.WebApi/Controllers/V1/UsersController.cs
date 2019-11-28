﻿using MachineRepairScheduler.WebApi.Domain.IdentityModels;
using MachineRepairScheduler.WebApi.Features.V1;
using MachineRepairScheduler.WebApi.Pagination;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Controllers.V1
{

    [Authorize(Roles = Roles.SysAdmin, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.Users.GetAllUsers)]
        public async Task<ActionResult<PagedResponse<GetAllUsers.UserDto>>> GetAllUsers([FromQuery]GetAllUsers.QueryFilter filter, [FromQuery]PaginationQuery paginationQuery)
        {
            var response = await _mediator.Send(new GetAllUsers.Query { QueryFilter = filter, PaginationQuery = paginationQuery });
            return Ok(response);
        }

        [HttpGet(ApiRoutes.Users.GetUser)]
        public async Task<ActionResult<GetUser.UserDto>> GetUser(string userId)
        {
            var result = await _mediator.Send(new GetUser.Query { UserId = userId });
            if (result is null) return NotFound(userId);
            return result;
        }
    }
}
