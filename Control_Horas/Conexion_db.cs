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
    public partial class Conexion_db : Form
    {
        public Conexion_db()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Opciones opciones = new Menu_Opciones();
            opciones.Show();
        }

        private void Aply_Button_Click(object sender, EventArgs e)
        {
            /*string connectionString = "";
            string server = (Server_Box.ToString() + ";").ToString(); ;
            string Source = Source_Box.ToString() + ";";
            string userid = Userid_Box.ToString() + ";";
            string pass = Password_Box.ToString() + ";";
            string ini_cat = Initial_Catalog_Box.ToString() + ";";
            connectionString = ("server=" + server + "Source=" + Source + "User Id=" + userid + "Password=" + pass + "Initial Catalog=" + ini_cat).ToString();
            if (server == "hola")
            {
                connection_label.Text = server;
                Form inicio = new Form();
                inicio.Close();
                inicio.Show();
            }
        }*/
        }
    }
}
//"server = 10.150.102.10;Data Source=CL10-15K9R3C;Persist Security Info=true;User Id=CLCANAXTRAX;Password=Cancura2020;Initial Catalog=AxTrax1;";
