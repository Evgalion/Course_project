using Course_project.Domain.Models;
using Course_project.Domain.Response;
using Course_project.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course_project.DAL.Interfaces; 
using Course_project.Domain.Enum;
using Course_project.Domain.ViewModels.Address;

namespace Course_project.Service.Implementations
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }


        // TODO: Может переделать для AddressViewModel

        //TODO: 29.08 1-11 Сделать Update
        public async Task<IBaseResponse<Address>> Update(int id, AddressViewModel model)
        {
            var baseResponse = new BaseResponse<Address>();
            try
            {
               var address = await _addressRepository.Get(id);
               if(address == null)
                {
                    baseResponse.StatusCode = StatusCode.DataAddressNotFound;
                    baseResponse.Description = "Address not found";
                    return baseResponse;
                }
                address.MainDestination = model.MainDestination;
                address.AccurateDestination = model.AccurateDestination;
                address.NextId = model.NextId;

                await _addressRepository.Update(address);

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<Address>()
                {
                    Description = $"[Update : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> CreateAddress(AddressViewModel addressViewModel)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {
                var addr = new Address()
                {
                    MainDestination = addressViewModel.MainDestination,
                    AccurateDestination = addressViewModel.AccurateDestination,
                    NextId = addressViewModel.NextId
                };

                await _addressRepository.Create(addr);
                baseResponse.Data = true;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[CreateAddress : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
           
        }
        public async Task<IBaseResponse<bool>> DeleteAddress(int id)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {
                var address = await _addressRepository.Get(id);
                if (address == null)
                {
                    baseResponse.Description = "Data Address isn't found";
                    baseResponse.StatusCode = StatusCode.DataAddressNotFound;
                    baseResponse.Data = false;
                    return baseResponse;
                }
                await _addressRepository.Delete(address);
                baseResponse.Data = true;
                return baseResponse;
            }
            catch(Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteAddress : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Address>> GetAddressByName(string address)
        {
            var baseResponse = new BaseResponse<Address>();
            try
            {
                var addrs = await _addressRepository.GetByName(address);
                if (addrs == null)
                {
                    baseResponse.Description = "Data Address isn't found";
                    baseResponse.StatusCode = StatusCode.DataAddressNotFound;
                    return baseResponse;
                }
                baseResponse.Data = addrs;
                return baseResponse;

            }
            catch (Exception ex)
            {
                return new BaseResponse<Address>()
                {
                    Description = $"[GetAddressByName : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Address>> GetAddress(int id)
        {
            var baseResponse = new BaseResponse<Address>();
            try
            {
                var address = await _addressRepository.Get(id);
                if (address == null)
                {
                    baseResponse.Description = "Data Address isn't found";
                    baseResponse.StatusCode = StatusCode.DataAddressNotFound;
                    return baseResponse;
                }
                baseResponse.Data = address;
                return baseResponse;

            }
            catch (Exception ex)
            {
                return new BaseResponse<Address>()
                {
                    Description = $"[GetAddress : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<Address>>> GetAddresses()
        {
            var baseResponse = new BaseResponse<IEnumerable<Address>>();
            try
            {
                var addresses = await _addressRepository.Select();
                if(addresses.Count == 0)
                {
                    baseResponse.Description = "Найденно 0 элементов";
                    baseResponse.StatusCode = StatusCode.OK;
                }

                baseResponse.Data = addresses;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Address>>()
                {
                    Description = $"[GetAddresses : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

       
    }
}
