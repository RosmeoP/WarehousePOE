using DataAccessLayer;
using EntitiLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class AdminForm : Form
    {
        private SupplierRepository _supplierRepo;
        public AdminForm()
        {
            InitializeComponent();
            _supplierRepo = new SupplierRepository();

            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            DataTable suppliersTable = _supplierRepo.GetSupplier();
            ProveedorDataGridView.DataSource = suppliersTable;
        }

        private void guardarProveedorIconButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreProveedorTextBox.Text) || string.IsNullOrEmpty(direccionTextBox.Text) || string.IsNullOrEmpty(telefonoTextBox.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var proveedores = new Proveedores
            {
                Nombre = nombreProveedorTextBox.Text,
                Direccion = direccionTextBox.Text,
                Telefono = telefonoTextBox.Text
            };

            var newSupplier = new Proveedores
            {
                Nombre = nombreProveedorTextBox.Text,
                Direccion = direccionTextBox.Text,
                Telefono = telefonoTextBox.Text
            };

            _supplierRepo.CreateSupplier(newSupplier);
            LoadSuppliers();
            MessageBox.Show("Proveedor guardado correctamente", "Proveedor guardado");

        }

        private void editarProveedorIconButton_Click(object sender, EventArgs e)
        {
            if (ProveedorDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = ProveedorDataGridView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            var proveedores = new Proveedores
            {
                Id = id,
                Nombre = nombreProveedorTextBox.Text,
                Direccion = direccionTextBox.Text,
                Telefono = telefonoTextBox.Text
            };
            _supplierRepo.UpdateSupplier(proveedores);
            LoadSuppliers();
            MessageBox.Show("Proveedor actualizado correctamente", "Proveedor actualizado");
        }

        private void deleteProveedorIconButton_Click(object sender, EventArgs e)
        {
            if (ProveedorDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = ProveedorDataGridView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            _supplierRepo.DeleteSupplier(id);
            LoadSuppliers();
            MessageBox.Show("Proveedor eliminado correctamente", "Proveedor eliminado");
        }

        private void exitAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();

            AdministrarForm administrarForm = new AdministrarForm();
            administrarForm.ShowDialog();
        }
    }
}
