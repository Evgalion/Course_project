using Course_project.Domain.Models;
using Course_project.Domain.Response;
using Course_project.Domain.ViewModels.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.Service.Interfaces
{
    public interface IAddressService
    {
        Task<IBaseResponse<IEnumerable<Address>>> GetAddresses();
        Task<IBaseResponse<Address>> GetAddress(int id);
        Task<IBaseResponse<Address>> GetAddressByName(string address);
        Task<IBaseResponse<AddressViewModel>> CreateAddress(AddressViewModel addressViewModel);
        Task<IBaseResponse<bool>> DeleteAddress(int id);



    }
}
