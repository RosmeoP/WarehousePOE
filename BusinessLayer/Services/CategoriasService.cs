using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiLayer.Entities;

namespace BusinessLayer.Services
{
    public class CategoriasService
        {
        private CategoryRepository _categoryRepository;

        public CategoriasService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public DataTable GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public void CreateCategory(Categorias categorias)
        {
            _categoryRepository.CreateCategory(categorias);
        }

        public void UpdateCategory(Categorias categorias)
        {
            _categoryRepository.UpdateCategory(categorias);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }
    }
}
