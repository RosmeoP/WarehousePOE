namespace PresentationLayer.Forms
{
    partial class CategoriasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            categoriasLabel = new Label();
            comboBox1 = new ComboBox();
            guardarBtn = new FontAwesome.Sharp.IconButton();
            editarBtn = new FontAwesome.Sharp.IconButton();
            eliminarCategoriaBtns = new FontAwesome.Sharp.IconButton();
            exitSelectBtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // categoriasLabel
            // 
            categoriasLabel.AutoSize = true;
            categoriasLabel.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriasLabel.Location = new Point(94, 34);
            categoriasLabel.Name = "categoriasLabel";
            categoriasLabel.Size = new Size(267, 55);
            categoriasLabel.TabIndex = 0;
            categoriasLabel.Text = "Categorias";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(375, 28);
            comboBox1.TabIndex = 1;
            // 
            // guardarBtn
            // 
            guardarBtn.Anchor = AnchorStyles.Top;
            guardarBtn.FlatStyle = FlatStyle.Flat;
            guardarBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            guardarBtn.IconColor = Color.Black;
            guardarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guardarBtn.IconSize = 50;
            guardarBtn.Location = new Point(578, 96);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(167, 70);
            guardarBtn.TabIndex = 2;
            guardarBtn.Text = "Guardar";
            guardarBtn.TextAlign = ContentAlignment.MiddleRight;
            guardarBtn.UseVisualStyleBackColor = true;
            // 
            // editarBtn
            // 
            editarBtn.Anchor = AnchorStyles.Top;
            editarBtn.FlatStyle = FlatStyle.Flat;
            editarBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarBtn.IconColor = Color.Black;
            editarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarBtn.IconSize = 50;
            editarBtn.Location = new Point(578, 189);
            editarBtn.Name = "editarBtn";
            editarBtn.Size = new Size(167, 70);
            editarBtn.TabIndex = 3;
            editarBtn.Text = "Editar";
            editarBtn.TextAlign = ContentAlignment.MiddleRight;
            editarBtn.UseVisualStyleBackColor = true;
            // 
            // eliminarCategoriaBtns
            // 
            eliminarCategoriaBtns.Anchor = AnchorStyles.Top;
            eliminarCategoriaBtns.FlatStyle = FlatStyle.Flat;
            eliminarCategoriaBtns.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            eliminarCategoriaBtns.IconColor = Color.Black;
            eliminarCategoriaBtns.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarCategoriaBtns.IconSize = 50;
            eliminarCategoriaBtns.Location = new Point(578, 282);
            eliminarCategoriaBtns.Name = "eliminarCategoriaBtns";
            eliminarCategoriaBtns.Size = new Size(167, 70);
            eliminarCategoriaBtns.TabIndex = 4;
            eliminarCategoriaBtns.Text = "Eliminar";
            eliminarCategoriaBtns.TextAlign = ContentAlignment.MiddleRight;
            eliminarCategoriaBtns.UseVisualStyleBackColor = true;
            // 
            // exitSelectBtn
            // 
            exitSelectBtn.FlatStyle = FlatStyle.Flat;
            exitSelectBtn.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            exitSelectBtn.IconColor = Color.Black;
            exitSelectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitSelectBtn.Location = new Point(12, 12);
            exitSelectBtn.Name = "exitSelectBtn";
            exitSelectBtn.Size = new Size(57, 71);
            exitSelectBtn.TabIndex = 5;
            exitSelectBtn.UseVisualStyleBackColor = true;
            exitSelectBtn.Click += exitSelectBtn_Click;
            // 
            // CategoriasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(exitSelectBtn);
            Controls.Add(eliminarCategoriaBtns);
            Controls.Add(editarBtn);
            Controls.Add(guardarBtn);
            Controls.Add(comboBox1);
            Controls.Add(categoriasLabel);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "CategoriasForm";
            Text = "CategoriasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categoriasLabel;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton guardarBtn;
        private FontAwesome.Sharp.IconButton editarBtn;
        private FontAwesome.Sharp.IconButton eliminarCategoriaBtns;
        private FontAwesome.Sharp.IconButton exitSelectBtn;
    }
}