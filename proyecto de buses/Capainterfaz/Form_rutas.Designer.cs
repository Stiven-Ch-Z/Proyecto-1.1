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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_rutas));
            btnvolver_rut = new Button();
            lbltitutorutas = new Label();
            btnanadir = new Button();
            lblinfo = new Label();
            lblnombre = new Label();
            lblprecio = new Label();
            lblhorariosalida = new Label();
            txtrutas = new TextBox();
            txtprecio = new TextBox();
            cbohorasalida = new ComboBox();
            errorProviderRutas = new ErrorProvider(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblhorarios = new Label();
            cbohorallegada = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProviderRutas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnvolver_rut
            // 
            btnvolver_rut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnvolver_rut.BackColor = Color.LightSteelBlue;
            btnvolver_rut.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_rut.FlatStyle = FlatStyle.Popup;
            btnvolver_rut.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_rut.Location = new Point(668, 425);
            btnvolver_rut.Name = "btnvolver_rut";
            btnvolver_rut.RightToLeft = RightToLeft.Yes;
            btnvolver_rut.Size = new Size(159, 50);
            btnvolver_rut.TabIndex = 15;
            btnvolver_rut.Text = "Volver";
            btnvolver_rut.UseVisualStyleBackColor = false;
            btnvolver_rut.Click += btnvolver_rut_Click;
            // 
            // lbltitutorutas
            // 
            lbltitutorutas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbltitutorutas.AutoSize = true;
            lbltitutorutas.BackColor = Color.Lavender;
            lbltitutorutas.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitutorutas.ForeColor = SystemColors.ActiveCaptionText;
            lbltitutorutas.Location = new Point(81, 9);
            lbltitutorutas.Name = "lbltitutorutas";
            lbltitutorutas.Size = new Size(324, 38);
            lbltitutorutas.TabIndex = 19;
            lbltitutorutas.Text = "Menu de mantenimiento";
            // 
            // btnanadir
            // 
            btnanadir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnanadir.BackColor = Color.LightSteelBlue;
            btnanadir.BackgroundImageLayout = ImageLayout.Stretch;
            btnanadir.FlatStyle = FlatStyle.Popup;
            btnanadir.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnanadir.Location = new Point(50, 425);
            btnanadir.Name = "btnanadir";
            btnanadir.RightToLeft = RightToLeft.Yes;
            btnanadir.Size = new Size(159, 50);
            btnanadir.TabIndex = 20;
            btnanadir.Text = "Añadir";
            btnanadir.UseVisualStyleBackColor = false;
            btnanadir.Click += btnanadir_Click;
            // 
            // lblinfo
            // 
            lblinfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblinfo.AutoSize = true;
            lblinfo.BackColor = Color.Lavender;
            lblinfo.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblinfo.ForeColor = SystemColors.ActiveCaptionText;
            lblinfo.Location = new Point(81, 47);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(404, 28);
            lblinfo.TabIndex = 21;
            lblinfo.Text = "Llene los espacios para añadir una nueva ruta";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnombre.ForeColor = SystemColors.ControlLightLight;
            lblnombre.Location = new Point(30, 137);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(176, 28);
            lblnombre.TabIndex = 22;
            lblnombre.Text = "Nombre de la ruta:";
            // 
            // lblprecio
            // 
            lblprecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblprecio.AutoSize = true;
            lblprecio.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprecio.ForeColor = SystemColors.ControlLightLight;
            lblprecio.Location = new Point(30, 199);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(202, 28);
            lblprecio.TabIndex = 23;
            lblprecio.Text = "Precio base de la ruta:";
            // 
            // lblhorariosalida
            // 
            lblhorariosalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblhorariosalida.AutoSize = true;
            lblhorariosalida.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhorariosalida.ForeColor = SystemColors.ControlLightLight;
            lblhorariosalida.Location = new Point(30, 266);
            lblhorariosalida.Name = "lblhorariosalida";
            lblhorariosalida.Size = new Size(141, 28);
            lblhorariosalida.TabIndex = 24;
            lblhorariosalida.Text = "Hora de salida:";
            // 
            // txtrutas
            // 
            txtrutas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtrutas.Location = new Point(262, 138);
            txtrutas.Name = "txtrutas";
            txtrutas.Size = new Size(443, 27);
            txtrutas.TabIndex = 25;
            // 
            // txtprecio
            // 
            txtprecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtprecio.Location = new Point(262, 203);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(443, 27);
            txtprecio.TabIndex = 26;
            // 
            // cbohorasalida
            // 
            cbohorasalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbohorasalida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbohorasalida.FormattingEnabled = true;
            cbohorasalida.Items.AddRange(new object[] { "06:00 AM", "08:30 AM", "10:00 AM", "12:30 PM", "02:00 PM", "04:30PM", "06:00 PM", "08:30 PM" });
            cbohorasalida.Location = new Point(262, 270);
            cbohorasalida.Name = "cbohorasalida";
            cbohorasalida.Size = new Size(443, 28);
            cbohorasalida.TabIndex = 27;
            // 
            // errorProviderRutas
            // 
            errorProviderRutas.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbltitutorutas);
            panel1.Controls.Add(lblinfo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 95);
            panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(668, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // lblhorarios
            // 
            lblhorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblhorarios.AutoSize = true;
            lblhorarios.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhorarios.ForeColor = SystemColors.ControlLightLight;
            lblhorarios.Location = new Point(30, 331);
            lblhorarios.Name = "lblhorarios";
            lblhorarios.Size = new Size(155, 28);
            lblhorarios.TabIndex = 29;
            lblhorarios.Text = "Hora de llegada:";
            // 
            // cbohorallegada
            // 
            cbohorallegada.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbohorallegada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbohorallegada.FormattingEnabled = true;
            cbohorallegada.Items.AddRange(new object[] { "06:30 AM", "09:00AM", "10:30 AM", "01:00 PM", "02:30 PM", "05:00PM", "06:30 PM", "09:00 PM" });
            cbohorallegada.Location = new Point(262, 331);
            cbohorallegada.Name = "cbohorallegada";
            cbohorallegada.Size = new Size(443, 28);
            cbohorallegada.TabIndex = 30;
            // 
            // Form_rutas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(865, 490);
            Controls.Add(cbohorallegada);
            Controls.Add(lblhorarios);
            Controls.Add(cbohorasalida);
            Controls.Add(txtprecio);
            Controls.Add(txtrutas);
            Controls.Add(lblhorariosalida);
            Controls.Add(lblprecio);
            Controls.Add(lblnombre);
            Controls.Add(btnanadir);
            Controls.Add(btnvolver_rut);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_rutas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Rutas";
            Load += Form_rutas_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderRutas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblhorariosalida;
        private TextBox txtrutas;
        private TextBox txtprecio;
        private ComboBox cbohorasalida;
        private ErrorProvider errorProviderRutas;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblhorarios;
        private ComboBox cbohorallegada;
    }
}