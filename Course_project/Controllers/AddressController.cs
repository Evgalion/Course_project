using Course_project.DAL.Interfaces;
using Course_project.Service.Implementations;
using Course_project.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Course_project.Domain.Models;

namespace Course_project.Controllers
{
    public class AddressController : Controller
    {
       
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
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
    }
}
