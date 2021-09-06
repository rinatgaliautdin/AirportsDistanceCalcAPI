using AirportTest.Models;
using AutoMapper;


namespace AirportTest.API.ViewModels.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Airport, AirportViewModel>();
        }
    }
}
