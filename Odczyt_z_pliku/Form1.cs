using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odczyt_z_pliku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrzycisk_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // załadowanie do edytora
                LoadToEditor(ofd.FileName);
            }

        }

        private void LoadToEditor(string fileName)
        {
            rtbPlik.Text = File.ReadAllText(fileName);
            rtbPlik.Enabled = true;
        }
    }
}
