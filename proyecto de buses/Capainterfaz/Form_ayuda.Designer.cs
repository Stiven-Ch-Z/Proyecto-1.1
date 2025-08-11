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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ayuda));
            btnvolver_ayu = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnacerca = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnvolver_ayu
            // 
            btnvolver_ayu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnvolver_ayu.BackColor = Color.LightSteelBlue;
            btnvolver_ayu.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_ayu.FlatStyle = FlatStyle.Popup;
            btnvolver_ayu.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_ayu.Location = new Point(22, 39);
            btnvolver_ayu.Name = "btnvolver_ayu";
            btnvolver_ayu.RightToLeft = RightToLeft.Yes;
            btnvolver_ayu.Size = new Size(193, 45);
            btnvolver_ayu.TabIndex = 13;
            btnvolver_ayu.Text = "Volver";
            btnvolver_ayu.UseVisualStyleBackColor = false;
            btnvolver_ayu.Click += btnvolver_ayu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 124);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 321);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 514);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(266, 194);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Historic", 16.2F);
            label1.Location = new Point(432, 20);
            label1.Name = "label1";
            label1.Size = new Size(243, 85);
            label1.TabIndex = 22;
            label1.Text = "Seccion de Ayuda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(282, 124);
            label2.Name = "label2";
            label2.Size = new Size(810, 161);
            label2.TabIndex = 23;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 10.2F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(295, 345);
            label3.Name = "label3";
            label3.Size = new Size(733, 92);
            label3.TabIndex = 24;
            label3.Text = resources.GetString("label3.Text");
            // 
            // btnacerca
            // 
            btnacerca.BackColor = Color.LightSteelBlue;
            btnacerca.FlatStyle = FlatStyle.Popup;
            btnacerca.Font = new Font("Segoe UI Historic", 12F);
            btnacerca.Location = new Point(878, 39);
            btnacerca.Margin = new Padding(3, 4, 3, 4);
            btnacerca.Name = "btnacerca";
            btnacerca.Size = new Size(193, 45);
            btnacerca.TabIndex = 29;
            btnacerca.Text = "Acerca de";
            btnacerca.UseVisualStyleBackColor = false;
            btnacerca.Click += btnacerca_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(btnacerca);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnvolver_ayu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 105);
            panel1.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(282, 56);
            label5.Name = "label5";
            label5.Size = new Size(536, 28);
            label5.TabIndex = 81;
            label5.Text = "Aqui podra entender mejor el funcionamiento del programa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Historic", 10.2F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(295, 524);
            label6.Name = "label6";
            label6.Size = new Size(766, 184);
            label6.TabIndex = 31;
            label6.Text = resources.GetString("label6.Text");
            // 
            // Form_ayuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SlateBlue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1093, 745);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_ayuda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ayuda";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver_ayu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnacerca;
        private Panel panel1;
        private Label label5;
        private Label label6;
    }
}