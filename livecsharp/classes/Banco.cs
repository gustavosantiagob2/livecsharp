using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace livecsharp.classes
{
    public static class Banco
    {
        public static MySqlCommand abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string strCon = @"server=127.0.0.1;database=liveescola; user id=root;password=";
            MySqlConnection cn = new MySqlConnection(strCon);
            cn.Open();
            cmd.Connection = cn;
            return cmd;

        }
    }
}
