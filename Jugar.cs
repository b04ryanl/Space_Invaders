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
    public partial class Jugar : Form
    {
        Socket Cliente;
        int j;
        public List<List<Label>> Enemigos;
        public List<List<Direccion>> DirEnemigos;

        public List<Label> Jugadores;

        public List<Label> Balas;
        public List<Direccion> DirBalas;


        //Para jugador 1
        List<int> crearnuevobicho = new List<int>();
        List<bool> pintarbichos = new List<bool>();
        int totalbichos = 4, tipobicho = 0;
        Random rand = new Random();
        int aleatoriodisparo;
        int valoraleatorio = 0;
        Posicion PosBalaJ1 = null,PosBalaJ2 = null;

        


        public Jugar(Socket Cl,int jug)
        {
            Cliente = Cl;
            j = jug;
            InitializeComponent();
            this.Text = "Jugar - Jugador " + j.ToString();

            Enemigos = new List<List<Label>>();
            DirEnemigos = new List<List<Direccion>>();

            Balas = new List<Label>();
            DirBalas = new List<Direccion>();

            Enemigos.Add(new List<Label>());
            DirEnemigos.Add(new List<Direccion>());
            DirEnemigos[0].Add(Direccion.Derecha);
            Label lbl = new Label();
            lbl.Location = new Point(10, 5);
            Image image2 = Image.FromFile("..\\..\\imagenes\\Octopus.png");
            lbl.Size = new Size(image2.Width, image2.Height);
            lbl.Text = "";
            lbl.Image = image2;
            Enemigos[0].Add(lbl);
            this.Controls.Add(Enemigos[0][0]);

            //Activar timers
            Timer ControlBalas = new Timer();
            ControlBalas.Enabled = true;
            ControlBalas.Interval = 10;
            ControlBalas.Tick += ControlBalas_Tick;


            if (j == 1)
            {

                crearnuevobicho.Add(0);
                pintarbichos.Add(true);
                aleatoriodisparo = rand.Next(30, 100);
                Jugadores = new List<Label>();

                Label lbl2 = new Label();
                lbl2.Location = new Point(10, 130*4);
                Image im = Image.FromFile("..\\..\\imagenes\\Jugador1.png");
                lbl2.Size = new Size(im.Width, im.Height);
                lbl2.Text = "";
                lbl2.Image = im;
                Jugadores.Add(lbl2);
                this.Controls.Add(Jugadores[0]);

                Label lbl3 = new Label();
                lbl3.Location = new Point(350*2, 130*4);
                Image im2 = Image.FromFile("..\\..\\imagenes\\Jugador2.png");
                lbl3.Size = new Size(im2.Width, im2.Height);
                lbl3.Text = "";
                lbl3.Image = im2;
                Jugadores.Add(lbl3);
                this.Controls.Add(Jugadores[1]);

                //Activar timers
                Timer MoverNaves = new Timer();
                MoverNaves.Enabled = true;
                MoverNaves.Interval = 50;
                MoverNaves.Tick += MoverNaves_Tick;
            }


            

        }

        private void ControlBalas_Tick(object sender, EventArgs e)
        {
            List<int> eliminarind = new List<int>();
            for (int i = 0; i < Balas.Count(); i++)
            {
                if (DirBalas[i] == Direccion.Arriba)
                {
                    Balas[i].Location = new Point(Balas[i].Location.X, Balas[i].Location.Y - 10);

                    if (PosBalaJ1.x == Balas[i].Location.X && PosBalaJ1.y == Balas[i].Location.Y + 10)
                    {
                        PosBalaJ1.y = Balas[i].Location.Y;
                    }
                    var resultado = verificarimpacto(Enemigos,i);
                    if (resultado != null)
                    {
                        Balas[i].Visible = false;
                        int valor = 0;
                        foreach (var lista in Enemigos)
                        {
                            var result = lista.FindIndex(x => x.Location.X == resultado.x && x.Location.Y == resultado.y);
                            if (result != -1)
                            {
                                lista[result].Visible = false;
                                DirEnemigos[valor].RemoveAt(result);
                                lista.RemoveAt(result);
                            }
                            valor++;
                        }
                        eliminarind.Add(i);
                    }
                }
            }
            for (int i = 0; i < eliminarind.Count(); i++)
            {
                if (PosBalaJ1 != null)
                {
                    if (PosBalaJ1.x == Balas[eliminarind[i]].Location.X && PosBalaJ1.y == Balas[eliminarind[i]].Location.Y)
                    {
                        PosBalaJ1 = null;
                    }
                }
                if (PosBalaJ2 != null)
                {
                    if (PosBalaJ2.x == Balas[eliminarind[i]].Location.X && PosBalaJ2.y == Balas[eliminarind[i]].Location.Y)
                    {
                        PosBalaJ2 = null;
                    }
                }
                
                Balas.RemoveAt(eliminarind[i]);
            }
            eliminarind.Clear();
        }

        private void MoverNaves_Tick(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////

            //Eliminar listas vacias
            var eliminar = Enemigos.Find(l => l.Count() == 0);
            var eliminarindex = Enemigos.FindIndex(l => l.Count() == 0);
            if (eliminar != null)
            {
                Enemigos.Remove(eliminar);
                DirEnemigos.RemoveAt(eliminarindex);
                crearnuevobicho.RemoveAt(eliminarindex);
                pintarbichos.RemoveAt(eliminarindex);
            }
            ///////////////////////////////////////////////////

            


            int indicelista = 0;
            int indiceitem = 0;
            List<int> ListaModificarLista = new List<int>();
            List<int> ListaModificarInd = new List<int>();
            List<Direccion> ListaModificarDir = new List<Direccion>();

            foreach (var listaDirEnemigos in DirEnemigos)
            {
                foreach (var enemigo in listaDirEnemigos)
                {
                    switch (enemigo)
                    {
                        case Direccion.Derecha:
                            Enemigos[indicelista][indiceitem].Location = new Point(Enemigos[indicelista][indiceitem].Location.X + 1, Enemigos[indicelista][indiceitem].Location.Y);
                            

                            break;
                        case Direccion.Izquierda:
                            Enemigos[indicelista][indiceitem].Location = new Point(Enemigos[indicelista][indiceitem].Location.X - 1, Enemigos[indicelista][indiceitem].Location.Y);

                            break;
                        case Direccion.Abajo:
                            Enemigos[indicelista][indiceitem].Location = new Point(Enemigos[indicelista][indiceitem].Location.X, Enemigos[indicelista][indiceitem].Location.Y + 50);
                            if (Enemigos[indicelista][Enemigos[indicelista].Count() - 1].Location.X == 10)
                            {
                                ListaModificarLista.Add(indicelista);
                                ListaModificarInd.Add(indiceitem);
                                ListaModificarDir.Add(Direccion.Derecha);
                            }
                            else
                            {
                                ListaModificarLista.Add(indicelista);
                                ListaModificarInd.Add(indiceitem);
                                ListaModificarDir.Add(Direccion.Izquierda);
                            }
                            break;
                        default:
                            break;
                    }
                    indiceitem++;
                }
                indiceitem = 0;
                indicelista++;
            }

            for (int i = 0; i < ListaModificarInd.Count(); i++)
            {
                DirEnemigos[ListaModificarLista[i]][ListaModificarInd[i]] = ListaModificarDir[i];
            }
            ListaModificarDir.Clear();
            ListaModificarInd.Clear();
            ListaModificarLista.Clear();

            int cantbichos = 0;
            foreach (var listaenemigos in Enemigos)
            {
                if (pintarbichos[cantbichos] == true)
                {
                    if (listaenemigos.Count() < totalbichos)
                    {
                        crearnuevobicho[cantbichos]++;
                        if (crearnuevobicho[cantbichos] == 60)
                        {
                            crearnuevobicho[cantbichos] = 0;
                            switch (tipobicho)
                            {
                                case 0:
                                    listaenemigos.Add(new Label());
                                    DirEnemigos[cantbichos].Add(Direccion.Derecha);
                                    listaenemigos[listaenemigos.Count - 1].Location = new Point(10, 5);
                                    Image imag = Image.FromFile("..\\..\\imagenes\\Octopus.png");
                                    listaenemigos[listaenemigos.Count - 1].Size = new Size(imag.Width, imag.Height);
                                    listaenemigos[listaenemigos.Count - 1].Text = "";
                                    listaenemigos[listaenemigos.Count - 1].Image = imag;

                                    this.Controls.Add(listaenemigos[listaenemigos.Count - 1]);
                                    ///////////////////////
                                    break;
                                case 1:
                                    listaenemigos.Add(new Label());
                                    DirEnemigos[cantbichos].Add(Direccion.Derecha);
                                    listaenemigos[listaenemigos.Count - 1].Location = new Point(10, 5);
                                    Image imag2 = Image.FromFile("..\\..\\imagenes\\Crab.png");
                                    listaenemigos[listaenemigos.Count - 1].Size = new Size(imag2.Width, imag2.Height);
                                    listaenemigos[listaenemigos.Count - 1].Text = "";
                                    listaenemigos[listaenemigos.Count - 1].Image = imag2;

                                    this.Controls.Add(listaenemigos[listaenemigos.Count - 1]);
                                    ///////////////////////
                                    break;
                                case 2:
                                    listaenemigos.Add(new Label());
                                    DirEnemigos[cantbichos].Add(Direccion.Derecha);
                                    listaenemigos[listaenemigos.Count - 1].Location = new Point(10, 5);
                                    Image imag3 = Image.FromFile("..\\..\\imagenes\\Squid.png");
                                    listaenemigos[listaenemigos.Count - 1].Size = new Size(imag3.Width, imag3.Height);
                                    listaenemigos[listaenemigos.Count - 1].Text = "";
                                    listaenemigos[listaenemigos.Count - 1].Image = imag3;

                                    this.Controls.Add(listaenemigos[listaenemigos.Count - 1]);
                                    ///////////////////////
                                    break;
                            }
                        }
                    }
                    else
                    {
                        pintarbichos[cantbichos] = false;
                    }

                }

                cantbichos++;
            }

            indiceitem = 0;
            indicelista = 0;
            int indiceitem2 = 0;
            int max = 650;

            foreach (var listaenemigos in Enemigos)
            {
                if (listaenemigos[0].Location.X > max)
                {
                    foreach (var enemigo in listaenemigos)
                    {

                        enemigo.Location = new Point(enemigo.Location.X - 1, enemigo.Location.Y);
                        DirEnemigos[indicelista][indiceitem2] = Direccion.Abajo;
                        indiceitem2++;
                    }
                    indiceitem2 = 0;

                }
                else if (listaenemigos[listaenemigos.Count() - 1].Location.X < 10)
                {
                    foreach (var enemigo in listaenemigos)
                    {
                        enemigo.Location = new Point(enemigo.Location.X + 1, enemigo.Location.Y);
                        DirEnemigos[indicelista][indiceitem2] = Direccion.Abajo;
                        indiceitem2++;
                    }
                    indiceitem2 = 0;
                }
                else
                {
                    foreach (var enemigo in listaenemigos)
                    {
                        indiceitem++;
                    }
                    indiceitem = 0;
                }
                indicelista++;
            }

            if (Enemigos[Enemigos.Count() - 1][0].Location.X == max || Enemigos[Enemigos.Count() - 1].Count() == 0)
            {
                tipobicho++;
                if (tipobicho >= 3)
                {
                    tipobicho = 0;
                }
                Enemigos.Add(new List<Label>());
                DirEnemigos.Add(new List<Direccion>());
                crearnuevobicho.Add(0);
                pintarbichos.Add(true);
                switch (tipobicho)
                {
                    case 0:
                        Enemigos[Enemigos.Count() - 1].Add(new Label());
                        DirEnemigos[DirEnemigos.Count() - 1].Add(Direccion.Derecha);
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count-1].Location = new Point(10, 5);
                        Image imag = Image.FromFile("..\\..\\imagenes\\Octopus.png");
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Size = new Size(imag.Width, imag.Height);
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Text = "";
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Image = imag;

                        this.Controls.Add(Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1]);
                        /////////////////////////////
                        break;
                    case 1:
                        /////////////////////////////
                        Enemigos[Enemigos.Count() - 1].Add(new Label());
                        DirEnemigos[DirEnemigos.Count() - 1].Add(Direccion.Derecha);
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Location = new Point(10, 5);
                        Image imag2 = Image.FromFile("..\\..\\imagenes\\Crab.png");
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Size = new Size(imag2.Width, imag2.Height);
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Text = "";
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Image = imag2;

                        this.Controls.Add(Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1]);
                        /////////////////////////////
                        break;
                    case 2:
                        /////////////////////////////
                        Enemigos[Enemigos.Count() - 1].Add(new Label());
                        DirEnemigos[DirEnemigos.Count() - 1].Add(Direccion.Derecha);
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Location = new Point(10, 5);
                        Image imag3 = Image.FromFile("..\\..\\imagenes\\Squid.png");
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Size = new Size(imag3.Width, imag3.Height);
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Text = "";
                        Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1].Image = imag3;

                        this.Controls.Add(Enemigos[Enemigos.Count - 1][Enemigos[Enemigos.Count - 1].Count - 1]);
                        /////////////////////////////
                        break;
                }

            }


        }

        private void Jugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                    if (PosBalaJ1 == null)
                    {
                        PosBalaJ1 = new Posicion(Jugadores[0].Location.X + 25, Jugadores[0].Location.Y - 2);
                        Balas.Add(new Label());
                        DirBalas.Add(Direccion.Arriba);
                        Balas[Balas.Count()-1].Location = new Point(Jugadores[0].Location.X + 25, Jugadores[0].Location.Y - 2);
                        Balas[Balas.Count() - 1].Size = new Size(5, 5);
                        Balas[Balas.Count() - 1].Text = "*";
                        this.Controls.Add(Balas[Balas.Count() - 1]);
                    }
                    break;
                case 's':
                    break;
                case 'a':
                    Jugadores[0].Location = new Point(Jugadores[0].Location.X - 1, Jugadores[0].Location.Y);
                    break;
                case 'd':
                    Jugadores[0].Location = new Point(Jugadores[0].Location.X + 1, Jugadores[0].Location.Y);

                    break;

            }
        }

        private void Jugar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Jugar_Load(object sender, EventArgs e)
        {

        }

        public Posicion verificarimpacto(List<List<Label>> Obj,int indice)
        {
            Posicion resultado = null;
            if (Balas[indice].Location.Y < 1)
            {
                resultado = new Posicion(Balas[indice].Location.X, Balas[indice].Location.Y);
            }
            foreach (var Lista in Obj)
            {
                var naveresult = Lista.FindIndex(e => (Balas[indice].Location.X >= e.Location.X && Balas[indice].Location.X < e.Location.X + e.Image.Width) && (Balas[indice].Location.Y >= e.Location.Y && Balas[indice].Location.Y < e.Location.Y + e.Image.Height));
                if (naveresult != -1)
                {
                    resultado = new Posicion(Lista[naveresult].Location.X, Lista[naveresult].Location.Y);
                    break;
                }
            }

            return resultado;
        }
        public Posicion verificarimpacto(List<Label> Obj)
        {
            Posicion resultado = null;

            return resultado;
        }


    }
}
