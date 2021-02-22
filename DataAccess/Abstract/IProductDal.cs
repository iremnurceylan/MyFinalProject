using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Code Refactoring -- Kodun İyileştirilmesi
   public interface IProductDal :IEntityRepository<Product>
    {
        List<ProductDetailDTO> GetProducutDetails();
    }
}
