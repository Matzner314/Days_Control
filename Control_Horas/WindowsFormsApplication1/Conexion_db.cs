using System;
using System.Windows.Forms;

namespace Contro_Dias
{
    public partial class Conexion_db : Form
    {
        public Conexion_db(string connectionString)
        {
            InitializeComponent();
        }

        public void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Opciones opciones = new Menu_Opciones();
            opciones.Show();
        }

        public void Aply_Button_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            string server = Server_Box.Text;
            string Source = Source_Box.Text;
            string userid = Userid_Box.Text;
            string pass = Password_Box.Text;
            string ini_cat = Initial_Catalog_Box.Text;
            connectionString = ("server=" + server + ";Database=" + Source + ";User Id=" + userid + ";Password=" + pass + ";Initial Catalog=" + ini_cat.ToString() + ";Trusted_Connection= True").ToString();
            getSet.connectionString = connectionString;
            connection_label.Text = "Credenciales de conexion para " + Source + " guardadas satisfactoriamente...";


        }

        private void Conexion_db_Load(object sender, EventArgs e)
        {

        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}

