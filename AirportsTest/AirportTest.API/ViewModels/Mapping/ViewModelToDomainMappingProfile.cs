using AirportTest.Models;
using AutoMapper;

namespace AirportTest.API.ViewModels.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AirportViewModel, Airport>();
        }
    }
}
