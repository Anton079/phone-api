using AutoMapper;
using Microsoft.EntityFrameworkCore;
using phones_api.Data.Migrations;
using phones_api.Phones.Dtos;
using phones_api.Phones.Models;

namespace phones_api.Phones.Repository
{
    public class PhoneRepo : IPhoneRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public PhoneRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<Phone>> GetPhonesAsync()
        {
            return await _appDbContext.Phones.ToListAsync();
        }

        public async Task<PhoneResponse> CreatePhoneAsync(PhoneRequest phoneReq)
        {
            Phone phone = _mapper.Map<Phone>(phoneReq);

            _appDbContext.Phones.Add(phone);

            await _appDbContext.SaveChangesAsync();

            PhoneResponse response = _mapper.Map<PhoneResponse>(phone);

            return response;
        }
    }
}
