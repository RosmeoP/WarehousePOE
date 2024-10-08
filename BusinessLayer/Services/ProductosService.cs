using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiLayer.Entities;

namespace BusinessLayer.Services
{
    public class ProductosService
    {
        private ProductosRepository _productosRepository;

        public ProductosService()
        {
            _productosRepository = new ProductosRepository();
        }

        public DataTable GetProducts()
        {
            return _productosRepository.GetProducts();
        }

        public void AddProduct(Productos producto)
        {
            _productosRepository.AddProduct(producto);
        }

        public void UpdateProduct(Productos producto)
        {
            _productosRepository.UpdateProduct(producto);
        }

        public void DeleteProduct(int id)
        {
            _productosRepository.DeleteProduct(id);
        }
    }
}
