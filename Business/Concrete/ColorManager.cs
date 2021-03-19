using Business.Abstract;
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
        public void Add(Color colorToAdd)
        {
            _colorDal.Add(colorToAdd);
        }

        public void Delete(Color colorToDelete)
        {
            _colorDal.Delete(colorToDelete);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public void Update(Color colorToUpdate)
        {
            _colorDal.Update(colorToUpdate);
        }
    }
}
