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
        bool isEditing = false;
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

            if (isEditing)
            {
                var newSupplier = new Proveedores
                {
                    Id = Convert.ToInt32(productIdLabel.Text),
                    Nombre = nombreProveedorTextBox.Text,
                    Direccion = direccionTextBox.Text,
                    Telefono = telefonoTextBox.Text
                };

                _supplierRepo.UpdateSupplier(newSupplier);
                isEditing = false;
                LoadSuppliers();
                MessageBox.Show("Proveedor actualizado correctamente", "Proveedor actualizado");
            }
            else
            {
                var newSupplier = new Proveedores
                {
                    Nombre = nombreProveedorTextBox.Text,
                    Direccion = direccionTextBox.Text,
                    Telefono = telefonoTextBox.Text
                };

                _supplierRepo.CreateSupplier(newSupplier);
                isEditing = false;
                LoadSuppliers();
                MessageBox.Show("Proveedor guardado correctamente", "Proveedor guardado");
            }
            CleanForm();
        }

        private void editarProveedorIconButton_Click(object sender, EventArgs e)
        {
            if (ProveedorDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isEditing = true;
            int id = int.Parse(ProveedorDataGridView.CurrentRow.Cells[0].Value.ToString());
            string nombreProveedor = ProveedorDataGridView.CurrentRow.Cells[1].Value.ToString();
            string direccion= ProveedorDataGridView.CurrentRow.Cells[2].Value.ToString();
            string telefono = ProveedorDataGridView.CurrentRow.Cells[3].Value.ToString();

            IdLabel.Text = "ID:";
            productIdLabel.Text = id.ToString();
            nombreProveedorTextBox.Text = nombreProveedor;
            direccionTextBox.Text = direccion;
            telefonoTextBox.Text = telefono;
        }
        private void CleanForm()
        {
            IdLabel.Text = "";
            productIdLabel.Text = "";
            nombreProveedorTextBox.Text = "";
            direccionTextBox.Text = "";
            telefonoTextBox.Text = "";
        }

        private void deleteProveedorIconButton_Click(object sender, EventArgs e)
        {

            if (ProveedorDataGridView.SelectedRows.Count == 0)
            if (ProveedorDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //DataGridViewRow selectedRow = ProveedorDataGridView.SelectedRows[0];
            int id = int.Parse(ProveedorDataGridView.CurrentRow.Cells[0].Value.ToString());

            try
            {
                _supplierRepo.DeleteSupplier(id);
                MessageBox.Show("Proveedor eliminado correctamente", "Proveedor eliminado");
            }
            catch
            {
                MessageBox.Show("Este proveedor ya tiene productos distribuidos, no puede ser eliminido", "Error");
            }
            LoadSuppliers();
            //MessageBox.Show($"{id}", "Proveedor eliminado");
        }

        private void exitAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
