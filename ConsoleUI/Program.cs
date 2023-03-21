//proje referansı olarak hepsini seç

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetCarsByColorId(1))
{
    Console.WriteLine(car.Description);
}
