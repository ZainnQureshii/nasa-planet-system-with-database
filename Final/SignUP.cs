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


namespace Final
{
    public partial class SignUP : Form
    {
        Form1 f = new Form1();

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHS\Documents\Visual Studio 2012\Projects\8. NASA Planet System Using Database - C#\DATABASE files\SatelliteDATA.mdf;Integrated Security=True;Connect Timeout=30");

        public SignUP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string Password = Cryptography.encrypt(txtpass.Text.Trim().ToString());

            SqlCommand cmd = new SqlCommand("insert into SignUP(Username, Password) values('" + txtname.Text + "' , '"+Password+"')", conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("YOUR DATA IS INSERTED SUCCESSFULLY", "YOU ARE DONE");

        }

    }
}
