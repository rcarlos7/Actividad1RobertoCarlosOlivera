﻿namespace Actividad1.VISTA.ComputadoraVistas
{
    partial class ComputadoraInsertarVista
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
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(384, 335);
            button2.Name = "button2";
            button2.Size = new Size(123, 56);
            button2.TabIndex = 19;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(214, 335);
            button1.Name = "button1";
            button1.Size = new Size(123, 56);
            button1.TabIndex = 18;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(361, 247);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 184);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(361, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(361, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 27);
            textBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 254);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 13;
            label4.Text = "FECHA DE FABRICACION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 191);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 12;
            label3.Text = "PRECIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 128);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 11;
            label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 65);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 10;
            label1.Text = "NOMBRE";
            // 
            // ComputadoraInsertarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ComputadoraInsertarVista";
            Text = "ComputadoraInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}