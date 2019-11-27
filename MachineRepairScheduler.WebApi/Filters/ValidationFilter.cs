using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRepairScheduler.WebApi.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errorsInModelState = context.ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value.Errors.Select(x => x.ErrorMessage))
                    .ToArray();

                var errorResponse = new ErrorResponse();

                foreach (var error in errorsInModelState)
                    foreach (var subError in error.Value)
                        errorResponse.Errors.Add($"{error.Key}: {subError}");

                context.Result = new BadRequestObjectResult(errorResponse);
                return;
            }

            await next();
        }

        public class ErrorResponse
        {
            public List<string> Errors { get; set; } = new List<string>();
            public bool Success = false;
        }
    }

}
