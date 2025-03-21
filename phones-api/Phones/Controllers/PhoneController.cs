﻿using Microsoft.AspNetCore.Mvc;
using phones_api.Phones.Dtos;
using phones_api.Phones.Models;
using phones_api.Phones.Repository;

namespace phones_api.Phones.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PhoneController : ControllerBase
    {
        private IPhoneRepo _phoneRepo;

        public PhoneController(IPhoneRepo phoneRepo)
        {
            _phoneRepo = phoneRepo;
        }

        [HttpGet("/allphones")]

        public async Task<ActionResult<List<Phone>>> GetPhonesAsync()
        {
            var phone = await _phoneRepo.GetPhonesAsync();

            return Ok(phone);
        }

        [HttpPost("addPhone")]

        public async Task<ActionResult<PhoneResponse>> CreateAsync([FromBody] PhoneRequest phoneReq)
        {
            PhoneResponse phoneSaved = await _phoneRepo.CreatePhoneAsync(phoneReq);

            return Ok(phoneSaved);
        }
    }
}
