using System.Threading.Tasks;
using HotelListing.Shared.Models;

namespace HotelListing.Server.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
    }
}