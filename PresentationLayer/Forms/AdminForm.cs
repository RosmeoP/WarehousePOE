﻿using DataAccessLayer;
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int grosorBorde = 4;
            Color colorBorde = Color.Gray;

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
            colorBorde, grosorBorde, ButtonBorderStyle.Solid,
            colorBorde, grosorBorde, ButtonBorderStyle.Solid,
            colorBorde, grosorBorde, ButtonBorderStyle.Solid,
            colorBorde, grosorBorde, ButtonBorderStyle.Solid
            );
        }
        private ProveedorRepository _supplierRepo;
        bool isEditing = false;
        public AdminForm()
        {
            InitializeComponent();
            _supplierRepo = new ProveedorRepository();

            LoadSuppliers();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujar un borde de color alrededor del formulario
            int grosorBorde = 3; // Grosor del borde
            Color colorBorde = Color.Gray; // Color del borde

            // Dibujar un rectángulo alrededor del borde del formulario
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle,
                colorBorde, grosorBorde, ButtonBorderStyle.Solid, // Borde superior
                colorBorde, grosorBorde, ButtonBorderStyle.Solid, // Borde izquierdo
                colorBorde, grosorBorde, ButtonBorderStyle.Solid, // Borde inferior
                colorBorde, grosorBorde, ButtonBorderStyle.Solid  // Borde derecho
            );
        }
        private void LoadSuppliers()
        {
            DataTable suppliersTable = _supplierRepo.GetProveedor();
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

                _supplierRepo.UpdateProveedor(newSupplier);
                isEditing = false;
                LoadSuppliers();
                MessageBox.Show("Proveedor actualizado correctamente", "Proveedor actualizado");
            }
            else
            {
                try
                {
                    var newProveedor = new Proveedores
                    {
                        Nombre = nombreProveedorTextBox.Text,
                        Direccion = direccionTextBox.Text,
                        Telefono = telefonoTextBox.Text
                    };

                    _supplierRepo.CreateProveedor(newProveedor);
                    isEditing = false;
                    LoadSuppliers();
                    MessageBox.Show("Proveedor guardado correctamente", "Proveedor guardado");
                }
                catch
                {
                    MessageBox.Show("Solo se admiten alores valido", "Error");
                    return;
                }
                
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
            int id = int.Parse(ProveedorDataGridView.CurrentRow.Cells[0].Value.ToString());

            try
            {
                _supplierRepo.DeleteProveedor(id);
                MessageBox.Show("Proveedor eliminado correctamente", "Proveedor eliminado");
            }
            catch
            {
                MessageBox.Show("Este proveedor ya tiene productos distribuidos, no puede ser eliminido", "Error");
            }
            LoadSuppliers();
        }

        private void exitAdminButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
