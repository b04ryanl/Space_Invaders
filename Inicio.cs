using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceinvaders
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            CrearPartida CP = new CrearPartida();
            this.Hide();
            CP.Show();
        }

        private void Btn_Unirse_Click(object sender, EventArgs e)
        {
            UnirsePartida UP = new UnirsePartida();
            this.Hide();
            UP.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
