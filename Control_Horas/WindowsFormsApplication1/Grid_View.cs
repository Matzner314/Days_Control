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
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            int orden = 0;
            String nombre = combo_Name.DisplayMember;
            int days;
            string name = combo_Name.Text;
            string queryString;
            object numero = combo_Name.SelectedValue;
            orden = combo_Name.SelectedIndex;
            if (checkBox1.Checked == true)
            {
                days = 7;
            }
            else
            {
                days = 0;
            }
            string connectionString = getSet.connectionString;
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;
            if (name == "Filtrar por nombre")
            {
                queryString = "select Name AS Nombre, employeeID as id, ConsecutiveDays AS Dias_Seguidos, CardID AS ID_Tarjeta, InicialDate AS Ultimo_Registro, FinalDate AS Primer_Registro from CAN_tblDayCount where ConsecutiveDays >= " + days + " AND InicialDate BETWEEN '" + from + "' AND '" + to + "' order by InicialDate desc";
            }
            else
            {
                queryString = "select Name AS Nombre, employeeID as id, ConsecutiveDays AS Dias_Seguidos, CardID AS ID_Tarjeta, InicialDate AS Ultimo_Registro, FinalDate AS Primer_Registro from CAN_tblDayCount where ConsecutiveDays >= " + days + " AND Name = '"+ name +"' AND InicialDate BETWEEN '" + from + "' AND '" + to + "' order by InicialDate desc";
            }
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

        public void combo_Fill(ComboBox cb)
        {
            try
            {
                string queryString = "SELECT tFirstName, tLastName, iEmployeeNum FROM tblEmployees order by tFirstName";
                SqlConnection connection = new SqlConnection(getSet.connectionString);
                SqlCommand com = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader rdr = com.ExecuteReader();
                cb.DisplayMember = "Text";
                cb.ValueMember = "Value";
                while (rdr.Read())
                {
                    cb.Items.Add(Text = (rdr["iEmployeeNum"].ToString() +" - " + rdr["tFirstName"].ToString() + " " + rdr["tLastName"].ToString()));
                }
                rdr.Close();
                connection.Close();
                cb.Text = "Filtrar por nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox" + ex.ToString());
            }
        }

        private void Grid_View_Load(object sender, EventArgs e)
        {
            combo_Fill(combo_Name);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
