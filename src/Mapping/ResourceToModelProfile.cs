using AutoMapper;
using dws_ex_1.src.Resources;
using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
            CreateMap<SaveEmployeeResource, Employee>();
        }
    }
}
