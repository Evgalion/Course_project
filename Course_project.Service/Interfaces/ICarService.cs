using Course_project.Domain.Models;
using Course_project.Domain.Response;
using Course_project.Domain.ViewModels.Address;
using Course_project.Domain.ViewModels.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_project.Service.Interfaces
{
    public interface ICarService
    {
        Task<IBaseResponse<IEnumerable<Car>>> GetCars();
        Task<IBaseResponse<CarViewModel>> GetCar(int id);
        Task<IBaseResponse<bool>> AddCar(CarViewModel addressViewModel);
        Task<IBaseResponse<bool>> RemoveCar(int id);
        Task<IBaseResponse<Car>> Update(int id, CarViewModel model);
    }
}
