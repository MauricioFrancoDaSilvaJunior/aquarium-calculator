using aquarium_calculator.Model;
using AutoMapper;

namespace aquarium_calculator.Data
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<CalculoLitragemResponseModel,CalculoLitragemRequestModel>().ReverseMap();
            CreateMap<CalculoLitragemResponseModel,long>().ReverseMap();
        }
    }
}