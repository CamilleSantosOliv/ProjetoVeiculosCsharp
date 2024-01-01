using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerC {
    internal class Conn {
        private static string server = @"MILLENOVO\SQLEXPRESS"; //o @ tem que ser colocado antes da string se tiver caractere especial
        private static string dataBase = "AgenciaAuto";
        private static string user = "sa";
        private static string password = "teste123";

        public static string StrCon { //StrCon eh uma propriedade criada na classe Conn
            get { return "Data Source=" + server + "; Integrated Security=False;Initial Catalog=" + dataBase + ";User ID=" + user + "; Password=" + password; }
            //get { return $"Data Source={server}; Integrated Security=false;Initial Catalog={dataBase}; User ID={user}; Password={password}"; }
        }

    }
}
