﻿namespace Probabilidad.Forms
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProbabilidadtextBox = new System.Windows.Forms.TextBox();
            this.Tirarbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.Mensajelabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa un número.";
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(13, 56);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(110, 23);
            this.NumerotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Probabilidad.";
            // 
            // ProbabilidadtextBox
            // 
            this.ProbabilidadtextBox.Location = new System.Drawing.Point(13, 127);
            this.ProbabilidadtextBox.Name = "ProbabilidadtextBox";
            this.ProbabilidadtextBox.Size = new System.Drawing.Size(110, 23);
            this.ProbabilidadtextBox.TabIndex = 3;
            // 
            // Tirarbutton
            // 
            this.Tirarbutton.Location = new System.Drawing.Point(121, 172);
            this.Tirarbutton.Name = "Tirarbutton";
            this.Tirarbutton.Size = new System.Drawing.Size(75, 23);
            this.Tirarbutton.TabIndex = 4;
            this.Tirarbutton.Text = "Tirar";
            this.Tirarbutton.UseVisualStyleBackColor = true;
            this.Tirarbutton.Click += new System.EventHandler(this.Tirarbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(356, 221);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(227, 172);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(75, 23);
            this.Limpiarbutton.TabIndex = 6;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(13, 172);
            this.CalcularButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(82, 22);
            this.CalcularButton.TabIndex = 7;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Mensajelabel3
            // 
            this.Mensajelabel3.AutoSize = true;
            this.Mensajelabel3.Location = new System.Drawing.Point(136, 56);
            this.Mensajelabel3.Name = "Mensajelabel3";
            this.Mensajelabel3.Size = new System.Drawing.Size(0, 15);
            this.Mensajelabel3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 238);
            this.Controls.Add(this.Mensajelabel3);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Tirarbutton);
            this.Controls.Add(this.ProbabilidadtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProbabilidadtextBox;
        private System.Windows.Forms.Button Tirarbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label Mensajelabel3;
    }
}

