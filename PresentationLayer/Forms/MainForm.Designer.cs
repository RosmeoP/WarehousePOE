namespace PresentationLayer.Forms
{
    partial class MainForm
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
            titleLabel = new Label();
            clienteButton = new FontAwesome.Sharp.IconButton();
            adminButton = new FontAwesome.Sharp.IconButton();
            clienteLabel = new Label();
            adminLabel = new Label();
            exitMainButton = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 50F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(148, 73);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(649, 97);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Ingresar como:";
            // 
            // clienteButton
            // 
            clienteButton.FlatAppearance.BorderSize = 0;
            clienteButton.FlatStyle = FlatStyle.Flat;
            clienteButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            clienteButton.IconColor = Color.Black;
            clienteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            clienteButton.IconSize = 125;
            clienteButton.Location = new Point(182, 244);
            clienteButton.Name = "clienteButton";
            clienteButton.Size = new Size(118, 102);
            clienteButton.TabIndex = 1;
            clienteButton.UseVisualStyleBackColor = true;
            clienteButton.Click += clienteButton_Click;
            // 
            // adminButton
            // 
            adminButton.FlatAppearance.BorderSize = 0;
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            adminButton.IconColor = Color.Black;
            adminButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            adminButton.IconSize = 100;
            adminButton.Location = new Point(507, 244);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(106, 81);
            adminButton.TabIndex = 2;
            adminButton.UseVisualStyleBackColor = true;
            adminButton.Click += adminButton_Click;
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Font = new Font("Arial", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clienteLabel.Location = new Point(117, 349);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new Size(311, 69);
            clienteLabel.TabIndex = 3;
            clienteLabel.Text = "Empleado";
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Font = new Font("Arial", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminLabel.Location = new Point(473, 342);
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(211, 69);
            adminLabel.TabIndex = 4;
            adminLabel.Text = "Admin";
            // 
            // exitMainButton
            // 
            exitMainButton.FlatAppearance.BorderSize = 0;
            exitMainButton.FlatStyle = FlatStyle.Flat;
            exitMainButton.ForeColor = Color.Wheat;
            exitMainButton.IconChar = FontAwesome.Sharp.IconChar.LessThan;
            exitMainButton.IconColor = Color.Black;
            exitMainButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitMainButton.Location = new Point(12, 12);
            exitMainButton.Name = "exitMainButton";
            exitMainButton.Size = new Size(40, 40);
            exitMainButton.TabIndex = 28;
            exitMainButton.UseVisualStyleBackColor = true;
            exitMainButton.Click += exitMainButton_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Wheat;
            CancelButton = exitMainButton;
            ClientSize = new Size(816, 489);
            Controls.Add(exitMainButton);
            Controls.Add(adminLabel);
            Controls.Add(clienteLabel);
            Controls.Add(adminButton);
            Controls.Add(clienteButton);
            Controls.Add(titleLabel);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private FontAwesome.Sharp.IconButton clienteButton;
        private FontAwesome.Sharp.IconButton adminButton;
        private Label clienteLabel;
        private Label adminLabel;
        private FontAwesome.Sharp.IconButton exitMainButton;
    }
}