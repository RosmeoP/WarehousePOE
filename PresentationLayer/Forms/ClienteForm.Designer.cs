namespace PresentationLayer.Forms
{
    partial class ClienteForm
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
            nombreProductoLabel = new Label();
            nombreProductoTextBox = new TextBox();
            categoriaTextBox = new TextBox();
            precioTextBox = new TextBox();
            stockTextBox = new TextBox();
            ClientesDataGridView = new DataGridView();
            precioLabel = new Label();
            stockLabel = new Label();
            categoriaLabel = new Label();
            guardarClientesIconButton = new FontAwesome.Sharp.IconButton();
            deleteClientesIconButton = new FontAwesome.Sharp.IconButton();
            editarClientesIconButton = new FontAwesome.Sharp.IconButton();
            exitMainButton = new FontAwesome.Sharp.IconButton();
            proveedorComboBox = new ComboBox();
            proveedorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ClientesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreProductoLabel.ForeColor = SystemColors.ActiveCaptionText;
            nombreProductoLabel.Location = new Point(62, 82);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new Size(257, 29);
            nombreProductoLabel.TabIndex = 0;
            nombreProductoLabel.Text = "Nombre del producto";
            // 
            // nombreProductoTextBox
            // 
            nombreProductoTextBox.Location = new Point(62, 116);
            nombreProductoTextBox.Name = "nombreProductoTextBox";
            nombreProductoTextBox.Size = new Size(174, 27);
            nombreProductoTextBox.TabIndex = 1;
            // 
            // categoriaTextBox
            // 
            categoriaTextBox.Location = new Point(336, 201);
            categoriaTextBox.Name = "categoriaTextBox";
            categoriaTextBox.Size = new Size(156, 27);
            categoriaTextBox.TabIndex = 3;
            // 
            // precioTextBox
            // 
            precioTextBox.Location = new Point(336, 116);
            precioTextBox.Name = "precioTextBox";
            precioTextBox.Size = new Size(156, 27);
            precioTextBox.TabIndex = 5;
            // 
            // stockTextBox
            // 
            stockTextBox.Location = new Point(62, 201);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(174, 27);
            stockTextBox.TabIndex = 7;
            // 
            // ClientesDataGridView
            // 
            ClientesDataGridView.BackgroundColor = Color.White;
            ClientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientesDataGridView.Location = new Point(62, 337);
            ClientesDataGridView.Name = "ClientesDataGridView";
            ClientesDataGridView.RowHeadersWidth = 51;
            ClientesDataGridView.Size = new Size(663, 301);
            ClientesDataGridView.TabIndex = 8;
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            precioLabel.ForeColor = SystemColors.ActiveCaptionText;
            precioLabel.Location = new Point(336, 82);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new Size(86, 29);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockLabel.ForeColor = SystemColors.ActiveCaptionText;
            stockLabel.Location = new Point(62, 162);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new Size(78, 29);
            stockLabel.TabIndex = 10;
            stockLabel.Text = "Stock";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriaLabel.ForeColor = SystemColors.ActiveCaptionText;
            categoriaLabel.Location = new Point(336, 162);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(123, 29);
            categoriaLabel.TabIndex = 11;
            categoriaLabel.Text = "Categoria";
            // 
            // guardarClientesIconButton
            // 
            guardarClientesIconButton.BackColor = Color.LightSalmon;
            guardarClientesIconButton.FlatAppearance.BorderSize = 0;
            guardarClientesIconButton.FlatStyle = FlatStyle.Flat;
            guardarClientesIconButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardarClientesIconButton.ForeColor = SystemColors.ActiveCaptionText;
            guardarClientesIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            guardarClientesIconButton.IconColor = Color.Black;
            guardarClientesIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            guardarClientesIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            guardarClientesIconButton.Location = new Point(532, 71);
            guardarClientesIconButton.Name = "guardarClientesIconButton";
            guardarClientesIconButton.Size = new Size(229, 65);
            guardarClientesIconButton.TabIndex = 12;
            guardarClientesIconButton.Text = "Guardar";
            guardarClientesIconButton.UseVisualStyleBackColor = false;
            guardarClientesIconButton.Click += guardarClientesIconButton_Click;
            // 
            // deleteClientesIconButton
            // 
            deleteClientesIconButton.BackColor = Color.LightSalmon;
            deleteClientesIconButton.FlatAppearance.BorderSize = 0;
            deleteClientesIconButton.FlatStyle = FlatStyle.Flat;
            deleteClientesIconButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteClientesIconButton.ForeColor = SystemColors.ActiveCaptionText;
            deleteClientesIconButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            deleteClientesIconButton.IconColor = Color.Black;
            deleteClientesIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteClientesIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteClientesIconButton.Location = new Point(532, 212);
            deleteClientesIconButton.Name = "deleteClientesIconButton";
            deleteClientesIconButton.Size = new Size(229, 65);
            deleteClientesIconButton.TabIndex = 13;
            deleteClientesIconButton.Text = "Borrar";
            deleteClientesIconButton.UseVisualStyleBackColor = false;
            // 
            // editarClientesIconButton
            // 
            editarClientesIconButton.BackColor = Color.LightSalmon;
            editarClientesIconButton.FlatAppearance.BorderColor = Color.LightSalmon;
            editarClientesIconButton.FlatAppearance.BorderSize = 0;
            editarClientesIconButton.FlatStyle = FlatStyle.Flat;
            editarClientesIconButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarClientesIconButton.ForeColor = SystemColors.ActiveCaptionText;
            editarClientesIconButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editarClientesIconButton.IconColor = Color.Black;
            editarClientesIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editarClientesIconButton.ImageAlign = ContentAlignment.MiddleLeft;
            editarClientesIconButton.Location = new Point(532, 141);
            editarClientesIconButton.Name = "editarClientesIconButton";
            editarClientesIconButton.Size = new Size(229, 65);
            editarClientesIconButton.TabIndex = 14;
            editarClientesIconButton.Text = "Editar";
            editarClientesIconButton.UseVisualStyleBackColor = false;
            editarClientesIconButton.Click += editarClientesIconButton_Click;
            // 
            // exitMainButton
            // 
            exitMainButton.FlatAppearance.BorderSize = 0;
            exitMainButton.FlatStyle = FlatStyle.Flat;
            exitMainButton.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            exitMainButton.IconColor = Color.Black;
            exitMainButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitMainButton.Location = new Point(12, 12);
            exitMainButton.Name = "exitMainButton";
            exitMainButton.Size = new Size(40, 40);
            exitMainButton.TabIndex = 28;
            exitMainButton.UseVisualStyleBackColor = true;
            // 
            // proveedorComboBox
            // 
            proveedorComboBox.FormattingEnabled = true;
            proveedorComboBox.Location = new Point(66, 293);
            proveedorComboBox.Name = "proveedorComboBox";
            proveedorComboBox.Size = new Size(426, 28);
            proveedorComboBox.TabIndex = 29;
            // 
            // proveedorLabel
            // 
            proveedorLabel.AutoSize = true;
            proveedorLabel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            proveedorLabel.ForeColor = SystemColors.ActiveCaptionText;
            proveedorLabel.Location = new Point(68, 258);
            proveedorLabel.Name = "proveedorLabel";
            proveedorLabel.Size = new Size(126, 27);
            proveedorLabel.TabIndex = 30;
            proveedorLabel.Text = "Proveedor";
            // 
            // ClienteForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Wheat;
            CancelButton = exitMainButton;
            ClientSize = new Size(800, 650);
            Controls.Add(proveedorLabel);
            Controls.Add(proveedorComboBox);
            Controls.Add(exitMainButton);
            Controls.Add(editarClientesIconButton);
            Controls.Add(deleteClientesIconButton);
            Controls.Add(guardarClientesIconButton);
            Controls.Add(categoriaLabel);
            Controls.Add(stockLabel);
            Controls.Add(precioLabel);
            Controls.Add(ClientesDataGridView);
            Controls.Add(stockTextBox);
            Controls.Add(precioTextBox);
            Controls.Add(categoriaTextBox);
            Controls.Add(nombreProductoTextBox);
            Controls.Add(nombreProductoLabel);
            ForeColor = Color.Wheat;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClienteForm";
            ((System.ComponentModel.ISupportInitialize)ClientesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreProductoLabel;
        private TextBox nombreProductoTextBox;
        private TextBox categoriaTextBox;
        private TextBox precioTextBox;
        private TextBox stockTextBox;
        private DataGridView ClientesDataGridView;
        private Label precioLabel;
        private Label stockLabel;
        private Label categoriaLabel;
        private FontAwesome.Sharp.IconButton guardarClientesIconButton;
        private FontAwesome.Sharp.IconButton deleteClientesIconButton;
        private FontAwesome.Sharp.IconButton editarClientesIconButton;
        private FontAwesome.Sharp.IconButton exitMainButton;
        private ComboBox proveedorComboBox;
        private Label proveedorLabel;
    }
}