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
            proveedorBtn = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            exitBtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // administrarLabel
            // 
            administrarLabel.AutoSize = true;
            administrarLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            administrarLabel.Location = new Point(208, 27);
            administrarLabel.Name = "administrarLabel";
            administrarLabel.Size = new Size(384, 70);
            administrarLabel.TabIndex = 0;
            administrarLabel.Text = "Administrar:";
            // 
            // proveedorLabel
            // 
            proveedorLabel.AutoSize = true;
            proveedorLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            proveedorLabel.Location = new Point(75, 258);
            proveedorLabel.Name = "proveedorLabel";
            proveedorLabel.Size = new Size(326, 70);
            proveedorLabel.TabIndex = 1;
            proveedorLabel.Text = "Proveedor";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoriaLabel.Location = new Point(419, 258);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new Size(306, 70);
            categoriaLabel.TabIndex = 2;
            categoriaLabel.Text = "Categoria";
            // 
            // proveedorBtn
            // 
            proveedorBtn.BackColor = Color.Wheat;
            proveedorBtn.FlatStyle = FlatStyle.Flat;
            proveedorBtn.ForeColor = SystemColors.ActiveCaptionText;
            proveedorBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            proveedorBtn.IconColor = Color.Black;
            proveedorBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            proveedorBtn.Location = new Point(121, 160);
            proveedorBtn.Name = "proveedorBtn";
            proveedorBtn.Size = new Size(163, 104);
            proveedorBtn.TabIndex = 3;
            proveedorBtn.UseVisualStyleBackColor = false;
            proveedorBtn.Click += proveedorBtn_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Wheat;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ActiveCaptionText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tags;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(488, 160);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(163, 104);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            exitBtn.IconColor = Color.Black;
            exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitBtn.Location = new Point(-1, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(71, 51);
            exitBtn.TabIndex = 5;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click_1;
            // 
            // AdministrarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(iconButton1);
            Controls.Add(proveedorBtn);
            Controls.Add(categoriaLabel);
            Controls.Add(proveedorLabel);
            Controls.Add(administrarLabel);
            Name = "AdministrarForm";
            Text = "AdministrarForm";
            Load += AdministrarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label administrarLabel;
        private Label proveedorLabel;
        private Label categoriaLabel;
        private FontAwesome.Sharp.IconButton proveedorBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton exitBtn;
    }
}