using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ObservadorApp{
    class Conexion{
        public static SqlConnection conn = new SqlConnection("Initial Catalog= Observaciones; Data Source=localhost; Integrated Security=SSPI;");

        public DataSet Reporte_Observaciones(string consu, string tabla)
        {
            DataSet ConjuntoDatos = new DataSet();

            SqlCommand comando = new SqlCommand(consu, conn);

            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(ConjuntoDatos, tabla);
            conn.Close();

            return ConjuntoDatos;
        }

        public DataSet Reporte_Especies(string consu, string tabla)
        {
            DataSet ConjuntoDatos = new DataSet();

            SqlCommand comando = new SqlCommand(consu, conn);

            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(ConjuntoDatos, tabla);
            conn.Close();

            return ConjuntoDatos;
        }

        public SqlDataReader Buscar(string CodConsulta){
            SqlCommand comando = new SqlCommand(CodConsulta, conn);
            conn.Open();
            SqlDataReader lector = comando.ExecuteReader();
            return lector;
        }

        public int ABM(string instruccion){
            int respuesta = 1;
            SqlCommand comando = new SqlCommand(instruccion, conn);
            conn.Open();
            respuesta = comando.ExecuteNonQuery();
            conn.Close();
            return respuesta;
        }

        public DataSet BuscarCmb(string consu, string tabla){
            DataSet ConjuntosDatos = new DataSet();
            SqlCommand comando = new SqlCommand(consu, conn);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(ConjuntosDatos, tabla);
            conn.Close();
            return ConjuntosDatos;
        }

        public DataSet TablaObservador(string observador, string idObservador){
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = "Select * from " + observador + " where estatus='Activo' order by " + idObservador + " ASC;";
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(datSet, observador);
            conn.Close();
            return datSet;
        }

        public DataSet TablaZona(string zona, string idZona){
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = "Select * from " + zona + " order by " + idZona + " ASC;";
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(datSet, zona);
            conn.Close();
            return datSet;
        }

        public DataSet TablaAsociacion(string asociacion, string idAsociacion){
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = "select * from " + asociacion + " order by " + idAsociacion + " ASC";
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(datSet, asociacion);
            conn.Close();
            return datSet;
        }

        public SqlDataReader BuscarAsociacion(string CodConsulta){
            SqlCommand comando = new SqlCommand(CodConsulta, conn);
            conn.Open();
            SqlDataReader lector = comando.ExecuteReader();
            return lector;
        }

        public DataSet TablaObservacion(string observacion, string idObservacion){
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = "Select * from " + observacion + " order by " + idObservacion + " ASC;";
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(datSet, observacion);
            conn.Close();
            return datSet;
        }

        public SqlDataReader BuscarEspecie(string CodConsulta){
            SqlCommand comando = new SqlCommand(CodConsulta, conn);
            conn.Open();
            SqlDataReader lector = comando.ExecuteReader();
            return lector;
        }

        public DataSet TablaEspecie(string especie, string idEspecie){
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = "select * from " + especie + " order by " + idEspecie + " ASC";
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(datSet, especie);
            conn.Close();
            return datSet;
        }
    }
}
