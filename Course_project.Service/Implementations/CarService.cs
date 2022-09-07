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

        public async Task<IBaseResponse<bool>> AddCar(CarViewModel carViewModel)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {

                var car = new Car()
                {
                    Brand = carViewModel.Brand,
                    Model = carViewModel.Model,
                    Year = carViewModel.Year,
                    StartOperation = DateTime.Now,
                    Status = (StatusOfCar)Convert.ToInt32(carViewModel.Status),
                    LiftingCapacity = carViewModel.LiftingCapacity
                };

                await _carRepository.Add(car);
                baseResponse.Data = true;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[AddCar : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> RemoveCar(int id)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {
                var car = await _carRepository.Get(id);
                if(car == null)
                {
                    baseResponse.Description = "Data Car isn't found";
                    baseResponse.StatusCode = StatusCode.DataCarNotFound;
                    baseResponse.Data = false;
                    return baseResponse;
                }
                await _carRepository.Remove(car);
                baseResponse.StatusCode = StatusCode.OK;
                baseResponse.Data = true;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[RemoveCar : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<CarViewModel>> GetCar(int id)
        {
            var baseResponse = new BaseResponse<CarViewModel>();
            try
            {
                var car = await _carRepository.Get(id);
                if(car == null)
                {
                    baseResponse.Description = "Data Car isn't found";
                    baseResponse.StatusCode = StatusCode.DataCarNotFound;
                    return baseResponse;
                }
                var data = new CarViewModel()
                {
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year,
                    LiftingCapacity = car.LiftingCapacity,
                    Status = car.Status.ToString()
                };

                baseResponse.Data = data;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch(Exception ex)
            {
                return new BaseResponse<CarViewModel>()
                {
                    Description = $"[GetCar : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<Car>>> GetCars()
        {
            var baseResponse = new BaseResponse<IEnumerable<Car>>();
            try
            {
                var cars = await _carRepository.GetAll();
                if (cars.Count == 0)
                {
                    baseResponse.Description = "Найденно 0 элементов";
                    baseResponse.StatusCode = StatusCode.DataCarNotFound;
                }

                baseResponse.Data = cars;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Car>>()
                {
                    Description = $"[GetCars : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Car>> Update(int id, CarViewModel model)
        {
            var baseResponse = new BaseResponse<Car>();
            try
            {
                var car = await _carRepository.Get(id);
                if (car == null)
                {
                    baseResponse.StatusCode = StatusCode.DataCarNotFound;
                    baseResponse.Description = "Car not found";
                    return baseResponse;
                }
                car.Brand = model.Brand;
                car.Model = model.Model;
                car.Year = model.Year;
                car.LiftingCapacity = model.LiftingCapacity;
                car.Status = (StatusOfCar)Convert.ToInt32(model.Status);

                await _carRepository.Update(car);
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<Car>()
                {
                    Description = $"[Update : {ex.Message}]",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
