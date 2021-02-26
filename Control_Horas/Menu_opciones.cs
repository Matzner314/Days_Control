using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contro_Dias
{
    public partial class Menu_Opciones : Form
    {
        public Menu_Opciones()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion_db conection = new Conexion_db();
            conection.Show();
            this.Hide();
        }

        private void Menu_Opciones_Load(object sender, EventArgs e)
        {

        }
    }
}
