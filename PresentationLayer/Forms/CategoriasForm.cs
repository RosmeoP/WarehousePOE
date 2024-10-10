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
    public partial class CategoriasForm : Form
    {
        public CategoriasForm()
        {
            InitializeComponent();
        }

        private void exitSelectBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            AdministrarForm administrarForm = new AdministrarForm();
            administrarForm.ShowDialog();
        }

       
    }
}
