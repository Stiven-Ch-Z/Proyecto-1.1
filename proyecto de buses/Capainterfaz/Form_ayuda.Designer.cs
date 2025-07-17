namespace proyecto_de_buses.Capainterfaz
{
    partial class Form_ayuda
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
            btnvolver_ayu = new Button();
            btnacerca = new Button();
            btnverayuda = new Button();
            lbltitulo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnvolver_ayu
            // 
            btnvolver_ayu.BackColor = Color.FromArgb(224, 224, 224);
            btnvolver_ayu.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_ayu.FlatStyle = FlatStyle.Popup;
            btnvolver_ayu.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_ayu.Location = new Point(171, 278);
            btnvolver_ayu.Margin = new Padding(3, 2, 3, 2);
            btnvolver_ayu.Name = "btnvolver_ayu";
            btnvolver_ayu.RightToLeft = RightToLeft.Yes;
            btnvolver_ayu.Size = new Size(140, 28);
            btnvolver_ayu.TabIndex = 13;
            btnvolver_ayu.Text = "Volver";
            btnvolver_ayu.UseVisualStyleBackColor = false;
            btnvolver_ayu.Click += btnvolver_ayu_Click;
            // 
            // btnacerca
            // 
            btnacerca.BackColor = Color.FromArgb(192, 255, 192);
            btnacerca.BackgroundImageLayout = ImageLayout.Stretch;
            btnacerca.FlatStyle = FlatStyle.Popup;
            btnacerca.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnacerca.Location = new Point(171, 160);
            btnacerca.Margin = new Padding(3, 2, 3, 2);
            btnacerca.Name = "btnacerca";
            btnacerca.RightToLeft = RightToLeft.Yes;
            btnacerca.Size = new Size(140, 28);
            btnacerca.TabIndex = 14;
            btnacerca.Text = "Acerca de";
            btnacerca.UseVisualStyleBackColor = false;
            btnacerca.Click += btnacerca_Click;
            // 
            // btnverayuda
            // 
            btnverayuda.BackColor = Color.FromArgb(192, 255, 192);
            btnverayuda.BackgroundImageLayout = ImageLayout.Stretch;
            btnverayuda.FlatStyle = FlatStyle.Popup;
            btnverayuda.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnverayuda.Location = new Point(171, 104);
            btnverayuda.Margin = new Padding(3, 2, 3, 2);
            btnverayuda.Name = "btnverayuda";
            btnverayuda.RightToLeft = RightToLeft.Yes;
            btnverayuda.Size = new Size(140, 28);
            btnverayuda.TabIndex = 15;
            btnverayuda.Text = "Ver ayuda";
            btnverayuda.UseVisualStyleBackColor = false;
            btnverayuda.Click += btnverayuda_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(151, 7);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(167, 30);
            lbltitulo.TabIndex = 17;
            lbltitulo.Text = "Menu de Ayuda";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 35);
            label1.Name = "label1";
            label1.Size = new Size(230, 21);
            label1.TabIndex = 18;
            label1.Text = "Por favor seleccione una opcion";
            // 
            // Form_ayuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(498, 321);
            Controls.Add(label1);
            Controls.Add(lbltitulo);
            Controls.Add(btnverayuda);
            Controls.Add(btnacerca);
            Controls.Add(btnvolver_ayu);
            Name = "Form_ayuda";
            Text = "Form_ayuda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver_ayu;
        private Button btnacerca;
        private Button btnverayuda;
        private Label lbltitulo;
        private Label label1;
    }
}