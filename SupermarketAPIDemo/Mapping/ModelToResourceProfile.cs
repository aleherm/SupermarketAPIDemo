using AutoMapper;
using SupermarketAPIDemo.Domain.Models;
using SupermarketAPIDemo.Resources;

namespace SupermarketAPIDemo.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
