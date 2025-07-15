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
            btnhistorial = new Button();
            btnayuda = new Button();
            btnrutas = new Button();
            btnventas = new Button();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // btnhistorial
            // 
            btnhistorial.BackColor = Color.Cyan;
            btnhistorial.Font = new Font("Harlow Solid Italic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnhistorial.Location = new Point(12, 11);
            btnhistorial.Margin = new Padding(3, 2, 3, 2);
            btnhistorial.Name = "btnhistorial";
            btnhistorial.Size = new Size(82, 22);
            btnhistorial.TabIndex = 0;
            btnhistorial.Text = "Historial";
            btnhistorial.UseVisualStyleBackColor = false;
            // 
            // btnayuda
            // 
            btnayuda.BackColor = Color.Cyan;
            btnayuda.Font = new Font("Harlow Solid Italic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnayuda.Location = new Point(12, 66);
            btnayuda.Margin = new Padding(3, 2, 3, 2);
            btnayuda.Name = "btnayuda";
            btnayuda.Size = new Size(82, 22);
            btnayuda.TabIndex = 1;
            btnayuda.Text = "Ayuda";
            btnayuda.UseVisualStyleBackColor = false;
            // 
            // btnrutas
            // 
            btnrutas.BackColor = Color.Cyan;
            btnrutas.Font = new Font("Harlow Solid Italic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnrutas.Location = new Point(12, 233);
            btnrutas.Margin = new Padding(3, 2, 3, 2);
            btnrutas.Name = "btnrutas";
            btnrutas.Size = new Size(82, 22);
            btnrutas.TabIndex = 2;
            btnrutas.Text = "Rutas";
            btnrutas.UseVisualStyleBackColor = false;
            // 
            // btnventas
            // 
            btnventas.BackColor = Color.Cyan;
            btnventas.Font = new Font("Harlow Solid Italic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnventas.Location = new Point(12, 305);
            btnventas.Margin = new Padding(3, 2, 3, 2);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(82, 22);
            btnventas.TabIndex = 3;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.Red;
            btnsalir.Font = new Font("Harlow Solid Italic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(606, 305);
            btnsalir.Margin = new Padding(3, 2, 3, 2);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(82, 22);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btnsalir);
            Controls.Add(btnventas);
            Controls.Add(btnrutas);
            Controls.Add(btnayuda);
            Controls.Add(btnhistorial);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnhistorial;
        private Button btnayuda;
        private Button btnrutas;
        private Button btnventas;
        private Button btnsalir;
    }
}
