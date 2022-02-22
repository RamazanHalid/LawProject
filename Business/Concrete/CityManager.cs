﻿using Business.Abstract;
using Business.Constants; 
using Core.Utilities.Results; 
using DataAccess.Abstract;
using Entities.Concrete; 
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(Messages.AddedSuccessfuly);
        }
 
        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll() ,Messages.GetAllSuccessfuly);
        }
 
    }
}
