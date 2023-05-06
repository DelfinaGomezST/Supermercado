using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


//Gitt prueba

namespace Datos
{
	class ConexionDB
	{
        private SqlConnection objConexion;
        private string strCadenaDeConexion = "";


        /* -------------------- private void Conectar() ------------ 
         * Este metodo como indica su nombre... me permite conectarme con la 
         * base de datos (en este caso, SqlServer)
         * 
         */
        private void Conectar()
        {   // HACK: Cadena de conexión hardcodeada. Luego ponerla como parametro de configuración del proyecto u otra alternativa.
            strCadenaDeConexion = @"CAMBIAR POR CADENA DE CONEXION LOCAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";

            //Instanció un objeto del tipo SqlConnection
            objConexion = new SqlConnection();
            objConexion.ConnectionString = strCadenaDeConexion;
            objConexion.Open();
        }

        private void Desconectar()
        {
            objConexion.Close();
            objConexion.Dispose();
        }

        public DataTable ObtenerResulatdoConsulta(string consulta)
		{
			//Instancio un objeto del tipo DataTable
			var unaTabla = new DataTable();

			//Instancio un objeto del tipo SqlCommand
			var objComando = new SqlCommand();
	
			Conectar();

			try
			{
				//Parametrizo el objeto SqlCommand con sus valores respectivos
				objComando.CommandType = CommandType.Text;
				objComando.Connection = this.objConexion;
				objComando.CommandText = consulta;

				//Instancio un adaptador con el parametro SqlCommand
				var objAdaptador = new SqlDataAdapter(objComando);
				//Lleno la tabla, el objeto unaTabla con el adaptador
				objAdaptador.Fill(unaTabla);

			}
			catch
			{
				//Como hay error... por el motivo que sea asigno el resultado a null
				unaTabla = null;
				throw;
			}
			finally
			{
				//Siempre, por más que salga bien o mal el llenado, me desconecto
				Desconectar();
			}
			return unaTabla;
		}
	}
}
