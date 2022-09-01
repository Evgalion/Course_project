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
using Course_project.Domain.ViewModels.Car;
using Course_project.Helper;
using Course_project.Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Course_project.Service.Implementations
{
    public class CarService : ICarService
    {
        public readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IBaseResponse<bool>> CreateCar(CarViewModel addressViewModel)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {
                
                var car = new Car()
                {
                    Brand = addressViewModel.Brand,
                    Model = addressViewModel.Model,
                    Year = addressViewModel.Year,
                    StartOperation = DateTime.Now,
                    Status =  addressViewModel.Status.GetAttribute<DisplayAttribute>().Name,
                    LiftingCapacity = addressViewModel.LiftingCapacity
            };

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[CreateCar : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IBaseResponse<Car>> GetCar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<IEnumerable<Car>>> GetCars()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<Car>> Update(int id, CarViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
