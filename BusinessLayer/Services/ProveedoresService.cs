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
    public class ProveedoresService
    {
        private ProveedorRepository _ProveedorRepository;

        public ProveedoresService()
        {
            _ProveedorRepository = new ProveedorRepository();
        }

        public DataTable GetProveedor()
        {
            return _ProveedorRepository.GetProveedor();
        }

        public void CreateSupplier(Proveedores proveedores)
        {
            _ProveedorRepository.CreateProveedor(proveedores);
        }

        public void UpdateProveedor(Proveedores proveedores)
        {
            _ProveedorRepository.UpdateProveedor(proveedores);
        }

        public void DeleteSupplier(int id)
        {
            _ProveedorRepository.DeleteProveedor(id);
        }
    }
}
