﻿using Entities.LogModel;
using Microsoft.AspNetCore.Mvc.Filters;
using Services.Contracts;

namespace SiteManagementSystem.ActionFilters
{
    public class LoggerFilterAttribute : ActionFilterAttribute
    {
        private readonly ILoggerService _logger;

        public LoggerFilterAttribute(ILoggerService loggerService)
        {
            _logger = loggerService;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInfo(Log("OnActionExecuting", context.RouteData));
        }

        private string Log(string modelName, RouteData routeData)
        {
            var logDetails = new LogDetails
            {
                ModelName = modelName,
                Controller = routeData.Values["controller"],
                Action = routeData.Values["action"],
            };

            if (routeData.Values.Count >= 3)
            {
                logDetails.Id = routeData.Values["Id"];
            }
            return logDetails.ToString();
        }
    }
}
