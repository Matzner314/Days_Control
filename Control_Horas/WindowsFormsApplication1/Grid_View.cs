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

        //--------------------------------------------------------------------------------------------------------
        //---------------------------------------APPLY FILTERS AND SEARCH IN DB-----------------------------------
        //--------------------------------------------------------------------------------------------------------

        private void Search_Button_Click(object sender, EventArgs e)
        {
            int days;
            string name = combo_Name.Text;
            string queryString;
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
            if (name == "Filtrar por nombre" || name == "")
            {
                queryString = "select Name AS Nombre, FinalDate AS Primer_Registro, InicialDate AS Ultimo_Registro, ConsecutiveDays AS Dias_Seguidos, CardID AS ID_Tarjeta, employeeID as id from CAN_tblDayCount where ConsecutiveDays >= " + days + " AND InicialDate BETWEEN '" + from + "' AND '" + to + "' order by InicialDate desc";
            }
            else
            {
                queryString = "select Name AS Nombre, FinalDate AS Primer_Registro, InicialDate AS Ultimo_Registro, ConsecutiveDays AS Dias_Seguidos, CardID AS ID_Tarjeta, employeeID as id from CAN_tblDayCount where ConsecutiveDays >= " + days + " AND employeeID = " + getSet.emp_id +" AND InicialDate BETWEEN '" + from + "' AND '" + to + "' order by InicialDate desc";
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
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    this.Close();
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------
        //----------------------------------------------FILL COMBO BOX--------------------------------------------
        //--------------------------------------------------------------------------------------------------------

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
                    cb.Items.Add(Text = (rdr["tFirstName"].ToString() +" " + rdr["tLastName"].ToString() + "-" + rdr["iEmployeeNum"].ToString()));
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

        //--------------------------------------------------------------------------------------------------------
        //-------------------------------------EXTRACT ID FROM COMBO BOX STRING-----------------------------------
        //--------------------------------------------------------------------------------------------------------

        private void combo_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSet.emp_id = "";
            string cadena = combo_Name.Text;
            char[] separators = new char[] { '-' };
            string[] subs = cadena.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sub in subs)
            {
                getSet.emp_id = sub;
            }
        }
    }
}
