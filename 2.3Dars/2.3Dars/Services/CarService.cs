using _2._3Dars.Models;

namespace _2._3Dars.Services;

public class CarService
{
    List<Car> Cars;
    public CarService()
    {
        Cars = new List<Car>();
    }

    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        Cars.Add(car);
        return car.CarId;
    }

    public Car? GetCarById(Guid carId)
    {
        foreach(var car in Cars)
        {
            if(car.CarId == carId)
            {
                return car;
            }
        }

        return null;
    }

    public bool DeleteCar(Guid carId)
    {
        foreach(var car in Cars)
        {
            if(car.CarId == carId)
            {
                Cars.Remove(car);
                return true;
            }
        }

        return false;
    }

    //public bool DeleteCar(Guid carId)
    //{
    //    var car = GetCarById(carId);

    //    if (car == null)
    //    {
    //        return false;
    //    }

    //    Cars.Remove(car);
    //    return true;
    //}

    public List<Car> GetAllCars()
    {
        return Cars;
    }

    public bool UpdateCar(Guid carId, Car newCar)
    {
        for (var i = 0; i < Cars.Count; i++)
        {
            if (Cars[i].CarId == carId)
            {
                Cars[i].Model = newCar.Model;
                Cars[i].Brand = newCar.Brand;
                Cars[i].Price = newCar.Price;
                Cars[i].Color = newCar.Color;
                return true;
            }
        }

        return false;
    }

    //public bool UpdateCar(Guid carId, Car newCar)
    //{
    //    var car = GetCarById(carId);
    //    if (car == null)
    //    {
    //        return false;
    //    }

    //    car.Model = newCar.Model;
    //    car.Brand = newCar.Brand;
    //    car.Price = newCar.Price;
    //    car.Color = newCar.Color;

    //    return true;
    //}
}
