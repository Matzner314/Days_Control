namespace WindowsFormsApplication1
{
    partial class Notificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificacion));
            this.Boton_cerrar_notif = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Titulo_notif = new System.Windows.Forms.Label();
            this.Hrs_Notif_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boton_cerrar_notif
            // 
            this.Boton_cerrar_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_cerrar_notif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Boton_cerrar_notif.Location = new System.Drawing.Point(176, 122);
            this.Boton_cerrar_notif.Name = "Boton_cerrar_notif";
            this.Boton_cerrar_notif.Size = new System.Drawing.Size(109, 39);
            this.Boton_cerrar_notif.TabIndex = 0;
            this.Boton_cerrar_notif.Text = "Cerrar";
            this.Boton_cerrar_notif.UseVisualStyleBackColor = true;
            this.Boton_cerrar_notif.Click += new System.EventHandler(this.Boton_cerrar_notif1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Titulo_notif
            // 
            this.Titulo_notif.AutoSize = true;
            this.Titulo_notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_notif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Titulo_notif.Location = new System.Drawing.Point(122, 21);
            this.Titulo_notif.Name = "Titulo_notif";
            this.Titulo_notif.Size = new System.Drawing.Size(211, 29);
            this.Titulo_notif.TabIndex = 1;
            this.Titulo_notif.Text = "¡Exceso De Días!";
            this.Titulo_notif.Click += new System.EventHandler(this.Titulo_notif_Click);
            // 
            // Hrs_Notif_txt
            // 
            this.Hrs_Notif_txt.AutoSize = true;
            this.Hrs_Notif_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hrs_Notif_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Hrs_Notif_txt.Location = new System.Drawing.Point(144, 76);
            this.Hrs_Notif_txt.Name = "Hrs_Notif_txt";
            this.Hrs_Notif_txt.Size = new System.Drawing.Size(141, 18);
            this.Hrs_Notif_txt.TabIndex = 2;
            this.Hrs_Notif_txt.Text = " Días Trabajados:";
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(466, 210);
            this.Controls.Add(this.Hrs_Notif_txt);
            this.Controls.Add(this.Titulo_notif);
            this.Controls.Add(this.Boton_cerrar_notif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificación";
            this.Load += new System.EventHandler(this.Notificacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_cerrar_notif;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Titulo_notif;
        private System.Windows.Forms.Label Hrs_Notif_txt;
    }
}