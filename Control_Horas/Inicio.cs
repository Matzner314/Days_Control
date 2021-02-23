using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tulpep.NotificationWindow;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {

        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //---------------------------------------INICIA EL PROCESO------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        /*public static void showNotification(int days)
        {
            Notificacion VentanaNotificacion = new Notificacion(days);
            VentanaNotificacion.Show();---
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Alerta de deias";
            popup.ContentText = "7 dias de trabajo";
            popup.AnimationDuration = 1000;

            popup.Popup();
        }*/

        public Inicio()
        {
            string connectionString = "Server = DESKTOP-P78S0RT; Database = AxTrax1; Trusted_Connection = True;";
            InitializeComponent();
            SqlDependency.Stop(connectionString);
            SqlDependency.Start(connectionString);
            RegisterForChanges();
        }

        //--------------------------------------------------------------------------------------------------------
        //---------------------------------------CAPTA CAMBIO EN BASE DE DATOS------------------------------------
        //--------------------------------------------------------------------------------------------------------

        public void RegisterForChanges()
        {
            SqlConnection conectarbd = new SqlConnection("Server = DESKTOP-P78S0RT; Database = AxTrax1; Trusted_Connection = True;");
            conectarbd.Open();
            string consulta1 = "select tFullName from dbo.tblEvents";
            try
            {
                SqlCommand comando = new SqlCommand(consulta1, conectarbd);
                SqlDependency oDependency = new SqlDependency(comando);
                oDependency.OnChange += new OnChangeEventHandler(OnNotificationChange);
                SqlDataReader objReader = comando.ExecuteReader();
                try
                {

                }
                finally
                {
                    objReader.Close();
                }
            }
            finally
            {
                conectarbd.Close();
            }
        }

        //--------------------------------------------------------------------------------------------------------
        //---------------------------------------ACTUALIZA TEXTO EN APLICACIÓN------------------------------------
        //--------------------------------------------------------------------------------------------------------

        public void OnNotificationChange(object caller, SqlNotificationEventArgs e)
        {
            string name;
            int days;
            int rows;
            string connectionString = "Server = DESKTOP-P78S0RT; Database = AxTrax1; Trusted_Connection = True;";
            name = ExtractName(connectionString);
            rows = ExtractRows(connectionString, name);
            days = ExtractDate(connectionString, name, rows);
            // Testisting if getting dependency response...
            Texto_Nombre.Invoke((MethodInvoker)delegate
            {
                Texto_Nombre.Text = name;
                Hours_Text.Text = days.ToString();
            });
            RegisterForChanges();
            pictureBox1_Click(days);
        }

        //--------------------------------------------------------------------------------------------------------
        //---------------------------------------EXTRAE NOMBRE DE BASE DE DATOS-----------------------------------
        //--------------------------------------------------------------------------------------------------------

        private static string ExtractName(string connectionString)
        {
            string name = "No hubo cambios";
            string queryString = "Select tFullName From tblEvents order by dtEventUpload desc";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();
            SqlDataReader rdr = command.ExecuteReader();
            // Call Read before accessing data. 
            if (rdr.HasRows)
            {
                for (int i = 0; i < 1; i++)
                {
                    rdr.Read();
                    name = rdr.GetString(0);
                }
                // Call Close when done reading.
                rdr.Close();
            }
            return name;
        }

        //--------------------------------------------------------------------------------------------------------
        //---------------------------------------EXTRAE FECHA DE BASE DE DATOS------------------------------------
        //--------------------------------------------------------------------------------------------------------
        public static int ExtractDate(string connectionString, string nombre, int rows)
        {
            double hrsDif = 0;
            int totalDays = 0;
            DateTime[] registerHour = new DateTime[rows];
            var dateString = "1/1/2000 12:00:00";
            DateTime storedHour = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
            string queryString_dates = "Select dtEventUpload From tblEvents where tFullName = '" + nombre + "' order by dtEventUpload desc";
            string queryString_rows = "SELECT count(dtEventUpload) FROM tblEvents WHERE tFUllName= '" + nombre + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString_dates, connection);
            connection.Open();
            SqlDataReader rdr = command.ExecuteReader();
            // Call Read before accessing data.

            for (int dayCount = 0; dayCount < rows; dayCount++)
            {
                if (rdr.HasRows)
                {
                    rdr.Read();
                    registerHour[dayCount] = rdr.GetDateTime(0);
                    if (dayCount == 0)
                    {
                        storedHour = registerHour[dayCount];
                    }
                    else
                    {
                        hrsDif = (Math.Abs(storedHour.Day - registerHour[dayCount].Day));
                        if (hrsDif == 30 || hrsDif == 29 || hrsDif == 28)
                        {
                            hrsDif = 1;
                        }
                        if (hrsDif == 1)
                        {
                            totalDays++;
                            storedHour = registerHour[dayCount];
                        }
                        if (hrsDif > 1)
                        {
                            break;
                        }
                        if (totalDays >= 7)
                        {
                            break;
                        }
                    }
                }
            }
            rdr.Close();
            connection.Close();
            return totalDays;
        }

        public static int ExtractRows(string connectionString, string nombre)
        {
            int rows = 0;
            string queryString_rows = "SELECT count(dtEventUpload) FROM tblEvents WHERE tFUllName= '" + nombre + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString_rows, connection);
            connection.Open();
            SqlDataReader rdr = command.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                rows = rdr.GetInt32(0);
            }
            rdr.Close();
            connection.Close();
            return rows;
        }


        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //----------------------------------------SE ARMA LA INTERFAZ---------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------




        /*public static void openNotification(EventArgs e, int days)
        {
            if (days >= 7)
            {
                Notificacion VentanaNotificacion = new Notificacion(days);
                VentanaNotificacion.Show();
            }
        }*/


        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar_Inicio1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(int days)
        {
            if (days >= 7)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            else
            {
                pictureBox1.Image = imageList1.Images[0];
            }
        }

        /* private void Boton_Prueba1(object sender, EventArgs e)
         {
             using (Notificacion VentanaNotificacion = new Notificacion(Texto_Horas.Text))
                 VentanaNotificacion.ShowDialog();*/
    }
}