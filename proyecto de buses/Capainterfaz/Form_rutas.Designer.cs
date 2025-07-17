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
            txtrutas = new TextBox();
            txtprecio = new TextBox();
            txthorarios = new TextBox();
            SuspendLayout();
            // 
            // btnvolver_rut
            // 
            btnvolver_rut.BackColor = Color.FromArgb(224, 224, 224);
            btnvolver_rut.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_rut.FlatStyle = FlatStyle.Popup;
            btnvolver_rut.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_rut.Location = new Point(564, 360);
            btnvolver_rut.Margin = new Padding(3, 2, 3, 2);
            btnvolver_rut.Name = "btnvolver_rut";
            btnvolver_rut.RightToLeft = RightToLeft.Yes;
            btnvolver_rut.Size = new Size(106, 28);
            btnvolver_rut.TabIndex = 15;
            btnvolver_rut.Text = "Volver";
            btnvolver_rut.UseVisualStyleBackColor = false;
            btnvolver_rut.Click += btnvolver_rut_Click;
            // 
            // lbltitutorutas
            // 
            lbltitutorutas.AutoSize = true;
            lbltitutorutas.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitutorutas.Location = new Point(207, 7);
            lbltitutorutas.Name = "lbltitutorutas";
            lbltitutorutas.Size = new Size(252, 30);
            lbltitutorutas.TabIndex = 19;
            lbltitutorutas.Text = "Menu de mantenimiento";
            // 
            // btnanadir
            // 
            btnanadir.BackColor = Color.FromArgb(192, 255, 192);
            btnanadir.BackgroundImageLayout = ImageLayout.Stretch;
            btnanadir.FlatStyle = FlatStyle.Popup;
            btnanadir.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnanadir.Location = new Point(55, 360);
            btnanadir.Margin = new Padding(3, 2, 3, 2);
            btnanadir.Name = "btnanadir";
            btnanadir.RightToLeft = RightToLeft.Yes;
            btnanadir.Size = new Size(106, 28);
            btnanadir.TabIndex = 20;
            btnanadir.Text = "Añadir";
            btnanadir.UseVisualStyleBackColor = false;
            btnanadir.Click += btnanadir_Click;
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblinfo.Location = new Point(173, 35);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(325, 21);
            lblinfo.TabIndex = 21;
            lblinfo.Text = "Llene los espacios para añadir una nueva ruta";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(116, 124);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(140, 21);
            lblnombre.TabIndex = 22;
            lblnombre.Text = "Nombre de la ruta:";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprecio.Location = new Point(94, 187);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(161, 21);
            lblprecio.TabIndex = 23;
            lblprecio.Text = "Precio base de la ruta:";
            // 
            // lblhorarios
            // 
            lblhorarios.AutoSize = true;
            lblhorarios.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhorarios.Location = new Point(115, 250);
            lblhorarios.Name = "lblhorarios";
            lblhorarios.Size = new Size(142, 21);
            lblhorarios.TabIndex = 24;
            lblhorarios.Text = "Horarios de la ruta:";
            // 
            // txtrutas
            // 
            txtrutas.Location = new Point(269, 127);
            txtrutas.Margin = new Padding(3, 2, 3, 2);
            txtrutas.Name = "txtrutas";
            txtrutas.Size = new Size(306, 23);
            txtrutas.TabIndex = 25;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(269, 190);
            txtprecio.Margin = new Padding(3, 2, 3, 2);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(306, 23);
            txtprecio.TabIndex = 26;
            // 
            // txthorarios
            // 
            txthorarios.Location = new Point(269, 254);
            txthorarios.Margin = new Padding(3, 2, 3, 2);
            txthorarios.Name = "txthorarios";
            txthorarios.Size = new Size(306, 23);
            txthorarios.TabIndex = 27;
            // 
            // Form_rutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 397);
            Controls.Add(txthorarios);
            Controls.Add(txtprecio);
            Controls.Add(txtrutas);
            Controls.Add(lblhorarios);
            Controls.Add(lblprecio);
            Controls.Add(lblnombre);
            Controls.Add(lblinfo);
            Controls.Add(btnanadir);
            Controls.Add(lbltitutorutas);
            Controls.Add(btnvolver_rut);
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
        private TextBox txtrutas;
        private TextBox txtprecio;
        private TextBox txthorarios;
    }
}