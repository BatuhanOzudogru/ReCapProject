﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //dataA ve entities proje referansı ver
    public interface ICarService
    {
        void Add(Car car);
        List<Car> GetAll();
        
        List<Car> GetCarsByColorId(int id);

        List<Car> GetCarsByBrandId(int id);
    }
}
