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
            categoriesDataGridView = new DataGridView();
            editCategorieButton = new FontAwesome.Sharp.IconButton();
            deleteCategorieButton = new FontAwesome.Sharp.IconButton();
            saveCategorieButton = new FontAwesome.Sharp.IconButton();
            categoriesTextBox = new TextBox();
            categorieIdLabel = new Label();
            IdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // categoriasLabel
            // 
            categoriasLabel.AutoSize = true;
            categoriasLabel.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriasLabel.Location = new Point(61, 43);
            categoriasLabel.Name = "categoriasLabel";
            categoriasLabel.Size = new Size(267, 55);
            categoriasLabel.TabIndex = 0;
            categoriasLabel.Text = "Categorias";
            // 
            // exitSelectBtn
            // 
            exitSelectBtn.FlatStyle = FlatStyle.Flat;
            exitSelectBtn.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            exitSelectBtn.IconColor = Color.Black;
            exitSelectBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitSelectBtn.Location = new Point(12, 12);
            exitSelectBtn.Name = "exitSelectBtn";
            exitSelectBtn.Size = new Size(48, 46);
            exitSelectBtn.TabIndex = 5;
            exitSelectBtn.UseVisualStyleBackColor = true;
            exitSelectBtn.Click += exitSelectBtn_Click;
            // 
            // categoriesDataGridView
            // 
            categoriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            categoriesDataGridView.BackgroundColor = Color.White;
            categoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesDataGridView.Location = new Point(61, 201);
            categoriesDataGridView.Name = "categoriesDataGridView";
            categoriesDataGridView.RowHeadersWidth = 51;
            categoriesDataGridView.Size = new Size(466, 338);
            categoriesDataGridView.TabIndex = 6;
            // 
            // editCategorieButton
            // 
            editCategorieButton.BackColor = Color.LightSalmon;
            editCategorieButton.FlatAppearance.BorderColor = Color.LightSalmon;
            editCategorieButton.FlatAppearance.BorderSize = 0;
            editCategorieButton.FlatStyle = FlatStyle.Flat;
            editCategorieButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCategorieButton.ForeColor = SystemColors.ActiveCaptionText;
            editCategorieButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editCategorieButton.IconColor = Color.Black;
            editCategorieButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editCategorieButton.ImageAlign = ContentAlignment.MiddleLeft;
            editCategorieButton.Location = new Point(559, 161);
            editCategorieButton.Name = "editCategorieButton";
            editCategorieButton.Size = new Size(229, 65);
            editCategorieButton.TabIndex = 17;
            editCategorieButton.Text = "Editar";
            editCategorieButton.UseVisualStyleBackColor = false;
            editCategorieButton.Click += editCategorieButton_Click;
            // 
            // deleteCategorieButton
            // 
            deleteCategorieButton.BackColor = Color.LightSalmon;
            deleteCategorieButton.FlatAppearance.BorderSize = 0;
            deleteCategorieButton.FlatStyle = FlatStyle.Flat;
            deleteCategorieButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteCategorieButton.ForeColor = SystemColors.ActiveCaptionText;
            deleteCategorieButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            deleteCategorieButton.IconColor = Color.Black;
            deleteCategorieButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteCategorieButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteCategorieButton.Location = new Point(559, 232);
            deleteCategorieButton.Name = "deleteCategorieButton";
            deleteCategorieButton.Size = new Size(229, 65);
            deleteCategorieButton.TabIndex = 16;
            deleteCategorieButton.Text = "Borrar";
            deleteCategorieButton.UseVisualStyleBackColor = false;
            deleteCategorieButton.Click += deleteCategorieButton_Click;
            // 
            // saveCategorieButton
            // 
            saveCategorieButton.BackColor = Color.LightSalmon;
            saveCategorieButton.FlatAppearance.BorderSize = 0;
            saveCategorieButton.FlatStyle = FlatStyle.Flat;
            saveCategorieButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveCategorieButton.ForeColor = SystemColors.ActiveCaptionText;
            saveCategorieButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            saveCategorieButton.IconColor = Color.Black;
            saveCategorieButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveCategorieButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveCategorieButton.Location = new Point(559, 91);
            saveCategorieButton.Name = "saveCategorieButton";
            saveCategorieButton.Size = new Size(229, 65);
            saveCategorieButton.TabIndex = 15;
            saveCategorieButton.Text = "Guardar";
            saveCategorieButton.UseVisualStyleBackColor = false;
            saveCategorieButton.Click += saveCategorieButton_Click;
            // 
            // categoriesTextBox
            // 
            categoriesTextBox.Location = new Point(61, 143);
            categoriesTextBox.Name = "categoriesTextBox";
            categoriesTextBox.Size = new Size(466, 27);
            categoriesTextBox.TabIndex = 18;
            // 
            // categorieIdLabel
            // 
            categorieIdLabel.AutoSize = true;
            categorieIdLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categorieIdLabel.ForeColor = SystemColors.ActiveCaptionText;
            categorieIdLabel.Location = new Point(61, 109);
            categorieIdLabel.Name = "categorieIdLabel";
            categorieIdLabel.Size = new Size(0, 29);
            categorieIdLabel.TabIndex = 19;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdLabel.ForeColor = SystemColors.ActiveCaptionText;
            IdLabel.Location = new Point(96, 109);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(0, 29);
            IdLabel.TabIndex = 20;
            // 
            // CategoriasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 551);
            Controls.Add(IdLabel);
            Controls.Add(categorieIdLabel);
            Controls.Add(categoriesTextBox);
            Controls.Add(editCategorieButton);
            Controls.Add(deleteCategorieButton);
            Controls.Add(saveCategorieButton);
            Controls.Add(categoriesDataGridView);
            Controls.Add(exitSelectBtn);
            Controls.Add(categoriasLabel);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "CategoriasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoriasForm";
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label categoriasLabel;
        private ComboBox categoriesComboBox;
        private FontAwesome.Sharp.IconButton exitSelectBtn;
        private DataGridView categoriesDataGridView;
        private FontAwesome.Sharp.IconButton editCategorieButton;
        private FontAwesome.Sharp.IconButton deleteCategorieButton;
        private FontAwesome.Sharp.IconButton saveCategorieButton;
        private TextBox categoriesTextBox;
        private Label categorieIdLabel;
        private Label IdLabel;
    }
}