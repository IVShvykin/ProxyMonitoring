using System.ComponentModel.DataAnnotations;

namespace Common.Dto.ViewModels.Request
{
    public class VmPageRequestBase
    {
        [Required]
        public int Limit { get; set; }
        [Required]
        public int Page { get; set; }
    }
}
