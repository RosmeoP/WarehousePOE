using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PresentationLayer.Forms
{
    public partial class AdministrarForm : Form
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
        public AdministrarForm()
        {
            InitializeComponent();
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
        private void AdministrarForm_Load(object sender, EventArgs e)
        {

        }

        private void proveedorBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CategoriasForm categoriasForm = new CategoriasForm();
            categoriasForm.ShowDialog();
        }



        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
