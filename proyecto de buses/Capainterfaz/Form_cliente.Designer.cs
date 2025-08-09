namespace proyecto_de_buses
{
    partial class Form_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cliente));
            lbltitulo = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbldescripcion = new Label();
            lblname = new Label();
            lblid = new Label();
            txtnombre = new TextBox();
            txtcedula = new TextBox();
            btncomprar = new Button();
            btnvolver_clien = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Lavender;
            lbltitulo.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ActiveCaptionText;
            lbltitulo.Location = new Point(12, 32);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(259, 38);
            lbltitulo.TabIndex = 80;
            lbltitulo.Text = "Registro del Cliente";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbldescripcion);
            panel1.Controls.Add(lbltitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 125);
            panel1.TabIndex = 81;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(432, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.BackColor = Color.Lavender;
            lbldescripcion.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldescripcion.ForeColor = SystemColors.ActiveCaptionText;
            lbldescripcion.Location = new Point(12, 70);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(396, 28);
            lbldescripcion.TabIndex = 81;
            lbldescripcion.Text = "Llene los espacios para completar la compra";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblname.ForeColor = SystemColors.ButtonHighlight;
            lblname.Location = new Point(36, 195);
            lblname.Name = "lblname";
            lblname.Size = new Size(183, 28);
            lblname.TabIndex = 83;
            lblname.Text = "Nombre del cliente:";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblid.ForeColor = SystemColors.ButtonHighlight;
            lblid.Location = new Point(36, 269);
            lblid.Name = "lblid";
            lblid.Size = new Size(175, 28);
            lblid.TabIndex = 84;
            lblid.Text = "Cedula del cliente: ";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(225, 199);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(266, 27);
            txtnombre.TabIndex = 85;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(225, 273);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(266, 27);
            txtcedula.TabIndex = 86;
            // 
            // btncomprar
            // 
            btncomprar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btncomprar.BackColor = Color.LightSteelBlue;
            btncomprar.BackgroundImageLayout = ImageLayout.Stretch;
            btncomprar.FlatStyle = FlatStyle.Popup;
            btncomprar.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncomprar.Location = new Point(411, 390);
            btncomprar.Name = "btncomprar";
            btncomprar.RightToLeft = RightToLeft.Yes;
            btncomprar.Size = new Size(121, 42);
            btncomprar.TabIndex = 87;
            btncomprar.Text = "Comprar";
            btncomprar.UseVisualStyleBackColor = false;
            btncomprar.Click += btncomprar_Click;
            // 
            // btnvolver_clien
            // 
            btnvolver_clien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnvolver_clien.BackColor = Color.LightSteelBlue;
            btnvolver_clien.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_clien.FlatStyle = FlatStyle.Popup;
            btnvolver_clien.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_clien.Location = new Point(36, 390);
            btnvolver_clien.Name = "btnvolver_clien";
            btnvolver_clien.RightToLeft = RightToLeft.Yes;
            btnvolver_clien.Size = new Size(121, 42);
            btnvolver_clien.TabIndex = 88;
            btnvolver_clien.Text = "Volver";
            btnvolver_clien.UseVisualStyleBackColor = false;
            btnvolver_clien.Click += btnvolver_clien_Click;
            // 
            // Form_cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(566, 454);
            Controls.Add(btnvolver_clien);
            Controls.Add(btncomprar);
            Controls.Add(txtcedula);
            Controls.Add(txtnombre);
            Controls.Add(lblid);
            Controls.Add(lblname);
            Controls.Add(panel1);
            Name = "Form_cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Panel panel1;
        private Label lbldescripcion;
        private PictureBox pictureBox1;
        private Label lblname;
        private Label lblid;
        private TextBox txtnombre;
        private TextBox txtcedula;
        private Button btncomprar;
        private Button btnvolver_clien;
    }
}