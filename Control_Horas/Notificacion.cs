using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Notificacion : Form
    {

        String Horas;

        public Notificacion(int horas)
        {
            InitializeComponent();
            Horas = horas.ToString();
            
        }
        private void Boton_cerrar_notif1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.Close();
        }

        private void Notificacion_Load(object sender, EventArgs e)
        {
            Hrs_Notif_txt.Text += " " + Horas;
        }

        private void Titulo_notif_Click(object sender, EventArgs e)
        {

        }
        protected void TamañoCambiado(EventArgs e)
        {
            
        }
        
    }
}
