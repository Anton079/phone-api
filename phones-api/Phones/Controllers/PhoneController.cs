using Microsoft.AspNetCore.Mvc;
using phones_api.Phones.Models;
using phones_api.Phones.Repository;

namespace phones_api.Phones.Controllers
{
    [ApiController]
    [Route("api/v1/[controller")]
    public class PhoneController : ControllerBase
    {
        private IPhoneRepo _phoneRepo;

        public PhoneRepo(IPhoneRepo phoneRepo)
        {
            _phoneRepo = phoneRepo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Phone>>> GetPhonesAsync()
        {
            var phone = await _phoneRepo.GetPhonesAsync();

            return Ok(phone);
        }
    }
}
