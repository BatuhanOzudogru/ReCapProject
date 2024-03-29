﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;    
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice >= 0)
            {
                _carDal.Add(car);
            }
            else
                Console.WriteLine("Araç Açıklaması 2 Harften fazla olmalı ve Günlük Kiralama Tutarı 0 Tl olamaz");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
    }
}
