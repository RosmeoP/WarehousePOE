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
            exitSelectBtn = new FontAwesome.Sharp.IconButton();
            categoriasDataGridView = new DataGridView();
            editCategoriaButton = new FontAwesome.Sharp.IconButton();
            deleteCategoriaButton = new FontAwesome.Sharp.IconButton();
            saveCategoriaButton = new FontAwesome.Sharp.IconButton();
            categoriasTextBox = new TextBox();
            categorieIdLabel = new Label();
            IdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)categoriasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // categoriasLabel
            // 
            categoriasLabel.AutoSize = true;
            categoriasLabel.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriasLabel.Location = new Point(111, 59);
            categoriasLabel.Name = "categoriasLabel";
            categoriasLabel.Size = new Size(216, 45);
            categoriasLabel.TabIndex = 0;
            categoriasLabel.Text = "Categorias";
            // 
            // exitSelectBtn
            // 
            exitSelectBtn.FlatAppearance.BorderSize = 0;
            exitSelectBtn.FlatStyle = FlatStyle.Flat;
            exitSelectBtn.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            exitSelectBtn.IconColor = Color.Black;
            exitSelectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitSelectBtn.Location = new Point(12, 12);
            exitSelectBtn.Margin = new Padding(3, 2, 3, 2);
            exitSelectBtn.Name = "exitSelectBtn";
            exitSelectBtn.Size = new Size(42, 34);
            exitSelectBtn.TabIndex = 5;
            exitSelectBtn.UseVisualStyleBackColor = true;
            exitSelectBtn.Click += exitSelectBtn_Click;
            // 
            // categoriasDataGridView
            // 
            categoriasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            categoriasDataGridView.BackgroundColor = Color.White;
            categoriasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriasDataGridView.Location = new Point(111, 178);
            categoriasDataGridView.Margin = new Padding(3, 2, 3, 2);
            categoriasDataGridView.Name = "categoriasDataGridView";
            categoriasDataGridView.RowHeadersWidth = 51;
            categoriasDataGridView.Size = new Size(408, 254);
            categoriasDataGridView.TabIndex = 6;
            // 
            // editCategoriaButton
            // 
            editCategoriaButton.BackColor = Color.LightSalmon;
            editCategoriaButton.FlatAppearance.BorderColor = Color.LightSalmon;
            editCategoriaButton.FlatAppearance.BorderSize = 0;
            editCategoriaButton.FlatStyle = FlatStyle.Flat;
            editCategoriaButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCategoriaButton.ForeColor = SystemColors.ActiveCaptionText;
            editCategoriaButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editCategoriaButton.IconColor = Color.Black;
            editCategoriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editCategoriaButton.ImageAlign = ContentAlignment.MiddleLeft;
            editCategoriaButton.Location = new Point(547, 148);
            editCategoriaButton.Margin = new Padding(3, 2, 3, 2);
            editCategoriaButton.Name = "editCategoriaButton";
            editCategoriaButton.Size = new Size(200, 49);
            editCategoriaButton.TabIndex = 17;
            editCategoriaButton.Text = "Editar";
            editCategoriaButton.UseVisualStyleBackColor = false;
            editCategoriaButton.Click += editCategorieButton_Click;
            // 
            // deleteCategoriaButton
            // 
            deleteCategoriaButton.BackColor = Color.LightSalmon;
            deleteCategoriaButton.FlatAppearance.BorderSize = 0;
            deleteCategoriaButton.FlatStyle = FlatStyle.Flat;
            deleteCategoriaButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteCategoriaButton.ForeColor = SystemColors.ActiveCaptionText;
            deleteCategoriaButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            deleteCategoriaButton.IconColor = Color.Black;
            deleteCategoriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteCategoriaButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteCategoriaButton.Location = new Point(547, 201);
            deleteCategoriaButton.Margin = new Padding(3, 2, 3, 2);
            deleteCategoriaButton.Name = "deleteCategoriaButton";
            deleteCategoriaButton.Size = new Size(200, 49);
            deleteCategoriaButton.TabIndex = 16;
            deleteCategoriaButton.Text = "Borrar";
            deleteCategoriaButton.UseVisualStyleBackColor = false;
            deleteCategoriaButton.Click += deleteCategorieButton_Click;
            // 
            // saveCategoriaButton
            // 
            saveCategoriaButton.BackColor = Color.LightSalmon;
            saveCategoriaButton.FlatAppearance.BorderSize = 0;
            saveCategoriaButton.FlatStyle = FlatStyle.Flat;
            saveCategoriaButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveCategoriaButton.ForeColor = SystemColors.ActiveCaptionText;
            saveCategoriaButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveCategoriaButton.IconColor = Color.Black;
            saveCategoriaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveCategoriaButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveCategoriaButton.Location = new Point(547, 95);
            saveCategoriaButton.Margin = new Padding(3, 2, 3, 2);
            saveCategoriaButton.Name = "saveCategoriaButton";
            saveCategoriaButton.Size = new Size(200, 49);
            saveCategoriaButton.TabIndex = 15;
            saveCategoriaButton.Text = "Guardar";
            saveCategoriaButton.UseVisualStyleBackColor = false;
            saveCategoriaButton.Click += saveCategorieButton_Click;
            // 
            // categoriasTextBox
            // 
            categoriasTextBox.Location = new Point(111, 134);
            categoriasTextBox.Margin = new Padding(3, 2, 3, 2);
            categoriasTextBox.Name = "categoriasTextBox";
            categoriasTextBox.Size = new Size(408, 23);
            categoriasTextBox.TabIndex = 18;
            // 
            // categorieIdLabel
            // 
            categorieIdLabel.AutoSize = true;
            categorieIdLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categorieIdLabel.ForeColor = SystemColors.ActiveCaptionText;
            categorieIdLabel.Location = new Point(53, 82);
            categorieIdLabel.Name = "categorieIdLabel";
            categorieIdLabel.Size = new Size(0, 22);
            categorieIdLabel.TabIndex = 19;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdLabel.ForeColor = SystemColors.ActiveCaptionText;
            IdLabel.Location = new Point(84, 82);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(0, 22);
            IdLabel.TabIndex = 20;
            // 
            // CategoriasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(816, 489);
            Controls.Add(IdLabel);
            Controls.Add(categorieIdLabel);
            Controls.Add(categoriasTextBox);
            Controls.Add(editCategoriaButton);
            Controls.Add(deleteCategoriaButton);
            Controls.Add(saveCategoriaButton);
            Controls.Add(categoriasDataGridView);
            Controls.Add(exitSelectBtn);
            Controls.Add(categoriasLabel);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "CategoriasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriasForm";
            ((System.ComponentModel.ISupportInitialize)categoriasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categoriasLabel;
        private ComboBox categoriesComboBox;
        private FontAwesome.Sharp.IconButton exitSelectBtn;
        private DataGridView categoriasDataGridView;
        private FontAwesome.Sharp.IconButton editCategoriaButton;
        private FontAwesome.Sharp.IconButton deleteCategoriaButton;
        private FontAwesome.Sharp.IconButton saveCategoriaButton;
        private TextBox categoriasTextBox;
        private Label categorieIdLabel;
        private Label IdLabel;
    }
}