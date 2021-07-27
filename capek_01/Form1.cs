using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capek_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShemaMaskTextBox(MaskedTextBox mtb)
        {
            mtb.Mask = "0000-00-00";
            mtb.ValidatingType = typeof(System.DateTime);
            mtb.TypeValidationCompleted += new TypeValidationEventHandler(maskedTextBox1_TypeValidationCompleted);
            mtb.BackColor = System.Drawing.ColorTranslator.FromHtml("#E5E5E5");
            mtb.TypeValidationCompleted += maskedTextBoxTypeValidationCompleted;
        }
        void maskedTextBoxTypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            MaskedTextBox mtb = sender as MaskedTextBox;

            if  ((!e.IsValidInput) && mtb.Text != "    -  -")
                {
                mtb.Select();
                mtb.Select(0, mtb.Text.Length);
                }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShemaMaskTextBox(maskedTextBox1);
            ShemaMaskTextBox(maskedTextBox2);

            dateTimePicker1.ValueChanged += dateTimePicker_ValueChanged;
            dateTimePicker2.ValueChanged += dateTimePicker_ValueChanged;

        }

       

        void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
        
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            //string test;
            //test = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            //maskedTextBox1.Text = test;

            foreach (Control tempCtrl in this.Controls)
            {
                // Determine whether the control is textBox1,
                // and if it is, remove it.
                if (tempCtrl.Name == dtp.Tag)
                {
                    tempCtrl.Text = dtp.Value.ToString("yyyy-MM-dd");
                    //Showm("JEST KONTROLKA");
                    //this.Controls.Remove(tempCtrl);
                }
            }


            //Form1. Controls.Find("maskedTextBox1", true)[0];

            //MaskedTextBox myTextBox = (MaskedTextBox)this.GetControlByName(this, "maskedTextBox1");

            //myTextBox.Text = "Hello!";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string test;
            test = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            maskedTextBox1.Text = test;
            
        }
    }
}
