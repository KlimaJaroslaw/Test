using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dtp1.CustomFormat = "HH:mm";
            dtp2.CustomFormat = "HH:mm";
            dtp1.Format = DateTimePickerFormat.Custom;
            dtp2.Format = DateTimePickerFormat.Custom;
        }

        private void cbCzw_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
