namespace proyecto_de_buses.Capainterfaz
{
    partial class Form_rutas
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
            btnvolver_rut = new Button();
            lbltitutorutas = new Label();
            btnanadir = new Button();
            lblinfo = new Label();
            lblnombre = new Label();
            lblprecio = new Label();
            lblhorarios = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // btnvolver_rut
            // 
            btnvolver_rut.BackColor = Color.FromArgb(224, 224, 224);
            btnvolver_rut.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_rut.FlatStyle = FlatStyle.Popup;
            btnvolver_rut.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_rut.Location = new Point(645, 480);
            btnvolver_rut.Name = "btnvolver_rut";
            btnvolver_rut.RightToLeft = RightToLeft.Yes;
            btnvolver_rut.Size = new Size(121, 37);
            btnvolver_rut.TabIndex = 15;
            btnvolver_rut.Text = "Volver";
            btnvolver_rut.UseVisualStyleBackColor = false;
            // 
            // lbltitutorutas
            // 
            lbltitutorutas.AutoSize = true;
            lbltitutorutas.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitutorutas.Location = new Point(237, 9);
            lbltitutorutas.Name = "lbltitutorutas";
            lbltitutorutas.Size = new Size(324, 38);
            lbltitutorutas.TabIndex = 19;
            lbltitutorutas.Text = "Menu de mantenimiento";
            // 
            // btnanadir
            // 
            btnanadir.BackColor = Color.FromArgb(192, 255, 192);
            btnanadir.BackgroundImageLayout = ImageLayout.Stretch;
            btnanadir.FlatStyle = FlatStyle.Popup;
            btnanadir.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnanadir.Location = new Point(63, 480);
            btnanadir.Name = "btnanadir";
            btnanadir.RightToLeft = RightToLeft.Yes;
            btnanadir.Size = new Size(121, 37);
            btnanadir.TabIndex = 20;
            btnanadir.Text = "Añadir";
            btnanadir.UseVisualStyleBackColor = false;
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblinfo.Location = new Point(198, 47);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(404, 28);
            lblinfo.TabIndex = 21;
            lblinfo.Text = "Llene los espacios para añadir una nueva ruta";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(133, 165);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(176, 28);
            lblnombre.TabIndex = 22;
            lblnombre.Text = "Nombre de la ruta:";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprecio.Location = new Point(107, 249);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(202, 28);
            lblprecio.TabIndex = 23;
            lblprecio.Text = "Precio base de la ruta:";
            // 
            // lblhorarios
            // 
            lblhorarios.AutoSize = true;
            lblhorarios.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhorarios.Location = new Point(131, 334);
            lblhorarios.Name = "lblhorarios";
            lblhorarios.Size = new Size(178, 28);
            lblhorarios.TabIndex = 24;
            lblhorarios.Text = "Horarios de la ruta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 27);
            textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(307, 253);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 27);
            textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 338);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(349, 27);
            textBox3.TabIndex = 27;
            // 
            // Form_rutas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 529);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblhorarios);
            Controls.Add(lblprecio);
            Controls.Add(lblnombre);
            Controls.Add(lblinfo);
            Controls.Add(btnanadir);
            Controls.Add(lbltitutorutas);
            Controls.Add(btnvolver_rut);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_rutas";
            Text = "Form_rutas";
            Load += Form_rutas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver_rut;
        private Label lbltitutorutas;
        private Button btnanadir;
        private Label lblinfo;
        private Label lblnombre;
        private Label lblprecio;
        private Label lblhorarios;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}