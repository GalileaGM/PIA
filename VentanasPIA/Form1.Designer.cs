namespace VentanasPIA
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(209, 186);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(209, 222);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(203, 253);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(276, 245);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(146, 286);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 6;
            label4.Text = "Confirmar Password:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(276, 283);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 23);
            textBox4.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(224, 323);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(261, 364);
            button1.Name = "button1";
            button1.Size = new Size(113, 43);
            button1.TabIndex = 9;
            button1.Text = "Sing up";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoBolegrama;
            pictureBox1.Location = new Point(180, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logoBolegrama;
            pictureBox2.Location = new Point(246, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(157, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(283, 147);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "REGISTRATE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(682, 450);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.GradientActiveCaption;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
    }
}
