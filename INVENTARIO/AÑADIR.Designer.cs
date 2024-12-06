namespace puntoDVenta.CATEGORIAS
{
    partial class AÑADIR
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 64, 0);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(119, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL PRODUCTO";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 329);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(28, 361);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(201, 361);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "HECHO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 271);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 11;
            label6.Text = "ID CATEGORIA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 238);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 10;
            label5.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 205);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "STOCK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 113);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 8;
            label3.Text = "DESCRIPCIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 77);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 7;
            label2.Text = "NOMBRE";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(127, 271);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(188, 27);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 27);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 27);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 110);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 89);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fondoAñadir;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 598);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AÑADIR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 588);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "AÑADIR";
            Text = "AÑADIR";
            Load += AÑADIR_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label7;
    }
}