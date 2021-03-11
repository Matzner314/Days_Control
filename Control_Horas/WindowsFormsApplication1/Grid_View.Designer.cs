namespace Contro_Dias
{
    partial class Grid_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grid_View));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Grid_Title = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.From_date_label = new System.Windows.Forms.Label();
            this.To_date_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.combo_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(932, 367);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(105, 32);
            this.Close_Button.TabIndex = 1;
            this.Close_Button.Text = "Cerrar";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(811, 367);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(106, 32);
            this.Search_Button.TabIndex = 2;
            this.Search_Button.Text = "Buscar";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Grid_Title
            // 
            this.Grid_Title.AutoSize = true;
            this.Grid_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Title.Location = new System.Drawing.Point(242, 9);
            this.Grid_Title.Name = "Grid_Title";
            this.Grid_Title.Size = new System.Drawing.Size(382, 32);
            this.Grid_Title.TabIndex = 3;
            this.Grid_Title.Text = "Registro de exceso de dias";
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.Location = new System.Drawing.Point(-2, 336);
            this.connect.MaximumSize = new System.Drawing.Size(36, 17);
            this.connect.MinimumSize = new System.Drawing.Size(36, 17);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(36, 17);
            this.connect.TabIndex = 4;
            this.connect.Text = "       ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 339);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 377);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // From_date_label
            // 
            this.From_date_label.AutoSize = true;
            this.From_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_date_label.Location = new System.Drawing.Point(28, 339);
            this.From_date_label.Name = "From_date_label";
            this.From_date_label.Size = new System.Drawing.Size(55, 18);
            this.From_date_label.TabIndex = 7;
            this.From_date_label.Text = "Desde:";
            // 
            // To_date_label
            // 
            this.To_date_label.AutoSize = true;
            this.To_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_date_label.Location = new System.Drawing.Point(28, 380);
            this.To_date_label.Name = "To_date_label";
            this.To_date_label.Size = new System.Drawing.Size(51, 18);
            this.To_date_label.TabIndex = 8;
            this.To_date_label.Text = "Hasta:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(383, 339);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(215, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Solo registros fuera de rango";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // combo_Name
            // 
            this.combo_Name.DisplayMember = "Filtrar por nombre";
            this.combo_Name.FormattingEnabled = true;
            this.combo_Name.Location = new System.Drawing.Point(506, 374);
            this.combo_Name.Name = "combo_Name";
            this.combo_Name.Size = new System.Drawing.Size(264, 24);
            this.combo_Name.TabIndex = 10;
            this.combo_Name.SelectedIndexChanged += new System.EventHandler(this.combo_Name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtro por nombre:";
            // 
            // Grid_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Name);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.To_date_label);
            this.Controls.Add(this.From_date_label);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.Grid_Title);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(801, 392);
            this.Name = "Grid_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Grid_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label Grid_Title;
        private System.Windows.Forms.Label connect;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label From_date_label;
        private System.Windows.Forms.Label To_date_label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox combo_Name;
        private System.Windows.Forms.Label label1;
    }
}