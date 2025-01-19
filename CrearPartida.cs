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
    public partial class CrearPartida : Form
    {
        bool conectado = false;
        Socket cliente;
        public CrearPartida()
        {
            InitializeComponent();
            string ip = ObtenerIp();
            DirIp.Text = ip;

        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            byte[] textoEnviar = Encoding.Default.GetBytes("OK");
            cliente.Send(textoEnviar, 0, textoEnviar.Length, 0);

            Jugar J = new Jugar(cliente,1);
            this.Hide();
            J.Show();
        }

        public string ObtenerIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }

        private void CrearPartida_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (conectado == false)
            {
                conectado = true;
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint Ip = new IPEndPoint(IPAddress.Any, 1234);
                server.Bind(Ip);
                server.Listen(2);
                cliente = server.Accept();
                label1.Text = "                     Todo Listo";
                label2.Text = "                   Puedes comenzar";
                Btn_Crear.Enabled = true;
            }
            
        }

        private void CrearPartida_Load(object sender, EventArgs e)
        {

        }
    }
}
