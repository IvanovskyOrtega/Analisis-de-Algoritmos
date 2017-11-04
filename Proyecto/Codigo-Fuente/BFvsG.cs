using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoADA
{
    public partial class BFvsG : Form
    {
        string s, t;
        int previous, next, len1, len2;
        int counterMG=0,counterMFB=0,counter1=0,counter2=0;
        ulong tiempoDeJuegoBF = 0, tiempoDeJuegoGreedy = 0;
        string cadenaLeida;
        char[] cadenaLeidaC = new char[100000];
        char[] cadenaLeidaC2 = new char[100000];
        int[,] movimientosGreedy = new int[500000, 2];
        int[,] movimientosFB = new int[10000000, 2];
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
        public BFvsG()
        {
            InitializeComponent();
            timer.Interval = 100;
            timer.Tick += iniciarAnimacionFuerzaBruta;
            timer2.Interval = 100;
            timer2.Tick += iniciarAnimacionGreedy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { timer.Stop(); } catch { }
            try { timer2.Stop(); } catch { }
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { timer.Stop(); } catch { }
            try { timer2.Stop(); } catch { }
            try { greedyTextBox.SelectAll(); greedyTextBox.SelectionBackColor = Color.White; } catch { }
            try { fbTextBox.SelectAll(); fbTextBox.SelectionBackColor = Color.White; } catch { }
            this.winnerLabel.Visible = false;
            counter1 = 0;
            counter2 = 0;
            counterMFB = 0;
            counterMG = 0;
            this.progressGreedy.Value = 0;
            this.progressFB.Value = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                cadenaLeida = sr.ReadToEnd();
                sr.Close();
                cadenaLeidaC = cadenaLeida.ToCharArray();
                cadenaLeidaC2 = cadenaLeida.ToCharArray();
                if (validate_string(cadenaLeida))
                {
                    MessageBox.Show("Tamaño de la cadena leida: " + cadenaLeida.Length);
                    char[] solucion = obtenerSolucion(cadenaLeida);
                    MessageBox.Show("Cadena valida");
                    greedyAlg(cadenaLeida);
                    if (cadenaLeida.Length <= 5000)
                    {
                        fuerzaBruta(cadenaLeidaC2, solucion, tiempoDeJuegoBF);
                        timer.Start();
                    }
                    timer2.Start();
                }
                else
                {
                    MessageBox.Show("Cadena inválida");
                }
            }
        }

        private void BFvsG_Load(object sender, EventArgs e)
        {

        }

        private char[] obtenerSolucion(string cad)
        {
            int ceros=0;
            char[] cadSol = new char[cad.Length];
            for( int i = 0 ; i < cad.Length; i++)
            {
                if (cad[i] == '0')
                {
                    ceros++;
                }
            }
            for (int i = 0 ; i < ceros; i++)
                cadSol[i] = '0';
           for (int i = ceros; i < cadSol.Length; i++)
                cadSol[i] = '1';
            return cadSol;
        }
        
        private void greedyAlg(string cad)
        {
            char[] cadAux = cad.ToCharArray();
            int i, j = 0, c = 0, aux = 0;
            ulong ceros = 0, movimientos = 0;
            for (i = (cad.Length - 1); i >= 0; i--)
            {
                movimientosGreedy[counterMG,0] = 210;
                movimientosGreedy[counterMG,1] = 39;
                counterMG++;
                if (cad[i] == '0')
                {
                    movimientosGreedy[counterMG,0] = 280;
                    movimientosGreedy[counterMG,1] = 18;
                    counterMG++;
                    if (aux == 0)
                    {
                        movimientosGreedy[counterMG,0] = 337;
                        movimientosGreedy[counterMG,1] = 10;
                        counterMG++;
                        aux = 1;
                        j = i;
                    }
                    ceros++;
                    c = 1;
                }
                if (cad[i] == '1' && c == 1)
                {
                    movimientosGreedy[counterMG,0] = 546;
                    movimientosGreedy[counterMG,1] = 28;
                    counterMG++;
                    if (ceros > 0)
                    {
                        movimientosGreedy[counterMG,0] = 613;
                        movimientosGreedy[counterMG,1] = 14;
                        counterMG++;
                        movimientos += ceros + 1;

                    }
                    cadAux[j] = '1';
                    cadAux[i] = '0';
                    j--;
                    tiempoDeJuegoGreedy += movimientos;
                    ceros = 0;
                }
            }
            movimientosGreedy[counterMG,0] = 902;
            movimientosGreedy[counterMG,1] = 53;
            counterMG++;
            this.progressGreedy.Maximum = counterMG - 1;
        }
        private void greedyAlgSA(string cad)
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
                    {
                        movimientos += ceros + 1;

                    }
                    cadAux[j] = '1';
                    cadAux[i] = '0';
                    j--;
                    tiempoDeJuego += movimientos;
                    ceros = 0;
                }
            }
        }
        private void fuerzaBruta(char[] cad, char[] cadSol, ulong tiempoDeJuego)
        {
            s = new string(cad);
            t = new string(cadSol);
            int c = string.Compare(s, t);
            if (c == 0)
            {
                tiempoDeJuegoBF = tiempoDeJuego;
                movimientosFB[counterMFB, 0] = 220;
                movimientosFB[counterMFB, 1] = 13;
                counterMFB++;
                movimientosFB[counterMFB, 0] = 250;
                movimientosFB[counterMFB, 1] = 53;
                counterMFB++;
                this.progressFB.Maximum = counterMFB;
                return;
            }
            else
            {
                movimientosFB[counterMFB, 0] = 340;
                movimientosFB[counterMFB, 1] = 6;
                counterMFB++;
                int k = 0;
                int j = 0;
                ulong ceros = 0;
                for (int i = 0; i < cad.Length; i++)
                {
                    movimientosFB[counterMFB, 0] = 450;
                    movimientosFB[counterMFB, 1] = 38;
                    counterMFB++;
                    if (cad[i] == '1')
                    {
                        movimientosFB[counterMFB, 0] = 509;
                        movimientosFB[counterMFB, 1] = 21;
                        counterMFB++;
                        k = i + 1;
                        if (k < cad.Length)
                        {
                            movimientosFB[counterMFB, 0] = 589;
                            movimientosFB[counterMFB, 1] = 18;
                            counterMFB++;
                            if (cad[k] == '0')
                            {
                                movimientosFB[counterMFB, 0] = 635;
                                movimientosFB[counterMFB, 1] = 20;
                                counterMFB++;
                                for (j = k; j < cad.Length; j++)
                                {
                                    movimientosFB[counterMFB, 0] = 688;
                                    movimientosFB[counterMFB, 1] = 34;
                                    counterMFB++;
                                    if (cad[j] == '0')
                                    {
                                        movimientosFB[counterMFB, 0] = 759;
                                        movimientosFB[counterMFB, 1] = 20;
                                        counterMFB++;
                                        ceros++;
                                    }
                                    else
                                    {
                                        movimientosFB[counterMFB, 0] = 865;
                                        movimientosFB[counterMFB, 1] = 6;
                                        counterMFB++;
                                        break;
                                    }
                                }
                                k = j;
                                cad[i] = '0';
                                cad[k - 1] = '1';
                                tiempoDeJuego += (1 + ceros);
                                if (k == cad.Length)
                                {
                                    movimientosFB[counterMFB, 0] = 1220;
                                    movimientosFB[counterMFB, 1] = 20;
                                    counterMFB++;
                                    i = k;
                                }
                                else
                                {
                                    movimientosFB[counterMFB, 0] = 1316;
                                    movimientosFB[counterMFB, 1] = 4;
                                    counterMFB++;
                                    i = k - 1;
                                }
                                ceros = 0;
                            }
                        }

                    }
                }
            movimientosFB[counterMFB, 0] =  1523;
            movimientosFB[counterMFB, 1] =  40;
            counterMFB++;
            fuerzaBruta(cad, cadSol, tiempoDeJuego);
            }   
        }
