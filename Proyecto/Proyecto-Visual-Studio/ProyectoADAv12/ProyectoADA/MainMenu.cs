using System;
using System.Windows.Forms;

namespace ProyectoADA
{
    public partial class GreedyVSBruteforce : Form
    {
        public GreedyVSBruteforce()
        {
            System.Media.SoundPlayer overworld = new System.Media.SoundPlayer(ProyectoADA.Properties.Resources.Super_Mario_Bros_Theme);
            overworld.PlayLooping();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( greedyRadioButton.Checked )
            {
                esconderElementos(1);
            }
            else if( fbRadioButton.Checked)
            {
                esconderElementos(2);
            }
            else if( gvsfbRadioButton.Checked)
            {
                esconderElementos(3);
            }
        }
        private void esconderElementos(int option)
        {
            switch(option)
            {
                case 1:
                    Greedy form1 = new Greedy();
                    form1.FormClosed += new FormClosedEventHandler(formClosed);
                    this.Hide();
                    form1.Show();
                    break;
                case 2:
                    BruteForce form2 = new BruteForce();
                    form2.FormClosed += new FormClosedEventHandler(formClosed);
                    this.Hide();
                    form2.Show();
                    break;
                case 3:
                    BFvsG form3 = new BFvsG();
                    form3.FormClosed += new FormClosedEventHandler(formClosed);
                    this.Hide();
                    form3.Show();
                    break;

            }
        }
        private void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

    }
}
