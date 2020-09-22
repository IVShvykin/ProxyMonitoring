using AutoMapper;

namespace Common.Helpers
{
    public static class MapperHelper
    {
        public static IMapper Mapper;
        public static TDestination Map<TSource, TDestination>(
            this TDestination destination, TSource source)
        {
            if (source != null)
            {
                return Mapper.Map(source, destination);
            }
            return destination;
        }
    }
}
