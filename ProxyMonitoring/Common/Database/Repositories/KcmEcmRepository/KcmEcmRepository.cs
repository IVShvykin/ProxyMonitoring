using Common.Database.Dapper.KcmEcmDapper;
using Common.Database.Models.KcmEcmModel;

namespace Common.Database.Repositories.KcmEcmRepository
{
    public class KcmEcmRepository : IKcmEcmRepository
    {
        private readonly IKcmEcmDapper _kcmEcmDapper;

        public KcmEcmRepository(IKcmEcmDapper kcmEcmDapper)
        {
            _kcmEcmDapper = kcmEcmDapper;
        }
    }
}
