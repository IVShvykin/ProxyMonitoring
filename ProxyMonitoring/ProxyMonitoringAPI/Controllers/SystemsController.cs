using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Common.Dto.ViewModels.Response;
using Common.Dto.ViewModels.Request;
using vmMock = Common.Mock.VmMock.VmMock;

namespace ProxyMobileMonitoringAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class SystemsController : ControllerBase
    {
        public async Task<VmSystemResponse[]> Get([FromQuery] VmSystemsRequest vmSystemsRequest)
        {
            return vmMock.vmSystemResponse;
        }

        [HttpGet("affected")]
        public async Task<string[]> GetAffectedSystem()
        {
            return vmMock.affectedSystems;
        }
    }
}
