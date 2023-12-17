using RepositoryDesignPattern.DataAccesLayer.Abstract;
using RepositoryDesignPattern.DataAccesLayer.Concrete;
using RepositoryDesignPattern.DataAccesLayer.Repositories;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccesLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context):base(context)
        {

        }
    }
}
