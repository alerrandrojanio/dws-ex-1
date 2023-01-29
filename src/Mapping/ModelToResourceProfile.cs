using AutoMapper;
using dws_ex_1.src.Domain.Models;
using dws_ex_1.src.Resources;

namespace dws_ex_1.src.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<Employee, EmployeeResource>();
        }
    }
}
