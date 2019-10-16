using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormPPE
{
    public class ConnectionMySql
    {
        MySqlConnection cnx;

        public MySqlConnection Cnx { get => cnx; set => cnx = value; }

        public ConnectionMySql(string h, string user, string pwd, string bdd)
        {
            string sCnx;

            sCnx = String.Format("server={0};uid={1};database={2};pwd={3}", h, user, bdd, pwd);

            cnx = new MySqlConnection(sCnx);

            try
            {
                Cnx.Open();
                Console.WriteLine("connexion réussi");
            }
            catch (Exception e)
            {
                Console.WriteLine("erreur connexion " + e.Message.ToString());
            }
        }
        public void Fermer()
        {
             cnx.Close();
        }
        public void Open()
        {
            cnx.Open();
        }
    }
}
