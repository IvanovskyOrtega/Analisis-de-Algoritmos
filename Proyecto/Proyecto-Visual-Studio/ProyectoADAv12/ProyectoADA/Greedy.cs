using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoADA
{
    public partial class Greedy : Form
    {
        PictureBox[] imagenes;
        PictureBox[] fantasmas;
        string[] cadenas = new string[200];
        ulong[] movimientos = new ulong[200];
        ulong[] noCeros = new ulong[200];
        string cad;
        int repeticion = 0;
        int counterCad;
        int counter = 0;
        int nuevoMario = 1;
        ulong noMarios;
        ulong mariosMovidos = 0;
        int posMario;
        int posX;
        int posXFinal;
        int posXAux;
        ulong tiempoDeJuego = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Greedy()
        {
            InitializeComponent();
            timer.Interval = 5;
            timer.Tick += moverMarios;
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i;
            int soldados = 0;
            int espacios = 0;
            counterCad = 0;
            string cad = Input.Text;
            int tamX = 80;
            imagenes = new PictureBox[cad.Length];
            fantasmas = new PictureBox[cad.Length];
            for (i = 0; i < cad.Length; i++)
            {
                if (cad[i] == '1')
                    soldados++;
                else if (cad[i] == '0')
                    espacios++;
            }

            for (i = 0; i < cad.Length; ++i)
            {
                imagenes[i] = new PictureBox();
                fantasmas[i] = new PictureBox();
            }
            int x = 640 - tamX / 2;
            for (i = 0; i < cad.Length; i++)
            {
                if (cad[i] == '1')
                {
                    imagenes[i].Image = ProyectoADA.Properties.Resources.mariow;
                    imagenes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    imagenes[i].Size = new System.Drawing.Size(tamX, 80);
                    imagenes[i].BackColor = System.Drawing.Color.Transparent;
                    imagenes[i].Location = new Point(x - ((cad.Length - 1) / 2) * tamX, 340);
                    x += tamX;
                    imagenes[i].Show();
                    this.Controls.Add(imagenes[i]);
                }
                else if (cad[i] == '0')
                {
                    imagenes[i].Image = ProyectoADA.Properties.Resources.brick;
                    imagenes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    imagenes[i].Size = new System.Drawing.Size(tamX, 80);
                    imagenes[i].BackColor = System.Drawing.Color.Transparent;
                    imagenes[i].Location = new Point(x - ((cad.Length - 1) / 2) * tamX, 340);
                    x += tamX;
                    imagenes[i].Show();
                    this.Controls.Add(imagenes[i]);
                }
            }
            ceros.Text = "ESPACIOS A RECORER: 0";
            mov.Text = "MOVIMIENTOS: 0";
            tiempo.Text = "TIEMPO DE JUEGO: 0";
            greedyAlg(cad);
            try { noMarios = Convert.ToUInt64(cad.Length) - noCeros[counterCad - 1]; } catch { }
            this.cad = cad;
            timer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = Input.Text;
            if (text.Length != 0)
            {
                validate_string(text);
            }
            else
            {
                Error.Text = "";
                Start.Enabled = false;
            }

        }

        private void validate_string(string text)
        {
            Regex Val = new Regex("^([0|1]+)$");

            if (!Val.IsMatch(text))
            {
                Error.Text = "Favor de Introducir solo cadenas con los siguientes caracteres: '0' y '1'";
                Start.Enabled = false;

            }
            else
            {
                Error.Text = "";
                Start.Enabled = true;
            }
        }

        private void greedyAlg(string cad)
        {
            char[] cadAux = cad.ToCharArray();
            int i, j = 0, c = 0, aux = 0;
            ulong ceros = 0, movimientos = 0, tiempoDeJuego = 0;
            for (i = (cad.Length - 1); i >= 0; i--)
            {
                if (cad[i] == '0')
                {
                    if (aux == 0)
                    {
                        aux = 1;
                        j = i;
                    }
                    ceros++;
                    c = 1;
                }
                if (cad[i] == '1' && c == 1)
                {
                    if (ceros > 0)
                        movimientos += ceros + 1;
                    cadAux[j] = '1';
                    cadAux[i] = '0';
                    cadenas[counterCad] = new string(cadAux);
                    this.movimientos[counterCad] = movimientos;
                    noCeros[counterCad] = ceros;
                    if (counterCad != 0)
                        noCeros[counterCad] += noCeros[counterCad - 1];
                    counterCad++;
                    j--;
                    tiempoDeJuego += movimientos;
                    ceros = 0;
                }
            }
        }
        private void iniciarMovimientos()
        {
            if (counter <= counterCad)
            {
                for (int j = cad.Length - 1; j >= 0; j--)
                {
                    try
                    {
                        if (cad[j] != cadenas[counter][j])
                        {
                            if (cad[j] == '1')
                            {
                                fantasmas[j].Image = ProyectoADA.Properties.Resources.mariow;
                                fantasmas[j].SizeMode = PictureBoxSizeMode.StretchImage;
                                fantasmas[j].Size = new System.Drawing.Size(80, 80);
                                fantasmas[j].BackColor = System.Drawing.Color.Transparent;
                                fantasmas[j].Location = new Point(imagenes[j].Location.X, 260);
                                fantasmas[j].Show();
                                this.Controls.Add(fantasmas[j]);
                                posMario = j;
                                posX = posXAux = imagenes[j].Location.X;
                            }
                            else
                                posXFinal = imagenes[j].Location.X;
                        }
                    }
                    catch { }
                }
                cad = cadenas[counter];
                counter++;
            }
        }

        private void moverMarios(object sender, EventArgs e)
        {

            if (mariosMovidos < noMarios)
            {
                if (nuevoMario == 1)
                {
                    iniciarMovimientos();
                    nuevoMario = 0;
                }
                else
                {
                    if (posX < posXFinal)
                    {
                        posX += 4;
                        fantasmas[posMario].Location = new Point(posX, 260);
                        if (posX >= (((posXFinal - posXAux) / 32) + posXAux) && repeticion == 0)
                        {
                            registro.Text += "Mario " + counter+"\n";
                            registro.Text += "Movimiento de Mario: \n+1 segundo\n\n";
                            registro.Text += "Espacios Recorridos:\n+" + noCeros[counter - 1] + " segundos(s)\n\n";
                            if (counter - 1 != 0)
                                registro.Text += "Tiempo del Mario Anterior:\n+" + movimientos[counter - 2] + " segundo(s)\n\n";
                            ceros.Text = "ESPACIOS A RECORER: " + noCeros[counter - 1];
                            mov.Text = "MOVIMIENTOS: " + movimientos[counter - 1];
                            tiempoDeJuego += movimientos[counter - 1];
                            tiempo.Text = "TIEMPO DE JUEGO: " + tiempoDeJuego;
                            repeticion = 1;
                        }
                    }
                    else
                    {
                        nuevoMario = 1;
                        mariosMovidos++;
                        repeticion = 0;
                    }
                }

            }
            else
            {
                timer.Stop();
            }
        }
    }
}
