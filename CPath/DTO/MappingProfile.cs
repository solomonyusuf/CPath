using AutoMapper;
using CPath.DTO.Resources;
using CPath.Models;

namespace CPath.DTO
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // domain to api
            CreateMap<Contact, ContactDTO>();
            CreateMap<New, NewDTO>();
            CreateMap<Staff, StaffDTO>();
            CreateMap<Result, ResultDTO>();
            CreateMap<ParentInfo, ParentInfoDTO>();
            CreateMap<Student, StudentDTO>();
            CreateMap<Subject, SubjectDTO>();

            // api to domain
            CreateMap< ResultDTO, Result>();
            CreateMap<StudentDTO, Student>();
              /*  .ForMember(s => s.ParentInfo.ParentName, opt => opt.MapFrom(sd => sd.ParentInfo.ParentName))
                .ForMember(s => s.ParentInfo.Email, opt => opt.MapFrom(sd => sd.ParentInfo.Email))
                .ForMember(s => s.ParentInfo.Occupation, opt => opt.MapFrom(sd => sd.ParentInfo.Occupation))
                .ForMember(s => s.ParentInfo.City, opt => opt.MapFrom(sd => sd.ParentInfo.City))
                .ForMember(s => s.ParentInfo.PhoneNumber_1, opt => opt.MapFrom(sd => sd.ParentInfo.PhoneNumber_1))
                .ForMember(s => s.ParentInfo.PhoneNumber_2, opt => opt.MapFrom(sd => sd.ParentInfo.PhoneNumber_2))
                .ForMember(s => s.ParentInfo.Address_1, opt => opt.MapFrom(sd => sd.ParentInfo.Address_1))
                .ForMember(s => s.ParentInfo.Address_2, opt => opt.MapFrom(sd => sd.ParentInfo.Address_2));
              */

        }
    }
}
