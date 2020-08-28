using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace graficar_datos
{
    class PostgreSQL
    {


        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = 141092; Database = postgres");
        //NpgsqlConnection conn = new NpgsqlConnection("Server = dbcourse01.centralus.cloudapp.azure.com; Port = 5432; User Id = postgres; Password = DBadmin01; Database = postgres");

        public void Conectar()
        {

            conn.Open();
           // MessageBox.Show("DataBase is Opened");

        

        }


        public void Desconectar()
        {

            conn.Close();
            //MessageBox.Show("DataBase is Closed");


        }

        public DataTable Consultar()
        {
            string query = "select * from captura";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return (tabla);
        }


        public void Insertar(int idvoltaje, string fecha, string voltaje)
        {


            //conn.Open();
            //if (conn.State.Equals(false))
            //{
            conn.Open();
            //MessageBox.Show("DataBase is Opened");
            string query = "Insert into captura values (" + idvoltaje + ",'" + fecha + "','" + voltaje + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            conn.Close();
            //}

            //else
            //{
            //    MessageBox.Show("No esta abierta");
            //    //conn.Open();
            //}
        }



        /*TENGO QUE SACAR EL ENVIO DE DATOS DEL TIMER PORQUE AL PARECER ES DE MAS ALTA PRIORIDAD PARA EL SISTEMA*/





    }
}
