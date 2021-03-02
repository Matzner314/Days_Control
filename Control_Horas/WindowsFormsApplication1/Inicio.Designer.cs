using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Titulo_Inicio = new System.Windows.Forms.Label();
            this.Nombre_txt = new System.Windows.Forms.Label();
            this.Horas_inicio_txt = new System.Windows.Forms.Label();
            this.Cerrar_Inicio = new System.Windows.Forms.Button();
            this.Texto_Nombre = new System.Windows.Forms.Label();
            this.Hours_Text = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo_Inicio
            // 
            this.Titulo_Inicio.AllowDrop = true;
            this.Titulo_Inicio.AutoEllipsis = true;
            resources.ApplyResources(this.Titulo_Inicio, "Titulo_Inicio");
            this.Titulo_Inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titulo_Inicio.Name = "Titulo_Inicio";
            // 
            // Nombre_txt
            // 
            resources.ApplyResources(this.Nombre_txt, "Nombre_txt");
            this.Nombre_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nombre_txt.Name = "Nombre_txt";
            // 
            // Horas_inicio_txt
            // 
            resources.ApplyResources(this.Horas_inicio_txt, "Horas_inicio_txt");
            this.Horas_inicio_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Horas_inicio_txt.Name = "Horas_inicio_txt";
            // 
            // Cerrar_Inicio
            // 
            resources.ApplyResources(this.Cerrar_Inicio, "Cerrar_Inicio");
            this.Cerrar_Inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cerrar_Inicio.Name = "Cerrar_Inicio";
            this.Cerrar_Inicio.UseVisualStyleBackColor = true;
            this.Cerrar_Inicio.Click += new System.EventHandler(this.Cerrar_Inicio1);
            // 
            // Texto_Nombre
            // 
            resources.ApplyResources(this.Texto_Nombre, "Texto_Nombre");
            this.Texto_Nombre.Name = "Texto_Nombre";
            // 
            // Hours_Text
            // 
            resources.ApplyResources(this.Hours_Text, "Hours_Text");
            this.Hours_Text.Name = "Hours_Text";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Captura.PNG");
            this.imageList1.Images.SetKeyName(1, "3.png");
            // 
            // Inicio
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hours_Text);
            this.Controls.Add(this.Texto_Nombre);
            this.Controls.Add(this.Cerrar_Inicio);
            this.Controls.Add(this.Horas_inicio_txt);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.Titulo_Inicio);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Inicio;
        private System.Windows.Forms.Label Nombre_txt;
        private System.Windows.Forms.Label Horas_inicio_txt;
        private System.Windows.Forms.Button Cerrar_Inicio;
        //private System.Windows.Forms.Button Boton_Prueba;
        private System.Windows.Forms.Label Texto_Nombre;
        private System.Windows.Forms.Label Hours_Text;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }


    class Dato
    {
        private String dato;

        public void setDato(String dato)
        {
            this.dato = dato;
        }
        public String getDato()
        {
            return this.dato;
        }
    }
}

