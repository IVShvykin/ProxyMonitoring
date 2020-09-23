using Common.Dto.ViewModels.SubModels;

namespace Common.Dto.ViewModels.Response
{
    public class VmAccedentWorkersResponse
    {
        public VmManager Manager { get; set; }
        public VmWorker[] Workers { get; set; }
    }
}
