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
        Task<IBaseResponse<AddressViewModel>> GetAddress(int id);
        Task<IBaseResponse<bool>> AddAddress(AddressViewModel addressViewModel);
        Task<IBaseResponse<bool>> RemoveAddress(int id);
        Task<IBaseResponse<Address>> Update(int id, AddressViewModel model);
    }
}
