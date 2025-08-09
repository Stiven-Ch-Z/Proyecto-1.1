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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnacerca = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnvolver_ayu
            // 
            btnvolver_ayu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnvolver_ayu.BackColor = Color.MediumPurple;
            btnvolver_ayu.BackgroundImageLayout = ImageLayout.Stretch;
            btnvolver_ayu.FlatStyle = FlatStyle.Popup;
            btnvolver_ayu.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnvolver_ayu.Location = new Point(787, 489);
            btnvolver_ayu.Margin = new Padding(3, 2, 3, 2);
            btnvolver_ayu.Name = "btnvolver_ayu";
            btnvolver_ayu.RightToLeft = RightToLeft.Yes;
            btnvolver_ayu.Size = new Size(75, 26);
            btnvolver_ayu.TabIndex = 13;
            btnvolver_ayu.Text = "Volver";
            btnvolver_ayu.UseVisualStyleBackColor = false;
            btnvolver_ayu.Click += btnvolver_ayu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-1, 417);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(152, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, -2);
            label1.Name = "label1";
            label1.Size = new Size(278, 21);
            label1.TabIndex = 22;
            label1.Text = "Bienvenido a la seccion de ayuda📌";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 71);
            label2.Name = "label2";
            label2.Size = new Size(433, 105);
            label2.TabIndex = 23;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(168, 219);
            label3.Name = "label3";
            label3.Size = new Size(493, 60);
            label3.TabIndex = 24;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(180, 417);
            label4.Name = "label4";
            label4.Size = new Size(425, 90);
            label4.TabIndex = 25;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 43);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 26;
            label5.Text = "Mantenimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 180);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 27;
            label6.Text = "Historial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 382);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 28;
            label7.Text = "Ventas";
            // 
            // btnacerca
            // 
            btnacerca.BackColor = Color.MediumSlateBlue;
            btnacerca.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnacerca.Location = new Point(787, 430);
            btnacerca.Name = "btnacerca";
            btnacerca.Size = new Size(75, 34);
            btnacerca.TabIndex = 29;
            btnacerca.Text = "Acerca de";
            btnacerca.UseVisualStyleBackColor = false;
            btnacerca.Click += btnacerca_Click;
            // 
            // Form_ayuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Thistle;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 524);
            Controls.Add(btnacerca);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnvolver_ayu);
            Name = "Form_ayuda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_ayuda";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnacerca;
    }
}