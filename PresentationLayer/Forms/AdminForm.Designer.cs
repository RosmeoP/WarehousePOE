namespace PresentationLayer.Forms
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            editarProveedorIconButton = new FontAwesome.Sharp.IconButton();
            deleteProveedorIconButton = new FontAwesome.Sharp.IconButton();
            guardarProveedorIconButton = new FontAwesome.Sharp.IconButton();
            direccionLabel = new Label();
            telefonoLabel = new Label();
            ProveedorDataGridView = new DataGridView();
            direccionTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            nombreProveedorTextBox = new TextBox();
            nombreProveedorLabel = new Label();
            exitAdminButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)ProveedorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // editarProveedorIconButton
            // 
            editarProveedorIconButton.BackColor = Color.LightSalmon;
            editarProveedorIconButton.FlatAppearance.BorderColor = Color.LightSalmon;
            editarProveedorIconButton.FlatAppearance.BorderSize = 0;
            editarProveedorIconButton.FlatStyle = FlatStyle.Flat;
            editarProveedorIconButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarProveedorIconButton.ForeColor = SystemColors.ActiveCaptionText;
            editarProveedorIconButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarProveedorIconButton.IconColor = Color.Black;
            editarProveedorIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarProveedorIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarProveedorIconButton.Location = new Point(521, 156);
            editarProveedorIconButton.Name = "editarProveedorIconButton";
            editarProveedorIconButton.Size = new Size(229, 65);
            editarProveedorIconButton.TabIndex = 26;
            editarProveedorIconButton.Text = "Editar";
            editarProveedorIconButton.UseVisualStyleBackColor = false;
            // 
            // deleteProveedorIconButton
            // 
            deleteProveedorIconButton.BackColor = Color.LightSalmon;
            deleteProveedorIconButton.FlatAppearance.BorderSize = 0;
            deleteProveedorIconButton.FlatStyle = FlatStyle.Flat;
            deleteProveedorIconButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteProveedorIconButton.ForeColor = SystemColors.ActiveCaptionText;
            deleteProveedorIconButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            deleteProveedorIconButton.IconColor = Color.Black;
            deleteProveedorIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteProveedorIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteProveedorIconButton.Location = new Point(521, 227);
            deleteProveedorIconButton.Name = "deleteProveedorIconButton";
            deleteProveedorIconButton.Size = new Size(229, 65);
            deleteProveedorIconButton.TabIndex = 25;
            deleteProveedorIconButton.Text = "Borrar";
            deleteProveedorIconButton.UseVisualStyleBackColor = false;
            // 
            // guardarProveedorIconButton
            // 
            guardarProveedorIconButton.BackColor = Color.LightSalmon;
            guardarProveedorIconButton.FlatAppearance.BorderSize = 0;
            guardarProveedorIconButton.FlatStyle = FlatStyle.Flat;
            guardarProveedorIconButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardarProveedorIconButton.ForeColor = SystemColors.ActiveCaptionText;
            guardarProveedorIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            guardarProveedorIconButton.IconColor = Color.Black;
            guardarProveedorIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guardarProveedorIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            guardarProveedorIconButton.Location = new Point(521, 86);
            guardarProveedorIconButton.Name = "guardarProveedorIconButton";
            guardarProveedorIconButton.Size = new Size(229, 65);
            guardarProveedorIconButton.TabIndex = 24;
            guardarProveedorIconButton.Text = "Guardar";
            guardarProveedorIconButton.UseVisualStyleBackColor = false;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            direccionLabel.ForeColor = SystemColors.ActiveCaptionText;
            direccionLabel.Location = new Point(337, 97);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(99, 22);
            direccionLabel.TabIndex = 22;
            direccionLabel.Text = "Direccion";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            telefonoLabel.ForeColor = SystemColors.ActiveCaptionText;
            telefonoLabel.Location = new Point(51, 187);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(91, 22);
            telefonoLabel.TabIndex = 21;
            telefonoLabel.Text = "Telefono";
            telefonoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ProveedorDataGridView
            // 
            ProveedorDataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProveedorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProveedorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProveedorDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ProveedorDataGridView.Location = new Point(51, 308);
            ProveedorDataGridView.Name = "ProveedorDataGridView";
            ProveedorDataGridView.Size = new Size(663, 301);
            ProveedorDataGridView.TabIndex = 20;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(290, 131);
            direccionTextBox.Multiline = true;
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(200, 100);
            direccionTextBox.TabIndex = 19;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.Location = new Point(51, 221);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(100, 23);
            telefonoTextBox.TabIndex = 18;
            // 
            // nombreProveedorTextBox
            // 
            nombreProveedorTextBox.Location = new Point(51, 131);
            nombreProveedorTextBox.Name = "nombreProveedorTextBox";
            nombreProveedorTextBox.Size = new Size(174, 23);
            nombreProveedorTextBox.TabIndex = 16;
            // 
            // nombreProveedorLabel
            // 
            nombreProveedorLabel.AutoSize = true;
            nombreProveedorLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreProveedorLabel.ForeColor = SystemColors.ActiveCaptionText;
            nombreProveedorLabel.Location = new Point(51, 97);
            nombreProveedorLabel.Name = "nombreProveedorLabel";
            nombreProveedorLabel.Size = new Size(218, 22);
            nombreProveedorLabel.TabIndex = 15;
            nombreProveedorLabel.Text = "Nombre del proveedor";
            // 
            // exitAdminButton
            // 
            exitAdminButton.FlatAppearance.BorderSize = 0;
            exitAdminButton.FlatStyle = FlatStyle.Flat;
            exitAdminButton.ForeColor = Color.Wheat;
            exitAdminButton.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            exitAdminButton.IconColor = Color.Black;
            exitAdminButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitAdminButton.Location = new Point(12, 12);
            exitAdminButton.Name = "exitAdminButton";
            exitAdminButton.Size = new Size(40, 40);
            exitAdminButton.TabIndex = 27;
            exitAdminButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Wheat;
            CancelButton = exitAdminButton;
            ClientSize = new Size(800, 650);
            Controls.Add(exitAdminButton);
            Controls.Add(editarProveedorIconButton);
            Controls.Add(deleteProveedorIconButton);
            Controls.Add(guardarProveedorIconButton);
            Controls.Add(direccionLabel);
            Controls.Add(telefonoLabel);
            Controls.Add(ProveedorDataGridView);
            Controls.Add(direccionTextBox);
            Controls.Add(telefonoTextBox);
            Controls.Add(nombreProveedorTextBox);
            Controls.Add(nombreProveedorLabel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)ProveedorDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton editarProveedorIconButton;
        private FontAwesome.Sharp.IconButton deleteProveedorIconButton;
        private FontAwesome.Sharp.IconButton guardarProveedorIconButton;
        private Label direccionLabel;
        private Label telefonoLabel;
        private DataGridView ProveedorDataGridView;
        private TextBox direccionTextBox;
        private TextBox telefonoTextBox;
        private TextBox nombreProveedorTextBox;
        private Label nombreProveedorLabel;
        private FontAwesome.Sharp.IconButton exitAdminButton;
    }
}