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
    public partial class MainForm : Form
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void clienteButton_Click(object sender, EventArgs e)
        {
            EmpleadoForm clienteForm = new EmpleadoForm();
            clienteForm.ShowDialog();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdministrarForm administrarForm = new AdministrarForm();
            administrarForm.ShowDialog();
        }

        private void exitMainButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
