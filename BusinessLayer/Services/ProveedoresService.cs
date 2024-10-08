using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntitiLayer.Entities;

namespace BusinessLayer.Services
{
    internal class ProveedoresService
    {
        private SupplierRepository _supplierRepository;

        public ProveedoresService()
        {
            _supplierRepository = new SupplierRepository();
        }

        public DataTable GetSupplier()
        {
            return _supplierRepository.GetSupplier();
        }

        public void CreateSupplier(Proveedores proveedores)
        {
            _supplierRepository.CreateSupplier(proveedores);
        }

        public void UpdateSupplier(Proveedores proveedores)
        {
            _supplierRepository.UpdateSupplier(proveedores);
        }

        public void DeleteSupplier(int id)
        {
            _supplierRepository.DeleteSupplier(id);
        }
    }
}
