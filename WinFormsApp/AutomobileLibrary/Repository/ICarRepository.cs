using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCar();
        Car GetCarById(int carId);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int carId);
    }
}
