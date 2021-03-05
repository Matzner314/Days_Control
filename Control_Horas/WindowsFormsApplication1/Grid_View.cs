using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Contro_Dias
{
    public partial class Grid_View : Form
    {
        public Grid_View()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu_Opciones opciones = new Menu_Opciones();
            opciones.Show();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string connectionString = getSet.connectionString;
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;
            string queryString = "select Name AS Nombre, ConsecutiveDays AS Dias_Seguidos, CardID AS ID_Tarjeta, InicialDate AS Ultimo_Registro, FinalDate AS Primer_Registro from CAN_tblDayCount where ConsecutiveDays >= 7 AND InicialDate BETWEEN '"+from+"' AND '"+to+"' order by InicialDate desc";
            if (connectionString != " ")
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand commandID = new SqlCommand(queryString, connection);
                    DataTable tbl = new DataTable();
                    connection.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(queryString, connectionString);
                    adapt.Fill(tbl);
                    dataGridView1.DataSource = tbl;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    this.Close();
                }
            }
        }
    }
}
