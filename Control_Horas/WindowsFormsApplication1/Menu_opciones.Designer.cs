namespace Contro_Dias
{
    partial class Menu_Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Opciones));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Stop_Test = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Sound_Test_label = new System.Windows.Forms.Label();
            this.Sound_Test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(83, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Conexion Manual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.Location = new System.Drawing.Point(83, 212);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(170, 42);
            this.Close_Button.TabIndex = 3;
            this.Close_Button.Text = "Cerrar";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Stop_Test
            // 
            this.Stop_Test.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Stop_Test.Location = new System.Drawing.Point(228, 97);
            this.Stop_Test.Name = "Stop_Test";
            this.Stop_Test.Size = new System.Drawing.Size(25, 25);
            this.Stop_Test.TabIndex = 28;
            this.Stop_Test.UseVisualStyleBackColor = true;
            this.Stop_Test.Click += new System.EventHandler(this.Stop_Test_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(108, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Detener Prueba:";
            // 
            // Sound_Test_label
            // 
            this.Sound_Test_label.AutoSize = true;
            this.Sound_Test_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sound_Test_label.Location = new System.Drawing.Point(108, 67);
            this.Sound_Test_label.Name = "Sound_Test_label";
            this.Sound_Test_label.Size = new System.Drawing.Size(104, 17);
            this.Sound_Test_label.TabIndex = 29;
            this.Sound_Test_label.Text = "Prueba sonido:";
            // 
            // Sound_Test
            // 
            this.Sound_Test.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Sound_Test.Location = new System.Drawing.Point(228, 63);
            this.Sound_Test.Name = "Sound_Test";
            this.Sound_Test.Size = new System.Drawing.Size(25, 25);
            this.Sound_Test.TabIndex = 27;
            this.Sound_Test.UseVisualStyleBackColor = true;
            this.Sound_Test.Click += new System.EventHandler(this.Sound_Test_Click);
            // 
            // Menu_Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(329, 278);
            this.Controls.Add(this.Stop_Test);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sound_Test_label);
            this.Controls.Add(this.Sound_Test);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(347, 337);
            this.Name = "Menu_Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_opciones";
            this.Load += new System.EventHandler(this.Menu_Opciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Stop_Test;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sound_Test_label;
        private System.Windows.Forms.Button Sound_Test;
    }
}