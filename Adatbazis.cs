using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace SnookerRanglista
{
    internal class Adatbazis
    {
        public MySqlConnection con = null;
        public MySqlCommand cmd = null;
        public List<Versenyzo> versenyzok = new List<Versenyzo>();

        public Adatbazis(string host = "localhost", string user = "root", string password = "", string database = "snooker")
        {
            MySqlConnectionStringBuilder b = new MySqlConnectionStringBuilder();
            b.Server = host;
            b.UserID = user;
            b.Password = password;
            b.Database = database;

            con = new MySqlConnection(b.ConnectionString);
        }
    }
}
