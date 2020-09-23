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
    public class MetricsController : ControllerBase
    {
        [HttpGet]
        public async Task<VmMetricsResponse[]> Get([FromRoute] VmMetricInfoRequest vmMetricsRequest)
        {
            return vmMock.vmMetricsResponse;
        }
    }
}
