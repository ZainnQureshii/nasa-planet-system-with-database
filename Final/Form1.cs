using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final
{
    public partial class Form1 : Form
    {
        Functions fs = new Functions();

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SHS\Documents\Visual Studio 2012\Projects\8. NASA Planet System Using Database - C#\DATABASE files\SatelliteDATA.mdf;Integrated Security=True;Connect Timeout=30");


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Distance between EARTH AND MARS IS 200000");
        }


        private void button1_Click_1(object sender, System.EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "") {
                MessageBox.Show("Please Insert Data", "YOU ARE DONE");
            }
            else{
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into SatelliteData(SatName, SatTime, SatRange, SatFreq) values('" + textBox3.Text + "' , '" + textBox4.Text + "', '" + textBox5.Text + "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("YOUR DATA IS INSERTED SUCCESSFULLY", "YOU ARE DONE");
            }
            
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Distance between EARTH AND Moon IS 200000");
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Distance between EARTH AND SUN IS 200000");
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Distance between EARTH AND JUPITER IS 200000");
        }
    }
}