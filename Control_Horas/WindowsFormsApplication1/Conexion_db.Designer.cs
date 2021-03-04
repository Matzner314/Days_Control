namespace Contro_Dias
{
    partial class Conexion_db
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conexion_db));
            this.Aply_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Server_Box = new System.Windows.Forms.TextBox();
            this.Source_Box = new System.Windows.Forms.TextBox();
            this.Userid_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Initial_Catalog_Box = new System.Windows.Forms.TextBox();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.connection_label = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Aply_Button
            // 
            this.Aply_Button.Location = new System.Drawing.Point(56, 496);
            this.Aply_Button.Name = "Aply_Button";
            this.Aply_Button.Size = new System.Drawing.Size(123, 32);
            this.Aply_Button.TabIndex = 1;
            this.Aply_Button.Text = "Aplicar";
            this.Aply_Button.UseVisualStyleBackColor = true;
            this.Aply_Button.Click += new System.EventHandler(this.Aply_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(352, 496);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(123, 32);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.Text = "Cerrar";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conexion Manual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Initial Catalog";
            // 
            // Server_Box
            // 
            this.Server_Box.Location = new System.Drawing.Point(163, 93);
            this.Server_Box.MaximumSize = new System.Drawing.Size(312, 22);
            this.Server_Box.MinimumSize = new System.Drawing.Size(312, 22);
            this.Server_Box.Name = "Server_Box";
            this.Server_Box.Size = new System.Drawing.Size(312, 22);
            this.Server_Box.TabIndex = 9;
            // 
            // Source_Box
            // 
            this.Source_Box.Location = new System.Drawing.Point(163, 167);
            this.Source_Box.Name = "Source_Box";
            this.Source_Box.Size = new System.Drawing.Size(312, 22);
            this.Source_Box.TabIndex = 10;
            // 
            // Userid_Box
            // 
            this.Userid_Box.Location = new System.Drawing.Point(163, 249);
            this.Userid_Box.Name = "Userid_Box";
            this.Userid_Box.Size = new System.Drawing.Size(312, 22);
            this.Userid_Box.TabIndex = 11;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(163, 335);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(312, 22);
            this.Password_Box.TabIndex = 12;
            // 
            // Initial_Catalog_Box
            // 
            this.Initial_Catalog_Box.Location = new System.Drawing.Point(163, 429);
            this.Initial_Catalog_Box.Name = "Initial_Catalog_Box";
            this.Initial_Catalog_Box.Size = new System.Drawing.Size(312, 22);
            this.Initial_Catalog_Box.TabIndex = 13;
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(206, 496);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(123, 32);
            this.Accept_Button.TabIndex = 14;
            this.Accept_Button.Text = "Aceptar";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // connection_label
            // 
            this.connection_label.AutoSize = true;
            this.connection_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connection_label.Location = new System.Drawing.Point(53, 554);
            this.connection_label.Name = "connection_label";
            this.connection_label.Size = new System.Drawing.Size(368, 17);
            this.connection_label.TabIndex = 15;
            this.connection_label.Text = "                                                                                 " +
    "         ";
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.Location = new System.Drawing.Point(12, 9);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(56, 17);
            this.connect.TabIndex = 16;
            this.connect.Text = "            ";
            // 
            // Conexion_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 596);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.connection_label);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.Initial_Catalog_Box);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Userid_Box);
            this.Controls.Add(this.Source_Box);
            this.Controls.Add(this.Server_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Aply_Button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(568, 643);
            this.Name = "Conexion_db";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion_db";
            this.Load += new System.EventHandler(this.Conexion_db_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aply_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Server_Box;
        private System.Windows.Forms.TextBox Source_Box;
        private System.Windows.Forms.TextBox Userid_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.TextBox Initial_Catalog_Box;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.Label connection_label;
        private System.Windows.Forms.Label connect;
    }
}