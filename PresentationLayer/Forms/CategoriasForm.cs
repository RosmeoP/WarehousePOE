using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;
using EntitiLayer.Entities;

namespace PresentationLayer.Forms
{
    public partial class CategoriasForm : Form
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
        private CategoriasService _categoriasService;
        bool isEditing = false;
        public CategoriasForm()
        {
            InitializeComponent();
            _categoriasService = new CategoriasService();
            loadCategories();
        }

        private void loadCategories()
        {
            DataTable categories = _categoriasService.GetCategories();
            categoriasDataGridView.DataSource = categories;
        }


        private void saveCategorieButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(categoriasTextBox.Text))
            {
                MessageBox.Show("Por favor, rellene el campo");
                return;
            }

            if (isEditing)
            {   
                var categorie = new Categorias
                {
                    Id = Convert.ToInt32(IdLabel.Text),
                    Nombre = categoriasTextBox.Text,
                };
                _categoriasService.UpdateCategory(categorie);
                isEditing = false;
                MessageBox.Show("Categoria actulizada con exito");
            }
            else
            {   
                var categorie = new Categorias
                {
                    Nombre = categoriasTextBox.Text,
                };
                _categoriasService.CreateCategory(categorie);
                isEditing = false;
                MessageBox.Show("Categoria creada con exito");
            }
            CleanForm();
            loadCategories();
        }

        private void editCategorieButton_Click(object sender, EventArgs e)
        {

            //UPDATE
            if (categoriasDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("Por favor, seleccione una categoria");
                return;
            }

            isEditing = true;
            int categorieId = Convert.ToInt32(categoriasDataGridView.CurrentRow.Cells[0].Value);
            string nombre = categoriasDataGridView.CurrentRow.Cells[1].Value.ToString();

            categorieIdLabel.Text = "ID:";
            IdLabel.Text = categorieId.ToString();
            categoriasTextBox.Text = nombre;
        }

        private void deleteCategorieButton_Click(object sender, EventArgs e)
        {
            
            if (categoriasDataGridView.SelectedRows.Count > 0)
            {
                MessageBox.Show("Por favor, seleccione una categoria");
                return;
            }

            isEditing = false;
            int categoriId = Convert.ToInt32(categoriasDataGridView.CurrentRow.Cells[0].Value.ToString());
            DialogResult confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta categoria?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _categoriasService.DeleteCategory(categoriId);
                    MessageBox.Show("Categoria eliminada correctamente", "Categoria eliminada");
                }
                catch
                {
                    MessageBox.Show("Este categoria ya esta siendo usada, no puede ser eliminida", "Error");
                }
                loadCategories();
                CleanForm();
            }
        }

        private void CleanForm()
        {
            IdLabel.Text = "";
            categorieIdLabel.Text = "";
            categoriasTextBox.Text = "";
        }

        private void exitSelectBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
