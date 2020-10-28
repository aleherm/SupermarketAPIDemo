using AutoMapper;
using SupermarketAPIDemo.Domain.Models;
using SupermarketAPIDemo.Resources;

namespace SupermarketAPIDemo.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
