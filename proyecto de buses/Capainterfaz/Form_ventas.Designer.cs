namespace proyecto_de_buses.Capainterfaz
{
    partial class Form_ventas
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
            btnvolver_ventas = new Button();
            SuspendLayout();
            // 
            // btnvolver_ventas
            // 
            btnvolver_ventas.BackColor = Color.FromArgb(224, 224, 224);
            btnvolver_ventas.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_ventas.FlatStyle = FlatStyle.Popup;
            btnvolver_ventas.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_ventas.Location = new Point(24, 551);
            btnvolver_ventas.Name = "btnvolver_ventas";
            btnvolver_ventas.RightToLeft = RightToLeft.Yes;
            btnvolver_ventas.Size = new Size(160, 37);
            btnvolver_ventas.TabIndex = 14;
            btnvolver_ventas.Text = "Volver";
            btnvolver_ventas.UseVisualStyleBackColor = false;
            // 
            // Form_ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(btnvolver_ventas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_ventas";
            Text = "Form_ventas";
            ResumeLayout(false);
        }

        #endregion

        private Button btnvolver_ventas;
    }
}