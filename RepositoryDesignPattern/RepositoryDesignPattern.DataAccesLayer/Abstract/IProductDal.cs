﻿using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccesLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {

    }
}
