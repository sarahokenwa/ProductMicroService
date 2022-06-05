using Microsoft.EntityFrameworkCore;
using ProductMicroService.DBContexts;
using ProductMicroService.Model;

namespace ProductMicroService.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsContext _dbContext;

        public ProductRepository(ProductsContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int ProductId)
        {
            var Product = _dbContext.Products.Find(ProductId);
            //var product = _dbContext.Products.Find(ProductId);
#pragma warning disable CS8604 // Possible null reference argument.
            //  _ = _dbContext.Products.Remove(entity: product);
            _ = _dbContext.Products.Remove(entity: Product);
#pragma warning restore CS8604 // Possible null reference argument.
            Save();
        }

        public Product GetProductByID(int ProductId)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _dbContext.Products.Find(ProductId);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product Product)
        {
            _dbContext.Add(Product);
            Save();
        }

        public void Save()
        {
            
           _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product Product)
        {
            _dbContext.Entry(Product).State = EntityState.Modified;
            Save();
        }
       /* public void DeleteProduct(int ProductId)
        {
            throw new NotImplementedException();
        }

        public Product GetByProductByID(int ProductId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product Product)
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product Product)
        {
            throw new NotImplementedException();
        }*/



    }
}

       
    
