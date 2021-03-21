using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color colorToAdd)
        {
            _colorDal.Add(colorToAdd);
            return new SuccessResult();
        }

        public IResult Delete(Color colorToDelete)
        {
            _colorDal.Delete(colorToDelete);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.AllColorsListed);
        }

        public IResult Update(Color colorToUpdate)
        {
            _colorDal.Update(colorToUpdate);
            return new SuccessResult();
        }
    }
}
