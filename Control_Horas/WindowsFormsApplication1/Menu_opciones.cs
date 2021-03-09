using System;
using System.Windows.Forms;
using System.Media;
namespace Contro_Dias
{
    public partial class Menu_Opciones : Form
    {
        SoundPlayer warning = new SoundPlayer();
        public Menu_Opciones()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            if (warning != null)
            {
                warning.Stop();
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion_db conection = new Conexion_db(getSet.connectionString);
            conection.Show();
            this.Hide();
        }

        private void Menu_Opciones_Load(object sender, EventArgs e)
        {
            
        }

        private void Sound_Test_Click(object sender, EventArgs e)
        {
            warning = new SoundPlayer(Application.StartupPath + @"\sound\alarma.wav");
            warning.PlayLooping();
        }

        private void Stop_Test_Click(object sender, EventArgs e)
        {
            if (warning != null)
            {
                warning.Stop();
            }
        }
    }
}
