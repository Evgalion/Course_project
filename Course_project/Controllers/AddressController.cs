using Course_project.DAL.Interfaces;
using Course_project.Service.Implementations;
using Course_project.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Course_project.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Course_project.Domain.ViewModels.Address;
using System;

namespace Course_project.Controllers
{
    public class AddressController : Controller
    {
       
        private readonly IAddressService _addressService;


        public AddressController(IAddressService addressService)
        {
            _addressService = addressService ?? throw new ArgumentNullException(nameof(addressService)); 
        }


        [HttpGet]
        public async Task<IActionResult> GetAddresses()
        {
           var response = await _addressService.GetAddresses();
           if(response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error");
        }

        [HttpGet]
        public async Task<IActionResult> GetAddress(int id)
        {
            var response = await _addressService.GetAddress(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error");
        }

        //Админ как пример. Чтобы обычные люди не могли удалять данные из бд
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _addressService.RemoveAddress(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetAddresses");
            }
            return RedirectToAction("Error");
        }

        //тип update
        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Save(int id)
        {
            if (id == 0)
                return View();

            var response = await _addressService.GetAddress(id);
            if(response.StatusCode == Domain.Enum.StatusCode.OK)
                return View(response.Data);

            return RedirectToAction("Error");
        }
        [HttpPost]
        public async Task<IActionResult> Save(AddressViewModel model)
        {
          if(ModelState.IsValid)
            {
                if(model.Id == 0 )
                {
                    await _addressService.AddAddress(model);
                }
                else
                {
                    await _addressService.Update(model.Id, model);
                }
            }
            return RedirectToAction("GetAddresses");
        }
    }
}
