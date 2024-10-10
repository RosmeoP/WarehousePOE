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
        public AdministrarForm()
        {
            InitializeComponent();
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
