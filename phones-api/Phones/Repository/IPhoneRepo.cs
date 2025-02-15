using phones_api.Phones.Models;

namespace phones_api.Phones.Repository
{
    public interface IPhoneRepo
    {
        Task<List<Phone>> GetPhonesAsync();
    }
}