private void fuerzaBrutaSA(char[] cad, char[] cadSol, ulong tiempoDeJuego)
        {
            s = new string(cad);
            t = new string(cadSol);
            int c = string.Compare(s, t);
            if (c == 0)
            {
                tiempoDeJuegoBF = tiempoDeJuego;
                return;
            }
            else
            {
                int k = 0;
                int j = 0;
                ulong ceros = 0;
                for (int i = 0; i < cad.Length; i++)
                {
                    if (cad[i] == '1')
                    {
                        k = i + 1;
                        if (k < cad.Length)
                        {
                            if (cad[k] == '0')
                            {
                                for (j = k; j < cad.Length; j++)
                                {
                                    if (cad[j] == '0')
                                    {
                                        ceros++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                k = j;
                                cad[i] = '0';
                                cad[k - 1] = '1';
                                tiempoDeJuego += (1 + ceros);
                                if (k == cad.Length)
                                {
                                    i = k;

                                }
                                else
                                {
                                    i = k - 1;
                                }
                                ceros = 0;
                            }
                        }

                    }
                }
                fuerzaBrutaSA(cad, cadSol, tiempoDeJuego);
            }
        }
        
        private void iniciarAnimacionGreedy(object sender, EventArgs e)
        {
            if(counter1 < counterMG)
            {
                next = movimientosGreedy[counter1, 0];
                len1 = movimientosGreedy[counter1, 1];
                if (counter1 > 0)
                {
                    previous = movimientosGreedy[counter1 - 1, 0];
                    len2 = movimientosGreedy[counter1 - 1, 1];
                    try { greedyTextBox.Select(previous, len2); } catch { }
                    try { greedyTextBox.SelectionBackColor = Color.White; } catch { }
                    try { greedyTextBox.Select(next, len1); } catch { }
                    try { greedyTextBox.SelectionBackColor = Color.SkyBlue; } catch { }
                    counter1++;
                }
                else
                {
                    try { greedyTextBox.Select(next, len1); } catch { }
                    try { greedyTextBox.SelectionBackColor = Color.SkyBlue; } catch { }
                    counter1++;
                }
                this.progressGreedy.Increment(1);
            }
            else
            {
                timer2.Stop();
                this.winnerLabel.Visible = true;
            }
        }

        private void iniciarAnimacionFuerzaBruta(object sender, EventArgs e)
        {
            if (counter2 < counterMFB)
            {
                next = movimientosFB[counter2, 0];
                len1 = movimientosFB[counter2, 1];
                if (counter2 > 0)
                {
                    previous = movimientosFB[counter2 - 1, 0];
                    len2 = movimientosFB[counter2 - 1, 1];
                    try { fbTextBox.Select(previous, len2); } catch { }
                    try { fbTextBox.SelectionBackColor = Color.White; } catch { }
                    try { fbTextBox.Select(next, len1); } catch { }
                    try { fbTextBox.SelectionBackColor = Color.SkyBlue; } catch { }
                    counter2++;
                }
                else
                {
                    try { fbTextBox.Select(next, len1); } catch { }
                    try { fbTextBox.SelectionBackColor = Color.SkyBlue; } catch { }
                    counter2++;
                }
                this.progressFB.Increment(1);
            }
            else
            {
                timer.Stop();
            }
        }

        private bool validate_string(string text)
        {
            Regex Val = new Regex("^([0|1]+)$");

            if (!Val.IsMatch(text))
            {
                return false;

            }
            else
            {
                return true;
            }
        }

    }
}
