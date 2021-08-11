using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAPEK_Przegladarka_komunikatow
{
    public partial class FormGrid : Form
    {
        //BindingSource bSource = new BindingSource();
        public FormGrid()
        {
            InitializeComponent();
        }

        private void FormGrid_Load(object sender, EventArgs e)
        {

            Polaczenie();
            textBox1.Text = Global.connection.ToString();            
            RefreshData();
            timer1.Enabled = true;
            

        }

        BindingSource bSource = new BindingSource();
        private void RefreshData()
        {
            DataTable dt = DaneDoGrida();
            bSource.DataSource = dt;
            grid.DataSource = bSource;

            grid.Columns["id"].Width = 10000;
        }

        
        private DataTable DaneDoGrida()
        {
            string zapytanie = "SELECT  * FROM dbo._ATB_AP_komunikaty";            
            return Global.ExecSQL(zapytanie);
        }




        string Connectstring;
        private void Polaczenie()
        {
            Connectstring = "Server= DESKTOP-16DL9PF\\SQLEXPRESS; Database= Capek;User ID=sa;Password=AproSoft2409";
            Global.connection = new SqlConnection(Connectstring);
            Global.connection.Open();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Czy Kontynuować", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (grid.SelectedRows.Count != 1)
                return;
            
            try
            {
                int selectedIndex = grid.SelectedRows[0].Index;
                int _id = Convert.ToInt32(grid["id", selectedIndex].Value);
                
                string zapytanie = "UPDATE dbo._ATB_AP_komunikaty SET status = 1 WHERE id = @id";
                SqlCommand cmd = new SqlCommand(zapytanie, Global.connection);
                cmd.Parameters.AddWithValue("@id", _id);

                cmd.ExecuteNonQuery();

                grid.Rows[selectedIndex].Cells["status"].Value = 1;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }


        }

        private void FormGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.connection.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count != 1)
                return;

            try
            {
                int selectedIndex = grid.SelectedRows[0].Index;
                int _id = Convert.ToInt32(grid["id", selectedIndex].Value);

                string zapytanie = "UPDATE dbo._ATB_AP_komunikaty SET status = 0 WHERE id = @id";
                SqlCommand cmd = new SqlCommand(zapytanie, Global.connection);
                cmd.Parameters.AddWithValue("@id", _id);

                cmd.ExecuteNonQuery();

                grid.Rows[selectedIndex].Cells["status"].Value = 0;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pKomunikator.Visible = !pKomunikator.Visible;
        }


        //string sql = null;
        //SqlCommand command;
        //SqlDataReader dataReader;
        //Connectstring = "Server= DESKTOP-16DL9PF\\SQLEXPRESS; Database= Capek;User ID=sa;Password=AproSoft2409";
        //sql = "INSERT INTO _ATB_AP_komunikaty (Cell_id)VALUES (9);";


    }
}
