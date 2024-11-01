using AutoMapper;
using Entities.Dtos.ApartmentDtos;
using Entities.Dtos.AuthenticationDtos;
using Entities.Dtos.HouseDtos;
using Entities.Dtos.MembeshipDtos;
using Entities.Dtos.SiteDtos;
using Entities.Models;

namespace SiteManagementSystem.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDtoForRegistration, AppUser>();

            CreateMap<Site, ResultSiteDto>().ReverseMap();
            CreateMap<Site, CreateSiteDto>().ReverseMap();
            CreateMap<Site, UpdateSiteDto>().ReverseMap();
            CreateMap<Site, GetByIdSiteDto>().ReverseMap();

            CreateMap<Apartment, ResultApartmentDto>().ReverseMap();
            CreateMap<Apartment, CreateApartmentDto>().ReverseMap();
            CreateMap<Apartment, UpdateApartmentDto>().ReverseMap();
            CreateMap<Apartment, GetByIdApartmentDto>().ReverseMap();

            CreateMap<House, ResultHouseDto>().ReverseMap();
            CreateMap<House, CreateHouseDto>().ReverseMap();
            CreateMap<House, UpdateHouseDto>().ReverseMap();
            CreateMap<House, GetByIdHouseDto>().ReverseMap();

            CreateMap<Membership, ResultMembershipDto>().ReverseMap();
            CreateMap<Membership, CreateMembershipDto>().ReverseMap();
            CreateMap<Membership, UpdateMembershipDto>().ReverseMap();
            CreateMap<Membership, GetByIdMembershipDto>().ReverseMap();

        }
    }
}
