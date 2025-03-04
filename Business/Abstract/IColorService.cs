﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();

        IResult Add(Color colorToAdd);
        IResult Delete(Color colorToDelete);
        IResult Update(Color colorToUpdate);
    }
}
