using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vmMock = Common.Mock.VmMock.VmMock;

namespace ProxyMobileMonitoringAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class FailurePointsController : ControllerBase
    {
        [HttpGet]
        public async Task<string[]> Get()
        {
            return vmMock.failurePoints;
        }
    }
}
