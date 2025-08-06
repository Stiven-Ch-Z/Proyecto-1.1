namespace proyecto_de_buses
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnayuda = new Button();
            lbltitulo = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnmantenimiento = new Button();
            btnhistorial = new Button();
            btnventas = new Button();
            btnsalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnayuda
            // 
            btnayuda.BackColor = Color.FromArgb(192, 255, 192);
            btnayuda.BackgroundImageLayout = ImageLayout.Stretch;
            btnayuda.FlatStyle = FlatStyle.Popup;
            btnayuda.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnayuda.Location = new Point(91, 298);
            btnayuda.Name = "btnayuda";
            btnayuda.RightToLeft = RightToLeft.Yes;
            btnayuda.Size = new Size(160, 37);
            btnayuda.TabIndex = 1;
            btnayuda.Text = "Ayuda";
            btnayuda.UseVisualStyleBackColor = false;
            btnayuda.Click += btnayuda_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(72, 21);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(451, 38);
            lbltitulo.TabIndex = 7;
            lbltitulo.Text = "Bienvenido al gestor de la empresa";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_07_15_at_8_04_05_PM;
            pictureBox1.Location = new Point(399, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 312);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 59);
            label1.Name = "label1";
            label1.Size = new Size(289, 28);
            label1.TabIndex = 9;
            label1.Text = "Por favor seleccione una opcion";
            // 
            // btnmantenimiento
            // 
            btnmantenimiento.BackColor = Color.FromArgb(224, 224, 224);
            btnmantenimiento.BackgroundImageLayout = ImageLayout.Stretch;
            btnmantenimiento.FlatStyle = FlatStyle.Popup;
            btnmantenimiento.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmantenimiento.Location = new Point(91, 121);
            btnmantenimiento.Name = "btnmantenimiento";
            btnmantenimiento.RightToLeft = RightToLeft.Yes;
            btnmantenimiento.Size = new Size(160, 37);
            btnmantenimiento.TabIndex = 10;
            btnmantenimiento.Text = "Mantenimiento";
            btnmantenimiento.UseVisualStyleBackColor = false;
            btnmantenimiento.Click += btnmantenimiento_Click;
            // 
            // btnhistorial
            // 
            btnhistorial.BackColor = Color.FromArgb(224, 224, 224);
            btnhistorial.BackgroundImageLayout = ImageLayout.Stretch;
            btnhistorial.FlatStyle = FlatStyle.Popup;
            btnhistorial.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnhistorial.Location = new Point(91, 237);
            btnhistorial.Name = "btnhistorial";
            btnhistorial.RightToLeft = RightToLeft.Yes;
            btnhistorial.Size = new Size(160, 37);
            btnhistorial.TabIndex = 11;
            btnhistorial.Text = "Historial";
            btnhistorial.UseVisualStyleBackColor = false;
            btnhistorial.Click += btnhistorial_Click;
            // 
            // btnventas
            // 
            btnventas.BackColor = Color.FromArgb(224, 224, 224);
            btnventas.BackgroundImageLayout = ImageLayout.Stretch;
            btnventas.FlatStyle = FlatStyle.Popup;
            btnventas.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnventas.Location = new Point(91, 177);
            btnventas.Name = "btnventas";
            btnventas.RightToLeft = RightToLeft.Yes;
            btnventas.Size = new Size(160, 37);
            btnventas.TabIndex = 12;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(255, 128, 128);
            btnsalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnsalir.FlatStyle = FlatStyle.Popup;
            btnsalir.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(91, 359);
            btnsalir.Name = "btnsalir";
            btnsalir.RightToLeft = RightToLeft.Yes;
            btnsalir.Size = new Size(160, 37);
            btnsalir.TabIndex = 13;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(797, 451);
            Controls.Add(btnsalir);
            Controls.Add(btnventas);
            Controls.Add(btnhistorial);
            Controls.Add(btnmantenimiento);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbltitulo);
            Controls.Add(btnayuda);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnayuda;
        private Label lbltitulo;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnmantenimiento;
        private Button btnhistorial;
        private Button btnventas;
        private Button btnsalir;
    }
}
