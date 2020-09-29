using Common.Dto.ViewModels.Request;
using Common.Dto.ViewModels.Response;
using Common.Mock.VmMock;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProxyMobileMonitoringAPI.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EventsController : ControllerBase
    {
        [HttpPost]
        public async Task<VmEventResponse[]> Get([FromBody] VmEventRequest vmEventRequest)
        {
            return VmMock.vmEventResponse;
        }
    }
}
