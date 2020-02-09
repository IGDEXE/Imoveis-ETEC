using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Imoveis
{
    class Conexao
    {
        //Modificar o Data Source
        SqlConnection conect = new SqlConnection(@"Data Source=LENOVO-4C3DDD4A\SQLIGD;Initial Catalog=DbImoveis;Integrated Security=SSPI");
        public SqlConnection Conectar()
        {
            if (conect.State == ConnectionState.Closed)
            {
                conect.Open();
            }
            return conect;
        }
        public SqlConnection Desconectar()
        {
            if (conect.State == ConnectionState.Open)
            {
                conect.Close();
            }
            return conect;
        }
    }
}
