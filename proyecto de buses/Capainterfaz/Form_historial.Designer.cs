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
            btnvolver_hist = new Button();
            dataGridView1 = new DataGridView();
            lbltitulo = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(857, 318);
            dataGridView1.TabIndex = 15;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(48, 18);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(245, 38);
            lbltitulo.TabIndex = 18;
            lbltitulo.Text = "Historial de ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 56);
            label1.Name = "label1";
            label1.Size = new Size(271, 28);
            label1.TabIndex = 19;
            label1.Text = "Aqui se visualizaran las ventas";
            // 
            // Form_historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 526);
            Controls.Add(label1);
            Controls.Add(lbltitulo);
            Controls.Add(dataGridView1);
            Controls.Add(btnvolver_hist);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_historial";
            Text = "Form_historial";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver_hist;
        private DataGridView dataGridView1;
        private Label lbltitulo;
        private Label label1;
    }
}