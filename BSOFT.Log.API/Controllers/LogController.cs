using BSOFT.Log.API.Helper;
using BSOFT.Log.API.ViewObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace BSOFT.Log.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {

        private readonly ILogger _logger;
        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        public IActionResult Post([FromBody] LogRequest request)
        {
            if (request.IsError)
            {
                _logger.LogError(request.Message);
                Sentry.Write(new Exception(request.Message));
            }
            else
            {
                _logger.LogInformation(request.Message);
            }
            LogResponse response = new LogResponse()
            {
                Message = "Register log",
                Success = true
            };
            return Ok(response);
        }
    }
}