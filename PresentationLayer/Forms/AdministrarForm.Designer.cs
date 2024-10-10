namespace PresentationLayer.Forms
{
    partial class AdministrarForm
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
            administrarLabel = new Label();
            proveedorLabel = new Label();
            categoriaLabel = new Label();
            proveedorIconButton = new FontAwesome.Sharp.IconButton();
            categoriaIconButton = new FontAwesome.Sharp.IconButton();
            exitBtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // administrarLabel
            // 
            administrarLabel.AutoSize = true;
            administrarLabel.Font = new Font("Arial", 50F, FontStyle.Bold);
            administrarLabel.Location = new Point(194, 54);
            administrarLabel.Name = "administrarLabel";
            administrarLabel.Size = new Size(429, 78);
            administrarLabel.TabIndex = 0;
            administrarLabel.Text = "Administrar:";
            // 
            // proveedorLabel
            // 
            proveedorLabel.AutoSize = true;
            proveedorLabel.Font = new Font("Arial", 35F, FontStyle.Bold);
            proveedorLabel.Location = new Point(129, 261);
            proveedorLabel.Name = "proveedorLabel";
            proveedorLabel.Size = new Size(255, 55);
            proveedorLabel.TabIndex = 1;
            proveedorLabel.Text = "Proveedor";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new Font("Arial", 35F, FontStyle.Bold);
            categoriaLabel.Location = new Point(430, 261);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(241, 55);
            categoriaLabel.TabIndex = 2;
            categoriaLabel.Text = "Categoria";
            // 
            // proveedorIconButton
            // 
            proveedorIconButton.BackColor = Color.Wheat;
            proveedorIconButton.FlatAppearance.BorderSize = 0;
            proveedorIconButton.FlatStyle = FlatStyle.Flat;
            proveedorIconButton.ForeColor = SystemColors.ActiveCaptionText;
            proveedorIconButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            proveedorIconButton.IconColor = Color.Black;
            proveedorIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            proveedorIconButton.Location = new Point(169, 187);
            proveedorIconButton.Margin = new Padding(3, 2, 3, 2);
            proveedorIconButton.Name = "proveedorIconButton";
            proveedorIconButton.Size = new Size(143, 78);
            proveedorIconButton.TabIndex = 3;
            proveedorIconButton.UseVisualStyleBackColor = false;
            proveedorIconButton.Click += proveedorBtn_Click;
            // 
            // categoriaIconButton
            // 
            categoriaIconButton.BackColor = Color.Wheat;
            categoriaIconButton.FlatAppearance.BorderSize = 0;
            categoriaIconButton.FlatStyle = FlatStyle.Flat;
            categoriaIconButton.ForeColor = SystemColors.ActiveCaptionText;
            categoriaIconButton.IconChar = FontAwesome.Sharp.IconChar.Tags;
            categoriaIconButton.IconColor = Color.Black;
            categoriaIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            categoriaIconButton.Location = new Point(490, 187);
            categoriaIconButton.Margin = new Padding(3, 2, 3, 2);
            categoriaIconButton.Name = "categoriaIconButton";
            categoriaIconButton.Size = new Size(143, 78);
            categoriaIconButton.TabIndex = 4;
            categoriaIconButton.UseVisualStyleBackColor = false;
            categoriaIconButton.Click += iconButton1_Click;
            // 
            // exitBtn
            // 
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            exitBtn.IconColor = Color.Black;
            exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitBtn.Location = new Point(12, 12);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(40, 40);
            exitBtn.TabIndex = 5;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click_1;
            // 
            // AdministrarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(816, 489);
            Controls.Add(exitBtn);
            Controls.Add(categoriaIconButton);
            Controls.Add(proveedorIconButton);
            Controls.Add(categoriaLabel);
            Controls.Add(proveedorLabel);
            Controls.Add(administrarLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AdministrarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministrarForm";
            Load += AdministrarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label administrarLabel;
        private Label proveedorLabel;
        private Label categoriaLabel;
        private FontAwesome.Sharp.IconButton proveedorIconButton;
        private FontAwesome.Sharp.IconButton categoriaIconButton;
        private FontAwesome.Sharp.IconButton exitBtn;
    }
}