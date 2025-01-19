using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceinvaders
{
    public partial class UnirsePartida : Form
    {
        Socket Cliente;
        bool iniciar = false;
        public UnirsePartida()
        {
            InitializeComponent();
        }

        private void UnirsePartida_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tb_IP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipserver = new IPEndPoint(IPAddress.Parse(Tb_IP.Text), 1234);
                Cliente.Connect(ipserver);

                label1.Text = "                Todo listo";
                label2.Text = "Esperando que inicien la partida";

                Tb_IP.Visible = false;
                iniciar = true;

                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iniciar == true)
            {
                iniciar = false;
                byte [] ByRec = new byte[50000];
                int a = Cliente.Receive(ByRec, 0, ByRec.Length, 0);

                string datorcb = Encoding.Default.GetString(ByRec, 0, a);
                if (datorcb == "OK")
                {
                    Jugar J = new Jugar(Cliente, 2);
                    this.Hide();
                    J.Show();
                }
            }
        }
    }
}
