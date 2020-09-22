using Common.Dto.BlModels;

namespace Common.Dto.ViewModels
{
    public class VmAccedentWorkersResponseModel
    {
        public BLWorker Manager { get; set; }
        public BLWorker[] Workers { get; set; }
    }
}
