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

        public ClienteForm()
        {

            InitializeComponent();
            _productoService = new ProductosService();
            _proveedorService = new ProveedoresService();


            LoadProductos();
            LoadProveedores();

        }

        private void LoadProveedores()
        {
            DataTable proveedores = _proveedorService.GetSupplier();
            proveedorComboBox.DataSource = proveedores;
            proveedorComboBox.DisplayMember = "Nombre";
            proveedorComboBox.ValueMember = "Id";
            proveedorComboBox.SelectedIndex = -1; // Ninguna selección inicial
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
                string.IsNullOrEmpty(categoriaTextBox.Text) ||
                proveedorComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            var producto = new Productos
            {
                Nombre = nombreProductoTextBox.Text,
                Precio = Convert.ToDecimal(precioTextBox.Text),
                Stock = Convert.ToInt32(stockTextBox.Text),
                CategoryId = Convert.ToInt32(categoriaTextBox.Text),
                SupplierId = Convert.ToInt32(proveedorComboBox.SelectedValue)
            };
            _productoService.AddProduct(producto);
            LoadProductos();
            CleanForm();
        }
        private void CleanForm()
        {
            nombreProductoTextBox.Text = "";
            precioTextBox.Text = "";
            stockTextBox.Text = "";
            categoriaTextBox.Text = "";
            proveedorComboBox.SelectedIndex = -1;
        }

        private void editarClientesIconButton_Click(object sender, EventArgs e)
        {
            //editar
            if (ClientesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto");
                return;
            }
            DataGridViewRow selectedRow = ClientesDataGridView.SelectedRows[0];
            int productoId = Convert.ToInt32(selectedRow.Cells["Id"].Value); // Asegúrate de que la columna de Id se llame "Id"
            string nombre = selectedRow.Cells["Nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(selectedRow.Cells["Precio"].Value);
            int stock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);
            int categoriaId = Convert.ToInt32(selectedRow.Cells["CategoryId"].Value);
            int proveedorId = Convert.ToInt32(selectedRow.Cells["SupplierId"].Value);


        }
    }

}
