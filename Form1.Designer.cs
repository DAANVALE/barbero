using System.Diagnostics;
using System.Drawing;

namespace barbero
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.agrBarbero = new System.Windows.Forms.Button();
            this.imgBarbero = new System.Windows.Forms.ImageList(this.components);
            this.agrCliente = new System.Windows.Forms.Button();
            this.borrarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agrBarbero
            // 
            this.agrBarbero.Location = new System.Drawing.Point(507, 52);
            this.agrBarbero.Name = "agrBarbero";
            this.agrBarbero.Size = new System.Drawing.Size(140, 35);
            this.agrBarbero.TabIndex = 0;
            this.agrBarbero.Text = "agregar barbero";
            this.agrBarbero.UseVisualStyleBackColor = true;
            this.agrBarbero.Click += new System.EventHandler(this.agrBarbero_Click);
            // 
            // imgBarbero
            // 
            this.imgBarbero.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgBarbero.ImageSize = new System.Drawing.Size(16, 16);
            this.imgBarbero.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // agrCliente
            // 
            this.agrCliente.Location = new System.Drawing.Point(507, 109);
            this.agrCliente.Name = "agrCliente";
            this.agrCliente.Size = new System.Drawing.Size(140, 35);
            this.agrCliente.TabIndex = 1;
            this.agrCliente.Text = "agregar cliente";
            this.agrCliente.UseVisualStyleBackColor = true;
            this.agrCliente.Click += new System.EventHandler(this.agreCliente_Click);
            // 
            // borrarCliente
            // 
            this.borrarCliente.Location = new System.Drawing.Point(507, 168);
            this.borrarCliente.Name = "borrarCliente";
            this.borrarCliente.Size = new System.Drawing.Size(140, 35);
            this.borrarCliente.TabIndex = 2;
            this.borrarCliente.Text = "eliminar  cliente";
            this.borrarCliente.UseVisualStyleBackColor = true;
            this.borrarCliente.Click += new System.EventHandler(this.borrarCliente_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.borrarCliente);
            this.Controls.Add(this.agrCliente);
            this.Controls.Add(this.agrBarbero);
            this.Name = "Form1";
            this.Text = "Barberia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgBarbero;
        private System.Windows.Forms.Button agrBarbero;
        private System.Windows.Forms.Button agrCliente;
        private System.Windows.Forms.Button borrarCliente;
    }
}

