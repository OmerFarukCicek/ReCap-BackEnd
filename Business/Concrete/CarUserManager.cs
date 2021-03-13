using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarUserManager : ICarUserService
    {
        ICarUserDal _carUserDal;
        public CarUserManager(ICarUserDal userDal)
        {
            _carUserDal = userDal;
        }
        public IResult Add(CarUser user)
        {
            _carUserDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(CarUser user)
        {
            _carUserDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<CarUser>> GetAll()
        {
            return new SuccessDataResult<List<CarUser>>(_carUserDal.GetAll());
        }

        public IResult Update(CarUser user)
        {
            _carUserDal.Update(user);
            return new SuccessResult();
        }
    }
}
