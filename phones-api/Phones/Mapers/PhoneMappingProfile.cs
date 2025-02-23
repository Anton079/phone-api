using AutoMapper;
using phones_api.Phones.Dtos;
using phones_api.Phones.Models;

namespace phones_api.Phones.Mapers
{
    public class PhoneMappingProfile:Profile
    {
        public PhoneMappingProfile()
        {
            CreateMap<PhoneRequest, Phone>();
            CreateMap<Phone, PhoneResponse>();
        }
    }
}
