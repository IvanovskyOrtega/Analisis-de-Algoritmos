using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace ProyectoADA
{
    public partial class BruteForce : Form
    {
        PictureBox[] imagenes;
        int posX;
        int posY;
        int lineas=0,counter=0,counterCad=0,counterCad2=0;
        int pixels;
        int cadLen;
        int movimientos = 0;
        string[] animacion = new string[200];
        string[] cadenas = new string[200];
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        StreamWriter sw;

        public BruteForce()
        {
            InitializeComponent();
            timer.Interval = 50;
            timer.Tick += iniciarAnimacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { sw.Close(); } catch { }
            this.Hide();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i;
            int soldados = 0;
            int espacios = 0;
            string cad = Input.Text;
            int tamX = 80;
            cadLen = Input.Text.Length;
            imagenes = new PictureBox[cad.Length];
            for ( i = 0 ; i < cad.Length ; i++ )
            {
                if (cad[i] == '1')
                    soldados++;
                else if (cad[i] == '0')
                    espacios++;
            }
            for ( i = 0; i < cad.Length; ++i)
            {
                imagenes[i] = new PictureBox();
            }
            int x = 640 - tamX/2;
            for ( i = 0 ; i < cad.Length; i++)
            {
                if (cad[i] == '1')
                {
                    imagenes[i].Image = ProyectoADA.Properties.Resources.mariow;
                    imagenes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    imagenes[i].Size = new System.Drawing.Size(tamX, 80);
                    imagenes[i].BackColor = Color.Transparent;
                    imagenes[i].Location = new Point(x - ((cad.Length-1)/2)*tamX,340);
                    x += tamX;
                    imagenes[i].Show();
                    this.Controls.Add(imagenes[i]);
                }
                else if (cad[i] == '0')
                {
                    imagenes[i].Image = ProyectoADA.Properties.Resources.brick;
                    imagenes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    imagenes[i].Size = new System.Drawing.Size(tamX, 80);
                    imagenes[i].BackColor = Color.Transparent;
                    imagenes[i].Location = new Point(x - ((cad.Length - 1) / 2) * tamX, 340);
                    x += tamX;
                    imagenes[i].Show();
                    this.Controls.Add(imagenes[i]);
                }
            }
            char[] cadSol = new char[cad.Length];
            char[] cadena = new char[cad.Length];
            cadSol = obtenerSolucion(cad);
            cadena = cad.ToCharArray();
            sw= new StreamWriter("test.txt");
            fuerzaBruta(cadena, cadSol, 0);
            generarAnimacion();
            timer.Start();
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

        private void crearMarios(string cad)
        {
            int i;
            int tamX = 80;
            for ( i = 0; i < cadLen; i++  )
            {
                imagenes[i].Visible = false;
            }
            for (i = 0; i < cadLen; i++)
            {
                this.Controls.Remove(imagenes[i]);
            }
            int x = 640 - tamX / 2;
            for (i = 0; i < cad.Length; i++)
            {
                if (cad[i] == '1')
                {
                    imagenes[i].Image = ProyectoADA.Properties.Resources.mariow;
                    imagenes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    imagenes[i].Size = new System.Drawing.Size(tamX, 80);
                    imagenes[i].BackColor = Color.Transparent;
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
                    imagenes[i].BackColor = Color.Transparent;
                    imagenes[i].Location = new Point(x - ((cad.Length - 1) / 2) * tamX, 340);
                    x += tamX;
                    imagenes[i].Show();
                    this.Controls.Add(imagenes[i]);
                }
            }
        }
        private void fuerzaBruta(char[] cad, char[] cadSol, ulong tiempoDeJuego)
        {
            string s = new string(cad);
            string t = new string(cadSol);
            int c = string.Compare(s, t);
            if (c == 0)
            {
                try { sw.Close(); } catch { }
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
                        if(k<cad.Length)
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
                                sw.WriteLine(i + " U");
                                for (int l = i + 1; l < k; l++)
                                {
                                    sw.WriteLine(l + " L");
                                }
                                for (int l = i; l < k - 1; l++)
                                {
                                    sw.WriteLine(i + " R");
                                }
                                sw.WriteLine(i + " D");
                                cad[i] = '0';
                                cad[k - 1] = '1';
                                tiempoDeJuego += (1 + ceros);
                                if (k == cad.Length)
                                    i = k;
                                else
                                    i = k - 1;
                                ceros = 0;
                            }
                        }
                        
                    }
                }
                sw.WriteLine("fin");
                cadenas[counterCad] = new string(cad);
                counterCad++;
                fuerzaBruta(cad, cadSol, tiempoDeJuego);
            }
        }

        private void generarAnimacion()
        {
            StreamReader swd = new StreamReader("test.txt");
            string buffer;
            while (!swd.EndOfStream)
            {
                buffer = swd.ReadLine();
                animacion[lineas] = buffer;
                lineas++;
            }
            try { swd.Close(); } catch { }
        }

        private void iniciarAnimacion(object sender, EventArgs e)
        {
            int posicion;
            char movimiento = '\0';
            if(counter < lineas-1)
            {
                if (string.Compare("fin", animacion[counter]) == 0)
                {
                    crearMarios(cadenas[counterCad2]);
                    counterCad2++;
                    counter++;
                }
                movimiento = animacion[counter][2];
                posicion = (int)char.GetNumericValue(animacion[counter][0]);
                if (pixels < 10)
                {
                    switch (movimiento)
                    {
                        case 'U':
                            pixels++;
                            posX = imagenes[posicion].Location.X;
                            posY = imagenes[posicion].Location.Y;
                            imagenes[posicion].Top -= 8;
                            if (pixels == 4)
                            {
                                movimientos++;
                                logRichTextBox.Text += "Movimiento de Mario: \n+1 segundo\n\n" ;
                                gtLabel.Text = movimientos + "";
                            }
                            break;
                        case 'D':
                            pixels++;
                            posX = imagenes[posicion].Location.X;
                            posY = imagenes[posicion].Location.Y;
                            imagenes[posicion].Top += 8;
                            break;
                        case 'L':
                            pixels++;
                            posX = imagenes[posicion].Location.X;
                            posY = imagenes[posicion].Location.Y;
                            imagenes[posicion].Left -= 8;
                            break;
                        case 'R':
                            pixels++;
                            posX = imagenes[posicion].Location.X;
                            posY = imagenes[posicion].Location.Y;
                            imagenes[posicion].Left += 8;
                            if (pixels == 4)
                            {
                                movimientos++;
                                logRichTextBox.Text += "Recorrimiento de Mario: \n+1 segundo\n\n";
                                gtLabel.Text = movimientos + "";
                            }
                            break;
                    }
                }
                else
                {
                    pixels = 0;
                    counter++;
                }
            }
            else
            {
                timer.Stop();
            }
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
                Error.Text= "Favor de Introducir solo cadenas con los siguientes caracteres: \'0' y '1'";
                Start.Enabled = false;

            }
            else
            {
                Error.Text = "";
                Start.Enabled = true;
            }
        }

    }
}
