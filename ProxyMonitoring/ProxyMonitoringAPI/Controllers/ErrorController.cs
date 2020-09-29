using Common.Dto.ViewModels.Response;
using Common.Helpers.DateTimeBinder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace Cross.Core.WebRequest
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        private IWebHostEnvironment _hostingEnvironment;

        public ErrorController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [Route("system/error")]
        public VmErrorResponse Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            HttpContext.Response.StatusCode = 501;

            var exception = context?.Error;

            if (!(exception is DateFormatException))
                throw exception;

            var webRequestException = (DateFormatException)exception;

            string message;
            if (_hostingEnvironment.IsDevelopment()|| _hostingEnvironment.EnvironmentName == "test")
            {
                message = $"Message =\n{exception.Message}\nStackTrace =\n{exception.StackTrace}";
            }
            else
            {
                message = exception.Message;
            }
            var result = new VmErrorResponse()
            {
                ErrorMessage = webRequestException.Message,
                RequestCode = HttpContext.TraceIdentifier
            };
            return result;
        }
    }
}
