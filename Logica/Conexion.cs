﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Conexion { 
      //contiene info de la cadena de conexión a usar por la clase.
        String CadenaDeConexion { get; set; }

    //este listado se usa para agregar los parámetros 
    //que se pasarán al procedimiento almacenado.

    public List<SqlParameter> ListaParametros = new List<SqlParameter>();

    /*
     Esta función ejecuta un procedimiento almacenado. 
     Recibe por parámetro el nombre del SP y además 
     agrega cualquier parámetro tipo SqlParameter
     que esté en la lista de parámetros "Parametros"
     Sirve para consultas tipo: DELETE FROM, UPDATE, INSERT.
    */
    public int EjecutarUpdateDeleteInsert(string NombreSP)
    {
        int Retorno = 0;

        using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))

        {
            SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
            MyComando.CommandType = CommandType.StoredProcedure;

            if (ListaParametros != null && ListaParametros.Count > 0)
            {
                foreach (SqlParameter item in ListaParametros)
                {
                    MyComando.Parameters.Add(item);
                }
            }

            MyCnn.Open();

            //Si el comando a ejecutar en un DML (update, Insert o delete) 
            //establecer SET NOCOUNT OFF; en el SP 

            Retorno = MyComando.ExecuteNonQuery();
        }

        return Retorno;
    }

    /*
     Esta función ejecuta un procedimiento almacenado. 
     Recibe por parámetro el nombre del SP y además 
     agrega cualquier parámetro tipo SqlParameter
     que esté en la lista de parámetros "ListadoParametros". 
     Sirve para hacer consultas tipo: SELECT FROM y crear un
     DataTable con dicha info.
    */
    public DataTable EjecutarSelect(String NombreSP, bool CargarEsquemaDeTabla = false)
    {
        DataTable Retorno = new DataTable();

        using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))
        {
            SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
            MyComando.CommandType = CommandType.StoredProcedure;
            if (ListaParametros != null && ListaParametros.Count > 0)
            {
                foreach (SqlParameter item in ListaParametros)
                {
                    MyComando.Parameters.Add(item);
                }
            }
            SqlDataAdapter MyAdaptador = new SqlDataAdapter(MyComando);

            if (CargarEsquemaDeTabla)
            {
                MyAdaptador.FillSchema(Retorno, SchemaType.Source);
            }
            else
            {

                //paso 1.3.1 y 1..3.2
                MyAdaptador.Fill(Retorno);
            }
        }
        return Retorno;
    }

    public Object EjecutarConRetornoEscalar(String NombreSP)
    {
        Object Retorno = null;
        using (SqlConnection MyCnn = new SqlConnection(CadenaDeConexion))

        {
            SqlCommand MyComando = new SqlCommand(NombreSP, MyCnn);
            MyComando.CommandType = CommandType.StoredProcedure;

            if (ListaParametros != null && ListaParametros.Count > 0)
            {
                foreach (SqlParameter item in ListaParametros)
                {
                    MyComando.Parameters.Add(item);
                }
            }
            MyCnn.Open();
            Retorno = MyComando.ExecuteScalar();
        }

        return Retorno;
    }

    //Constructor. Carga la info del app.config
    //en la cadena de conexión al momento de crear 
    //una instancia nueva de la clase.
    public Conexion()
    {
        this.CadenaDeConexion = ConfigurationManager.ConnectionStrings["CNNSTR"].ToString();
    }
}
}
