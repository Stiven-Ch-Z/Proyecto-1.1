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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnayuda = new Button();
            lbltitulo = new Label();
            label1 = new Label();
            btnmantenimiento = new Button();
            btnhistorial = new Button();
            btnventas = new Button();
            btnsalir = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnayuda
            // 
            btnayuda.BackColor = Color.LightSteelBlue;
            btnayuda.BackgroundImageLayout = ImageLayout.Stretch;
            btnayuda.FlatStyle = FlatStyle.Popup;
            btnayuda.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnayuda.ForeColor = SystemColors.ActiveCaptionText;
            btnayuda.Location = new Point(559, 67);
            btnayuda.Name = "btnayuda";
            btnayuda.RightToLeft = RightToLeft.Yes;
            btnayuda.Size = new Size(134, 37);
            btnayuda.TabIndex = 1;
            btnayuda.Text = "Ayuda";
            btnayuda.UseVisualStyleBackColor = false;
            btnayuda.Click += btnayuda_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.FromArgb(64, 0, 0);
            lbltitulo.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ControlLightLight;
            lbltitulo.Location = new Point(56, 241);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(704, 38);
            lbltitulo.TabIndex = 7;
            lbltitulo.Text = "Bienvenido al gestor de la empresa Gran Central Sabalo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(39, 279);
            label1.Name = "label1";
            label1.Size = new Size(741, 28);
            label1.TabIndex = 9;
            label1.Text = "Por favor seleccione una de las opciones que se encuentran en los botones de arriba";
            label1.Click += label1_Click;
            // 
            // btnmantenimiento
            // 
            btnmantenimiento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnmantenimiento.BackColor = Color.LightSteelBlue;
            btnmantenimiento.BackgroundImageLayout = ImageLayout.Stretch;
            btnmantenimiento.FlatStyle = FlatStyle.Popup;
            btnmantenimiento.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmantenimiento.ForeColor = SystemColors.ActiveCaptionText;
            btnmantenimiento.Location = new Point(292, 24);
            btnmantenimiento.Name = "btnmantenimiento";
            btnmantenimiento.RightToLeft = RightToLeft.Yes;
            btnmantenimiento.Size = new Size(156, 37);
            btnmantenimiento.TabIndex = 10;
            btnmantenimiento.Text = "Mantenimiento";
            btnmantenimiento.UseVisualStyleBackColor = false;
            btnmantenimiento.Click += btnmantenimiento_Click;
            // 
            // btnhistorial
            // 
            btnhistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnhistorial.BackColor = Color.LightSteelBlue;
            btnhistorial.BackgroundImageLayout = ImageLayout.None;
            btnhistorial.FlatStyle = FlatStyle.Popup;
            btnhistorial.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnhistorial.ForeColor = SystemColors.ActiveCaptionText;
            btnhistorial.Location = new Point(635, 24);
            btnhistorial.Name = "btnhistorial";
            btnhistorial.RightToLeft = RightToLeft.Yes;
            btnhistorial.Size = new Size(145, 37);
            btnhistorial.TabIndex = 11;
            btnhistorial.Text = "Historial";
            btnhistorial.UseVisualStyleBackColor = false;
            btnhistorial.Click += btnhistorial_Click;
            // 
            // btnventas
            // 
            btnventas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnventas.BackColor = Color.LightSteelBlue;
            btnventas.BackgroundImageLayout = ImageLayout.Stretch;
            btnventas.FlatStyle = FlatStyle.Popup;
            btnventas.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnventas.ForeColor = SystemColors.ActiveCaptionText;
            btnventas.Location = new Point(468, 24);
            btnventas.Name = "btnventas";
            btnventas.RightToLeft = RightToLeft.Yes;
            btnventas.Size = new Size(141, 37);
            btnventas.TabIndex = 12;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            btnventas.Click += btnventas_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.LightSteelBlue;
            btnsalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnsalir.FlatStyle = FlatStyle.Popup;
            btnsalir.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = SystemColors.ActiveCaptionText;
            btnsalir.Location = new Point(372, 67);
            btnsalir.Name = "btnsalir";
            btnsalir.RightToLeft = RightToLeft.Yes;
            btnsalir.Size = new Size(141, 38);
            btnsalir.TabIndex = 13;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(btnventas);
            panel1.Controls.Add(btnayuda);
            panel1.Controls.Add(btnsalir);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnhistorial);
            panel1.Controls.Add(btnmantenimiento);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 140);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 16);
            panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Lavender;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Navy;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 142);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(797, 314);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(797, 451);
            Controls.Add(label1);
            Controls.Add(lbltitulo);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnayuda;
        private Label lbltitulo;
        private Label label1;
        private Button btnmantenimiento;
        private Button btnhistorial;
        private Button btnventas;
        private Button btnsalir;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
