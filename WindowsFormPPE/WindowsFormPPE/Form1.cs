using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Web;

namespace WindowsFormPPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnectionMySql cnx = new ConnectionMySql("localhost", "adminRl", "siojjr", "rallyLecture");
            try
            {
                cnx.Open();
                MessageBox.Show("Connexion réussi");
           
            }
            catch (Exception e)
            {
                MessageBox.Show("erreur connexion " + e.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

     
    }
}
