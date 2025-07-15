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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_rutas));
            btnatras = new Button();
            SuspendLayout();
            // 
            // btnatras
            // 
            btnatras.BackColor = Color.Cyan;
            btnatras.Font = new Font("Harlow Solid Italic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnatras.Location = new Point(3, 415);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(75, 23);
            btnatras.TabIndex = 0;
            btnatras.Text = "⏪Atras";
            btnatras.UseVisualStyleBackColor = false;
            // 
            // Form_rutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnatras);
            Name = "Form_rutas";
            Text = "Form_rutas";
            ResumeLayout(false);
        }

        #endregion

        private Button btnatras;
    }
}