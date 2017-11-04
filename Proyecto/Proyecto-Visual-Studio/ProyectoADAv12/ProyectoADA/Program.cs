using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Media.SoundPlayer start = new System.Media.SoundPlayer(ProyectoADA.Properties.Resources.smb_coin);
            start.Play();
            Application.Run(new GreedyVSBruteforce());
        }
    }
}
