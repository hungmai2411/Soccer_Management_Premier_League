using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soccer_Management_Premier_League
{
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            using (SqlConnection connectionn = new SqlConnection(@"Data Source=DESKTOP-KBHC686\SQLEXPRESS;Initial Catalog=QLDB;Integrated Security=True"))
            {
                string query = "select * from CLUB";
                SqlDataAdapter ada = new SqlDataAdapter(query, connectionn);
                DataTable dt = new DataTable();
                ada.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DesignClub club = new DesignClub();

                    byte[] img1 = (byte[])dt.Rows[i][3];
                    MemoryStream ms1 = new MemoryStream(img1);
                    club.imgClub.Image = Image.FromStream(ms1);
                    club.lbNameClub.Text = dt.Rows[i][1].ToString();
                    club.lbStadium.Text = dt.Rows[i][6].ToString();
                    flowLayoutPanel1.Controls.Add(club);
                }
            }
            
        }
    }
}
