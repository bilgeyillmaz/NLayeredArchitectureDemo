using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Business code burada yazılır. Bu kişi bu datayı çekmeye çalışıyor ama bu datayı çekebilir mi?
        //Çektiği data gerçekten onun görebileceği bir data mı? Birimi uygun mu ? gibi kurallar
        //Örneğin; bir bankacılık uygulamasında, bir kredi datasını görebileceği zaman mevzuata uygunluk vs gibi kodlar yazılabilir.
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        { //kurumsal bir mimaride entity framework olmaz, bu doğru bir yapı değil
            try
            {
                _productDal.Delete(product);
            }
            catch
            {

                throw new Exception("Data didn't deleted! ");
            }

        }

        public List<Product> GetAll()
        {

            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);

        }
    }
}
