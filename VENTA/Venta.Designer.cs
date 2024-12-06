namespace puntoDVenta
{
    partial class Venta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 43);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "CLAVE EMPLEADO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 38);
            label2.Name = "label2";
            label2.Size = new Size(379, 50);
            label2.TabIndex = 1;
            label2.Text = "DETALLES DE VENTA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 74);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "NUM. ORDEN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 100);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "FECHA :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 245);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "TOTAL :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(49, 32);
            button1.Name = "button1";
            button1.Size = new Size(146, 56);
            button1.TabIndex = 5;
            button1.Text = "MENÚ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(56, 229);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "ELIMINAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(251, 229);
            button3.Name = "button3";
            button3.Size = new Size(123, 29);
            button3.TabIndex = 10;
            button3.Text = "ACEPTAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 548);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 43);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(219, 74);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 13;
            label7.Text = "label7";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 100);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(909, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 321);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 284);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 19;
            label12.Click += label12_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 27);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(56, 182);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 17;
            label10.Text = "CANTIDAD:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 27);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(56, 138);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 15;
            label9.Text = "ID PRODUCTO:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(914, 352);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(433, 323);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(100, 279);
            button4.Name = "button4";
            button4.Size = new Size(181, 29);
            button4.TabIndex = 11;
            button4.Text = "CONFIRMAR ORDEN";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(119, 245);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 6;
            label11.Click += label11_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(51, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 724);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Venta";
            Text = "Venta";
            Load += Venta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox1;
        private Label label9;
        private PictureBox pictureBox1;
        private Label label11;
        private Button button4;
        private Label label12;
    }
}