using AutoMapper;
using Traversal.Core.Concrete.Entities;
using Traversal.DTO.DTOs.AnnouncementDtos;
using Traversal.DTO.DTOs.AppUserDTOs;
using Traversal.DTO.DTOs.ContactDTOs;

namespace TraversalProject.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>();
            CreateMap<Announcement, AnnouncementAddDto>();

            CreateMap<AnnouncementListDto, Announcement>();
            CreateMap<Announcement, AnnouncementListDto>();

            CreateMap<AnnouncementUpdateDto, Announcement>();
            CreateMap<Announcement, AnnouncementUpdateDto>();

            CreateMap<ApppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, ApppUserRegisterDTOs>();


            CreateMap<AppUserLoginDtos, AppUser>();
            CreateMap<AppUser, AppUserLoginDtos>();


            CreateMap<SendMessageDto, ContactUs>().ReverseMap();

        }
    }
}
