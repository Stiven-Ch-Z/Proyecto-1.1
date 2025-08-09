namespace proyecto_de_buses.Capainterfaz
{
    partial class Form_historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_historial));
            btnvolver_hist = new Button();
            dgvhistorial = new DataGridView();
            lbltitulo = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvhistorial).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnvolver_hist
            // 
            btnvolver_hist.BackColor = Color.FromArgb(224, 224, 224);
            btnvolver_hist.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_hist.FlatStyle = FlatStyle.Popup;
            btnvolver_hist.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_hist.Location = new Point(849, 477);
            btnvolver_hist.Name = "btnvolver_hist";
            btnvolver_hist.RightToLeft = RightToLeft.Yes;
            btnvolver_hist.Size = new Size(121, 37);
            btnvolver_hist.TabIndex = 14;
            btnvolver_hist.Text = "Volver";
            btnvolver_hist.UseVisualStyleBackColor = false;
            btnvolver_hist.Click += btnvolver_hist_Click;
            // 
            // dgvhistorial
            // 
            dgvhistorial.BackgroundColor = SystemColors.ActiveCaption;
            dgvhistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhistorial.Location = new Point(48, 136);
            dgvhistorial.Name = "dgvhistorial";
            dgvhistorial.RowHeadersWidth = 51;
            dgvhistorial.Size = new Size(857, 278);
            dgvhistorial.TabIndex = 15;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Lavender;
            lbltitulo.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(34, 18);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(245, 38);
            lbltitulo.TabIndex = 18;
            lbltitulo.Text = "Historial de ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 56);
            label1.Name = "label1";
            label1.Size = new Size(497, 28);
            label1.TabIndex = 19;
            label1.Text = "Aqui se visualizaran las ventas con sus respectivos datos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbltitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 97);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(837, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Form_historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 526);
            Controls.Add(dgvhistorial);
            Controls.Add(btnvolver_hist);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_historial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_historial";
            Load += Form_historial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvhistorial).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnvolver_hist;
        private DataGridView dgvhistorial;
        private Label lbltitulo;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}