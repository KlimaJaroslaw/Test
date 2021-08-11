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

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = dtp1.Value.ToString();
            //maskedTextBox1.Select();

            int  dni = (dtp2.Value - dtp2.Value).Days;
            textBox1.Text = dni.ToString();
            textBox1.Focus();

        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Select(0, maskedTextBox1.Text.Length);
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            MaskedTextBox mtb = sender as MaskedTextBox;

            if ((!e.IsValidInput) && mtb.Text != "    -  -")
            {
                mtb.Select();
                mtb.Select(0, mtb.Text.Length);
                //mtb.Select(0);
            }
        }
    }
}
