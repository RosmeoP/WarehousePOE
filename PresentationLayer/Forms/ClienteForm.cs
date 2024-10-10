using BusinessLayer.Services;
using EntitiLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace PresentationLayer.Forms
{
    public partial class ClienteForm : Form
    {
        private ProductosService _productoService;
        private ProveedoresService _proveedorService;
        private CategoriasService _categoriasService;

        bool isEditing = false;

        public ClienteForm()
        {

            InitializeComponent();
            _productoService = new ProductosService();
            _proveedorService = new ProveedoresService();
            _categoriasService = new CategoriasService();

            LoadProductos();
            LoadProveedores();
            LoadCategorias();

        }

        private void LoadProveedores()
        {
            DataTable proveedores = _proveedorService.GetSupplier();
            proveedorComboBox.DataSource = proveedores;
            proveedorComboBox.DisplayMember = "Nombre";
            proveedorComboBox.ValueMember = "Id";
            proveedorComboBox.SelectedIndex = -1; // Ninguna selección inicial
        }
        private void LoadCategorias()
        {
            DataTable categorias = _categoriasService.GetCategories();
            categoriaComboBox.DataSource = categorias;
            categoriaComboBox.DisplayMember = "Nombre";
            categoriaComboBox.ValueMember = "Id";
            categoriaComboBox.SelectedValue = -1; // Ninguna selección inicial
        }



        private void LoadProductos()
        {
            DataTable productos = _productoService.GetProducts();
            ClientesDataGridView.DataSource = productos;
        }

        private void guardarClientesIconButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreProductoTextBox.Text) ||
                string.IsNullOrEmpty(precioTextBox.Text) ||
                string.IsNullOrEmpty(stockTextBox.Text) ||
                categoriaComboBox.SelectedIndex == -1 ||
                proveedorComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            if (isEditing)
            {
                var producto = new Productos
                {
                    Id = Convert.ToInt32(productIdLabel.Text),
                    Nombre = nombreProductoTextBox.Text,
                    Precio = Convert.ToDecimal(precioTextBox.Text),
                    Stock = Convert.ToInt32(stockTextBox.Text),
                    CategoryId = Convert.ToInt32(categoriaComboBox.SelectedValue),
                    SupplierId = Convert.ToInt32(proveedorComboBox.SelectedValue)
                };
                _productoService.UpdateProduct(producto);
                isEditing = false;
                MessageBox.Show("Actulizado");
            }
            else
            {
                var producto = new Productos
                {
                    Nombre = nombreProductoTextBox.Text,
                    Precio = Convert.ToDecimal(precioTextBox.Text),
                    Stock = Convert.ToInt32(stockTextBox.Text),
                    CategoryId = Convert.ToInt32(categoriaComboBox.SelectedValue),
                    SupplierId = Convert.ToInt32(proveedorComboBox.SelectedValue)
                };
                _productoService.AddProduct(producto);
                isEditing = false;
                MessageBox.Show("Guardado");
            }
            LoadProductos();
            CleanForm();
        }
        private void CleanForm()
        {
            productIdLabel.Text = "";
            nombreProductoTextBox.Text = "";
            precioTextBox.Text = "";
            stockTextBox.Text = "";
            categoriaComboBox.SelectedIndex = -1;
            proveedorComboBox.SelectedIndex = -1;
        }

        private void editarClientesIconButton_Click(object sender, EventArgs e)
        {
            //editar
            if (ClientesDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("Por favor, seleccione un producto");
                return;
            }

            isEditing = true;
            int productoId = Convert.ToInt32(ClientesDataGridView.CurrentRow.Cells[0].Value);
            string nombre = ClientesDataGridView.CurrentRow.Cells[1].Value.ToString();
            decimal precio = Convert.ToDecimal(ClientesDataGridView.CurrentRow.Cells[2].Value);
            int stock = Convert.ToInt32(ClientesDataGridView.CurrentRow.Cells[3].Value);

            string categoria = ClientesDataGridView.CurrentRow.Cells[4].Value.ToString();
            int categoriaId = Convert.ToInt32(ClientesDataGridView.CurrentRow.Cells[6].Value);

            categoriaComboBox.SelectedValue = categoriaId; // Ninguna selección inicial

            string proveedor = ClientesDataGridView.CurrentRow.Cells[5].Value.ToString();
            int proveedorId = Convert.ToInt32(ClientesDataGridView.CurrentRow.Cells[7].Value);

            productIdLabel.Text = productoId.ToString();
            nombreProductoTextBox.Text = nombre;
            precioTextBox.Text = precio.ToString();
            stockTextBox.Text = stock.ToString();
            proveedorComboBox.SelectedValue = proveedorId;
        }
        //borrar
        private void deleteClientesIconButton_Click(object sender, EventArgs e)
        {
            if (ClientesDataGridView.SelectedRows.Count < 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }

            isEditing = false;
            int productoId = Convert.ToInt32(ClientesDataGridView.CurrentRow.Cells[0].Value.ToString());
            DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _productoService.DeleteProduct(productoId);
                LoadProductos();

                MessageBox.Show("Producto eliminado correctamente");
            }
        }
    }
}
